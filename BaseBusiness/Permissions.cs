using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraNavBar;
using DevExpress.XtraGrid.Views.Grid;
using BMS.Utils;
using BMS.Business;
using System.Drawing;


namespace BMS
{
    public class Permissions
    {
        public static string GroupId;
        public static string UserName;
        public static DataTable tblUser;
        public static bool _IsUserControl = false;//không load phím tắt cho User control

        public static bool CheckPermissonByUser(string code, int userID)
        {
            try
            {
                DataTable tblPermisson = LoadPermissionByUser(userID);
                foreach (DataRow dr in tblPermisson.Rows)
                {
                    if (dr["Code"].ToString().Equals(code))
                        return true;
                }
                return false;

            }
            catch { return false; }
        }

        public static bool CheckExistsValue(string pValue)
        {
            try
            {
                foreach (DataRow dr in tblUser.Rows)
                {
                    if (dr["Code"].ToString().Equals(pValue))
                        return true;
                }
                return false;
                
            }catch{ return false;}
        }
        public static DataRow CheckPermission(string pValue)
        {
            foreach (DataRow dr in tblUser.Rows)
            {
                if (dr["Code"].ToString().Equals(pValue))
                    return dr;
            }
            return null;
        }
        public static void CheckControls(object parentControl)
        {
            //ToolStripButton
            try
            {
                #region Menustrip
                if (parentControl is MenuStrip)
                {
                    MenuStrip menu = (MenuStrip)parentControl;
                    foreach (ToolStripItem item in menu.Items)
                    {
                        if (item.Tag != null && !item.Tag.ToString().Equals(""))
                        {
                            DataRow dr = CheckPermission(item.Tag.ToString());
                            if ( dr == null)
                                item.Enabled = false;
                            else
                            {
                                item.Enabled = true;
                                if (!string.IsNullOrEmpty(dr["strShortcutKey"].ToString()) && !_IsUserControl)
                                {
                                    item.Tag = dr["ShortcutKey"].ToString();
                                    item.ToolTipText = dr["strShortcutKey"].ToString();
                                }
                            }
                        }
                        CheckControls(item);
                    }
                    return;
                }
                #endregion

                #region ToolStripMenu
                if (parentControl is ToolStripMenuItem)
                {
                    ToolStripItemCollection menuitems = ((ToolStripMenuItem)parentControl).DropDownItems;
                    foreach (ToolStripItem item in menuitems)
                    {
                        if (item.Tag != null && !item.Tag.ToString().Equals(""))
                        {
                            DataRow dr = CheckPermission(item.Tag.ToString());
                            if (dr == null)
                                item.Enabled = false;
                            else
                            {
                                item.Enabled = true;
                                if (!string.IsNullOrEmpty(dr["strShortcutKey"].ToString())  && !_IsUserControl)
                                {
                                    item.Tag = dr["ShortcutKey"].ToString();
                                    item.ToolTipText = dr["strShortcutKey"].ToString();
                                }
                            }
                        }
                        CheckControls(item);
                    }
                    return;
                }
                #endregion

                #region ToolStripSplitButton
                if (parentControl is ToolStripSplitButton)
                {
                    ToolStripSplitButton menu = (ToolStripSplitButton)parentControl;

                    foreach (ToolStripItem item in menu.DropDown.Items)
                    {
                        if (item.Tag != null && !item.Tag.ToString().Equals(""))
                        {
                            DataRow dr = CheckPermission(item.Tag.ToString());
                            if (dr == null)
                                item.Enabled = false;
                            else
                            {
                                item.Enabled = true;
                                if (!string.IsNullOrEmpty(dr["strShortcutKey"].ToString()) && !_IsUserControl)
                                {
                                    item.Tag = dr["ShortcutKey"].ToString();
                                    item.ToolTipText = dr["strShortcutKey"].ToString();
                                }
                            }
                        }
                        CheckControls(item);
                    }
                    return;
                }
                #endregion

                #region ToolStrip
                if (parentControl is ToolStrip)
                {
                    ToolStrip menu = (ToolStrip)parentControl;
                    foreach (ToolStripItem item in menu.Items)
                    {
                        if (item.Tag != null && !item.Tag.ToString().Equals(""))
                        {
                            DataRow dr = CheckPermission(item.Tag.ToString());
                            if (dr == null)
                                item.Enabled = false;
                            else
                            {
                                item.Enabled = true;
                                if (!string.IsNullOrEmpty(dr["strShortcutKey"].ToString()) && !_IsUserControl)
                                {
                                    item.Tag = dr["ShortcutKey"].ToString();
                                    item.ToolTipText = dr["strShortcutKey"].ToString();
                                }
                            }
                        }
                        else
                        {
                            if (!_IsUserControl)
                            {
                                if (item.Name == "btnSave")
                                {
                                    item.Tag = "S, Control";
                                    item.ToolTipText = "Ctrl + S";
                                }
                                if (item.Name == "btnOK")
                                {
                                    item.Tag = "Q, Control";
                                    item.ToolTipText = "Ctrl + Q";
                                }
                                if (item.Name == "btnSearch" && item.Enabled == true)
                                {
                                    item.Tag = "F, Control";
                                    item.ToolTipText = "Ctrl + F";
                                }
                                if ((item.Name == "btnExport" || item.Name == "btnExcel") && item.Enabled == true)
                                {
                                    item.Tag = "E, Control";
                                    item.ToolTipText = "Ctrl + E";
                                }
                                if (item.Name == "btnPrint" && item.Enabled == true)
                                {
                                    item.Tag = "I, Control";
                                    item.ToolTipText = "Ctrl + I";
                                }
                                if (item.Name == "btnNew" && item.Enabled == true)
                                {
                                    item.Tag = "N, Control";
                                    item.ToolTipText = "Ctrl + N";
                                }
                                if (item.Name == "btnEdit" && item.Enabled == true)
                                {
                                    item.Tag = "G, Control";
                                    item.ToolTipText = "Ctrl + G";
                                }
                                if ((item.Name == "btnDelete" || item.Name == "btnDel") && item.Enabled == true)
                                {
                                    item.Tag = "D, Control";
                                    item.ToolTipText = "Ctrl + D";
                                }
                            }
                        }
                        CheckControls(item);
                    }
                    return;
                }
                #endregion

                #region Panel
                if (parentControl is Panel)
                {
                    foreach (Control item in (parentControl as Control).Controls)
                    {
                        if (item.Tag != null && !item.Tag.ToString().Equals(""))
                        {
                            DataRow dr = CheckPermission(item.Tag.ToString());
                            if (dr == null)
                                item.Enabled = false;
                            else
                            {
                                item.Enabled = true;
                                if (!string.IsNullOrEmpty(dr["strShortcutKey"].ToString()) && !_IsUserControl)
                                {
                                    item.Tag = dr["ShortcutKey"].ToString();
                                    item.Text += " (" + dr["strShortcutKey"].ToString() + ")";
                                }
                            }
                        }
                        CheckControls(item);
                    }
                    return;
                }
                #endregion

                #region NavBarControl
                if (parentControl is DevExpress.XtraNavBar.NavBarControl)
                {
                    DevExpress.XtraNavBar.NavBarControl _navBarControl = (DevExpress.XtraNavBar.NavBarControl)parentControl;
                    foreach (DevExpress.XtraNavBar.NavBarGroup _navBarGroup in _navBarControl.Groups)
                    {
                        foreach (DevExpress.XtraNavBar.NavBarItemLink item in _navBarGroup.ItemLinks)
                        {
                            if (item.Item.Tag != null && !item.Item.Tag.ToString().Equals(""))
                            {
                                bool isExitsPermission = CheckExistsValue(item.Item.Tag.ToString());
                                item.Item.Enabled = isExitsPermission;
                                if (!isExitsPermission)
                                    item.Item.Appearance.ForeColor = Color.DarkGray;
                            }
                        }
                    }
                    return;
                }
                #endregion

                #region GridControl
                if (parentControl is DevExpress.XtraGrid.GridControl)
                {
                    DevExpress.XtraGrid.GridControl _gridControl = (DevExpress.XtraGrid.GridControl)parentControl;
                    ContextMenuStrip cms = _gridControl.ContextMenuStrip;
                    if (cms != null)
                    {
                        foreach (ToolStripItem item in cms.Items)
                        {
                            if (item.Tag != null && !item.Tag.ToString().Equals(""))
                            {
                                DataRow dr = CheckPermission(item.Tag.ToString());
                                if (dr == null)
                                    item.Enabled = false;
                                else
                                {
                                    item.Enabled = true;
                                    if (!string.IsNullOrEmpty(dr["strShortcutKey"].ToString()) && !_IsUserControl)
                                    {
                                        item.Tag = dr["ShortcutKey"].ToString();
                                        item.ToolTipText = dr["strShortcutKey"].ToString();
                                    }
                                }
                            }
                            CheckControls(item);
                        }
                    }
                    return;
                }
                #endregion

                #region RibbonControl
                if (parentControl is DevExpress.XtraBars.Ribbon.RibbonControl)
                {
                    DevExpress.XtraBars.Ribbon.RibbonControl _ribbonControl = (DevExpress.XtraBars.Ribbon.RibbonControl)parentControl;

                    foreach (DevExpress.XtraBars.BarButtonItem item in _ribbonControl.Items)
                    {
                        if (item.Tag != null && !item.Tag.ToString().Equals(""))
                        {
                            DataRow dr = CheckPermission(item.Tag.ToString());
                            if (dr == null)
                                item.Enabled = false;
                            else
                            {
                                if (!string.IsNullOrEmpty(dr["strShortcutKey"].ToString()) && !_IsUserControl)
                                {
                                    item.Hint = dr["strShortcutKey"].ToString();
                                }
                            }
                        }
                    }
                    return;
                }

                #endregion

                #region SplitContainer
                if (parentControl is SplitContainer)
                {
                    foreach (Control item in (parentControl as Control).Controls)
                    {
                        if (item.Tag != null && !item.Tag.ToString().Equals(""))
                        {
                            DataRow dr = CheckPermission(item.Tag.ToString());
                            if (dr == null)
                                item.Enabled = false;
                            else
                            {
                                item.Enabled = true;
                                if (!string.IsNullOrEmpty(dr["strShortcutKey"].ToString()) && !_IsUserControl)
                                {
                                    item.Tag = dr["ShortcutKey"].ToString();
                                    item.Text += " (" + dr["strShortcutKey"].ToString() + ")";
                                }
                            }
                        }
                        CheckControls(item);
                    }
                    return;
                }
                #endregion

                #region Control
                if (parentControl is Control)
                {
                    foreach (Control item in (parentControl as Control).Controls)
                    {
                        if (item.Tag != null && !item.Tag.ToString().Equals(""))
                            item.Enabled = CheckExistsValue(item.Tag.ToString());
                        else
                        {
                            if (item.Name == "btnSave")
                            {
                                item.Tag = "S, Control";
                                //item.to = "Ctrl + S";
                            }
                        }
                        CheckControls(item);
                    }
                    return;
                }
                #endregion

                #region Button
                if (parentControl is Button)
                {
                    foreach (Control item in (parentControl as Control).Controls)
                    {
                        if (item.Tag != null && !item.Tag.ToString().Equals(""))
                            item.Enabled = CheckExistsValue(item.Tag.ToString());
                       
                        CheckControls(item);
                    }
                    return;
                }
                #endregion
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message); }

        }
        public static void LoadFormPermission(Form form)
        {
            try
            {
                //if (form == null || Global.AppUserName.ToUpper() == "ADMIN") return;
                if (form.Controls.Count <= 0) return;
                LoadPermission();
                _IsUserControl = false;
                foreach (Control item in form.Controls)
                 {
                     if (item.Tag != null && !item.Tag.ToString().Equals(""))
                         item.Enabled = CheckExistsValue(item.Tag.ToString());
                     CheckControls(item);
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
        public static void LoadUserControlPermission(UserControl uc)
        {
            try
            {
                //if (uc == null || Global.AppUserName == "admin" || Global.AppUserName == "support3") return;
                if (uc.Controls.Count <= 0) return;
                //LoadPermission();
                _IsUserControl = true;
                foreach (Control item in uc.Controls)
                {
                    if (item.Tag != null && !item.Tag.ToString().Equals(""))
                        item.Enabled = CheckExistsValue(item.Tag.ToString());
                    CheckControls(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LoadPermission()
        {
            tblUser = FormAndFunctionBO.Instance.LoadDataFromSP("spPermissionAndShortcutKey1", "_t", new string[] { "@UserID" }, new object[] { Global.UserID });
        }
        public static DataTable LoadPermissionByUser(int userID)
        {
            return FormAndFunctionBO.Instance.LoadDataFromSP("spPermissionAndShortcutKey1", "_t", new string[] { "@UserID" }, new object[] { userID });
        }
    }
}
