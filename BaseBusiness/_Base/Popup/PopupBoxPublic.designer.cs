namespace BMS
{
    partial class PopupBoxPublic
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupBoxPublic));
            this.txtFloatingBox = new System.Windows.Forms.TextBox();
            this.btnDownArrow = new DevExpress.XtraEditors.SimpleButton();
            this.btnDownArrowR = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtFloatingBox
            // 
            this.txtFloatingBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFloatingBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFloatingBox.Location = new System.Drawing.Point(0, 0);
            this.txtFloatingBox.Name = "txtFloatingBox";
            this.txtFloatingBox.Size = new System.Drawing.Size(177, 21);
            this.txtFloatingBox.TabIndex = 0;
            this.txtFloatingBox.TextChanged += new System.EventHandler(this.txtFloatingBox_TextChanged);
            this.txtFloatingBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFloatingBox_KeyDown);
            this.txtFloatingBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloatingBox_KeyPress);
            // 
            // btnDownArrow
            // 
            this.btnDownArrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownArrow.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnDownArrow.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownArrow.Appearance.Options.UseBackColor = true;
            this.btnDownArrow.Appearance.Options.UseFont = true;
            this.btnDownArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownArrow.Image = ((System.Drawing.Image)(resources.GetObject("btnDownArrow.Image")));
            this.btnDownArrow.Location = new System.Drawing.Point(202, 0);
            this.btnDownArrow.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btnDownArrow.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDownArrow.Name = "btnDownArrow";
            this.btnDownArrow.Size = new System.Drawing.Size(25, 21);
            this.btnDownArrow.TabIndex = 1;
            this.btnDownArrow.Click += new System.EventHandler(this.btnDownArrow_Click);
            // 
            // btnDownArrowR
            // 
            this.btnDownArrowR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownArrowR.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnDownArrowR.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownArrowR.Appearance.Options.UseBackColor = true;
            this.btnDownArrowR.Appearance.Options.UseFont = true;
            this.btnDownArrowR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownArrowR.Image = ((System.Drawing.Image)(resources.GetObject("btnDownArrowR.Image")));
            this.btnDownArrowR.Location = new System.Drawing.Point(177, 0);
            this.btnDownArrowR.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btnDownArrowR.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDownArrowR.Name = "btnDownArrowR";
            this.btnDownArrowR.Size = new System.Drawing.Size(25, 21);
            this.btnDownArrowR.TabIndex = 2;
            this.btnDownArrowR.Click += new System.EventHandler(this.btnDownArrowR_Click);
            // 
            // PopupBoxPublic
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnDownArrowR);
            this.Controls.Add(this.btnDownArrow);
            this.Controls.Add(this.txtFloatingBox);
            this.Name = "PopupBoxPublic";
            this.Size = new System.Drawing.Size(227, 21);
            this.ParentChanged += new System.EventHandler(this.FloatingBox_ParentChanged);
            this.SizeChanged += new System.EventHandler(this.FloatingBox_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox txtFloatingBox;
        private DevExpress.XtraEditors.SimpleButton btnDownArrow;
        private IPopup iPopup;
        private DevExpress.XtraEditors.SimpleButton btnDownArrowR;
    }
}
