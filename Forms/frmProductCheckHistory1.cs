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

namespace BMS
{
    public partial class frmProductCheckHistory1 : Form
    {
        public long _WorkerID = 0;
        string _order = "";
        string _productCode = "";
        string _tienTo = "";
        string _stt = "";
        int _stepIndex = 0;
        Color _colorEmpty;

        int oldHeight = 0;
        int oldHeightGrid = 0;

        DataTable _dtData = new DataTable();

        public frmProductCheckHistory1()
        {
            InitializeComponent();
        }
        private void frmProductCheckHistory1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.btnSave, "F12");

            _colorEmpty = Color.FromArgb(255, 192, 255);
            initBackColor();
            oldHeight = this.Height;
            oldHeightGrid = grdData.Height;
        }
        /// <summary>
        /// Set focus vào cell trên grid
        /// </summary>
        /// <param name="indexRow"></param>
        /// <param name="indexColum"></param>
        void setFocusCell(int indexRow, int indexColum)
        {
            grvData.FocusedRowHandle = indexRow;

            grvData.FocusedColumn = grvData.VisibleColumns[indexColum];

            grvData.ShowEditor();
        }
        public void SetConnectCom(int rowIndex, bool isConnect)
        {
            for (int i = 1; i < 7; i++)
            {
                grvData.SetRowCellValue(rowIndex, colIsConnected, isConnect);
            }
        }
        void initBackColor()
        {
            if (cboWorkingStep.SelectedIndex > 0)
            {
                cboWorkingStep.BackColor = Color.White;
            }
            else
            {
                cboWorkingStep.BackColor = _colorEmpty;
            }

            if (string.IsNullOrWhiteSpace(txtQRCode.Text))
            {
                txtQRCode.BackColor = _colorEmpty;
            }
            else
            {
                txtQRCode.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtWorker.Text))
            {
                txtWorker.BackColor = _colorEmpty;
            }
            else
            {
                txtWorker.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtOrder.Text))
            {
                txtOrder.BackColor = _colorEmpty;
            }
            else
            {
                txtOrder.BackColor = Color.White;
            }
        }
        void loadStep(string productCode)
        {
            DataTable dt = TextUtils.LoadDataFromSP("spGetProductStep_ByProductCode", "A"
                , new string[1] { "@ProductCode" }
                , new object[1] { productCode });
            DataRow dr = dt.NewRow();
            dr["ID"] = 0;
            dr["ProductStepCode"] = "";
            dt.Rows.InsertAt(dr, 0);

            cboWorkingStep.DataSource = dt;
            cboWorkingStep.DisplayMember = "ProductStepCode";
            cboWorkingStep.ValueMember = "ID";

            if (_stepIndex > 0 && _stepIndex < dt.Rows.Count)
            {
                cboWorkingStep.SelectedIndex = _stepIndex;
            }
        }
        /// <summary>
        /// Load danh sách công đoạn kiểm tra
        /// </summary>
        void loadDataWorkingStep()
        {
            if (!string.IsNullOrWhiteSpace(txtQRCode.Text.Trim()))
            {
                string orderCode = txtQRCode.Text.Trim();
                string[] arr = orderCode.Split(' ');
                if (arr.Length > 1)
                {
                    loadStep(arr[1]);
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
        public void SetRealValue(object value, int rowIndex, int workingID)
        {
            int id = TextUtils.ToInt(grvData.GetRowCellValue(rowIndex, colWorkingID));
            if (id != workingID) return;

            this.grvData.SetRowCellValue(rowIndex, grvData.FocusedColumn, value);
            if (rowIndex < grvData.RowCount - 1)
            {
                this.setFocusCell(rowIndex + 1, grvData.FocusedColumn.VisibleIndex);
            }
            else
            {
                (this.Controls.Find("textBox" + (grvData.FocusedColumn.VisibleIndex - 2), true)[0]).Focus();
            }
        }

        int getSumHeightRows()
        {
            int total = 0;
            GridViewInfo vi = grvData.GetViewInfo() as GridViewInfo;
            for (int i = 0; i < grvData.RowCount; i++)
            {
                GridRowInfo ri = vi.RowsInfo.FindRow(i);
                if (ri != null)
                    total += ri.Bounds.Height;
            }
            
            return total;
        }

        int getRowIndex(int columnIndex)
        {
            int rowIndex = -1;
            for (int i = 0; i < _dtData.Rows.Count; i++)
            {
                DataRow r = _dtData.Rows[i];
                string value = TextUtils.ToString(r["RealValue" + (columnIndex - 2)]);
                int type = TextUtils.ToInt(r["ValueType"]);
                int checkValueType = TextUtils.ToInt(r["CheckValueType"]);
                string standardValue = TextUtils.ToString(r["StandardValue"]);
                if ((string.IsNullOrWhiteSpace(value) && type > 0) || (checkValueType == 2 && string.IsNullOrWhiteSpace(value) && !string.IsNullOrWhiteSpace(standardValue)))
                {
                    rowIndex = i;
                    break;
                }
            }
            if (rowIndex == -1)
            {
                rowIndex = grvData.RowCount - 1;
            }
            return rowIndex;
        }
        void resetControl()
        {
            /*
             * reset lại tiêu đề cột, các kết quả check
             */
            for (int i = 3; i < 9; i++)
            {
                grvData.Columns["RealValue" + (i - 2)].Caption = "#";

                Control control = this.Controls.Find("textbox" + (i - 2), false)[0];
                control.Text = "";
            }
        }

        bool _isStartColor = false;
        private void cboWorkingStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Stopwatch s = new Stopwatch();
            //s.Start();
            _isStartColor = false;
            int workingStepID = TextUtils.ToInt(cboWorkingStep.SelectedValue);
            string qrCode = txtQRCode.Text.Trim();
            if (string.IsNullOrWhiteSpace(qrCode)) return;

            if (cboWorkingStep.SelectedIndex > 0)
            {
                cboWorkingStep.BackColor = Color.White;
            }
            else
            {
                cboWorkingStep.BackColor = _colorEmpty;
            }

            resetControl();

            if (workingStepID == 0)
            {
                _dtData = null;
                grdData.DataSource = null;
                txtStepName.Text = "";
                return;
            }
            /*
             * Tách chuỗi QrCode
             */
            string orderCode = txtQRCode.Text.Trim();
            string[] arr1 = orderCode.Split(' ');
            if (arr1.Length > 1)
            {
                _order = arr1[0];
                _productCode = arr1[1].Trim();
                string[] arr;
                if (_order.Contains("-"))
                {
                    arr = _order.Split('-');
                    _tienTo = (arr[0] + "-" + arr[1] + "-");
                    _stt = arr[2];
                }
                else
                {
                    arr = Regex.Split(_order, @"\D+");
                    _stt = arr[arr.Length - 1];
                    _tienTo = _order.Substring(0, _order.IndexOf(_stt));
                }
            }
            //s.Stop();
            //double a = s.Elapsed.TotalSeconds;

            //s.Restart();
            //Gán dữ liệu vào grid
            DataSet ds = ProductCheckHistoryDetailBO.Instance.GetDataSet("spGetWorkingByProduct",
                new string[] { "@WorkingStepID", "@WorkingStepCode", "@ProductCode" },
                new object[] { workingStepID, cboWorkingStep.Text, arr1[1].ToString() });
            //s.Stop();
            //double b = s.Elapsed.TotalSeconds;
            //s.Restart();
            _dtData = ds.Tables[0];
            grdData.DataSource = _dtData;
            txtStepName.Text = TextUtils.ToString(ds.Tables[1].Rows[0][0]);
            //grvData.Columns["RealValue1"].Caption = _stt;

            string maSungLuc = TextUtils.ToString(ds.Tables[1].Rows[0][1]);
            //Khởi tạo các hàm lấy dữ liệu tự động
            for (int i = 0; i < _dtData.Rows.Count; i++)
            {
                DataRow dr = _dtData.Rows[i];
                int value = TextUtils.ToInt(dr["Comport"]);
                int workingID = TextUtils.ToInt(dr["WorkingID"]);
                int port = TextUtils.ToInt(dr["Port"]);
                string ip = TextUtils.ToString(dr["IpAddress"]);

                if (value > 0)
                {
                    BalanceObj clsGetComValue = new BalanceObj(this, "COM" + value, 15, 0, i, workingID);
                }
                
                if (port > 0 && !string.IsNullOrWhiteSpace(ip))
                {
                    TouqueMObj cls = new TouqueMObj(this, ip, port, i, workingID, maSungLuc);
                    maSungLuc = "";
                }
            }
            //s.Stop();
            //double c = s.Elapsed.TotalSeconds;
            // Set lại chiều cao của dòng
            grvData.RowHeight = -1;
            int totalHeightRow = this.getSumHeightRows();
            if ((oldHeightGrid - grvData.ColumnPanelRowHeight - 30) > totalHeightRow)
            {
                grvData.RowHeight = (oldHeightGrid - grvData.ColumnPanelRowHeight - 30) / grvData.RowCount;
            }

            //Nhảy đến ô cần điền giá trị đầu tiên
            int cIndex = grvData.Columns["RealValue1"].VisibleIndex;
            setFocusCell(getRowIndex(cIndex), cIndex);
           

            //MessageBox.Show(string.Format("{0} {1} {2}", a, b, c));
            _isStartColor = true;
        }        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grvData.RowCount == 0)
            {
                return;
            }

            int productID = TextUtils.ToInt(TextUtils.ExcuteScalar(string.Format("SELECT TOP 1 ID FROM dbo.Product WITH(NOLOCK) WHERE ProductCode = '{0}'", _productCode.Trim())));
            int stepID = TextUtils.ToInt(cboWorkingStep.SelectedValue);
            if (productID == 0)
            {
                MessageBox.Show(string.Format("Không tồn tại sản phẩm có mã [{0}]!", _productCode.Trim()), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (stepID == 0)
            {
                MessageBox.Show(string.Format("Bạn chưa chọn công đoạn nào!", _productCode.Trim()), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtWorker.Text.Trim()))
            {
                MessageBox.Show(string.Format("Bạn chưa điền người làm!", _productCode.Trim()), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isHasValue = false;
            for (int i = 1; i < 7; i++)
            {
                Control control = this.Controls.Find("textbox" + i, false)[0];
                if (control.Text == "0" || control.Text == "1")
                {
                    isHasValue = true;
                    break;
                }
            }
            if (!isHasValue)
            {
                //MessageBox.Show("Bạn chưa nhập các giá trị kiểm tra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn cất dữ liệu?", "Cất?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            
            int count = _dtData.Rows.Count;
            for (int i = 3; i < 9; i++)
            {
                Control control = this.Controls.Find("textbox" + (i - 2), false)[0];
                string columnCaption = grvData.Columns[i].Caption;
                string qrCode = "";
                if (columnCaption == "#") continue;
                else
                {
                    qrCode = _tienTo + columnCaption + " " + _productCode;
                }
                if (string.IsNullOrWhiteSpace(control.Text.Trim()) || TextUtils.ToInt(control.Text.Trim()) > 1 || TextUtils.ToInt(control.Text.Trim()) < 0)
                {
                    continue;
                }

                /*
                 * Xóa các giá trị đã lưu cũ
                 */
                ProductCheckHistoryDetailBO.Instance.DeleteByExpression(new Utils.Expression("QRCode", qrCode).And(new Utils.Expression("ProductStepID", stepID)));
                /*
                 * Insert lại dữ liệu kiểm tra vào bảng
                 */
                for (int j = 0; j < count; j++)
                {
                    ProductCheckHistoryDetailModel cModel = new ProductCheckHistoryDetailModel();
                    cModel.ProductStepID = stepID;
                    cModel.ProductWorkingID = TextUtils.ToInt(grvData.GetRowCellValue(j, colWorkingID));                     
                    cModel.WorkerCode = txtWorker.Text.Trim();
                    cModel.StandardValue = TextUtils.ToString(grvData.GetRowCellValue(j, colStandardValue)); 
                    cModel.RealValue = TextUtils.ToString(grvData.GetRowCellValue(j, "RealValue" + (i - 2)));
                    cModel.ValueType = TextUtils.ToInt(grvData.GetRowCellValue(j, colValueType));
                    cModel.EditValue1 = "";
                    cModel.EditValue2 = "";
                    cModel.StatusResult = TextUtils.ToInt(control.Text.Trim());
                    cModel.ProductID = productID;
                    cModel.QRCode = qrCode;
                    cModel.OrderCode = string.IsNullOrWhiteSpace(txtOrder.Text.Trim()) ? 
                        (_tienTo.Contains("-") ? _tienTo.Substring(0, _tienTo.Length - 1) : _order) : 
                        txtOrder.Text.Trim();
                    cModel.PackageNumber = _tienTo.Contains("-") ? _tienTo.Split('-')[1] : "";
                    cModel.QtyInPackage = columnCaption;
                    cModel.Approved = "";
                    cModel.Monitor = "";
                    cModel.DateLR = DateTime.Now;
                    cModel.EditContent = "";
                    cModel.EditDate = DateTime.Now;

                    cModel.ProductOrder = _order;

                    ProductCheckHistoryDetailBO.Instance.Insert(cModel);
                }
            }

            _stepIndex = cboWorkingStep.SelectedIndex;

            grdData.DataSource = null;
            txtQRCode.Text = "";
            cboWorkingStep.DataSource = null;
            resetControl();
            txtQRCode.Focus();
        }
        private void txtQRCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboWorkingStep.Focus();
                loadDataWorkingStep();
            }
            else
            {
                return;
            }
        }
        private void txtQRCode_Leave(object sender, EventArgs e)
        {
        }
        private void frmProductCheckHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Nếu là dòng cuối cùng thì nhảy xuống control check box bên dưới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grvData_KeyDown(object sender, KeyEventArgs e)
        {
            if (grvData.FocusedRowHandle == grvData.RowCount -1 && e.KeyCode == Keys.Down)//dòng cuối cùng
            {
                int indexColumn = grvData.FocusedColumn.VisibleIndex;
                (this.Controls.Find("textBox" + (indexColumn-2), true)[0]).Focus();
            }
        }       
        private void grvData_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!_isStartColor) return;
            if (e.RowHandle >= 0 && e.Column.VisibleIndex > 2)
            {
                Control control = this.Controls.Find("textbox" + (e.Column.VisibleIndex - 2), false)[0];
                if (control.Text.Trim() == "0" || control.Text.Trim() == "1")
                {
                    control.BackColor = Color.White;
                }
                else
                {
                    control.BackColor = _colorEmpty;
                }

                if (e.RowHandle < grvData.RowCount - 1)
                {
                    this.setFocusCell(e.RowHandle + 1, grvData.FocusedColumn.VisibleIndex);
                }
                else
                {
                    (this.Controls.Find("textBox" + (grvData.FocusedColumn.VisibleIndex - 2), true)[0]).Focus();
                }

                if (cboWorkingStep.Text == "CD3")
                {
                    string fieldName = string.Format("RealValue{0}", e.Column.VisibleIndex - 2);

                    DataRow r = _dtData.Select("SortOrder = 80")[0];
                    DataRow r1 = _dtData.Select("SortOrder = 70")[0];
                    DataRow r2 = _dtData.Select("SortOrder = 60")[0];
                    DataRow r3 = _dtData.Select("SortOrder = 50")[0];
                    List<decimal> lst = new List<decimal>() {TextUtils.ToDecimal(r1[fieldName]), TextUtils.ToDecimal(r2[fieldName]), TextUtils.ToDecimal(r3[fieldName])};

                    r[fieldName] = lst.Max() - lst.Min();
                }
            }
        }
        private void grvData_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (!_isStartColor) return;
            if (e.RowHandle < 0) return;

            if (e.Column.VisibleIndex < 3) return;

            string value = TextUtils.ToString(grvData.GetRowCellValue(e.RowHandle, e.Column));            
            //int comport = TextUtils.ToInt(grvData.GetRowCellValue(e.RowHandle, colComport));
            //bool isConnect = TextUtils.ToBoolean(grvData.GetRowCellValue(e.RowHandle, colIsConnected));
            int checkValueType = TextUtils.ToInt(grvData.GetRowCellValue(e.RowHandle, colCheckValueType));
            string standardValue = TextUtils.ToString(grvData.GetRowCellValue(e.RowHandle, colNote));

            if (checkValueType == 2 && !string.IsNullOrWhiteSpace(value.Trim()) && !string.IsNullOrWhiteSpace(standardValue.Trim()))
            {
                string[] arr = value.Split(',');
                if (arr.Length > 0 && arr[0].ToLower() != standardValue.ToLower())
                {
                    e.Appearance.BackColor = Color.Red;
                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(102, 255, 255);
                }
                return;
            }

            int valueType = TextUtils.ToInt(grvData.GetRowCellValue(e.RowHandle, colValueType));
            if (valueType <= 0)
            {
                if(checkValueType == 2 && string.IsNullOrWhiteSpace(value.Trim()) && !string.IsNullOrWhiteSpace(standardValue.Trim()))
                {
                    e.Appearance.BackColor = _colorEmpty;
                }
                if (value == "OK")
                {
                    e.Appearance.BackColor = Color.FromArgb(102, 255, 255);
                }
                else if (value == "NG")
                {
                    e.Appearance.BackColor = Color.Red;
                }
                return;
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                e.Appearance.BackColor = _colorEmpty;
            }
            else
            {
                decimal number = TextUtils.ToDecimal(value);
                decimal min = TextUtils.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colMinValue));
                decimal max = TextUtils.ToDecimal(grvData.GetRowCellValue(e.RowHandle, colMaxValue));
                if (number < min || number > max)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.FromArgb(255, 255, 0);
                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(102, 255, 255);
                }
            }

            //102, 255, 255
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text.Trim()))
            {
                txt.BackColor = _colorEmpty;
            }
            else
            {
                txt.BackColor = Color.White;
            }
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            
            if(txt.Text.Trim()=="0" || txt.Text.Trim() == "1")
            {
                txt.BackColor = Color.White;
            }
            else
            {
                txt.BackColor = _colorEmpty;
            }
        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (grvData.RowCount == 0) return;
            TextBox textBox = (TextBox)sender;
            int textIndex = TextUtils.ToInt(textBox.Tag);

            int columnIndex = textIndex + 2;          

            //if (columnIndex - 2 != textIndex)
            //{
            //    return;
            //}

            //Khi ấn mũi tên đi lên thì focus vào cột tương ứng
            if (e.KeyCode == Keys.Up)
            {
                setFocusCell(getRowIndex(columnIndex), columnIndex);
            }

            if (e.KeyCode == Keys.Enter)
            {
                string value = ((TextBox)sender).Text;

                string valueString = "";// 
                if (value == "1")
                {
                    valueString = "OK";
                }
                else if (value == "0")
                {
                    valueString = "NG";
                }

                //Set giá trị các ô có giá trị check mark
                for (int i = 0; i < _dtData.Rows.Count; i++)
                {
                    DataRow r = _dtData.Rows[i];
                    
                    int checkValueType = TextUtils.ToInt(r["CheckValueType"]);
                    string standardValue = TextUtils.ToString(r["StandardValue"]);
                    int valueType = TextUtils.ToInt(r["ValueType"]);

                    if (valueType > 0) continue;

                    if (checkValueType == 2 && !string.IsNullOrWhiteSpace(standardValue))
                    {
                        continue;
                    }

                    if (valueType == 0)
                    {
                        r["RealValue" + (columnIndex - 2)] = valueString;
                    }
                }
                //Set tiêu đề cột trước khi chuyển sang cột mới
                if (value == "1" || value == "0")
                {
                    grvData.Columns["RealValue" + (columnIndex - 2)].Caption = (int.Parse(_stt) + columnIndex - 3).ToString();

                    if (columnIndex < 8)
                    {
                        //focus vào ô của cột tiếp theo
                        setFocusCell(getRowIndex(columnIndex + 1), columnIndex + 1);
                    }
                    else
                    {
                        btnSave.Focus();
                    }
                }
                else
                {
                    setFocusCell(getRowIndex(columnIndex), columnIndex);
                }
            }
        }

        private void textBox_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave_Click(null, null);
        }
    }
}
