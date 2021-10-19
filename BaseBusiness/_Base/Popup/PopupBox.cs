using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
namespace BMS
{
    /// <summary>
    /// Summary description for UserControl1.
    /// </summary>
    public partial class PopupBox : System.Windows.Forms.UserControl
    {
        private bool _IsMultilSelect;
        public bool IsMultilSelect
        {
            get { return _IsMultilSelect; }
            set { _IsMultilSelect = value; }
        }
        private BMS.Model.BaseModel _SelectedModel;
        public BMS.Model.BaseModel SelectedModel
        {
            get { return _SelectedModel; }
            set { _SelectedModel = value; }
        }
        private BMS.Model.BaseModel[] _SelectedMultiModel;
        public BMS.Model.BaseModel[] SelectedMultiModel
        {
            get { return _SelectedMultiModel; }
            set { _SelectedMultiModel = value; }
        }
        private object _ObjectID=null;
        public object ObjectID
        {
            get { return _ObjectID; }
            set { _ObjectID = value; }
        }
        private int[] _ArrayObjectID;
        public int[] ArrayObjectID
        {
            get { return _ArrayObjectID; }
            set { _ArrayObjectID = value; }
        }
        private bool _ReadOnlyText;
        public bool ReadOnlyText
        {
            get { return _ReadOnlyText; }
            set { _ReadOnlyText = value; }
        }

        public event CancelEventHandler PopupHiding = null;
        public event CancelEventHandler PopupShowing = null;
        public event EventHandler PopupHidden = null;
        public event EventHandler PopupShown = null;
        public PopupBox()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();  
            // TODO: Add any initialization after the InitComponent call
            iPopup = new frmPopupBase();

            this.txtFloatingBox.SelectionStart = 1;
            this.ObjectID = null;

            iPopup.UserControl = this;
            iPopup.PopupHidden += new EventHandler(iPopup_PopupHidden);
            iPopup.PopupHiding += new CancelEventHandler(iPopup_PopupHiding);
            iPopup.PopupShowing += new CancelEventHandler(iPopup_PopupShowing);
            iPopup.PopupShown += new EventHandler(iPopup_PopupShown);
        }

        private void FloatingBox_SizeChanged(object sender, System.EventArgs e)
        {
            if (this.Height != this.btnDownArrow.Height)
                this.Height = this.btnDownArrow.Height;
            if (this.Width < this.btnDownArrow.Width * 2)
                this.Width = this.btnDownArrow.Width * 2;
        }

        private void btnDownArrow_Click(object sender, System.EventArgs e)
        {
            this.iPopup.Show();
        }

        private void txtFloatingBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }
        private void txtFloatingBox_KeyDown(object sender, KeyEventArgs e)
        {
            btnDownArrow_Click(null, null);
        }
        private void txtFloatingBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void txtFloatingBox_TextChanged(object sender, System.EventArgs e)
        {
            OnTextChanged(e);
        }

        public override string Text
        {
            get
            {
                return this.txtFloatingBox.Text;
            }
            set
            {
                this.txtFloatingBox.Text = value;
            }
        }

        protected virtual void OnPopupHidden(EventArgs e)
        {
            if (PopupHidden != null)
                PopupHidden(this, e);
        }
        private void iPopup_PopupHidden(object sender, EventArgs e)
        {
            OnPopupHidden(e);
        }

        protected virtual void OnPopupHiding(CancelEventArgs e)
        {
            if (PopupHiding != null)
                PopupHiding(this, e);
        }
        private void iPopup_PopupHiding(object sender, CancelEventArgs e)
        {
            OnPopupHiding(e);
        }
        protected virtual void OnPopupShowing(CancelEventArgs e)
        {
            if (PopupShowing != null)
                PopupShowing(this, e);
        }
        private void iPopup_PopupShowing(object sender, CancelEventArgs e)
        {
            OnPopupShowing(e);
        }

        protected virtual void OnPopupShown(EventArgs e)
        {
            if (PopupShown != null)
                PopupShown(this, e);
        }
        private void iPopup_PopupShown(object sender, EventArgs e)
        {
            OnPopupShown(e);
        }

        private void FloatingBox_ParentChanged(object sender, System.EventArgs e)
        {
            if (this.Parent is Form && iPopup != null)
            {
                ((Form)this.Parent).AddOwnedForm(iPopup.PopupForm);
                ((Form)this.Parent).Move += new EventHandler(FloatingBox_Move);
            }
        }

        private void FloatingBox_Move(object sender, EventArgs e)
        {
            iPopup.SetAutoLocation();
        }

        public IPopup Popup
        {
            get
            {
                return iPopup;
            }
            set
            {
                if (iPopup != null)
                {
                    iPopup.PopupHidden -= new EventHandler(iPopup_PopupHidden);
                    iPopup.PopupHiding -= new CancelEventHandler(iPopup_PopupHiding);
                    iPopup.PopupShowing -= new CancelEventHandler(iPopup_PopupShowing);
                    iPopup.PopupShown -= new EventHandler(iPopup_PopupShown);
                }
                if (value != null)
                {
                    iPopup = value;
                    iPopup.PopupHidden += new EventHandler(iPopup_PopupHidden);
                    iPopup.PopupHiding += new CancelEventHandler(iPopup_PopupHiding);
                    iPopup.PopupShowing += new CancelEventHandler(iPopup_PopupShowing);
                    iPopup.PopupShown += new EventHandler(iPopup_PopupShown);
                }
            }
        }
        public int SelectionStart
        {
            get
            {
                return this.txtFloatingBox.SelectionStart;
            }
            set
            {
                this.txtFloatingBox.SelectionStart = value;
            }
        }
        public int SelectionLength
        {
            get
            {
                return this.txtFloatingBox.SelectionLength;
            }
            set
            {
                this.txtFloatingBox.SelectionLength = value;
            }
        }
    }
}
