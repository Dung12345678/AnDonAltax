using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hardware;
namespace BMS
{
    public class RFID_Reader : SerialInterface
    {
        public delegate void OnGetValueHandler(string _ReaderName, string _ParkingLineLocation, string _CardNumber);
        public event OnGetValueHandler OnGetValue;
        public string ReaderName = "";
        public string ParkingLineLocation = "";
        public System.Timers.Timer timer;
        public RFID_Reader(string _ComPort, string _PortMode)
            : base(_ComPort, _PortMode)
        {
                timer = new System.Timers.Timer();
                timer.Interval = 100;
                timer.Elapsed += tm_Elapsed;
        }

        byte[] Command = new byte[] { 0xAA, 0xBB, 0x05, 0x00, 0x00, 0x00, 0x05, 0x02, 0x07 };
        byte[] LightRed = new byte[] { 0xAA, 0xBB, 0x06, 0x00, 0x00, 0x00, 0x07, 0x01, 0x01, 0x07 };
        byte[] LightGreen = new byte[] { 0xAA, 0xBB, 0x06, 0x00, 0x00, 0x00, 0x07, 0x01, 0x02, 0x04 };
        byte[] LightAll = new byte[] { 0xAA, 0xBB, 0x06, 0x00, 0x00, 0x00, 0x07, 0x01, 0x03, 0x05 };
        byte[] LightOff = new byte[] { 0xAA, 0xBB, 0x06, 0x00, 0x00, 0x00, 0x07, 0x01, 0x00, 0x06 };
        byte[] AlamBeep = new byte[] { 0xAA, 0xBB, 0x06, 0x00, 0x00, 0x00, 0x06, 0x01, 0x0B, 0x0C };
        void tm_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            SendData(Command);
        }
        private int DataCnt = 0;
        private int DataLength = 0;
        private int DataType = 0;
        public byte[] DataByte;

        protected override void ReceiveData(byte[] _data)
        {
            byte[] buffer = _data;
            for (int i = 0; i < buffer.Length; i++)
            {
                byte c = buffer[i];

                switch (DataState)
                {
                    case 0:
                        if (c == 0xAA)
                        {
                            DataState = 1;
                        }
                        break;
                    case 1:
                        if (c == 0xBB)
                        {
                            DataState = 2;
                            DataLength = 0;
                        }
                        break;
                    case 2:
                        if (DataLength == 0)
                        {
                            DataLength = c;
                            DataState = 3;
                            DataByte = new byte[DataLength];
                            DataCnt = 0;
                        }
                        break;
                    case 3:
                        if (DataCnt < DataLength)
                        {
                            DataByte[DataCnt++] = c;
                        }
                        if (DataCnt == DataLength)
                        {
                            if (DataLength == 10)
                            {
                                StringBuilder sbText = new StringBuilder();

                                for (int j = 6; j < DataLength; j++)
                                {
                                    sbText.Append(DataByte[j].ToString("X2"));
                                }
                                timer.Stop();
                                timer.Enabled = false;
                                SendData(AlamBeep);
                     
                                OnGetValue(ReaderName, ParkingLineLocation,sbText.ToString());
                                System.Threading.Thread.Sleep(500);
                                SendData(LightGreen);
                                System.Threading.Thread.Sleep(500);
                                SendData(LightRed);
                                timer.Enabled = true;
                                timer.Start();
                            }
                            DataState = 0;
                        }
                        break;
                }

                
            }
  
        }
    }
}
