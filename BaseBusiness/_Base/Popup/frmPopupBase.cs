using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BMS.Business;
using BMS.Model;
using BMS.Facade;
using BMS.Utils;
namespace BMS
{
    public partial class frmPopupBase : System.Windows.Forms.Form, IPopup
    {
        [DllImport("user32.dll")]
        public extern static int GetWindowRect(IntPtr hWnd, out Rect lpRect);
        public frmPopupBase()
        {
            InitializeComponent();
        }
        private void CheckToHide(object sender, EventArgs e)
        {
            this.Hide();
        }
        private System.Windows.Forms.Timer tmrForceActivate;
        System.Windows.Forms.UserControl userControl;
        protected virtual void OnPopupHiding(CancelEventArgs e)
        {
            if (PopupHiding != null)
                PopupHiding(this, e);
            if (e.Cancel == false)
            {
                base.Hide();
                OnPopupHidden(new EventArgs());
                if (this.Owner != null)
                    this.Owner.BringToFront();
            }
            else
            {
                this.tmrForceActivate.Enabled = true;
            }

        }
        protected virtual void OnPopupShowing(CancelEventArgs e)
        {
            if (PopupShowing != null)
            {
                PopupShowing(this, e);
            }
            if (e.Cancel == false)
            {
                SetAutoLocation();
                base.Show();
                OnPopupShown(new EventArgs());
            }
        }
        protected virtual void OnPopupHidden(EventArgs e)
        {
            if (PopupHidden != null)
                PopupHidden(this, e);
        }
        protected virtual void OnPopupShown(EventArgs e)
        {
            if (PopupShown != null)
                PopupShown(this, e);
        }

        private void tmrForceActivate_Tick(object sender, System.EventArgs e)
        {
            this.tmrForceActivate.Enabled = false;
            this.Activate();
        }

        #region IFloatingPopup Members

        public event System.ComponentModel.CancelEventHandler PopupHiding;

        public event System.ComponentModel.CancelEventHandler PopupShowing;

        public event System.EventHandler PopupHidden;

        public event System.EventHandler PopupShown;

        public new void Show()
        {
            // TODO:  Add frmFloatingBase.Show implementation
            OnPopupShowing(new CancelEventArgs());
        }

        public new void Hide()
        {
            // TODO:  Add frmFloatingBase.Hide implementation
            OnPopupHiding(new CancelEventArgs());
        }

        public void ForceShow()
        {
            // TODO:  Add frmFloatingBase.ForceShow implementation
            this.tmrForceActivate.Enabled = true;
        }

        public UserControl UserControl
        {
            get
            {
                // TODO:  Add frmFloatingBase.UserControl getter implementation
                return userControl;
            }
            set
            {
                // TODO:  Add frmFloatingBase.UserControl setter implementation
                userControl = value;
            }
        }

        public void SetAutoLocation()
        {
            // TODO:  Add frmFloatingBase.SetAutoLocation implementation
            Rect rect;
            GetWindowRect(UserControl.Handle, out rect);
            Point tergatePoint;
            tergatePoint = new Point(rect.left, rect.top + UserControl.Height);
            if (rect.left + UserControl.Width - this.Width < 0)
            {
                tergatePoint.X = 0;
            }
            else
            {
                tergatePoint.X = rect.left - this.Width + UserControl.Width;
            }
            if (tergatePoint.X + this.Width > System.Windows.Forms.SystemInformation.WorkingArea.Right)
            {
                tergatePoint.X = System.Windows.Forms.SystemInformation.WorkingArea.Right - this.Width;
            }
            else if (tergatePoint.X < 0)
                tergatePoint.X = 0;
            if (tergatePoint.Y + this.Height > System.Windows.Forms.SystemInformation.WorkingArea.Bottom)
            {
                tergatePoint.Y = rect.top - this.Height;
            }
            if (tergatePoint.Y < 0)
            {
                tergatePoint.Y = 0;
            }
            if (tergatePoint.X < 0)
            {
                tergatePoint.X = 0;
            }
            this.Location = tergatePoint;

        }
        public Form PopupForm
        {
            get
            {
                return this;
            }
        }
        #endregion
    }
    public struct Rect
    {
        internal int left, top, right, bottom;
    }
}