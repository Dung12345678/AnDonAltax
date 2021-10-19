using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows;
using System.IO;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
//using System.Windows.Threading;

namespace BMS
{
    public class TouqueMObj : ObservableObject
    {
        private TcpClient SocketTCP;
        private Stream TouqueTCP;
        private Thread ReceiveTCPThread;
        public string JobID { get; set; }
        public bool ChangeJob { get; set; }
        private System.Timers.Timer timerSentCommand;

        readonly frmProductCheckHistory1 _Form;
        int _rowIndex;
        int _WorkingID;
        string _maSungLuc;
        //public delegate void ReceiveDelegate(string StringReceive);
        //public event ReceiveDelegate ReceiveTCPEvent;

        /// <summary>
        /// Hàm khởi tạo 
        /// Mở kết nối tới cổng TCP
        /// Tạo Thread nhận dữ liệu từ cổng TCP
        /// Khai báo timer 1s để gửi lệnh duy trì kết nối
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="port"></param>
        public TouqueMObj(frmProductCheckHistory1 form, string ipAddress, int port, int rowIndex, int workingID, string MaSungLuc)
        {
            try
            {
                _Form = form;
                _rowIndex = rowIndex;
                _WorkingID = workingID;
                //_maSungLuc = MaSungLuc;
                _maSungLuc = "0000000000000000000000001";

                SocketTCP = new TcpClient();
                SocketTCP.Connect(ipAddress, port);
                if (SocketTCP.Connected)
                {
                    //Console.WriteLine("Khởi tạo kết nối - IP :" + ipAddress + " - Port: " + port.ToString());
                    TouqueTCP = SocketTCP.GetStream();
                    ReceiveTCPThread = new Thread(ReceiveDataTCP);
                    ReceiveTCPThread.IsBackground = true;
                    ReceiveTCPThread.Start();
                    timerSentCommand = new System.Timers.Timer();
                    //timerSentCommand.Tick += ProcessTimer;
                    timerSentCommand.Interval = 1000;
                    timerSentCommand.Elapsed += ProcessTimer;
                    timerSentCommand.Start();
                }
                else
                {
                    //MessageBox.Show("Không kết nối được đến thiết bị: " + ipAddress + " - Port: " + port.ToString());
                }
            }
            catch (Exception ex)
            {
               
            }
           
        }

        /// <summary>
        /// Thread nhận dữ liệu về từ cổng TCP, chu kỳ 100ms
        /// Điều kiện chuỗi ký tự trả về có chứa '0'
        /// </summary>
        private void ReceiveDataTCP()
        {
            SentOverTCP("00200001            \00"); // 0200001 là lệnh mở truyền thông với thiết bị súng lực
            if (!string.IsNullOrWhiteSpace(_maSungLuc))
            {
                Thread.Sleep(500);
                SentOverTCP(string.Format("00450050            {0}\00", _maSungLuc)); // Gửi mã súng lực xuống độ dài 25 ký tự
            }
            byte[] data;
            while (true)
            {
                try
                {
                    //Thread.Sleep(100);
                    data = new byte[1024];
                    TouqueTCP.Read(data, 0, data.Length);
                    string tempStringReceive = System.Text.Encoding.UTF8.GetString(data).Replace("\r", "").Replace("\n", "").Replace("\r\n", "").Replace("?", "").Replace("\0", "");
                    // Kiểm tra có phải là chuối trả giá trị súng lực về không?
                    if ((tempStringReceive.IndexOf("0061") >= 0))
                    {
                        ProcessTCPReceiveData(tempStringReceive);
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        float GetData(string tempGet)
        {
            float valueReturn;
            // GetData
            //var tempGet = stringReceive;
            while (true)
            {
                if (tempGet.IndexOf("15") >= 0)
                {
                    tempGet = tempGet.Substring(tempGet.IndexOf("15"));
                    if (tempGet[9] == '6') break;
                    tempGet = tempGet.Substring(2);
                    //Console.WriteLine("try " + tempGet);
                }
                else
                {
                    valueReturn = 0;
                    break;
                }
            }
            valueReturn = float.Parse(tempGet.Substring(2, 6)) / 100;
            return valueReturn;
        }

        /// <summary>
        /// Gửi liên tục lệnh duy trì kết nối
        /// Option gửi lệnh chuyển Job
        /// </summary>
        /// <param name="connect"></param>
        /// <param name="changeJob"></param>
        public void CycleCommand()
        {
            SentOverTCP("00209999            \00"); // 0209999 là lệnh duy trì kết nối với súng lực
            //await Task.Delay(100);
            Thread.Sleep(100);
            SentOverTCP("00200060            \00"); // 0209999 là lệnh duy trì kết nối với súng lực
            //await Task.Delay(100);
            Thread.Sleep(100);
            if (ChangeJob)
            {
                SentOverTCP("");
                ChangeJob = false;
            }
        }

        /// <summary>
        /// Hàm hỗ trợ gửi string v qua TCP
        /// </summary>
        /// <param name="v"></param>
        private void SentOverTCP(string v)
        {
            byte[] tempSent = Encoding.ASCII.GetBytes(v);
            TouqueTCP.Write(tempSent, 0, tempSent.Length);
            TouqueTCP.Flush();
        }

        /// <summary>
        /// Kiểm tra chuỗi nhận về
        /// Nếu là giá trị lực thì gửi qua Event
        /// </summary>
        private void ProcessTCPReceiveData(string tempStringReceive)
        {
            //Console.WriteLine(tempStringReceive);
            // Bổ xung thêm điều kiện kiểm tra OK/NG (09110 => OK)
            if ((tempStringReceive.IndexOf("0061") >= 0)&&((tempStringReceive.IndexOf("09110") >=0)))
            {
                //Console.WriteLine("Nhận tín hiệu đo lực gửi về! " + tempStringReceive);
                float valueReturn = GetData(tempStringReceive);
                _Form.Invoke((MethodInvoker)delegate
                {
                    _Form.SetRealValue(valueReturn, _rowIndex, _WorkingID);
                });
                //if (ReceiveTCPEvent != null) ReceiveTCPEvent(tempStringReceive);

            }
        }

        /// <summary>
        /// Xử lý gửi nhận Command theo timer 1s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessTimer(object sender, EventArgs e)
        {
            CycleCommand();
        }
    }
}
