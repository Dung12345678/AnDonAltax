using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BMS.Model;

namespace BMS
{
    public partial class CheckControl : UserControl
    {
        public ProductCheckHistoryDetailModel _model;
        public CheckControl()
        {
            InitializeComponent();
        }

        private void CheckControl_Load(object sender, EventArgs e)
        {
            txtEditValue1.Visible = txtEditValue2.Visible = txtRealValue1.Visible = _model.ValueType == 1;
            chkValue1.Visible = chkValue2.Visible = chkValue.Visible = !(_model.ValueType == 1);

            txtWorkingName.Text = _model.WorkingName;
            txtStandardValue.Text = _model.StandardValue;
            txtEditValue1.Text = _model.EditValue1;
            txtEditValue2.Text = _model.EditValue2;
            txtRealValue1.Text = _model.RealValue;

            chkValue.Checked = _model.ValueType == 0 && _model.RealValue == "V";
            chkValue1.Checked = _model.ValueType == 0 && _model.EditValue1 == "V";
            chkValue2.Checked = _model.ValueType == 0 && _model.EditValue2 == "V";

            if (_model.Comport > 0)
            {
                txtRealValue1.ReadOnly = true;
                GetWeightValue getWeightValue = new GetWeightValue(this);
            }
        }

        public void SetErrorCom()
        {
            txtRealValue1.BackColor = Color.Red;
        }

        public void SetRealValue(string realValue)
        {
            txtRealValue1.Text = realValue;
            _model.RealValue = realValue;
        }

        private void txtRealValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _model.RealValue = txtRealValue1.Text.Trim();
            }
        }

        private void txtRealValue_Leave(object sender, EventArgs e)
        {
            _model.RealValue = txtRealValue1.Text.Trim();
        }

        private void txtEditValue1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _model.EditValue1 = txtEditValue1.Text.Trim();
            }
        }

        private void txtEditValue1_Leave(object sender, EventArgs e)
        {
            _model.EditValue1 = txtEditValue1.Text.Trim();
        }

        private void txtEditValue2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _model.EditValue2 = txtEditValue2.Text.Trim();
            }
        }

        private void txtEditValue2_Leave(object sender, EventArgs e)
        {
            _model.EditValue2 = txtEditValue2.Text.Trim();
        }

        private void chkValue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValue.Checked)
            {
                _model.RealValue = "V";
            }
            else
            {
                _model.RealValue = "";
            }
        }
        private void chkValue1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValue1.Checked)
            {
                _model.EditValue1 = "V";
            }
            else
            {
                _model.EditValue1 = "";
            }
        }

        private void chkValue2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValue2.Checked)
            {
                _model.EditValue2 = "V";
            }
            else
            {
                _model.EditValue2 = "";
            }
        }
    }
}
