using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BMS.Utils;
using System.Drawing;

namespace BMS
{
    public class ShortcutKey
    {
        public static void CheckControls(object parentControl, string strShortcutKeys)
        {
            try
            {
                if (parentControl is MenuStrip)
                {
                    MenuStrip menu = (MenuStrip)parentControl;
                    foreach (ToolStripItem item in menu.Items)
                    {
                        if (item.Tag != null && item is ToolStripButton)
                        {
                            ToolStripButton button = (ToolStripButton)item;
                            if (button.Tag.ToString().Equals(strShortcutKeys))
                            {
                                button.PerformClick();
                                return;
                            }
                        }
                        CheckControls(item, strShortcutKeys);
                    }
                    return;
                }
                if (parentControl is ToolStripMenuItem)
                {
                    ToolStripItemCollection menuitems = ((ToolStripMenuItem)parentControl).DropDownItems;
                    foreach (ToolStripItem item in menuitems)
                    {
                        if (item.Tag != null)
                        {
                            ToolStripItem button = (ToolStripItem)item;
                            if (button.Tag.ToString().Equals(strShortcutKeys))
                            {
                                button.PerformClick();
                                return;
                            }
                        }
                        CheckControls(item, strShortcutKeys);
                    }
                    return;
                }
                if (parentControl is ToolStripSplitButton)
                {
                    ToolStripSplitButton menu = (ToolStripSplitButton)parentControl;

                    foreach (ToolStripItem item in menu.DropDown.Items)
                    {
                        if (item.Tag != null)
                        {
                            ToolStripItem button = (ToolStripItem)item;
                            if (button.Tag.ToString().Equals(strShortcutKeys))
                            {
                                button.PerformClick();
                                return;
                            }
                        }
                        CheckControls(item, strShortcutKeys);
                    }
                    return;
                }

                if (parentControl is ToolStrip)
                {

                    ToolStrip menu = (ToolStrip)parentControl;
                    foreach (ToolStripItem item in menu.Items)
                    {
                        if (item.Tag != null)
                        {
                            ToolStripItem button = (ToolStripItem)item;
                            if (button.Tag.ToString().Equals(strShortcutKeys))
                            {
                                button.PerformClick();
                                return;
                            }
                        }
                        CheckControls(item, strShortcutKeys);
                    }
                    return;
                }
                if (parentControl is Panel)
                {
                    foreach (Control item in (parentControl as Control).Controls)
                    {
                        if (item is Button)
                        {
                            Button button = (Button)item;
                            if (button.Tag.ToString().Equals(strShortcutKeys))
                            {
                                button.PerformClick();
                                return;
                            }
                        }
                    }
                    return;
                }


                //if (parentControl is DevExpress.XtraNavBar.NavBarControl)
                //{
                //    DevExpress.XtraNavBar.NavBarControl _navBarControl = (DevExpress.XtraNavBar.NavBarControl)parentControl;
                //    foreach (DevExpress.XtraNavBar.NavBarGroup _navBarGroup in _navBarControl.Groups)
                //    {
                //        foreach (DevExpress.XtraNavBar.NavBarItemLink item in _navBarGroup.ItemLinks)
                //        {
                //            if (item.Item.Tag != null && !item.Item.Tag.ToString().Equals(""))
                //            {
                //                bool isExitsPermission = CheckExistsValue(item.Item.Tag.ToString(),strShortcutKeys);
                //                DevExpress.XtraNavBar.NavBarItemLink button = (DevExpress.XtraNavBar.NavBarItemLink)item.Item;
                //                button.
                //                if (!isExitsPermission)
                //                    item.Item.Appearance.ForeColor = Color.DarkGray;
                //            }
                //        }
                //    }
                //    return;
                //}
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message); }
        }
        public static void LoadFormShortcutKey(Form form, string strShortcutKeys, ref bool handled)
        {
            if (strShortcutKeys.Contains("Control") || strShortcutKeys.Contains("F"))
            {
                try
                {
                    if (form.Controls.Count <= 0) return;
                    foreach (Control items in form.Controls)
                    {
                        if (items.Tag != null && items is Button)
                        {
                            Button button = (Button)items;
                            if (button.Tag.ToString().Equals(strShortcutKeys))
                            {
                                button.PerformClick();
                                handled = true;
                                return;
                            }
                        }
                        object parentControl = items;
                        if (parentControl is MenuStrip)
                        {
                            MenuStrip menu = (MenuStrip)parentControl;
                            foreach (ToolStripItem item in menu.Items)
                            {
                                if (item.Tag != null && item is ToolStripButton)
                                {
                                    ToolStripButton button = (ToolStripButton)item;
                                    if (button.Tag.ToString().Equals(strShortcutKeys))
                                    {
                                        button.PerformClick();
                                        handled = true;
                                        return;
                                    }
                                }
                                CheckControls(item, strShortcutKeys);
                            }
                            return;
                        }
                        if (parentControl is ToolStrip)
                        {
                            ToolStrip menu = (ToolStrip)parentControl;
                            foreach (ToolStripItem item in menu.Items)
                            {
                                if (item.Tag != null)
                                {
                                    ToolStripItem button = (ToolStripItem)item;
                                    if (button.Tag.ToString().Equals(strShortcutKeys))
                                    {
                                        button.PerformClick();
                                        handled = true;
                                        return;
                                    }
                                }
                                CheckControls(item, strShortcutKeys);
                            }
                        }
                        if (parentControl is ToolStripMenuItem)
                        {
                            ToolStripItemCollection menuitems = ((ToolStripMenuItem)parentControl).DropDownItems;
                            foreach (ToolStripItem item in menuitems)
                            {
                                if (item.Tag != null)
                                {
                                    ToolStripItem button = (ToolStripItem)item;
                                    if (button.Tag.ToString().Equals(strShortcutKeys))
                                    {
                                        button.PerformClick();
                                        handled = true;
                                        return;
                                    }
                                }
                                CheckControls(item, strShortcutKeys);
                            }
                        }
                        //CheckControls(item, strShortcutKeys);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //if (strShortcutKeys == "Escape")
                //{
                //    form.Close();
                //}                
            }
        }
        public static void LoadUserControlShortcutKey(UserControl uc, string strShortcutKeys)
        {
            if (strShortcutKeys.Contains("Control") || strShortcutKeys.Contains("F"))
            {
                try
                {
                    if (uc.Controls.Count <= 0) return;
                    foreach (Control items in uc.Controls)
                    {
                        if (items.Tag != null && items is Button)
                        {
                            Button button = (Button)items;
                            if (button.Tag.ToString().Equals(strShortcutKeys))
                            {
                                button.PerformClick();
                                return;
                            }
                        }
                        object parentControl = items;
                        if (parentControl is ToolStrip)
                        {
                            ToolStrip menu = (ToolStrip)parentControl;
                            foreach (ToolStripItem item in menu.Items)
                            {
                                if (item.Tag != null)
                                {
                                    ToolStripItem button = (ToolStripItem)item;
                                    if (button.Tag.ToString().Equals(strShortcutKeys))
                                    {
                                        button.PerformClick();
                                        return;
                                    }
                                }
                                CheckControls(item, strShortcutKeys);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
