using BMS.Business;
using BMS.Model;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace BMS
{
    public partial class frmTestta : Form
    {
        public long _WorkerID = 0;
        int Qty;
        DataTable _dtData = new DataTable();
        public decimal SlitMax;
        private Color tempColor = new Color();
        private Color tempColor1 = new Color();

        public frmTestta()
        {
            InitializeComponent();
        }

        private void txtOrderNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData();
            }
        }
        /// <summary>
        /// LoadDataInTextBox
        /// </summary>
        private void LoadData()
        {
            if (!string.IsNullOrEmpty(txtOrderNo.Text.Trim()))
            {
                
                try
                {
                    DataTable dt = TextUtils.LoadDataFromSP("spGetGearInfo_ByOrderCode", "A"
                      , new string[1] { "@OrderCode" }
                      , new object[1] { txtOrderNo.Text.Trim() });
                    Qty = TextUtils.ToInt(dt.Rows[0]["Qty"]);
                    txtQty.Text = Qty.ToString("n0");
                    txtLAP.Text = TextUtils.ToString(dt.Rows[0]["ProductCode"]);
                    txtSlitMax.Text = TextUtils.ToDecimal(dt.Rows[0]["SlitMax"]).ToString("n3");
                    txtSlitMin.Text = TextUtils.ToDecimal(dt.Rows[0]["SlitMin"]).ToString("n3");
                    txtVibrateMaxT.Text = TextUtils.ToDecimal(dt.Rows[0]["VibrateMax"]).ToString("n3");
                    txtVibrateMaxN.Text = txtVibrateMaxT.Text;
                    txtVibrateMinT.Text = TextUtils.ToDecimal(dt.Rows[0]["VibrateMin"]).ToString("n3");
                    txtVibrateMinN.Text = txtVibrateMinT.Text;
                    SlitMax = Decimal.Parse(txtSlitMax.Text.ToString());
                    AddNewRowInDataTable();

                }
                catch (Exception)
                {

                    MessageBox.Show("OrderNo is not correct");
                }
            }  
        }
        /// <summary>
        /// ShowDataInGrid
        /// </summary>
        private void AddNewRowInDataTable()
        {
            DataTable dt1 = TextUtils.Select(string.Format("SELECT * FROM dbo.Testta WHERE OrderCode = '{0}' order by number",txtOrderNo.Text.Trim()));
            if (dt1.Rows.Count==0)           
            {
                dateTimePicker1.CustomFormat = "dd/MM/yyyy";
                dateTimePicker1.Value = DateTime.Now;
                //dateTimePicker1.Value = new DateTime(2012,1,1);
                dt1 = TextUtils.Select("SELECT * FROM dbo.Testta WHERE ID = 0");
                for (int i = 0; i < Qty; i++)
                {
                    DataRow r = dt1.NewRow();
                    r["Number"] = i + 1;
                    dt1.Rows.Add(r);
                }
                
                grdData.DataSource = dt1;
            }
            else
            {
                grdData.DataSource = dt1;
                dateTimePicker1.CustomFormat = "dd/MM/yyyy";
                dateTimePicker1.Value = Convert.ToDateTime(dt1.Rows[0]["DateWork"]);
                txtWorkerName.Text = TextUtils.ToString(dt1.Rows[0]["WorkerName"]);
                txtName.Text = TextUtils.ToString(dt1.Rows[0]["Name"]);
                txtLeader.Text = TextUtils.ToString(dt1.Rows[0]["Leader"]);
            }
        }
        /// <summary>
        /// F12 is Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn lưu dữ liệu?","Lưu dữ liệu",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) return;
            for (int i = 0; i < Qty ; i++)
            {
                TesttaModel tModel = new TesttaModel();
                tModel.ID = TextUtils.ToInt(grvData.GetRowCellValue(i, colID));
                tModel.Number = TextUtils.ToInt(grvData.GetRowCellValue(i, colNumber));
                tModel.ClockDial11 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colClockDial11));
                tModel.ClockDial12 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colClockDial12));
                tModel.VibrationForward1 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colVibrationMax1));
                tModel.VibrationReverse1 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colVibrationMin1));
                tModel.CheckEye11 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colCheckEye11));
                tModel.CheckEye12 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colCheckEye12));
                tModel.Result1 = TextUtils.ToString(grvData.GetRowCellValue(i, colResult1));
                tModel.Vibrate11 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colVibrate11));
                tModel.Vibrate12 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colVibrate12));
                tModel.Vibrate13 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colVibrate13));
                tModel.ClockDial21 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colClockDial21));
                tModel.ClockDial22 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colClockDial22));
                tModel.VibrationForward2 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colVibrationMax1));
                tModel.VibrationReverse2 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colVibrationMin1));
                tModel.CheckEye21 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colCheckEye21));
                tModel.CheckEye22 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colCheckEye22));
                tModel.Result2 = TextUtils.ToString(grvData.GetRowCellValue(i, colResult2));
                tModel.Vibrate21 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colVibrate21));
                tModel.Vibrate22 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colVibrate22));
                tModel.Vibrate23 = TextUtils.ToDecimal(grvData.GetRowCellValue(i, colVibrate23));
                tModel.OrderCode = txtOrderNo.Text;
                tModel.DateWork = dateTimePicker1.Value.Date;
                tModel.WorkerName = txtWorkerName.Text;
                tModel.MeasureName = txtName.Text;
                tModel.Leader = txtLeader.Text;
                if (txtWorkerName.Text.Trim()=="" || txtName.Text.Trim() == "" || txtLeader.Text.Trim() == "")
                {
                    if (txtWorkerName.Text.Trim() == "")
                    {
                        MessageBox.Show("chưa nhập tên người gia công","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    if (txtName.Text.Trim() == "")
                    {
                        MessageBox.Show("chưa nhập tên người đo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtLeader.Text.Trim() == "")
                    {
                        MessageBox.Show("chưa nhập tên Leader", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if (tModel.ID == 0)
                    {
                        TesttaBO.Instance.Insert(tModel);
                    }
                    else
                    {
                        TesttaBO.Instance.Update(tModel);
                    }
                }
            }
            MessageBox.Show("Đã hoàn thành việc lưu dữ liệu","Hoàn thành",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        /// Check_OK_NG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grvData_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colClockDial12 || e.Column == colVibrationMax1 || e.Column == colVibrationMin1)
            {
                if (TextUtils.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colClockDial12)) <= Decimal.Parse(txtSlitMax.Text.ToString()) && TextUtils.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colVibrationMax1)) <= Decimal.Parse(txtVibrateMaxT.Text.ToString()) && TextUtils.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colVibrationMin1)) <= Decimal.Parse(txtVibrateMaxN.Text.ToString()))
                {
                    grvData.SetRowCellValue(e.RowHandle,colResult1,"OK");
                }
                else
                {
                    grvData.SetRowCellValue(e.RowHandle, colResult1, "NG");
                }
                return;
            }
            if (e.Column == colVibrate21 || e.Column == colVibrate22 || e.Column == colVibrate23 || e.Column == colClockDial22 || e.Column == colVibrationMax2 || e.Column == colVibrationMin2)
            {
                if (TextUtils.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colClockDial22)) <= Decimal.Parse(txtSlitMax.Text.ToString()) && TextUtils.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colVibrationMax2)) <= Decimal.Parse(txtVibrateMaxT.Text.ToString()) && TextUtils.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colVibrationMin2)) <= Decimal.Parse(txtVibrateMaxN.Text.ToString()) && TextUtils.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colVibrate21)) <= 0.01M && TextUtils.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colVibrate22)) <= 0.02M && TextUtils.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colVibrate23)) <= 0.01M)
                {
                    grvData.SetRowCellValue(e.RowHandle, colResult2, "OK");
                }
                else
                {
                    grvData.SetRowCellValue(e.RowHandle, colResult2, "NG");

                }
                return;
            }
        }

        private void grvData_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            string value = TextUtils.ToString(grvData.GetRowCellValue(e.RowHandle, e.Column));
            if ((value == "NG")&&(tempColor
                != Color.Red))
            {
                e.Appearance.BackColor = Color.Red;
                return;
            }
            
            if ((value == "OK") && (tempColor != Color.Green))
            {
                e.Appearance.BackColor = Color.Green;
                return;
            }
            //if (e.Column == colClockDial12)
            //{
            //    if (TextUtils.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colClockDial12)) > Decimal.Parse(txtSlitMax.Text.ToString()))
            //    {
            //        e.Appearance.BackColor = Color.Red;
            //        return;
            //    }
            //}



        }
    }
}

