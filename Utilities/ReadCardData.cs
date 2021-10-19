using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.IO;
using BMS.Utils;

namespace BMS
{
    public class ReadCardData
    {
        
        public static Thread readCom;
        public static Control _displayWindow;
        public static SerialPort comPort = new SerialPort();

        public Control DisplayWindow
        {
            get { return _displayWindow; }
            set { _displayWindow = value; }
        }
        public static void DisplayData(string msg)
        {
            if(!_displayWindow.IsDisposed)
            {
                _displayWindow.Invoke(new EventHandler(delegate
                {
                    _displayWindow.Text = msg;
                }));
            }
        }
        public static void IntitPort()
        {
            comPort.BaudRate = 9600;    //BaudRate
            comPort.DataBits = 8;    //DataBits
            comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1"); ;    //StopBits
            comPort.Parity = (Parity)Enum.Parse(typeof(Parity), "None");    //Parity
            string strPortName = "";
            try
            {
                string[] settings = File.ReadAllLines("settings.ini");
                for (int i = 0; i < settings.Length; i++)
                {
                    if (settings[i].StartsWith("COMPort"))
                        strPortName = settings[i].Split('=')[1].Trim().ToUpper();
                }
            }
            catch
            {
                strPortName = "COM1";
                MessageBox.Show("Cổng COM của đầu đọc thẻ chưa được thiết lập!\nCổng mặc định (COM1) sẽ được sử dụng.", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            comPort.PortName = strPortName;   //PortName
            try
            {
                comPort.Open();
                readCom = new Thread(GetDataFormCard);
                readCom.Start();
            }
            catch
            {
                MessageBox.Show("Lỗi cổng COM: Không thể kết nối với đầu đọc thẻ!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static void GetDataFormCard()
        {
            string msg;
            string data;
            while (true)
            {
                data = "";
                try
                {
                    if (comPort.BytesToRead > 0)
                    {
                        System.Threading.Thread.Sleep(25);
                        msg = comPort.ReadExisting().ToString();
                        for (int i = 0; i < msg.Length; i++)
                        {
                            if (Char.IsDigit(msg[i]))
                                data += msg[i];
                            else
                                data += char.Parse("\r");
                        }
                        //if (data.Length == 11)
                            DisplayData(data);
                    };
                }
                catch
                {
                }
            }
        }
        public static void InitControl(Control ctrl)
        {
            _displayWindow = ctrl;
        }
        public static void ClosePort()
        {
            if (readCom != null)
                readCom.Abort();
            try
            {
                if (comPort.IsOpen)
                    comPort.Close();
            }
            catch { };
        }
    }
}
