using BMS.Business;
using BMS.Model;
using BMS.Utils;
using InControls.PLC.FX;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmServer : Form
	{
		private FxSerialDeamon _FxSerial;
		string _cmd;
		FxCommandResponse _res;

		public StatusColorCDModel _StatusColorCDModel;
		public AndonModel _AndonModel = new AndonModel();
		//public NotUseCD _NotUseCD = new NotUseCD();
		public StatusColorCDModel _NotUseCD;

		List<Socket> clientSockets = new List<Socket>();

		public SendData _SendData;

		Socket serverSocket;
		int BUFFER_SIZE = 1024;
		bool _isStart = false;
		byte[] buffer;
		public frmServer()
		{
			InitializeComponent();
		}
		private void frmServer_Load(object sender, EventArgs e)
		{
			_NotUseCD = new StatusColorCDModel();

			//Load trạng thái ban đầu trong file trạng thái dạng text
			_StatusColorCDModel = new StatusColorCDModel();

			//Load Andon từ file setting dạng text
			_AndonModel = new AndonModel();

			btnSend.Enabled = false;
			buffer = new byte[BUFFER_SIZE];
			OpenPort(1);

			btnStart_Click(null, null);
		}
		public void OpenPort(int port)
		{
			if (_FxSerial == null)
			{
				_FxSerial = new FxSerialDeamon();
				_FxSerial.Start(port);
			}
		}
		void setStatusColor(string cd, int status)
		{
			switch (cd)
			{
				case "CD1":
					_StatusColorCDModel.CD1 = status;
					break;
				case "CD2":
					_StatusColorCDModel.CD2 = status;
					break;
				case "CD3":
					_StatusColorCDModel.CD3 = status;
					break;
				case "CD4":
					_StatusColorCDModel.CD4 = status;
					break;
				case "CD5":
					_StatusColorCDModel.CD5 = status;
					break;
				case "CD6":
					_StatusColorCDModel.CD6 = status;
					break;
				case "CD7":
					_StatusColorCDModel.CD7 = status;
					break;
				case "CD8":
					_StatusColorCDModel.CD8 = status;
					break;
				case "CD9":
					_StatusColorCDModel.CD9 = status;
					break;
				case "CD8-1":
					_StatusColorCDModel.CD81 = status;
					break;
				default:
					break;
			}
		}
		private void ReceiveCallback(IAsyncResult AR)
		{
			Socket current = (Socket)AR.AsyncState;
			int received = 0;

			try
			{
				received = current.EndReceive(AR);

				byte[] recBuf = new byte[received];
				Array.Copy(buffer, recBuf, received);
				string text = Encoding.ASCII.GetString(recBuf);

				if (string.IsNullOrEmpty(text)) return;
				if (!text.Contains(";")) return;

				string[] arr = text.Split(';');
				if (arr.Length != 3) return;

				string step = arr[0];
				string value = arr[1];
				string type = arr[2];

				//sự cố + //Hoàn thành
				if (type == "1" || type == "2")
				{
					setStatusColor(step, TextUtils.ToInt(value));
				}
				//Cập nhật số lượng thực tế
				if (type == "3")
				{
					_AndonModel.QtyActual += 1;
					_AndonModel.QtyDelay = _AndonModel.QtyPlanCurrent - _AndonModel.QtyActual;
					_SendData(3, 1, "");
				}
				//Khởi động ca làm việc
				if (type == "4")
				{
					_AndonModel.IsStart = true;
					_SendData(4, 1, "");

				}
				// Nhận tín hiệu không sử dụng

				if (type == "10")
				{
					if (value == "10")
					{
						switch (step)
						{
							case "CD1":
								_NotUseCD.CD1 = 10;
								_SendData(10, 10, "CD1");
								break;
							case "CD2":
								_NotUseCD.CD2 = 10;
								_SendData(10, 10, "CD2");
								break;
							case "CD3":
								_NotUseCD.CD3 = 10;
								_SendData(10, 10, "CD3");
								break;
							case "CD4":
								_NotUseCD.CD4 = 10;
								_SendData(10, 10, "CD4");
								break;
							case "CD5":
								_NotUseCD.CD5 = 10;
								_SendData(10, 10, "CD5");
								break;
							case "CD6":
								_NotUseCD.CD6 = 10;
								_SendData(10, 10, "CD6");
								break;
							case "CD7":
								_NotUseCD.CD7 = 10;
								_SendData(10, 10, "CD7");
								break;
							case "CD8":
								_NotUseCD.CD8 = 10;
								_SendData(10, 10, "CD8");
								break;
							case "CD8-1":
								_NotUseCD.CD81 = 10;
								_SendData(10, 10, "CD8-1");
								break;
							case "CD9":
								_NotUseCD.CD9 = 10;
								_SendData(10, 10, "CD9");
								break;
							default:
								break;
						}
					}
					else if (value == "11")
					{
						switch (step)
						{
							case "CD1":
								_NotUseCD.CD1 = 11;
								_SendData(10, 11, "CD1");
								break;
							case "CD2":
								_NotUseCD.CD2 = 11;
								_SendData(10, 11, "CD2");
								break;
							case "CD3":
								_NotUseCD.CD3 = 11;
								_SendData(10, 11, "CD3");
								break;
							case "CD4":
								_NotUseCD.CD4 = 11;
								_SendData(10, 11, "CD4");
								break;
							case "CD5":
								_NotUseCD.CD5 = 11;
								_SendData(10, 11, "CD5");
								break;
							case "CD6":
								_NotUseCD.CD6 = 11;
								_SendData(10, 11, "CD6");
								break;
							case "CD7":
								_NotUseCD.CD7 = 11;
								_SendData(10, 11, "CD7");
								break;
							case "CD8":
								_NotUseCD.CD8 = 11;
								_SendData(10, 11, "CD8");
								break;
							case "CD8-1":
								_NotUseCD.CD81 = 11;
								_SendData(10, 11, "CD8-1");
								break;
							case "CD9":
								_NotUseCD.CD9 = 11;
								_SendData(10, 11, "CD9");
								break;
							default:
								break;
						}
					}
				}
			}
			catch (Exception)
			{
			}


			try
			{
				current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
			}
			catch (Exception)
			{
				//return;
			}
		}
		private void AcceptCallback(IAsyncResult AR)
		{
			Socket socket;
			if (serverSocket == null)
			{
				return;
			}
			try
			{
				socket = serverSocket.EndAccept(AR);
				clientSockets.Add(socket);
			}
			catch (ObjectDisposedException)
			{
				return;
			}

			socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
			serverSocket.BeginAccept(AcceptCallback, null);
		}
		private int SetupServer()
		{
			try
			{
				serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				serverSocket.Bind(new IPEndPoint(IPAddress.Any, int.Parse(txtPort.Text.Trim())));
				serverSocket.Listen(0);
				serverSocket.BeginAccept(AcceptCallback, null);
				return 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return 0;
			}
		}
		private void CloseSocketServer()
		{
			serverSocket.Close();
		}
		private void frmServer_FormClosed(object sender, FormClosedEventArgs e)
		{
			CloseSocketServer();
		}
		private void btnSend_Click(object sender, EventArgs e)
		{
			//byte[] data = Encoding.ASCII.GetBytes(txtSendValue.Text.Trim());
			////current.Send(data);
			//foreach (Socket socket in clientSockets)
			//{
			//    socket.Send(data);
			//}
			////serverSocket.Send(data);
		}
		void sendAll(byte[] data)
		{
			////clientSockets[0].Send(data);
			//foreach (Socket socket in clientSockets)
			//{
			//    try
			//    {
			//        socket.Send(data);
			//    }
			//    catch (Exception)
			//    {
			//    }
			//}
		}
		public void SendAll(string text)
		{
			try
			{
				byte[] data = Encoding.ASCII.GetBytes(text.Trim());
				foreach (Socket socket in clientSockets)
				{
					try
					{
						if (socket.Poll(1000, SelectMode.SelectRead))
						{
							clientSockets.Remove(socket);
							continue;
						}
						socket.Send(data);
					}
					catch
					{

					}
				}
				//serverSocket.Send(data);
			}
			catch (Exception ex)
			{

			}
		}
		private void btnStart_Click(object sender, EventArgs e)
		{
			if (!_isStart)
			{
				if (SetupServer() == 0) return;
				btnStart.Text = "Stop";
				btnStart.BackColor = Color.Red;
				btnSend.Enabled = true;
				_isStart = true;
			}
			else
			{
				CloseSocketServer();
				serverSocket = null;
				listBox1.Items.Clear();
				btnStart.Text = "Start";
				btnStart.BackColor = Color.Green;
				btnSend.Enabled = false;
				_isStart = false;
			}
		}
	}
}
