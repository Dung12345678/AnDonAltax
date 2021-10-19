using BMS.Business;
using BMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmShifts : Form
	{
		private bool _isAdd;
		public frmShifts()
		{
			InitializeComponent();
		}

		

		private void frmShifts_Load(object sender, EventArgs e)
		{
			loadShifts();
			ClearInterface();
		}

		
		#region Methods
		private void loadShifts()
		{			
			DataTable data = TextUtils.Select("Select * from Shift");
			grdData.DataSource = data;
			grvData.BestFitColumns();

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
			txtName.Text = "";
			DateTime date = DateTime.Now.Date;
			pickerStart.Value = date.AddHours(0);
			pickerEnd.Value = date.AddHours(0);
			pickerStartBreak1.Value = date.AddHours(0);
			pickerEndBreak1.Value = date.AddHours(0);
			pickerStartBreak2.Value = date.AddHours(0);
			pickerEndBreak2.Value = date.AddHours(0);
			pickerStartBreak3.Value = date.AddHours(0);
			pickerEndBreak3.Value = date.AddHours(0);
			pickerStartBreak4.Value = date.AddHours(0);
			pickerEndBreak4.Value = date.AddHours(0);
		}

		private bool checkValid(DateTime startTime, DateTime endTime, DateTime startBreak1, DateTime endBreak1,
			DateTime startBreak2, DateTime endBreak2, DateTime startBreak3, DateTime endBreak3, DateTime startBreak4, DateTime endBreak4)
		{
			if(startBreak1 < startTime || startBreak1 > endTime || startBreak2 < startTime || startBreak2 > endTime
				|| startBreak3 < startTime || startBreak3 > endTime || startBreak4 < startTime || startBreak4 > endTime)
			{
				MessageBox.Show("Start Time Break value invalid!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			if (endBreak1 < startTime || endBreak1 > endTime || endBreak2 < startTime || endBreak2 > endTime
				|| endBreak3 < startTime || endBreak3 > endTime || endBreak4 < startTime || endBreak4 > endTime)
			{
				MessageBox.Show("Start Time Break value invalid!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			if (txtName.Text == "")
			{
				MessageBox.Show("You have not entered the shift name!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			return true;
		}

		private DateTime[] loadDateTime( DateTime sTime, DateTime eTime, DateTime sBreak1,
			DateTime eBreak1, DateTime sBreak2, DateTime eBreak2, DateTime sBreak3, DateTime eBreak3, DateTime sBreak4, DateTime eBreak4)
		{
			DateTime dateStart = DateTime.Now;
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
			
			return new[] { dateTimeStart, dateTimeEnd, dateTimeStartBreak1, dateTimeEndtBreak1, dateTimeStartBreak2,
				dateTimeEndtBreak2, dateTimeStartBreak3, dateTimeEndtBreak3, dateTimeStartBreak4, dateTimeEndtBreak4 };
		}

		#endregion

		#region events
		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (!grvData.IsDataRow(grvData.FocusedRowHandle))
				return;
			SetInterface(true);
			_isAdd = false;
			txtName.Text = TextUtils.ToString(grvData.GetRowCellValue(grvData.FocusedRowHandle, "Name"));
			pickerStart.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "StartTime"));
			pickerEnd.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "EndTime"));
			pickerStartBreak1.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "StartTimeBreak1"));
			pickerEndBreak1.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "EndTimeBreak1"));
			pickerStartBreak2.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "StartTimeBreak2"));
			pickerEndBreak2.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "EndTimeBreak2"));
			pickerStartBreak3.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "StartTimeBreak3"));
			pickerEndBreak3.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "EndTimeBreak3"));
			pickerStartBreak4.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "StartTimeBreak4"));
			pickerEndBreak4.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "EndTimeBreak4"));
		}
		private void btnNew_Click(object sender, EventArgs e)
		{
			SetInterface(true);
			_isAdd = true;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				DateTime[] dateTimes = loadDateTime(pickerStart.Value, pickerEnd.Value,
					pickerStartBreak1.Value, pickerEndBreak1.Value, pickerStartBreak2.Value, pickerEndBreak2.Value, pickerStartBreak3.Value, pickerEndBreak3.Value, pickerStartBreak4.Value, pickerEndBreak4.Value);
				if (checkValid(dateTimes[0], dateTimes[1], dateTimes[2], dateTimes[3],
					dateTimes[4], dateTimes[5], dateTimes[6], dateTimes[7],
					dateTimes[8], dateTimes[9]))
				{
					ShiftModel shift;
					if (_isAdd)
					{
						shift = new ShiftModel();						
					}
					else
					{
						int ID = Convert.ToInt32(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ID").ToString());
						shift = ShiftBO.Instance.FindByPK(ID) as ShiftModel;						
					}
					DateTime sTime = pickerStart.Value;
					DateTime eTime = pickerEnd.Value;
					TimeSpan timeSpan = eTime - sTime;
					int totalSeconds = TextUtils.ToInt(timeSpan.TotalSeconds);
					
					shift.Name = txtName.Text;
					shift.StartTime = sTime;
					shift.EndTime = eTime;
					shift.StartTimeBreak1 = pickerStartBreak1.Value;
					shift.EndTimeBreak1 = pickerEndBreak1.Value;
					shift.StartTimeBreak2 = pickerStartBreak2.Value;
					shift.EndTimeBreak2 = pickerEndBreak2.Value;
					shift.StartTimeBreak3 = pickerStartBreak3.Value;
					shift.EndTimeBreak3 = pickerEndBreak3.Value;
					shift.StartTimeBreak4 = pickerStartBreak4.Value;
					shift.EndTimeBreak4 = pickerEndBreak4.Value;
					shift.TotalTime = sTime.Date.AddHours(timeSpan.Hours).AddMinutes(timeSpan.Minutes);
					
					if (_isAdd)
					{
						ShiftBO.Instance.Insert(shift);
					}
					else
					{
						ShiftBO.Instance.Update(shift);
					}
					SetInterface(false);
					ClearInterface();
					loadShifts();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			

		}

		#endregion

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (!grvData.IsDataRow(grvData.FocusedRowHandle))
				return;
			int ID = TextUtils.ToInt(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ID").ToString());
			string strName = grvData.GetRowCellValue(grvData.FocusedRowHandle, "Name").ToString();

			DialogResult result = MessageBox.Show(String.Format("Are you want to delete [{0}] ?", strName), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No) return;
			try
			{
				ShiftBO.Instance.Delete(ID);
				loadShifts();
			}
			catch (Exception)
			{
				MessageBox.Show("An error occurred during processing, please try again later!");
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

		

		
	}
}
