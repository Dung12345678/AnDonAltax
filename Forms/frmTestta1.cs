using BMS.Business;
using BMS.Model;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmTestta1 : Form
	{
		public long _WorkerID = 0;
		private Color tempColor = Color.FromArgb(255, 26, 26);
		private Color temColor1 = Color.FromArgb(216, 216, 216);
		int _qty;
		DataTable _dtData = new DataTable();

		public frmTestta1()
		{
			InitializeComponent();
		}
		private void frmTestta1_Load(object sender, EventArgs e)
		{

		}
		private void txtOrderNo_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				LoadData();
			}
		}
		/// <summary>
		/// load dữ liệu order khi nhập order và sau khi cất
		/// nvthao
		/// 25.12.2019
		/// </summary>
		private void LoadData()
		{
			try
			{
				DataTable dt = TextUtils.LoadDataFromSP("spGetGearInfo_ByOrderCode", "A"
				  , new string[1] { "@OrderCode" }
				  , new object[1] { txtOrderNo.Text.Trim() });
				if (dt.Rows.Count > 0)
				{
					_qty = TextUtils.ToInt(dt.Rows[0]["Qty"]);
					txtQty.Text = _qty.ToString("n0");
					txtLAP.Text = TextUtils.ToString(dt.Rows[0]["Lap"]);

					txtSlitMax.Text = TextUtils.ToDecimal(dt.Rows[0]["SlitMax"]).ToString("n3");
					txtSlitMin.Text = TextUtils.ToDecimal(dt.Rows[0]["SlitMin"]).ToString("n3");

					txtDoDaoJigLapMin.Text = TextUtils.ToDecimal(dt.Rows[0]["DoDaoJigLapMin"]).ToString("n3");
					txtDoDaoJigLapMax.Text = TextUtils.ToDecimal(dt.Rows[0]["DoDaoJigLapMax"]).ToString("n3");

					txtVibrateMaxN.Text = txtVibrateMaxT.Text = TextUtils.ToDecimal(dt.Rows[0]["VibrateMax"]).ToString("n3");
					txtVibrateMinN.Text = txtVibrateMinT.Text = TextUtils.ToDecimal(dt.Rows[0]["VibrateMin"]).ToString("n3");

					AddNewRowInDataTable();
				}
				else
				{
					txtDoDaoJigLapMax.Text = txtDoDaoJigLapMin.Text = txtSlitMin.Text = txtVibrateMinN.Text = txtVibrateMinT.Text =
						txtSlitMax.Text = txtVibrateMaxN.Text = txtVibrateMaxT.Text = 0.ToString("n3");
					txtQty.Text = "0";
					txtLAP.Text = "";
					dteNgayGiaCong.Value = DateTime.Now;
					grvData.DataSource = null;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		/// <summary>
		/// Load dư dữ liệu vào grid với 2 trường hợp là order mới và order cũ
		/// Order mới sinh các dòng dữ liệu rồi đẩy vào grid
		/// Order cũ load lại các dòng dữ liệu từ database ra
		/// nvthao 
		/// 25.12.2019
		/// </summary>
		private void AddNewRowInDataTable()
		{
			string sql = string.Format("SELECT * FROM dbo.Testta WITH(NOLOCK) WHERE OrderCode = '{0}' order by number", txtOrderNo.Text.Trim());
			DataTable dt1 = TextUtils.Select(sql);
			if (dt1.Rows.Count == 0)
			{
				dteNgayGiaCong.Value = DateTime.Now;
				for (int i = 0; i < _qty; i++)
				{
					DataRow r = dt1.NewRow();
					r["Number"] = i + 1;
					r["CheckEye11"] = "View";
					r["CheckEye12"] = "View";
					r["CheckEye21"] = "View";
					r["CheckEye22"] = "View";
					dt1.Rows.Add(r);
				}
			}
			else
			{
				dteNgayGiaCong.Value = Convert.ToDateTime(dt1.Rows[0]["DateWork"]);
				txtWorkerName.Text = TextUtils.ToString(dt1.Rows[0]["WorkerName"]);
				txtMeasureName.Text = TextUtils.ToString(dt1.Rows[0]["MeasureName"]);
				txtLeader.Text = TextUtils.ToString(dt1.Rows[0]["Leader"]);
			}

			grvData.AutoGenerateColumns = false;
			grvData.DataSource = dt1;

			//Stopwatch stopwatch = Stopwatch.StartNew();
			if (dt1.Rows.Count > 0) checkColor();
			//stopwatch.Stop();
			//MessageBox.Show(stopwatch.ElapsedMilliseconds.ToString());

			changeColorGrid();

			grvData.Focus();
			grvData.CurrentCell = grvData[1, 0];
			grvData.BeginEdit(true);
		}

		/// <summary>
		/// Bôi màu các dòng từ 1-5 và các dòng có number chia hết cho 10
		/// created by: nvthao
		/// created date: 25.12.2019
		/// </summary>
		private void changeColorGrid()
		{
			// các cột luôn hiện thỉ màu nền là LightBlue

			grvData.Columns[colResult1.Name].DefaultCellStyle.BackColor = temColor1;
			grvData.Columns[colResult2.Name].DefaultCellStyle.BackColor = temColor1;

			grvData.Columns[colVibrate11.Name].DefaultCellStyle.BackColor = temColor1;
			grvData.Columns[colVibrate12.Name].DefaultCellStyle.BackColor = temColor1;
			grvData.Columns[colVibrate13.Name].DefaultCellStyle.BackColor = temColor1;

			grvData.Columns[colVibrate21.Name].DefaultCellStyle.BackColor = temColor1;
			grvData.Columns[colVibrate22.Name].DefaultCellStyle.BackColor = temColor1;
			grvData.Columns[colVibrate23.Name].DefaultCellStyle.BackColor = temColor1;

			for (int i = 0; i < grvData.RowCount; i++)
			{
				// nếu số lượng hàng bé thua 5. các Row luôn hiện màu nền temColor1
				if (i <= 4)
				{
					grvData.Rows[i].DefaultCellStyle.BackColor = temColor1;
				}
				else
				{
					// nếu vị trí hàng chia hết cho 10. thực hiện đổi màu nền tại hàng đó là LightBlue
					if (i % 10 == 9)
					{
						grvData.Rows[i].DefaultCellStyle.BackColor = temColor1;
					}
				}
			}
		}
		/// <summary>
		/// check Color in dataGridview when load data from DataBase
		/// hàm chỉ được thực hiện khi load dữ liệu từ dataBase lên form
		/// </summary>
		private void checkColor()
		{
			for (int i = 0; i < _qty; i++)
			{
				if (TextUtils.ToString(grvData.Rows[i].Cells[colResult1.Name].Value).ToUpper() == "OK")
				{
					grvData.Rows[i].Cells[colResult1.Name].Style.BackColor = Color.Green;
				}
				if (TextUtils.ToString(grvData.Rows[i].Cells[colResult1.Name].Value).ToUpper() == "NG")
				{
					grvData.Rows[i].Cells[colResult1.Name].Style.BackColor = tempColor;
				}
				if (TextUtils.ToString(grvData.Rows[i].Cells[colResult2.Name].Value).ToUpper() == "OK")
				{
					grvData.Rows[i].Cells[colResult2.Name].Style.BackColor = Color.Green;
				}
				if (TextUtils.ToString(grvData.Rows[i].Cells[colResult2.Name].Value).ToUpper() == "NG")
				{
					grvData.Rows[i].Cells[colResult2.Name].Style.BackColor = tempColor;
				}
				if (TextUtils.ToDecimal(grvData.Rows[i].Cells[colClockDial12.Name].Value) > TextUtils.ToDecimal(txtSlitMax.Text.ToString()))
				{
					grvData.Rows[i].Cells[colClockDial12.Name].Style.BackColor = tempColor;
				}
				if (TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrationForward1.Name].Value) > TextUtils.ToDecimal(txtVibrateMaxT.Text.ToString()))
				{
					grvData.Rows[i].Cells[colVibrationForward1.Name].Style.BackColor = tempColor;
				}
				if (TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrationReverse1.Name].Value) > TextUtils.ToDecimal(txtVibrateMaxN.Text.ToString()))
				{
					grvData.Rows[i].Cells[colVibrationReverse1.Name].Style.BackColor = tempColor;
				}
				if (TextUtils.ToDecimal(grvData.Rows[i].Cells[colClockDial22.Name].Value) > TextUtils.ToDecimal(txtSlitMax.Text.ToString()))
				{
					grvData.Rows[i].Cells[colClockDial22.Name].Style.BackColor = tempColor;
				}
				if (TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrationForward2.Name].Value) > TextUtils.ToDecimal(txtVibrateMaxT.Text.ToString()))
				{
					grvData.Rows[i].Cells[colVibrationForward2.Name].Style.BackColor = tempColor;
				}
				if (TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrationReverse2.Name].Value) > TextUtils.ToDecimal(txtVibrateMaxN.Text.ToString()))
				{
					grvData.Rows[i].Cells[colVibrationReverse2.Name].Style.BackColor = tempColor;
				}
				if (TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrate21.Name].Value) > 0.01M)
				{
					grvData.Rows[i].Cells[colVibrate21.Name].Style.BackColor = tempColor;
				}
				if (TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrate22.Name].Value) > 0.02M)
				{
					grvData.Rows[i].Cells[colVibrate22.Name].Style.BackColor = tempColor;
				}
				if (TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrate23.Name].Value) > 0.01M)
				{
					grvData.Rows[i].Cells[colVibrate23.Name].Style.BackColor = tempColor;
				}
			}
		}
		/// <summary>
		/// F12 is Save
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (txtOrderNo.Text.Trim() == "")
			{
				MessageBox.Show("Bạn chưa nhập Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (TextUtils.ToInt(txtQty.Text.Trim()) == 0)
			{
				MessageBox.Show("Bạn chưa nhập Số lượng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (txtLAP.Text.Trim() == "")
			{
				MessageBox.Show("Bạn chưa nhập TESTTA LAP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (txtWorkerName.Text.Trim() == "")
			{
				MessageBox.Show("Bạn chưa nhập Người gia công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (txtMeasureName.Text.Trim() == "")
			{
				MessageBox.Show("Bạn chưa nhập Người đo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (txtLeader.Text.Trim() == "")
			{
				MessageBox.Show("Bạn chưa nhập Leader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// hiện thị messagebox về việc lưu dữ liệu
			DialogResult rs = MessageBox.Show("Bạn muốn lưu dữ liệu?", "Lưu dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (rs == DialogResult.Cancel) return;
			// thực hiện lấy giá trị trên form
			for (int i = 0; i < _qty; i++)
			{
				TesttaModel tModel = new TesttaModel();
				tModel.ID = TextUtils.ToInt(grvData.Rows[i].Cells[colID.Name].Value);
				tModel.Number = TextUtils.ToInt(grvData.Rows[i].Cells[colNumber.Name].Value);
				tModel.ClockDial11 = TextUtils.ToDecimal(grvData.Rows[i].Cells[colClockDial11.Name].Value);
				tModel.ClockDial12 = TextUtils.ToDecimal(grvData.Rows[i].Cells[colClockDial12.Name].Value);
				tModel.VibrationForward1 = TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrationForward1.Name].Value);
				tModel.VibrationReverse1 = TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrationReverse1.Name].Value);
				tModel.CheckEye11 = TextUtils.ToString(grvData.Rows[i].Cells[colCheckEye11.Name].Value);
				tModel.CheckEye12 = TextUtils.ToString(grvData.Rows[i].Cells[colCheckEye12.Name].Value);
				tModel.Result1 = TextUtils.ToString(grvData.Rows[i].Cells[colResult1.Name].Value);
				tModel.Vibrate11 = TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrate11.Name].Value);
				tModel.Vibrate12 = TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrate12.Name].Value);
				tModel.Vibrate13 = TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrate13.Name].Value);
				tModel.ClockDial21 = TextUtils.ToDecimal(grvData.Rows[i].Cells[colClockDial21.Name].Value);
				tModel.ClockDial22 = TextUtils.ToDecimal(grvData.Rows[i].Cells[colClockDial22.Name].Value);
				tModel.VibrationForward2 = TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrationForward2.Name].Value);
				tModel.VibrationReverse2 = TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrationReverse2.Name].Value);
				tModel.CheckEye21 = TextUtils.ToString(grvData.Rows[i].Cells[colCheckEye21.Name].Value);
				tModel.CheckEye22 = TextUtils.ToString(grvData.Rows[i].Cells[colCheckEye22.Name].Value);
				tModel.Result2 = TextUtils.ToString(grvData.Rows[i].Cells[colResult2.Name].Value);
				tModel.Vibrate21 = TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrate21.Name].Value);
				tModel.Vibrate22 = TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrate22.Name].Value);
				tModel.Vibrate23 = TextUtils.ToDecimal(grvData.Rows[i].Cells[colVibrate23.Name].Value);
				tModel.OrderCode = txtOrderNo.Text.Trim();
				tModel.DateWork = dteNgayGiaCong.Value.Date;
				tModel.WorkerName = txtWorkerName.Text.Trim();
				tModel.MeasureName = txtMeasureName.Text.Trim();
				tModel.Leader = txtLeader.Text.Trim();

				// nếu ID = 0 thì thực hiện insert dữ liệu lên Database
				if (tModel.ID == 0)
				{
					TesttaBO.Instance.Insert(tModel);
				}
				// ID khác 0 thực hiện update dữ liệu lên DataBase
				else
				{
					TesttaBO.Instance.Update(tModel);
				}
			}

			txtOrderNo.Text = "";
			LoadData();
			//MessageBox.Show("Đã hoàn thành việc lưu dữ liệu", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		/// <summary>
		/// write OK,NG and color Green or Red in dataGridView
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void grvData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			// nếu chưa có dòng nào trên Grid, return
			if (e.RowIndex < 0)
			{
				return;
			}
			// gán index columns
			int index1 = grvData.Columns[colClockDial12.Name].Index;
			int index2 = grvData.Columns[colVibrationForward1.Name].Index;
			int index3 = grvData.Columns[colVibrationReverse1.Name].Index;
			int index4 = grvData.Columns[colClockDial22.Name].Index;
			int index5 = grvData.Columns[colVibrationForward2.Name].Index;
			int index6 = grvData.Columns[colVibrationReverse2.Name].Index;
			int index7 = grvData.Columns[colVibrate21.Name].Index;
			int index8 = grvData.Columns[colVibrate22.Name].Index;
			int index9 = grvData.Columns[colVibrate23.Name].Index;
			// thực hiện check giá trị. Hiển thị kết quả OK/NG , màu sắc
			// khi có sự thay đổi giá trị tại 1 trong 3 cột
			if (e.ColumnIndex == index1 || e.ColumnIndex == index2 || e.ColumnIndex == index3)
			{
				// so sánh giá trị Result1
				if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colClockDial12.Name].Value) <= TextUtils.ToDecimal(txtSlitMax.Text) ||
					TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationForward1.Name].Value) <= TextUtils.ToDecimal(txtVibrateMaxT.Text) ||
					TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationReverse1.Name].Value) <= TextUtils.ToDecimal(txtVibrateMaxN.Text))
				{
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colClockDial12.Name].Value) <= TextUtils.ToDecimal(txtSlitMax.Text))
					{
						grvData.Rows[e.RowIndex].Cells[colClockDial12.Name].Style.BackColor = temColor1;
					}
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationForward1.Name].Value) <= TextUtils.ToDecimal(txtVibrateMaxT.Text))
					{
						grvData.Rows[e.RowIndex].Cells[colVibrationForward1.Name].Style.BackColor = temColor1;
					}
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationReverse1.Name].Value) <= TextUtils.ToDecimal(txtVibrateMaxN.Text))
					{
						grvData.Rows[e.RowIndex].Cells[colVibrationReverse1.Name].Style.BackColor = temColor1;
					}
					grvData.Rows[e.RowIndex].Cells[colResult1.Name].Value = "OK";
					grvData.Rows[e.RowIndex].Cells[colResult1.Name].Style.BackColor = Color.Green;
				}
				// so sánh giá trị Result1
				if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colClockDial12.Name].Value) > TextUtils.ToDecimal(txtSlitMax.Text) ||
					TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationForward1.Name].Value) > TextUtils.ToDecimal(txtVibrateMaxT.Text) ||
					TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationReverse1.Name].Value) > TextUtils.ToDecimal(txtVibrateMaxN.Text))
				{
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colClockDial12.Name].Value) > TextUtils.ToDecimal(txtSlitMax.Text))
					{
						grvData.Rows[e.RowIndex].Cells[colClockDial12.Name].Style.BackColor = tempColor;
					}
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationForward1.Name].Value) > TextUtils.ToDecimal(txtVibrateMaxT.Text))
					{
						grvData.Rows[e.RowIndex].Cells[colVibrationForward1.Name].Style.BackColor = tempColor;
					}
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationReverse1.Name].Value) > TextUtils.ToDecimal(txtVibrateMaxN.Text))
					{
						grvData.Rows[e.RowIndex].Cells[colVibrationReverse1.Name].Style.BackColor = tempColor;
					}
					grvData.Rows[e.RowIndex].Cells[colResult1.Name].Value = "NG";
					grvData.Rows[e.RowIndex].Cells[colResult1.Name].Style.BackColor = tempColor;
				}
			}
			// so sánh giá trị Result2
			if (e.ColumnIndex == index4 || e.ColumnIndex == index5 || e.ColumnIndex == index6 ||
				e.ColumnIndex == index7 || e.ColumnIndex == index8 || e.ColumnIndex == index9)
			{
				if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colClockDial22.Name].Value) <= TextUtils.ToDecimal(txtSlitMax.Text.ToString()) ||
					TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationForward2.Name].Value) <= TextUtils.ToDecimal(txtVibrateMaxT.Text.ToString()) ||
					TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationReverse2.Name].Value) <= TextUtils.ToDecimal(txtVibrateMaxN.Text.ToString()) ||
					TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrate21.Name].Value) <= 0.01M ||
					TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrate22.Name].Value) <= 0.02M ||
					TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrate23.Name].Value) <= 0.01M)
				{
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colClockDial22.Name].Value) <= TextUtils.ToDecimal(txtSlitMax.Text.ToString()))
					{
						grvData.Rows[e.RowIndex].Cells[colClockDial22.Name].Style.BackColor = temColor1;
					}
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationForward2.Name].Value) <= TextUtils.ToDecimal(txtVibrateMaxT.Text.ToString()))
					{
						grvData.Rows[e.RowIndex].Cells[colVibrationForward2.Name].Style.BackColor = temColor1;
					}
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationReverse2.Name].Value) <= TextUtils.ToDecimal(txtVibrateMaxN.Text.ToString()))
					{
						grvData.Rows[e.RowIndex].Cells[colVibrationReverse2.Name].Style.BackColor = temColor1;
					}
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrate21.Name].Value) <= 0.01M)
					{
						grvData.Rows[e.RowIndex].Cells[colVibrate21.Name].Style.BackColor = temColor1;
					}
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrate22.Name].Value) <= 0.02M)
					{
						grvData.Rows[e.RowIndex].Cells[colVibrate22.Name].Style.BackColor = temColor1;
					}
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrate23.Name].Value) <= 0.01M)
					{
						grvData.Rows[e.RowIndex].Cells[colVibrate23.Name].Style.BackColor = temColor1;
					}
					grvData.Rows[e.RowIndex].Cells[colResult2.Name].Value = "OK";
					grvData.Rows[e.RowIndex].Cells[colResult2.Name].Style.BackColor = Color.Green;
				}
				// so sánh giá trị Result2
				if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colClockDial22.Name].Value) > TextUtils.ToDecimal(txtSlitMax.Text.ToString()) ||
					TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationForward2.Name].Value) > TextUtils.ToDecimal(txtVibrateMaxT.Text.ToString()) ||
					TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationReverse2.Name].Value) > TextUtils.ToDecimal(txtVibrateMaxN.Text.ToString()) ||
					TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrate21.Name].Value) > 0.01M ||
					TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrate22.Name].Value) > 0.02M ||
					TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrate23.Name].Value) > 0.01M)
				{
					grvData.Rows[e.RowIndex].Cells[colResult2.Name].Value = "NG";
					grvData.Rows[e.RowIndex].Cells[colResult2.Name].Style.BackColor = Color.Red;
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colClockDial22.Name].Value) > TextUtils.ToDecimal(txtSlitMax.Text.ToString()))
					{
						grvData.Rows[e.RowIndex].Cells[colClockDial22.Name].Style.BackColor = tempColor;
					}
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationForward2.Name].Value) > TextUtils.ToDecimal(txtVibrateMaxT.Text.ToString()))
					{
						grvData.Rows[e.RowIndex].Cells[colVibrationForward2.Name].Style.BackColor = tempColor;
					}
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrationReverse2.Name].Value) > TextUtils.ToDecimal(txtVibrateMaxN.Text.ToString()))
					{
						grvData.Rows[e.RowIndex].Cells[colVibrationReverse2.Name].Style.BackColor = tempColor;
					}
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrate21.Name].Value) > 0.01M)
					{
						grvData.Rows[e.RowIndex].Cells[colVibrate21.Name].Style.BackColor = tempColor;
					}
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrate22.Name].Value) > 0.02M)
					{
						grvData.Rows[e.RowIndex].Cells[colVibrate22.Name].Style.BackColor = tempColor;
					}
					if (TextUtils.ToDecimal(grvData.Rows[e.RowIndex].Cells[colVibrate23.Name].Value) > 0.01M)
					{
						grvData.Rows[e.RowIndex].Cells[colVibrate23.Name].Style.BackColor = tempColor;
					}
				}
			}
		}

		/// <summary>
		/// Sự kiện khi next ô tiếp theo khi đã điền dữ liệu vào ô trên grid
		/// created by: nguyenvan.thao
		/// created date: 25.12.2019
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void grvData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			if (grvData.Columns[e.ColumnIndex].Name == colResult1.Name)
			{
				grvData.CurrentCell = grvData[colClockDial11.Index, e.RowIndex + 1];
				grvData.BeginEdit(true);
				
			}else if(grvData.Columns[e.ColumnIndex].Name == colResult2.Name)
			{
				grvData.CurrentCell = grvData[colClockDial21.Index, e.RowIndex + 1];
				grvData.BeginEdit(true);
			}
			else
			{
				SendKeys.Send("{Tab}");
				SendKeys.Send("{Up}");
			}
		}

		/// <summary>
		/// Sự kiện dùng để xem lại ảnh khi muốn check bằng mắt thường
		/// created by: nvthao
		/// created date: 25.12.2019
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void grvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			if (e.ColumnIndex < 0) return;
			if (!grvData.Columns[e.ColumnIndex].Name.Contains("colCheckEye")) return;
			string fileName = string.Format("{0}_{1}_{2}.jpg"
				, txtOrderNo.Text.Trim()
				, txtLAP.Text.Trim()
				, TextUtils.ToString(grvData.Rows[e.RowIndex].Cells[colNumber.Name].Value));
			fileName = @"F:\222.PNG";
			Process.Start(fileName);
		}

		private void grvData_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)			
			{
				int cellCurrentIndex = grvData.CurrentCell.ColumnIndex;
				if (cellCurrentIndex == colResult1.Index)
				{
					grvData.CurrentCell = grvData[colClockDial11.Index, grvData.CurrentCell.RowIndex];
					//SendKeys.Send("{Up}");
				}
				else if(cellCurrentIndex == colResult2.Index)
				{
					grvData.CurrentCell = grvData[colClockDial21.Index, grvData.CurrentCell.RowIndex];
					//SendKeys.Send("{Up}");
				}
				else
				{
					SendKeys.Send("{Tab}");
					SendKeys.Send("{Up}");
				}
			}
		}

		
	}
}

