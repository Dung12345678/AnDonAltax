using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BMS.Utils;
using BMS.BO;
using BMS.Model;
using BMS.Facade;
using BMS.Exceptions;
using BMS.Business;
using CrystalDecisions.CrystalReports.Engine;

namespace BMS
{
    public partial class frmReportViewer : _Forms
    {
        #region Khai bao cac thuoc tinh

        public string path;
        public DataTable data;
        public string[] FormulaFields;
        public string[] FormulaFieldsValue;

        #endregion

        #region Get and Set

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public DataTable Data
        {
            get { return data; }
            set { data = value; }
        }

        #endregion

        #region Load Form

        public frmReportViewer()
        {
            InitializeComponent();
        }

        #endregion

        #region Cac ham viet them

        public void ShowReport()
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                rpt.Load(Application.StartupPath+"\\"+ this.Path);

                if (this.Data != null)
                    rpt.SetDataSource(this.Data);

                if (FormulaFieldsValue != null)
                {
                    for (int i = 0; i < FormulaFields.Length; i++)
                    {
                        rpt.DataDefinition.FormulaFields[FormulaFields[i]].Text = "\"" + FormulaFieldsValue[i] + "\"";
                    }
                }
                rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
                this.ShowDialog();
            }
            catch (Exception ex)
            {
                frmGenMessageBox frm = new frmGenMessageBox("_SystemMessage",
                                                             "frmReportViewer",
                                                             "ShowReport",
                                                             TextUtils.Caption,
                                                             "",
                                                             ex.Message, MessageBoxIcon.Error);
                frm.ShowDialog();
                return;
            }
        }

        #endregion

        private void frmReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}