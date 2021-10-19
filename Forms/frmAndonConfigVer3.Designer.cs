namespace BMS
{
	partial class frmAndonConfigVer3
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAndonConfigVer3));
			this.mnuMenu = new System.Windows.Forms.ToolStrip();
			this.btnNew = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.btnCancel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtTakt = new System.Windows.Forms.TextBox();
			this.txtPlanDay = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pickerEndTime = new System.Windows.Forms.DateTimePicker();
			this.pickerStartTime = new System.Windows.Forms.DateTimePicker();
			this.pickerEndDate = new System.Windows.Forms.DateTimePicker();
			this.pickerStartDate = new System.Windows.Forms.DateTimePicker();
			this.cbxShiftType = new System.Windows.Forms.ComboBox();
			this.Now = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.grdData = new DevExpress.XtraGrid.GridControl();
			this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colShiftID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQtyPlanDay = new DevExpress.XtraGrid.Columns.GridColumn();
			this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
			this.mnuMenu.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// mnuMenu
			// 
			this.mnuMenu.AutoSize = false;
			this.mnuMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.mnuMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mnuMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnDelete,
            this.btnSave,
            this.btnCancel,
            this.toolStripSeparator1,
            this.btnClose});
			this.mnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.mnuMenu.Location = new System.Drawing.Point(0, 0);
			this.mnuMenu.Name = "mnuMenu";
			this.mnuMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuMenu.Size = new System.Drawing.Size(911, 65);
			this.mnuMenu.TabIndex = 18;
			this.mnuMenu.Text = "toolStrip2";
			// 
			// btnNew
			// 
			this.btnNew.AutoSize = false;
			this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
			this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(55, 40);
			this.btnNew.Tag = "Form_Department_Add";
			this.btnNew.Text = "&Thêm";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.AutoSize = false;
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(55, 40);
			this.btnEdit.Tag = "Form_Department_Edit";
			this.btnEdit.Text = "Sửa";
			this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.AutoSize = false;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(55, 40);
			this.btnDelete.Tag = "Form_Department_Del";
			this.btnDelete.Text = "Xóa";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.AutoSize = false;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(55, 40);
			this.btnSave.Text = "Ghi";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSave.Visible = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnCancel.AutoSize = false;
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(55, 40);
			this.btnCancel.Text = "Hủy";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCancel.Visible = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AutoSize = false;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
			// 
			// btnClose
			// 
			this.btnClose.AutoSize = false;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(55, 40);
			this.btnClose.Text = "Thoát";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.groupBox1.Controls.Add(this.timeEdit1);
			this.groupBox1.Controls.Add(this.txtTakt);
			this.groupBox1.Controls.Add(this.txtPlanDay);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.pickerEndTime);
			this.groupBox1.Controls.Add(this.pickerStartTime);
			this.groupBox1.Controls.Add(this.pickerEndDate);
			this.groupBox1.Controls.Add(this.pickerStartDate);
			this.groupBox1.Controls.Add(this.cbxShiftType);
			this.groupBox1.Controls.Add(this.Now);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(0, 70);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(918, 243);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			// 
			// txtTakt
			// 
			this.txtTakt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTakt.Location = new System.Drawing.Point(703, 107);
			this.txtTakt.Name = "txtTakt";
			this.txtTakt.ReadOnly = true;
			this.txtTakt.Size = new System.Drawing.Size(172, 35);
			this.txtTakt.TabIndex = 44;
			this.txtTakt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPlanDay
			// 
			this.txtPlanDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlanDay.Location = new System.Drawing.Point(703, 47);
			this.txtPlanDay.Name = "txtPlanDay";
			this.txtPlanDay.ReadOnly = true;
			this.txtPlanDay.Size = new System.Drawing.Size(172, 35);
			this.txtPlanDay.TabIndex = 43;
			this.txtPlanDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(548, 107);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 26);
			this.label2.TabIndex = 41;
			this.label2.Text = "Takt time (s): ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(582, 47);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 26);
			this.label3.TabIndex = 42;
			this.label3.Text = "Plan Day: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(36, 171);
			this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 26);
			this.label5.TabIndex = 40;
			this.label5.Text = "End Date:";
			// 
			// pickerEndTime
			// 
			this.pickerEndTime.CustomFormat = "HH:mm";
			this.pickerEndTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerEndTime.Location = new System.Drawing.Point(353, 168);
			this.pickerEndTime.Name = "pickerEndTime";
			this.pickerEndTime.ShowUpDown = true;
			this.pickerEndTime.Size = new System.Drawing.Size(108, 35);
			this.pickerEndTime.TabIndex = 37;
			this.pickerEndTime.Value = new System.DateTime(2020, 1, 8, 8, 0, 0, 0);
			this.pickerEndTime.ValueChanged += new System.EventHandler(this.pickerEndTime_ValueChanged);
			// 
			// pickerStartTime
			// 
			this.pickerStartTime.CustomFormat = "HH:mm";
			this.pickerStartTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerStartTime.Location = new System.Drawing.Point(351, 107);
			this.pickerStartTime.Name = "pickerStartTime";
			this.pickerStartTime.ShowUpDown = true;
			this.pickerStartTime.Size = new System.Drawing.Size(109, 35);
			this.pickerStartTime.TabIndex = 35;
			this.pickerStartTime.Value = new System.DateTime(2020, 1, 8, 8, 0, 0, 0);
			this.pickerStartTime.ValueChanged += new System.EventHandler(this.pickerStartTime_ValueChanged);
			// 
			// pickerEndDate
			// 
			this.pickerEndDate.CustomFormat = "dd/MM/yyyy";
			this.pickerEndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerEndDate.Location = new System.Drawing.Point(164, 168);
			this.pickerEndDate.Name = "pickerEndDate";
			this.pickerEndDate.Size = new System.Drawing.Size(183, 35);
			this.pickerEndDate.TabIndex = 36;
			this.pickerEndDate.ValueChanged += new System.EventHandler(this.pickerEndDate_ValueChanged);
			// 
			// pickerStartDate
			// 
			this.pickerStartDate.CustomFormat = "dd/MM/yyyy";
			this.pickerStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerStartDate.Location = new System.Drawing.Point(164, 107);
			this.pickerStartDate.Name = "pickerStartDate";
			this.pickerStartDate.Size = new System.Drawing.Size(183, 35);
			this.pickerStartDate.TabIndex = 34;
			this.pickerStartDate.ValueChanged += new System.EventHandler(this.pickerStartDate_ValueChanged);
			// 
			// cbxShiftType
			// 
			this.cbxShiftType.DisplayMember = "da";
			this.cbxShiftType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxShiftType.FormattingEnabled = true;
			this.cbxShiftType.Location = new System.Drawing.Point(165, 47);
			this.cbxShiftType.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.cbxShiftType.Name = "cbxShiftType";
			this.cbxShiftType.Size = new System.Drawing.Size(296, 34);
			this.cbxShiftType.TabIndex = 33;
			this.cbxShiftType.SelectedIndexChanged += new System.EventHandler(this.cbxShiftType_SelectedIndexChanged);
			// 
			// Now
			// 
			this.Now.AutoSize = true;
			this.Now.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Now.Location = new System.Drawing.Point(26, 110);
			this.Now.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.Now.Name = "Now";
			this.Now.Size = new System.Drawing.Size(126, 26);
			this.Now.TabIndex = 39;
			this.Now.Text = "Start Date:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(77, 50);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 26);
			this.label1.TabIndex = 38;
			this.label1.Text = "Type: ";
			// 
			// grdData
			// 
			this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grdData.Location = new System.Drawing.Point(0, 311);
			this.grdData.MainView = this.grvData;
			this.grdData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grdData.Name = "grdData";
			this.grdData.Size = new System.Drawing.Size(911, 325);
			this.grdData.TabIndex = 20;
			this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
			// 
			// grvData
			// 
			this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShiftID,
            this.colID,
            this.colType,
            this.colStartTime,
            this.colEndTime,
            this.colQtyPlanDay});
			this.grvData.GridControl = this.grdData;
			this.grvData.Name = "grvData";
			this.grvData.OptionsBehavior.Editable = false;
			// 
			// colShiftID
			// 
			this.colShiftID.Caption = "gridColumn1";
			this.colShiftID.FieldName = "ShiftID";
			this.colShiftID.Name = "colShiftID";
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			// 
			// colType
			// 
			this.colType.AppearanceCell.Options.UseTextOptions = true;
			this.colType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colType.AppearanceHeader.Options.UseTextOptions = true;
			this.colType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colType.Caption = "Type";
			this.colType.FieldName = "Name";
			this.colType.Name = "colType";
			this.colType.Visible = true;
			this.colType.VisibleIndex = 0;
			this.colType.Width = 146;
			// 
			// colStartTime
			// 
			this.colStartTime.AppearanceCell.Options.UseTextOptions = true;
			this.colStartTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStartTime.AppearanceHeader.Options.UseTextOptions = true;
			this.colStartTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStartTime.Caption = "Start Time";
			this.colStartTime.DisplayFormat.FormatString = "HH:mm yyyy-MM-dd";
			this.colStartTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colStartTime.FieldName = "ShiftStartTime";
			this.colStartTime.Name = "colStartTime";
			this.colStartTime.Visible = true;
			this.colStartTime.VisibleIndex = 1;
			this.colStartTime.Width = 203;
			// 
			// colEndTime
			// 
			this.colEndTime.AppearanceCell.Options.UseTextOptions = true;
			this.colEndTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colEndTime.AppearanceHeader.Options.UseTextOptions = true;
			this.colEndTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colEndTime.Caption = "End Time";
			this.colEndTime.DisplayFormat.FormatString = "HH:mm yyyy-MM-dd";
			this.colEndTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colEndTime.FieldName = "ShiftEndTime";
			this.colEndTime.Name = "colEndTime";
			this.colEndTime.Visible = true;
			this.colEndTime.VisibleIndex = 2;
			this.colEndTime.Width = 165;
			// 
			// colQtyPlanDay
			// 
			this.colQtyPlanDay.AppearanceCell.Options.UseTextOptions = true;
			this.colQtyPlanDay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQtyPlanDay.AppearanceHeader.Options.UseTextOptions = true;
			this.colQtyPlanDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQtyPlanDay.Caption = "Plan Day";
			this.colQtyPlanDay.FieldName = "QtyPlanDay";
			this.colQtyPlanDay.Name = "colQtyPlanDay";
			this.colQtyPlanDay.Visible = true;
			this.colQtyPlanDay.VisibleIndex = 3;
			this.colQtyPlanDay.Width = 182;
			// 
			// timeEdit1
			// 
			this.timeEdit1.EditValue = new System.DateTime(2020, 2, 12, 0, 0, 0, 0);
			this.timeEdit1.Location = new System.Drawing.Point(587, 171);
			this.timeEdit1.Name = "timeEdit1";
			this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.timeEdit1.Size = new System.Drawing.Size(202, 26);
			this.timeEdit1.TabIndex = 45;
			// 
			// frmAndonConfigVer3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(911, 632);
			this.Controls.Add(this.grdData);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.mnuMenu);
			this.Name = "frmAndonConfigVer3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAndonConfigVer3";
			this.Load += new System.EventHandler(this.frmAndonConfigVer3_Load);
			this.mnuMenu.ResumeLayout(false);
			this.mnuMenu.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip mnuMenu;
		private System.Windows.Forms.ToolStripButton btnNew;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripButton btnCancel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.GroupBox groupBox1;
		private DevExpress.XtraGrid.GridControl grdData;
		private DevExpress.XtraGrid.Views.Grid.GridView grvData;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colType;
		private DevExpress.XtraGrid.Columns.GridColumn colStartTime;
		private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
		private DevExpress.XtraGrid.Columns.GridColumn colQtyPlanDay;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker pickerEndTime;
		private System.Windows.Forms.DateTimePicker pickerStartTime;
		private System.Windows.Forms.DateTimePicker pickerEndDate;
		private System.Windows.Forms.DateTimePicker pickerStartDate;
		private System.Windows.Forms.ComboBox cbxShiftType;
		private System.Windows.Forms.Label Now;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTakt;
		private System.Windows.Forms.TextBox txtPlanDay;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private DevExpress.XtraGrid.Columns.GridColumn colShiftID;
		private DevExpress.XtraEditors.TimeEdit timeEdit1;
	}
}