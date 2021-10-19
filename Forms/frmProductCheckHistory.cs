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
    public partial class frmProductCheckHistory : _Forms
    {
        public long _ProductID = 0;
        public long _WorkerID = 0;

        List<CheckControl> lstUC = new List<CheckControl>();

        public frmProductCheckHistory()
        {
            InitializeComponent();
        }

        private void btnShowWorking_Click(object sender, EventArgs e)
        {            
            int Y = 0;

            int workingStepID = TextUtils.ToInt(cboWorkingStep.SelectedValue);
            string qrCode = txtQRCode.Text.Trim();
            string workerCode = txtWorker.Text.Trim();
            string productCode = "";
            string orderCode = txtQRCode.Text.Trim();
            string[] arr1 = orderCode.Split(' ');
            if (arr1.Length > 1)
            {
                productCode = arr1[1];
            }

            if (workingStepID == 0)
            {
                MessageBox.Show("Bạn chưa chọn công đoạn kiểm tra!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(qrCode))
            {
                MessageBox.Show("Bạn chưa nhập sản phẩm cần kiểm tra!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!ProductBO.Instance.CheckExist("ProductCode", productCode))
                {
                    MessageBox.Show("Mã sản phẩm không đúng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            //if (string.IsNullOrWhiteSpace(workerCode))
            //{
            //    MessageBox.Show("Bạn chưa nhập người kiểm tra!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //else
            //{
            //    if (!UsersBO.Instance.CheckExist("Code", workerCode))
            //    {
            //        MessageBox.Show("Mã người kiểm tra không đúng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}

            lstUC.Clear();
            panel1.Controls.Clear();

            ArrayList arr = ProductCheckHistoryDetailBO.Instance.GetListObject("spGetWorkingByProductGroupID", 
                new string[4] { "@WorkingStepID", "@QRCode", "@ProductCode", "@WorkerCode" },
                new object[4] { workingStepID, qrCode, productCode, workerCode });

            if (arr.Count > 0)
            {
                foreach (var item in arr)
                {
                    CheckControl uc = new CheckControl();
                    uc._model = (ProductCheckHistoryDetailModel)item;
                    uc.Location = new Point(uc.Location.X, Y);
                    panel1.Controls.Add(uc);
                    Y += 53;
                    lstUC.Add(uc);
                }
            }
            else
            {
                lstUC.Clear();
                panel1.Controls.Clear();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn cất dữ liệu?","Cất?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            int count = lstUC.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    var model = lstUC[i]._model;
                    ProductCheckHistoryDetailBO.Instance.Update(model);
                }
            }
            
            /*
             * reset lại control sau khi cất
             */
            lstUC.Clear();
            panel1.Controls.Clear();
            txtQRCode.Text = "";
            cboWorkingStep.DataSource = null;
        }

        void loadWorkingStep(string productCode)
        {
            DataTable dt = TextUtils.LoadDataFromSP("spGetWorkingStep_ByProduct", "A", new string[1] { "@ProductCode" }, new object[1] { productCode });
            cboWorkingStep.DataSource = dt;
            cboWorkingStep.DisplayMember = "WorkingStepCode";
            cboWorkingStep.ValueMember = "ID";
        }

        void loadDataWorkingStep()
        {
            if (!string.IsNullOrWhiteSpace(txtQRCode.Text.Trim()))
            {
                string orderCode = txtQRCode.Text.Trim();
                string[] arr = orderCode.Split(' ');
                if (arr.Length > 1)
                {
                    loadWorkingStep(arr[1]);
                }
                else
                {
                    cboWorkingStep.DataSource = null;
                }
            }
            else
            {
                cboWorkingStep.DataSource = null;
            }
        }

        private void txtQRCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.Enter)
            {
                loadDataWorkingStep();
            }
            else
            {
                return;
            }
        }

        private void txtQRCode_Leave(object sender, EventArgs e)
        {
            loadDataWorkingStep();
        }

        private void frmProductCheckHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
