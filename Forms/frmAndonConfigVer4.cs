using BMS.Business;
using BMS.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMS
{
	public delegate void UpdateAndon(bool isUpdate);
	public partial class frmAndonConfigVer4 : Form
	{
		private bool _isAdd;
		public UpdateAndon _UpdateAndon;
		public frmAndonConfigVer4()
		{
			InitializeComponent();
		}

		private void frmAndonConfigVer3_Load(object sender, EventArgs e)
		{
			
			loadShiftAndTaktTime();
			ClearInterface();
			LoadData();
		}

		#region methods

		void changeEndDateTime(DateTime startDate, DateTime startTime)
		{
			if (cbxShiftType.SelectedItem == null) return;
			DataRowView shift = cbxShiftType.SelectedItem as DataRowView;
			DateTime sTime = TextUtils.ToDate3(shift.Row["StartTime"]);
			DateTime eTime = TextUtils.ToDate3(shift.Row["EndTime"]);
			// check thời gian bắt đầu ca và thời gian kết thúc ca trong bảng Shift
			// trường hợp thời gian bắt đầu > thời gian kết thúc thì hiểu là thời gian kết thúc đã sang ngày khác
			if (sTime > eTime)
			{
				eTime = eTime.AddDays(1);
			}
			TimeSpan span = eTime - sTime;
			DateTime dateTimeStart = startDate.Date.AddHours(startTime.Hour).AddMinutes(startTime.Minute);
			DateTime dateTimeEnd = dateTimeStart.AddMinutes(span.TotalMinutes);
			pickerEndTime.Value = dateTimeEnd;		
		}

		void changePlanDay(DateTime sTime, DateTime eTime, DateTime sBreak1,
			DateTime eBreak1, DateTime sBreak2, DateTime eBreak2, DateTime sBreak3, DateTime eBreak3, DateTime sBreak4, DateTime eBreak4)
		{
			// nếu start time >= end time thì add 1 ngày để biểu thị là sang ngày mới
			if (cbxShiftType.SelectedItem == null) return;
			TimeSpan timeSpan = (eTime - sTime) - (eBreak1 - sBreak1) - (eBreak2
				- sBreak2) - (eBreak3 - sBreak3) - (eBreak4 - sBreak4);
			int totalSeconds = (int)timeSpan.TotalSeconds;
			int takt = TextUtils.ToInt(txtTakt.Text);
			txtPlanDay.Text = (totalSeconds / takt).ToString();
		}
		private bool checkValid(DateTime sTime, DateTime eTime, DateTime sBreak1, DateTime eBreak1,
			DateTime sBreak2, DateTime eBreak2, DateTime sBreak3, DateTime eBreak3, DateTime sBreak4, DateTime eBreak4)
		{
			if (cbxShiftType.SelectedIndex == -1)
			{
				MessageBox.Show("You have not select a shift!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}							
			if (sTime > sBreak1)
			{
				MessageBox.Show("Time Start >= Time Break Start!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (sTime > sBreak2)
			{
				MessageBox.Show("Time Start >= Time Break Start!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (sTime > sBreak3)
			{
				MessageBox.Show("Time Start >= Time Break Start!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (sTime > sBreak4)
			{
				MessageBox.Show("Time Start >= Time Break Start!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (eTime < eBreak1)
			{
				MessageBox.Show("Time End <= Time End Break!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (eTime < eBreak2)
			{
				MessageBox.Show("Time End <= Time End Break!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (eTime < eBreak3)
			{
				MessageBox.Show("Time End <= Time End Break!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (eTime < eBreak4)
			{
				MessageBox.Show("Time End <= Time End Break!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			return true;
		}

		// Xử lý thời gian bắt đầu ca, kết thúc ca, bắt đầu giờ nghỉ,kết thức giờ nghỉ trên Form
		private DateTime[] loadDateTime(DateTime dateStart, DateTime sTime, DateTime eTime, DateTime sBreak1,
			DateTime eBreak1, DateTime sBreak2, DateTime eBreak2, DateTime sBreak3, DateTime eBreak3, DateTime sBreak4, DateTime eBreak4)
		{
			// Lấy các mốc thời gian theo ngày bắt đầu
			DateTime dateTimeStart = dateStart.Date.AddHours(sTime.Hour).AddMinutes(sTime.Minute);
			DateTime dateTimeEnd = dateStart.Date.AddHours(eTime.Hour).AddMinutes(eTime.Minute);
			DateTime dateTimeStartBreak1 = dateStart.Date.AddHours(sBreak1.Hour).AddMinutes(sBreak1.Minute);
			DateTime dateTimeEndtBreak1 = dateStart.Date.AddHours(eBreak1.Hour).AddMinutes(eBreak1.Minute);
			DateTime dateTimeStartBreak2 = dateStart.Date.AddHours(sBreak2.Hour).AddMinutes(sBreak2.Minute);
			DateTime dateTimeEndtBreak2 = dateStart.Date.AddHours(eBreak2.Hour).AddMinutes(eBreak2.Minute);
			DateTime dateTimeStartBreak3 = dateStart.Date.AddHours(sBreak3.Hour).AddMinutes(sBreak3.Minute);
			DateTime dateTimeEndtBreak3 = dateStart.Date.AddHours(eBreak3.Hour).AddMinutes(eBreak3.Minute);
			DateTime dateTimeStartBreak4 = dateStart.Date.AddHours(sBreak4.Hour).AddMinutes(sBreak4.Minute);
			DateTime dateTimeEndtBreak4 = dateStart.Date.AddHours(eBreak4.Hour).AddMinutes(eBreak4.Minute);
			if (dateTimeStart > dateTimeEnd)
			{
				dateTimeEnd = dateTimeEnd.AddDays(1);
			}
			if (dateTimeStartBreak1 > dateTimeEndtBreak1)
			{
				dateTimeEndtBreak1 = dateTimeEndtBreak1.AddDays(1);
			}
			else if (dateTimeStart > dateTimeStartBreak1)
			{	
				dateTimeStartBreak1 = dateTimeStartBreak1.AddDays(1);
				dateTimeEndtBreak1 = dateTimeEndtBreak1.AddDays(1);	
			}
			if (dateTimeStartBreak2 > dateTimeEndtBreak2)
			{
				dateTimeEndtBreak2 = dateTimeEndtBreak2.AddDays(1);
			}
			else if (dateTimeStart > dateTimeStartBreak2)
			{
				dateTimeStartBreak2 = dateTimeStartBreak2.AddDays(1);
				dateTimeEndtBreak2 = dateTimeEndtBreak2.AddDays(1);
			}
			if (dateTimeStartBreak3 > dateTimeEndtBreak3)
			{
				dateTimeEndtBreak3 = dateTimeEndtBreak3.AddDays(1);
			}
			else if (dateTimeStart > dateTimeStartBreak3)
			{
				dateTimeStartBreak3 = dateTimeStartBreak3.AddDays(1);
				dateTimeEndtBreak3 = dateTimeEndtBreak3.AddDays(1);
			}
			if (dateTimeStartBreak4 > dateTimeEndtBreak4)
			{
				dateTimeEndtBreak4 = dateTimeEndtBreak4.AddDays(1);
			}
			else if (dateTimeStart > dateTimeStartBreak4)
			{
				dateTimeStartBreak4 = dateTimeStartBreak4.AddDays(1);
				dateTimeEndtBreak4 = dateTimeEndtBreak4.AddDays(1);
			}

			/*if (dateTimeStart > dateTimeStartBreak)
			{
				if (dateTimeStartBreak > dateTimeEndtBreak)
				{
					//dateTimeStartBreak = dateTimeStartBreak.AddDays(1);
					dateTimeEndtBreak = dateTimeEndtBreak.AddDays(1);
					return new[] { dateTimeStart, dateTimeEnd, dateTimeStartBreak, dateTimeEndtBreak };
				}
				dateTimeStartBreak = dateTimeStartBreak.AddDays(1);
				dateTimeEndtBreak = dateTimeEndtBreak.AddDays(1);			
				return new[] { dateTimeStart, dateTimeEnd, dateTimeStartBreak, dateTimeEndtBreak };
			}*/

			return new[] { dateTimeStart, dateTimeEnd, dateTimeStartBreak1, dateTimeEndtBreak1, dateTimeStartBreak2, 
				dateTimeEndtBreak2, dateTimeStartBreak3, dateTimeEndtBreak3, dateTimeStartBreak4, dateTimeEndtBreak4 };
		}
		private void loadShiftAndTaktTime()
		{			
			object takt = TextUtils.ExcuteScalar("Select Takt from dbo.AndonConfig with(nolock)");
			txtTakt.Text = TextUtils.ToString(takt);
			DataTable data = TextUtils.Select("Select * from dbo.Shift with(nolock)");
			//ArrayList arr = ShiftBO.Instance.FindAll(
			//DataTable data = TextUtils.LoadDataFromSP("spGetShift", "Shift", new string[] { }, new object[] { });
			cbxShiftType.DataSource = data;
			cbxShiftType.DisplayMember = "Name";
			cbxShiftType.ValueMember = "ID";
		}
		private void LoadData()
		{
			// Load Andon có thời gian bắt đầu >= ngày hiện tại để hiển thị lên gridView
			DataTable data = TextUtils.LoadDataFromSP("spGetAndonByDate", "Andon", new string[] { }, new object[] { });
			grdData.DataSource = data;
		}

		private void SetInterface(bool isEdit)
		{
			grdData.Enabled = !isEdit;

			btnSave.Visible = isEdit;
			btnCancel.Visible = isEdit;

			btnNew.Visible = !isEdit;
			btnEdit.Visible = !isEdit;
			btnDelete.Visible = !isEdit;
		}

		private void ClearInterface()
		{
			object takt = TextUtils.ExcuteScalar("Select top 1 Takt from AndonConfig");
			txtTakt.Text = TextUtils.ToString(takt);
			DateTime date = DateTime.Now.Date;
			pickerStartDate.Value = date;
			pickerStartTime.Value = date.AddHours(0);
			pickerEndTime.Value = date.AddHours(0);
			pickerStartBreak1.Value = date.AddHours(0);
			pickerEndBreak1.Value = date.AddHours(0);
			pickerStartBreak2.Value = date.AddHours(0);
			pickerEndBreak2.Value = date.AddHours(0);
			pickerStartBreak3.Value = date.AddHours(0);
			pickerEndBreak3.Value = date.AddHours(0);
			pickerStartBreak4.Value = date.AddHours(0);
			pickerEndBreak4.Value = date.AddHours(0);
			cbxShiftType.SelectedIndex = -1;
		}
		#endregion

		#region events
		private void btnNew_Click(object sender, EventArgs e)
		{
			SetInterface(true);			
			_isAdd = true;
			cbxShiftType.SelectedIndex = 0;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (!grvData.IsDataRow(grvData.FocusedRowHandle))
				return;
			SetInterface(true);
			_isAdd = false;
			txtPlanDay.Text = TextUtils.ToString(grvData.GetRowCellValue(grvData.FocusedRowHandle, "QtyPlanDay"));
			txtTakt.Text = TextUtils.ToString(grvData.GetRowCellValue(grvData.FocusedRowHandle, "Takt"));
			pickerStartDate.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ShiftStartTime"));
			pickerStartTime.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ShiftStartTime"));
			pickerEndTime.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ShiftEndTime"));
			pickerStartBreak1.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "StartTimeBreak1"));
			pickerEndBreak1.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "EndTimeBreak1"));
			pickerStartBreak2.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "StartTimeBreak2"));
			pickerEndBreak2.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "EndTimeBreak2"));
			pickerStartBreak3.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "StartTimeBreak3"));
			pickerEndBreak3.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "EndTimeBreak3"));
			pickerStartBreak4.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "StartTimeBreak4"));
			pickerEndBreak4.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "EndTimeBreak4"));
			cbxShiftType.SelectedValue = TextUtils.ToInt(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ShiftID"));
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (!grvData.IsDataRow(grvData.FocusedRowHandle))
				return;
			int ID = TextUtils.ToInt(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ID"));
			string sTime = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ShiftStartTime")).ToString("yyyy/MM/dd HH:mm");
			string eTime = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ShiftEndTime")).ToString("yyyy/MM/dd HH:mm");
			DialogResult result = MessageBox.Show(String.Format("Are you want to delete a shift {0} - {1} ?", sTime, eTime), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No) return;
			try
			{
				AndonBO.Instance.Delete(ID);
				LoadData();
			}
			catch (Exception)
			{
				MessageBox.Show("An error occurred during processing, please try again later!");
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				textBox1.Focus();

				DateTime[] dateTimes = loadDateTime(pickerStartDate.Value, pickerStartTime.Value, pickerEndTime.Value, 
					pickerStartBreak1.Value, pickerEndBreak1.Value, pickerStartBreak2.Value, pickerEndBreak2.Value, pickerStartBreak3.Value, pickerEndBreak3.Value, pickerStartBreak4.Value, pickerEndBreak4.Value);
				if (checkValid(dateTimes[0], dateTimes[1], dateTimes[2], dateTimes[3], dateTimes[4], dateTimes[5], dateTimes[6], dateTimes[7], dateTimes[8], dateTimes[9]))
				{
					AndonModel andon = new AndonModel();					
					if (!_isAdd)
					{
						// Check trong khoảng thời gian xem đã có ca nào được tạo chưa trừ ca đang chọn
						int ID = Convert.ToInt32(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ID").ToString());						
						andon = AndonBO.Instance.FindByPK(ID) as AndonModel;
					}

					string sql = string.Format("exec spCheckAndonIsUpdatedByTime @AndonID = {0}, @dateTimeStart = '{1}', @dateTimeEnd = '{2}'", andon.ID, dateTimes[0].ToString("yyyy-MM-dd HH:mm"), dateTimes[1].ToString("yyyy-MM-dd HH:mm"));
					int check = TextUtils.ToInt(TextUtils.ExcuteScalar(sql));
					if (check > 0)
					{
						MessageBox.Show(dateTimes[0].ToString("yyyy/MM/dd HH:mm") + " - " + dateTimes[1].ToString("yyyy/MM/dd HH:mm") + " had a another shift  ", "Notice", MessageBoxButtons.OK);
						return;
					}

					//DataRowView shiftRow = cbxShiftType.SelectedItem as DataRowView;
					TimeSpan timeSpan = dateTimes[1] - dateTimes[0];
					int totalSeconds = TextUtils.ToInt(timeSpan.TotalSeconds);
					andon.ShiftStartTime = dateTimes[0];
					andon.ShiftEndTime = dateTimes[1];
					andon.StartTimeBreak1 = dateTimes[2];
					andon.EndTimeBreak1 = dateTimes[3];
					andon.StartTimeBreak2 = dateTimes[4];
					andon.EndTimeBreak2 = dateTimes[5];
					andon.StartTimeBreak3 = dateTimes[6];
					andon.EndTimeBreak3 = dateTimes[7];
					andon.StartTimeBreak4 = dateTimes[8];
					andon.EndTimeBreak4 = dateTimes[9];
					andon.TotalSeconds = totalSeconds;
					andon.Takt = TextUtils.ToInt(txtTakt.Text);
					andon.QtyPlanDay = TextUtils.ToInt(txtPlanDay.Text);
					andon.ShiftID = TextUtils.ToInt(cbxShiftType.SelectedValue);
					
					if (_isAdd)
					{
						andon.IsStart = false;
						AndonBO.Instance.Insert(andon);
					}
					else
					{
						_UpdateAndon(false);
						AndonBO.Instance.Update(andon);
						_UpdateAndon(true);
					}
					LoadData();
					SetInterface(false);
					ClearInterface();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			SetInterface(false);
			ClearInterface();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbxShiftType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxShiftType.SelectedItem == null) return;
			if (_isAdd)
			{
				DataRowView shift = cbxShiftType.SelectedItem as DataRowView;
				//ShiftModel m = 
				pickerStartTime.Value = TextUtils.ToDate3(shift.Row["StartTime"]);
				pickerEndTime.Value = TextUtils.ToDate3(shift.Row["EndTime"]);
				pickerStartBreak1.Value = TextUtils.ToDate3(shift.Row["StartTimeBreak1"]);
				pickerEndBreak1.Value = TextUtils.ToDate3(shift.Row["EndTimeBreak1"]);
				pickerStartBreak2.Value = TextUtils.ToDate3(shift.Row["StartTimeBreak2"]);
				pickerEndBreak2.Value = TextUtils.ToDate3(shift.Row["EndTimeBreak2"]);
				pickerStartBreak3.Value = TextUtils.ToDate3(shift.Row["StartTimeBreak3"]);
				pickerEndBreak3.Value = TextUtils.ToDate3(shift.Row["EndTimeBreak3"]);
				pickerStartBreak4.Value = TextUtils.ToDate3(shift.Row["StartTimeBreak4"]);
				pickerEndBreak4.Value = TextUtils.ToDate3(shift.Row["EndTimeBreak4"]);
				DateTime[] dateTimes = loadDateTime(pickerStartDate.Value, pickerStartTime.Value, pickerEndTime.Value, pickerStartBreak1.Value, pickerEndBreak1.Value,
					pickerStartBreak2.Value, pickerEndBreak2.Value, pickerStartBreak3.Value, pickerEndBreak3.Value, pickerStartBreak4.Value, pickerEndBreak4.Value);

				changePlanDay(dateTimes[0], dateTimes[1], dateTimes[2], dateTimes[3], dateTimes[4],
					dateTimes[5], dateTimes[6], dateTimes[7], dateTimes[8], dateTimes[9]);
			}
		}
		private void pickerStartDate_ValueChanged(object sender, EventArgs e)
		{
			changeEndDateTime(pickerStartDate.Value, pickerStartTime.Value);
			DateTime[] dateTimes = loadDateTime(pickerStartDate.Value, pickerStartTime.Value, pickerEndTime.Value, pickerStartBreak1.Value, pickerEndBreak1.Value,
					pickerStartBreak2.Value, pickerEndBreak2.Value, pickerStartBreak3.Value, pickerEndBreak3.Value, pickerStartBreak4.Value, pickerEndBreak4.Value);

			changePlanDay(dateTimes[0], dateTimes[1], dateTimes[2], dateTimes[3], dateTimes[4],
				dateTimes[5], dateTimes[6], dateTimes[7], dateTimes[8], dateTimes[9]);
		}
		private void pickerStartTime_ValueChanged(object sender, EventArgs e)
		{
			changeEndDateTime(pickerStartDate.Value, pickerStartTime.Value);
			DateTime[] dateTimes = loadDateTime(pickerStartDate.Value, pickerStartTime.Value, pickerEndTime.Value, pickerStartBreak1.Value, pickerEndBreak1.Value,
					pickerStartBreak2.Value, pickerEndBreak2.Value, pickerStartBreak3.Value, pickerEndBreak3.Value, pickerStartBreak4.Value, pickerEndBreak4.Value);

			changePlanDay(dateTimes[0], dateTimes[1], dateTimes[2], dateTimes[3], dateTimes[4],
				dateTimes[5], dateTimes[6], dateTimes[7], dateTimes[8], dateTimes[9]);
		}
		private void pickerEndTime_ValueChanged(object sender, EventArgs e)
		{
			DateTime[] dateTimes = loadDateTime(pickerStartDate.Value, pickerStartTime.Value, pickerEndTime.Value, pickerStartBreak1.Value, pickerEndBreak1.Value,
					pickerStartBreak2.Value, pickerEndBreak2.Value, pickerStartBreak3.Value, pickerEndBreak3.Value, pickerStartBreak4.Value, pickerEndBreak4.Value);

			changePlanDay(dateTimes[0], dateTimes[1], dateTimes[2], dateTimes[3], dateTimes[4],
				dateTimes[5], dateTimes[6], dateTimes[7], dateTimes[8], dateTimes[9]);
		}
		private void pickerStartBreak_ValueChanged(object sender, EventArgs e)
		{
			DateTime[] dateTimes = loadDateTime(pickerStartDate.Value, pickerStartTime.Value, pickerEndTime.Value, pickerStartBreak1.Value, pickerEndBreak1.Value,
					pickerStartBreak2.Value, pickerEndBreak2.Value, pickerStartBreak3.Value, pickerEndBreak3.Value, pickerStartBreak4.Value, pickerEndBreak4.Value);

			changePlanDay(dateTimes[0], dateTimes[1], dateTimes[2], dateTimes[3], dateTimes[4],
				dateTimes[5], dateTimes[6], dateTimes[7], dateTimes[8], dateTimes[9]);
		}
		private void pickerEndBreak_ValueChanged(object sender, EventArgs e)
		{
			DateTime[] dateTimes = loadDateTime(pickerStartDate.Value, pickerStartTime.Value, pickerEndTime.Value, pickerStartBreak1.Value, pickerEndBreak1.Value,
					pickerStartBreak2.Value, pickerEndBreak2.Value, pickerStartBreak3.Value, pickerEndBreak3.Value, pickerStartBreak4.Value, pickerEndBreak4.Value);

			changePlanDay(dateTimes[0], dateTimes[1], dateTimes[2], dateTimes[3], dateTimes[4],
				dateTimes[5], dateTimes[6], dateTimes[7], dateTimes[8], dateTimes[9]);
		}

		private void pickerStartBreak2_ValueChanged(object sender, EventArgs e)
		{
			DateTime[] dateTimes = loadDateTime(pickerStartDate.Value, pickerStartTime.Value, pickerEndTime.Value, pickerStartBreak1.Value, pickerEndBreak1.Value,
					pickerStartBreak2.Value, pickerEndBreak2.Value, pickerStartBreak3.Value, pickerEndBreak3.Value, pickerStartBreak4.Value, pickerEndBreak4.Value);

			changePlanDay(dateTimes[0], dateTimes[1], dateTimes[2], dateTimes[3], dateTimes[4],
				dateTimes[5], dateTimes[6], dateTimes[7], dateTimes[8], dateTimes[9]);
		}

		private void pickerEndBreak2_ValueChanged(object sender, EventArgs e)
		{
			DateTime[] dateTimes = loadDateTime(pickerStartDate.Value, pickerStartTime.Value, pickerEndTime.Value, pickerStartBreak1.Value, pickerEndBreak1.Value,
					pickerStartBreak2.Value, pickerEndBreak2.Value, pickerStartBreak3.Value, pickerEndBreak3.Value, pickerStartBreak4.Value, pickerEndBreak4.Value);

			changePlanDay(dateTimes[0], dateTimes[1], dateTimes[2], dateTimes[3], dateTimes[4],
				dateTimes[5], dateTimes[6], dateTimes[7], dateTimes[8], dateTimes[9]);
		}

		private void pickerStartBreak3_ValueChanged(object sender, EventArgs e)
		{
			DateTime[] dateTimes = loadDateTime(pickerStartDate.Value, pickerStartTime.Value, pickerEndTime.Value, pickerStartBreak1.Value, pickerEndBreak1.Value,
					pickerStartBreak2.Value, pickerEndBreak2.Value, pickerStartBreak3.Value, pickerEndBreak3.Value, pickerStartBreak4.Value, pickerEndBreak4.Value);

			changePlanDay(dateTimes[0], dateTimes[1], dateTimes[2], dateTimes[3], dateTimes[4],
				dateTimes[5], dateTimes[6], dateTimes[7], dateTimes[8], dateTimes[9]);
		}

		private void pickerEndBreak3_ValueChanged(object sender, EventArgs e)
		{
			DateTime[] dateTimes = loadDateTime(pickerStartDate.Value, pickerStartTime.Value, pickerEndTime.Value, pickerStartBreak1.Value, pickerEndBreak1.Value,
					pickerStartBreak2.Value, pickerEndBreak2.Value, pickerStartBreak3.Value, pickerEndBreak3.Value, pickerStartBreak4.Value, pickerEndBreak4.Value);

			changePlanDay(dateTimes[0], dateTimes[1], dateTimes[2], dateTimes[3], dateTimes[4],
				dateTimes[5], dateTimes[6], dateTimes[7], dateTimes[8], dateTimes[9]);
		}

		private void pickerStartBreak4_ValueChanged(object sender, EventArgs e)
		{
			DateTime[] dateTimes = loadDateTime(pickerStartDate.Value, pickerStartTime.Value, pickerEndTime.Value, pickerStartBreak1.Value, pickerEndBreak1.Value,
					pickerStartBreak2.Value, pickerEndBreak2.Value, pickerStartBreak3.Value, pickerEndBreak3.Value, pickerStartBreak4.Value, pickerEndBreak4.Value);

			changePlanDay(dateTimes[0], dateTimes[1], dateTimes[2], dateTimes[3], dateTimes[4],
				dateTimes[5], dateTimes[6], dateTimes[7], dateTimes[8], dateTimes[9]);
		}

		private void pickerEndBreak4_ValueChanged(object sender, EventArgs e)
		{
			DateTime[] dateTimes = loadDateTime(pickerStartDate.Value, pickerStartTime.Value, pickerEndTime.Value, pickerStartBreak1.Value, pickerEndBreak1.Value,
					pickerStartBreak2.Value, pickerEndBreak2.Value, pickerStartBreak3.Value, pickerEndBreak3.Value, pickerStartBreak4.Value, pickerEndBreak4.Value);

			changePlanDay(dateTimes[0], dateTimes[1], dateTimes[2], dateTimes[3], dateTimes[4],
				dateTimes[5], dateTimes[6], dateTimes[7], dateTimes[8], dateTimes[9]);
		}

		#endregion

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
