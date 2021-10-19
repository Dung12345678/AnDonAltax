 using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using BMS.Utils;
using BMS.BO;
using BMS.Model;
using BMS.Facade;
using BMS.Exceptions;
using BMS.Business;
using CrystalDecisions.CrystalReports.Engine;
using System.Drawing.Printing;
using System.Reflection;
using System.Diagnostics;

//using System.Management;

namespace BMS
{
    public partial class frmPosShowReport_New : Form
    {
        #region Khai bao bien dung chung

        public DataTable Source = null;
        public DataTable SubReportSource = null;
        public string ReportName = "";
        public string[] FormulaFields;
        public string[] FormulaFieldsValue;
        public string[] SubFormulaFields;
        public string[] SubFormulaFieldsValue;
        ReportDocument rpt = null;
        int mode = 0;

        ToolStripButton PrintReportToolStripButton = new ToolStripButton();

        #endregion

        #region Load Form

        public frmPosShowReport_New()
        {
            InitializeComponent();
        }
        public frmPosShowReport_New(int _mode)
        {
            mode = _mode;
            InitializeComponent();
        }
        private void frmPosShowReport_Load(object sender, System.EventArgs e)
        {
            this.PrintReportToolStripButton.Click += new System.EventHandler(this.PrintReportToolStripButton_Click);
            ToolStrip ts = null;
            foreach(Control ctrl in crystalReportViewer1.Controls)
            {
                if (ctrl is ToolStrip)
                {
                    ts=(ToolStrip)ctrl;
                    break;
                }
            }
            PrintReportToolStripButton.ToolTipText = "Print Report";
            PrintReportToolStripButton.AutoSize = ((ToolStripButton)ts.Items[0]).AutoSize;
            PrintReportToolStripButton.ImageAlign = ((ToolStripButton)ts.Items[0]).ImageAlign;
            PrintReportToolStripButton.ImageScaling = ((ToolStripButton)ts.Items[0]).ImageScaling;
            ts.Items.RemoveAt(1);
            ts.Items.Insert(1, PrintReportToolStripButton);

            //((ToolStripButton)ts.Items[0]).Image = (Image)Cashering.Properties.Resources.fileexport_32;
            //((ToolStripButton)ts.Items[1]).Image = (Image)Cashering.Properties.Resources.Printer_32__1_;
            //((ToolStripButton)ts.Items[2]).Image = (Image)Cashering.Properties.Resources.Gnome_View_Refresh_32;
            //((ToolStripButton)ts.Items[3]).Image = (Image)Cashering.Properties.Resources.Gnome_Go_First_32;
            //((ToolStripButton)ts.Items[4]).Image = (Image)Cashering.Properties.Resources.Gnome_Go_Previous_32;
            //((ToolStripButton)ts.Items[5]).Image = (Image)Cashering.Properties.Resources.Gnome_Go_Next_32;
            //((ToolStripButton)ts.Items[6]).Image = (Image)Cashering.Properties.Resources.Gnome_Go_Last_32;
            ////goto
            //((ToolStripButton)ts.Items[7]).Image = (Image)Cashering.Properties.Resources.Links_32;
            ////
            //((ToolStripButton)ts.Items[8]).Image = (Image)Cashering.Properties.Resources.fileclose_32;
            ////
            //((ToolStripButton)ts.Items[9]).Image = (Image)Cashering.Properties.Resources.Find_32;

            //((ToolStripButton)ts.Items[10]).Image = (Image)Cashering.Properties.Resources.Find_32;
            //((ToolStripDropDownButton)ts.Items[11]).Image = (Image)Cashering.Properties.Resources.Gnome_Zoom_Fit_Best_32;
        }

        private void PrintReportToolStripButton_Click(object sender, EventArgs e)
        {
            /* Chọn máy in trong danh sách */
            if (mode == 1)
            {
                PrintDialog PrintDialog1 = new PrintDialog();
                DialogResult result = PrintDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    rpt.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName;
                    rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
                    rpt.PrintToPrinter(1, true, 1, 99); //; crystalReportViewer1.ViewCount); 

                    string sql = "Insert Into PrintVAT(DateTime, FolioNo, RoomNo, GuestName, CompanyName, TaxCode, Address,AmountBeforeTax, VAT5, VAT10, AmountAfterTax, FullName,UserName, ComputerName, PrinterName,Status) Values " +
                       " ('" + TextUtils.GetSystemDate().ToString("MM/dd/yyy hh:mm:ss tt") + "', " + Convert.ToInt32(FormulaFieldsValue[5]) + " ,'" + FormulaFieldsValue[0] + "',N'" + FormulaFieldsValue[6] + "', " +
                       " N'" + (FormulaFieldsValue[7]) + "', N'" + (FormulaFieldsValue[8]) + "',N'" + (FormulaFieldsValue[9]) + "', " +
                       " '" + ((FormulaFieldsValue[18])) + "', '" + ((FormulaFieldsValue[20])) + "', '" + ((FormulaFieldsValue[21])) + "','" + ((FormulaFieldsValue[22])) + "', " +
                       " N'" + Global.AppFullName + "',N'" + Global.AppUserName + "','" + TextUtils.GetHostName() + "','" + PrintDialog1.PrinterSettings.PrinterName+ "',1)";

                    TextUtils.ExcuteSQL(sql);
                    TextUtils.ExcuteSQL("Update Folio Set IsPrintVAT =1 Where ID = " + Convert.ToInt32(FormulaFieldsValue[5]));

                    //ActionPosting.InsertHistory(TextUtils.GetSystemDate(), TextUtils.GetBusinessDate(), TextUtils.ToInt(FormulaFieldsValue[5]), TextUtils.ToInt(FormulaFieldsValue[5]), FormulaFieldsValue[5], ActionPosting.HistoryType.Print,
                    //    ActionPosting.GetActionText(ActionPosting.HistoryType.Print, "", "Print VAT Invoice "),
                    //    Global.UserName, "", "Print VAT Invoice", TextUtils.ToDecimal((FormulaFieldsValue[22])), TextUtils.GetHostName() + PrintDialog1.PrinterSettings.PrinterName, "", "", "");

                }
            }
            else
            {
                #region Khong hoi may in
                ////rpt.PrintOptions.PrinterName = GetDefaultPrinter();
                ////rpt.PrintToPrinter(1, true, 1, 99); //; crystalReportViewer1.ViewCount); 
                #endregion
                
                PrintDialog PrintDialog1 = new PrintDialog();
                DialogResult result = PrintDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    rpt.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName;
                    rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                    rpt.PrintToPrinter(1, true, 1, 99);
                    //ActionPosting.InsertHistory(Convert.ToDateTime(TextUtils.GetSystemDate()), Convert.ToDateTime(TextUtils.GetBusinessDate()), TextUtils.ToInt(FormulaFieldsValue[6]), TextUtils.ToInt(FormulaFieldsValue[6]), "", ActionPosting.HistoryType.Print,
                    //    ActionPosting.GetActionText(ActionPosting.HistoryType.Print, "", "Print Folio "),
                    //    Global.UserName, "", "PrintFolio", TextUtils.ToDecimal((FormulaFieldsValue[19])), TextUtils.GetHostName(), "", "", "");

                }
            }
        }

        #endregion

        #region Cac ham viet them

        public void BindData()
        {
            try
            {
                rpt = new ReportDocument();
                rpt.Load(Application.StartupPath + "\\Reports\\" + ReportName);
                if (this.Source != null)
                    rpt.SetDataSource(this.Source);
                if (this.SubReportSource != null)
                    rpt.Subreports[0].SetDataSource(SubReportSource);
                if (FormulaFieldsValue != null)
                {
                    for (int i = 0; i < FormulaFields.Length; i++)
                    {
                        rpt.DataDefinition.FormulaFields[FormulaFields[i]].Text = "\"" + FormulaFieldsValue[i].Replace("\r\n","@#$") + "\"";
                    }
                }
               
                //rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                crystalReportViewer1.DisplayGroupTree = false;
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.ShowGroupTreeButton = false;
                crystalReportViewer1.RefreshReport();
                
            }
            catch (Exception ex)
            {
                frmGenMessageBox frm = new frmGenMessageBox("KienNT", this.Name, "ReportName", TextUtils.Caption,
                                                             "", ex.Message, MessageBoxIcon.Error);
                frm.ShowDialog();
                return;
            }
        }

        public void PrintReport()
        {
            /* Chọn máy in trong danh sách */
            if (mode == 1) //VAT
            {
                PrintDialog PrintDialog1 = new PrintDialog();
                DialogResult result = PrintDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
                    rpt.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName;
                    rpt.PrintToPrinter(1, true, 1, 99); //; crystalReportViewer1.ViewCount); 
                }
            }
            else //FOLIO
            {
                PrintDialog PrintDialog1 = new PrintDialog();
                DialogResult result = PrintDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                    rpt.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName;
                    rpt.PrintToPrinter(1, true, 1, 99); 
                }
            }
        }

        public CrystalDecisions.Windows.Forms.CrystalReportViewer GetViewer()
        {
            try
            {
                return crystalReportViewer1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }

        #endregion

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}