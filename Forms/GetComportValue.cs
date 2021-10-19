using BMS.Model;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace BMS
{
    public class GetComportValue
    {
        //public readonly CheckControl _ControlData;

        private WeighObj lbdWeighRead, lbdWeighTakeOut;
        private SerialPort COM_Kern;
        private float oldWeighValue;
        private System.Timers.Timer wZeroTimer;
        private float[] valueArr = new float[15];
        private string blanceStatus = "None";
        private float lowRangeValue = 5;
        private float highRangeValue = 10;
        private int countZero;
        private int countReceive = 0;
        private int countReceiveOld = 0;
        private int countErrorCOM = 0;
        private bool messageShow = false;

        //public GetComportValue(CheckControl ControlData)
        //{
        //    _ControlData = ControlData;
        //    try
        //    {
        //        COMPortInitial();
        //        DataInitial();
        //    }
        //    catch
        //    {
        //        _ControlData.SetErrorCom();
        //    }
        //}
        readonly frmProductCheckHistory1 _Form;
        int _rowIndex;
        int _WorkingID;
        
        public GetComportValue(frmProductCheckHistory1 ControlData, string comPort, int rowIndex, int workingID)
        {
            _Form = ControlData;
            _rowIndex = rowIndex;
            _WorkingID = workingID;
            try
            {
                COMPortInitial(comPort);
                _Form.SetConnectCom(rowIndex, true);
                //DataInitial();
            }
            catch
            {
                //_Form.SetConnectCom(rowIndex, false);
            }
        }

        public GetComportValue()
        {
            
        }
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            countReceive += 1;
            string temp = COM_Kern.ReadLine();

            if (_Form.InvokeRequired)
            {
                _Form.Invoke((MethodInvoker)delegate
                {
                    _Form.SetRealValue(temp, _rowIndex, _WorkingID);
                });
            }
            else
            {
                _Form.SetRealValue(temp, _rowIndex, _WorkingID);
            }
            return;
            //Console.WriteLine("READ " + temp);

            if (temp.IndexOf("g") >= 0)
            {
                float wValue = 0;
                try
                {
                    wValue = float.Parse((temp.Substring(temp.LastIndexOf("  ") + 1)).Replace("g", ""));
                }
                catch { wValue = (float)-9.999; }
                lbdWeighRead.Weigh = wValue;
                PushToArray(valueArr, wValue);
                // Kiểm tra
                var tempCheck = CheckDataStatus();
                // Nếu trạng thái dữ liệu - Không có vật trên cân
                if (tempCheck == 1)
                {
                    CalculateTakeOut(1);
                }
                // Nếu trạng thái dữ liệu - Vừa đặt vật vào cân
                if (tempCheck == 2)
                {
                    CalculateTakeOut(2);
                }
            }

        }
        private void COMPortInitial(string com)
        {
            string tempStringCOM = com;
            COM_Kern = new SerialPort(tempStringCOM, 9600, Parity.None, 8, StopBits.One);
            COM_Kern.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived); //ProcessWeighData;
            COM_Kern.Open();
        }
        //private void COMPortInitial()
        //{
        //    string tempStringCOM = "COM" + _ControlData._model.Comport;
        //    COM_Kern = new SerialPort(tempStringCOM, 9600, Parity.None, 8, StopBits.One);
        //    COM_Kern.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived); //ProcessWeighData;
        //    COM_Kern.Open();
        //}
        private void CalculateTakeOut(int high)
        {
            switch (high)
            {
                case 1: // Kiểm tra vừa lấy vật ra
                    lbdWeighTakeOut.Weigh = 0;
                    //Console.WriteLine("Giá trị cũ: " + oldWeighValue.ToString());
                    break;
                case 2: // Kiểm tra vừa đặt vật vào
                    if (oldWeighValue > lowRangeValue) lbdWeighTakeOut.Weigh = -valueArr.Average() + oldWeighValue;
                    oldWeighValue = lbdWeighRead.Weigh;
                    //Console.WriteLine("Giá trị mới: " + oldWeighValue.ToString());
                    if (Math.Abs(lbdWeighTakeOut.Weigh) < 100)
                    {
                        //if (_ControlData.InvokeRequired)
                        //{
                        //    _ControlData.Invoke((MethodInvoker)delegate
                        //    {
                        //        _ControlData.SetRealValue(lbdWeighTakeOut.Weigh.ToString("#.##"));
                        //    });
                        //}
                        //else
                        //{
                        //    _ControlData.SetRealValue(lbdWeighTakeOut.Weigh.ToString("#.##"));
                        //}
                    }
                    break;
                default:
                    break;
            }
        }

        

        private void DataInitial()
        {
            lbdWeighRead = new WeighObj();
            lbdWeighTakeOut = new WeighObj();
            // Khởi tạo mảng lưu trữ mặc định
            for (int i = 0; i < valueArr.Length; i++)
            {
                valueArr[i] = 0;
            }
            //lblWeighRead.DataContext = lbdWeighRead;
            //lblWeighTakeOut.DataContext = lbdWeighTakeOut;
            // Timer kiểm tra trạng thái Stable 0 (không gửi dữ liệu về PC)
            wZeroTimer = new System.Timers.Timer(500);
            wZeroTimer.Elapsed += CheckWeighValue;
            wZeroTimer.Start();
        }
        /// <summary>
        /// Thêm giá trị vào cuối mảng, đẩy giá trị đầu tiên ra
        /// </summary>
        /// <param name="valueArr"></param>
        /// <param name="wValue"></param>
        private void PushToArray(float[] valueArr, float wValue)
        {
            Array.ConstrainedCopy(valueArr, 1, valueArr, 0, valueArr.Length - 1);
            valueArr[valueArr.Length - 1] = wValue;
        }

        /// <summary>
        /// Kiểm tra trạng thái dữ liệu cân gửi về
        /// </summary>
        /// <returns></returns>
        private int CheckDataStatus()
        {
            if (valueArr.Average() < lowRangeValue)
            {
                if ((blanceStatus == "None") || (blanceStatus == "High"))
                {
                    blanceStatus = "Low";
                    return 1;
                }
            }
            // Giá trị lớn hơn khoảng giới hạn high, và giá trị chênh lệch giữa max-min < giá trị low
            if ((valueArr.Average() > highRangeValue) && ((valueArr.Max() - valueArr.Min()) < lowRangeValue))
            {
                if ((blanceStatus == "None") || (blanceStatus == "Low"))
                {
                    blanceStatus = "High";
                    return 2;
                }
            }

            return 0;
        }
        //private void ProcessWeighData(object sender, SerialDataReceivedEventArgs e)
        //{
        //    countReceive += 1;
        //    string temp = COM_Kern.ReadLine();

        //    //Console.WriteLine("READ " + temp);
        //    if (temp.IndexOf("g") >= 0)
        //    {
        //        float wValue = 0;
        //        try
        //        {
        //            wValue = float.Parse((temp.Substring(temp.LastIndexOf("  ") + 1)).Replace("g", ""));
        //        }
        //        catch { wValue = (float)-9.999; }
        //        lbdWeighRead.Weigh = wValue;
        //        PushToArray(valueArr, wValue);
        //        // Kiểm tra
        //        var tempCheck = CheckDataStatus();
        //        // Nếu trạng thái dữ liệu - Không có vật trên cân
        //        if (tempCheck == 1)
        //        {
        //            CalculateTakeOut(1);
        //        }
        //        // Nếu trạng thái dữ liệu - Vừa đặt vật vào cân
        //        if (tempCheck == 2)
        //        {
        //            CalculateTakeOut(2);
        //        }
        //    }
        //}

        private void CheckWeighValue(object sender, ElapsedEventArgs e)
        {
            if (valueArr[(valueArr.Length - 1)] < lowRangeValue) countZero += 1;
            else countZero = 0;
            if (countZero > 1)
            {
                countZero = 0;
                for (int i = 0; i < valueArr.Length; i++)
                {
                    if (valueArr[i] > lowRangeValue) valueArr[i] = 0;
                }
                if ((blanceStatus == "None") || (blanceStatus == "High"))
                {
                    blanceStatus = "Low";
                    CalculateTakeOut(1); // Nếu cân Stable ở trạng thái 0 trong 2s, thì xử lý giống với vừa lấy vật ra
                }
            }

            // Xử lý kiểm tra tín hiệu cổng COM
            if ((countReceive == countReceiveOld) && (!messageShow))
            {
                //Console.WriteLine("count");
                ErrorTimeOutCOM();
                if (countReceive > 10000) countReceive = 0;
                countReceiveOld = countReceive;
            }
        }

        private void WriteToKeyBoard()
        {
            //System.Windows.Clipboard.Clear();  // Always clear the clipboard first
            //string stringWrite = lbdWeighTakeOut.Weigh.ToString("#.##");
            //System.Windows.Clipboard.SetText(stringWrite);
            //System.Windows.Forms.SendKeys.SendWait("^v");  // Paste
            //System.Windows.Forms.SendKeys.SendWait("{ENTER}");
            //Console.WriteLine("Confirm\n");
        }

        private void ErrorTimeOutCOM()
        {
            countErrorCOM += 1;
            //if (countErrorCOM < 5) ReconnectCOM(ref COM_Kern);
            //else
            //{
            //    messageShow = true;
            //    MessageBoxResult temp = MessageBox.Show("Check COM Port and Click OK", "ERROR!!!", MessageBoxButton.OKCancel);
            //    if (temp == MessageBoxResult.OK) countErrorCOM = 0;
            //    if (temp == MessageBoxResult.Cancel) Dispatcher.Invoke(new Action(delegate { Application.Current.Shutdown(); }));
            //    messageShow = false;
            //}
        }
    }
}
