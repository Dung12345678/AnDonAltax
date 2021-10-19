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
	public partial class frmRisk : Form
	{
		private bool _isAdd;
		public frmRisk()
		{
			InitializeComponent();
		}
		private void frmRisk_Load(object sender, EventArgs e)
		{
			LoadRisk();
			ClearInterface();
		}
		#region methods
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
			txtCode.Text = "";
			txtDescription.Text = "";
		}

		private void LoadRisk()
		{
			ArrayList arrRisk = RiskBO.Instance.FindAll();
			grdData.DataSource = arrRisk;
			grvData.BestFitColumns();
		}

		private bool checkValid()
		{
			
			if (txtCode.Text == "")
			{
				MessageBox.Show("You have not entered code!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (txtDescription.Text == "")
			{
				MessageBox.Show("You have not entered description!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			return true;
		}

		#endregion

		#region events
		private void btnNew_Click(object sender, EventArgs e)
		{
			SetInterface(true);
			_isAdd = true;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (!grvData.IsDataRow(grvData.FocusedRowHandle))
				return;
			SetInterface(true);
			_isAdd = false;
			txtCode.Text = TextUtils.ToString(grvData.GetRowCellValue(grvData.FocusedRowHandle, "Code"));
			txtDescription.Text = TextUtils.ToString(grvData.GetRowCellValue(grvData.FocusedRowHandle, "Description"));			
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (!grvData.IsDataRow(grvData.FocusedRowHandle))
				return;
			int ID = TextUtils.ToInt(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ID").ToString());
			string strName = grvData.GetRowCellValue(grvData.FocusedRowHandle, "Code").ToString();

			DialogResult result = MessageBox.Show(String.Format("Are you want to delete [{0}] ?", strName), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No) return;
			try
			{
				RiskBO.Instance.Delete(ID);
				LoadRisk();
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
				if (checkValid())
				{
					RiskModel risk;
					if (_isAdd)
					{
						risk = new RiskModel();
					}
					else
					{
						int ID = Convert.ToInt32(grvData.GetRowCellValue(grvData.FocusedRowHandle, "ID").ToString());
						risk = RiskBO.Instance.FindByPK(ID) as RiskModel;
					}
					risk.Code = txtCode.Text;
					risk.Description = txtDescription.Text;
					if (_isAdd)
					{
						RiskBO.Instance.Insert(risk);
											
					}
					else
					{
						RiskBO.Instance.Update(risk);
					}
					SetInterface(false);
					ClearInterface();
					LoadRisk();
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
		#endregion	
	}
}
