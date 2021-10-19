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
	public partial class frmAndonConfigVer3 : Form
	{
		private bool _isAdd;
		public frmAndonConfigVer3()
		{
			InitializeComponent();
		}

		private void frmAndonConfigVer3_Load(object sender, EventArgs e)
		{
			loadCombo();
			LoadData();
		}

		#region methods

		void changeEndDateTime(DateTime startDate, DateTime startTime)
		{
			DataRowView r = cbxShiftType.SelectedItem as DataRowView;
			if (r != null)
			{
				int shiftHour = TextUtils.ToDate3(r.Row["TotalTime"]).Hour;
				DateTime dateTimeEnd = startDate.Date.AddHours(startTime.Hour).AddMinutes(startTime.Minute).AddHours(shiftHour);
				pickerEndDate.Value = dateTimeEnd;
				pickerEndTime.Value = dateTimeEnd;
			}
		}

		void changePlanDay(DateTime timeStart, DateTime dateStart, DateTime timeEnd, DateTime dateEnd)
		{
			DateTime dateTimeStart = dateStart.Date.AddHours(timeStart.Hour).AddMinutes(timeStart.Minute);
			DateTime dateTimeEnd = dateEnd.Date.AddHours(timeEnd.Hour).AddMinutes(timeEnd.Minute);
			TimeSpan timeSpan = (TimeSpan)(dateTimeEnd - dateTimeStart);
			int totalSeconds = (int)timeSpan.TotalSeconds;
			int takt = TextUtils.ToInt(txtTakt.Text);
			txtPlanDay.Text = (totalSeconds / takt).ToString();
		}

		private bool checkValid(DateTime dateTimeStart, DateTime dateTimeEnd)
		{
			if (cbxShiftType.SelectedIndex == -1)
			{
				MessageBox.Show("You have not select a shift.", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (dateTimeStart > dateTimeEnd)
			{
				MessageBox.Show("Start Time > End Time.", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			
			return true;
		}

		private void loadCombo()
		{			
			object takt = TextUtils.ExcuteScalar("Select Takt from AndonConfig");
			txtTakt.Text = TextUtils.ToString(takt);
			DataTable data = TextUtils.LoadDataFromSP("spGetShift", "Shift", new string[] { }, new object[] { });
			cbxShiftType.DataSource = data;
			cbxShiftType.DisplayMember = "hourTime";
			cbxShiftType.ValueMember = "ID";
		}
		private void LoadData()
		{
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
			object takt = TextUtils.ExcuteScalar("Select Takt from AndonConfig");
			txtTakt.Text = TextUtils.ToString(takt);
			DateTime date = DateTime.Now.Date;
			pickerStartDate.Value = date;
			pickerStartTime.Value = date.AddHours(8);
			pickerEndDate.Value = date;
			pickerEndTime.Value = date.AddHours(12);			
		}
		#endregion

		#region events
		private void btnNew_Click(object sender, EventArgs e)
		{
			SetInterface(true);
			ClearInterface();
			_isAdd = true;
			cbxShiftType.SelectedIndex = 1;
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
			pickerEndDate.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ShiftEndTime"));
			pickerEndTime.Value = TextUtils.ToDate3(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ShiftEndTime"));
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
				DateTime dateTimeStart = pickerStartDate.Value.Date.AddHours(pickerStartTime.Value.Hour).AddMinutes(pickerStartTime.Value.Minute);
				DateTime dateTimeEnd = pickerEndDate.Value.Date.AddHours(pickerEndTime.Value.Hour).AddMinutes(pickerEndTime.Value.Minute);
				if (checkValid(dateTimeStart, dateTimeEnd))
				{
					AndonModel andon;
					if (_isAdd)
					{
						string sql = string.Format("exec spCheckAndonIsCreatedByTime @dateTimeStart = '{0}', @dateTimeEnd = '{1}'", dateTimeStart.ToString("yyyy-MM-dd HH:mm"), dateTimeEnd.ToString("yyyy-MM-dd HH:mm"));
						int check = TextUtils.ToInt(TextUtils.ExcuteScalar(sql));
						if (check > 0)
						{
							MessageBox.Show(dateTimeStart.ToString("yyyy/MM/dd HH:mm") + " - " + dateTimeEnd.ToString("yyyy/MM/dd HH:mm") + " exist a another shift  ", "Notice", MessageBoxButtons.OK);
							return;
						}
						andon = new AndonModel();
					}
					else
					{

						int ID = Convert.ToInt32(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ID").ToString());
						string sql = string.Format("exec spCheckAndonIsUpdatedByTime @AndonID = {0}, @dateTimeStart = '{1}', @dateTimeEnd = '{2}'", ID, dateTimeStart.ToString("yyyy-MM-dd HH:mm"), dateTimeEnd.ToString("yyyy-MM-dd HH:mm"));
						int check = TextUtils.ToInt(TextUtils.ExcuteScalar(sql));
						if (check > 0)
						{
							MessageBox.Show(dateTimeStart.ToString("yyyy/MM/dd HH:mm") + " - " + dateTimeEnd.ToString("yyyy/MM/dd HH:mm") + " had a another shift  ", "Notice", MessageBoxButtons.OK);
							return;
						}
						andon = AndonBO.Instance.FindByPK(ID) as AndonModel;
					}
					DataRowView shiftRow = cbxShiftType.SelectedItem as DataRowView;
					TimeSpan timeSpan = dateTimeEnd - dateTimeStart;
					int totalSeconds = TextUtils.ToInt(timeSpan.TotalSeconds);
					andon.ShiftStartTime = dateTimeStart;
					andon.ShiftEndTime = dateTimeEnd;
					andon.TotalSeconds = totalSeconds;
					andon.Takt = TextUtils.ToInt(txtTakt.Text);
					andon.QtyPlanDay = TextUtils.ToInt(txtPlanDay.Text);
					andon.ShiftID = TextUtils.ToInt(shiftRow.Row["ID"]);
					if (_isAdd)
					{
						AndonBO.Instance.Insert(andon);
						LoadData();
						MessageBox.Show("Add a shift successfully!", TextUtils.Caption, MessageBoxButtons.OK);
					}
					else
					{
						AndonBO.Instance.Update(andon);
						LoadData();
						MessageBox.Show("Edit a shift successfully!", TextUtils.Caption, MessageBoxButtons.OK);
					}
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
			changeEndDateTime(pickerStartDate.Value, pickerStartTime.Value);
			changePlanDay(pickerStartTime.Value, pickerStartDate.Value, pickerEndTime.Value, pickerEndDate.Value);
		}

		private void pickerStartDate_ValueChanged(object sender, EventArgs e)
		{
			changeEndDateTime(pickerStartDate.Value, pickerStartTime.Value);
			changePlanDay(pickerStartTime.Value, pickerStartDate.Value, pickerEndTime.Value, pickerEndDate.Value);
		}

		private void pickerStartTime_ValueChanged(object sender, EventArgs e)
		{
			changeEndDateTime(pickerStartDate.Value, pickerStartTime.Value);
			changePlanDay(pickerStartTime.Value, pickerStartDate.Value, pickerEndTime.Value, pickerEndDate.Value);
		}

		private void pickerEndDate_ValueChanged(object sender, EventArgs e)
		{
			changePlanDay(pickerStartTime.Value, pickerStartDate.Value, pickerEndTime.Value, pickerEndDate.Value);

		}

		private void pickerEndTime_ValueChanged(object sender, EventArgs e)
		{
			changePlanDay(pickerStartTime.Value, pickerStartDate.Value, pickerEndTime.Value, pickerEndDate.Value);

		}
		#endregion

	}
}
