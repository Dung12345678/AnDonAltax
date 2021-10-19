namespace BMS
{
	partial class frmShifts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShifts));
			this.NhomPhong = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.mnuMenu = new System.Windows.Forms.ToolStrip();
			this.btnNew = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.btnCancel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pickerEndBreak4 = new System.Windows.Forms.DateTimePicker();
			this.pickerEndBreak3 = new System.Windows.Forms.DateTimePicker();
			this.pickerEndBreak2 = new System.Windows.Forms.DateTimePicker();
			this.pickerEndBreak1 = new System.Windows.Forms.DateTimePicker();
			this.pickerStartBreak4 = new System.Windows.Forms.DateTimePicker();
			this.pickerStartBreak3 = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pickerStartBreak2 = new System.Windows.Forms.DateTimePicker();
			this.pickerStartBreak1 = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pickerEnd = new System.Windows.Forms.DateTimePicker();
			this.pickerStart = new System.Windows.Forms.DateTimePicker();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.grdData = new DevExpress.XtraGrid.GridControl();
			this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStartBreak1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEndBreak1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNumHour = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStartBreak2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStartBreak3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStartBreak4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEndBreak2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEndBreak3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEndBreak4 = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.NhomPhong)).BeginInit();
			this.mnuMenu.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
			this.SuspendLayout();
			// 
			// NhomPhong
			// 
			this.NhomPhong.AutoHeight = false;
			this.NhomPhong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.NhomPhong.DisplayMember = "Name";
			this.NhomPhong.Name = "NhomPhong";
			this.NhomPhong.ValueMember = "ID";
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
			this.mnuMenu.Size = new System.Drawing.Size(1276, 65);
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
			this.btnNew.Text = "&Add";
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
			this.btnEdit.Text = "Edit";
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
			this.btnDelete.Text = "Delete";
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
			this.btnSave.Text = "Save";
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
			this.btnCancel.Text = "Cancel";
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
			this.btnClose.Text = "Exit";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.groupBox1.Controls.Add(this.pickerEndBreak4);
			this.groupBox1.Controls.Add(this.pickerEndBreak3);
			this.groupBox1.Controls.Add(this.pickerEndBreak2);
			this.groupBox1.Controls.Add(this.pickerEndBreak1);
			this.groupBox1.Controls.Add(this.pickerStartBreak4);
			this.groupBox1.Controls.Add(this.pickerStartBreak3);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.pickerStartBreak2);
			this.groupBox1.Controls.Add(this.pickerStartBreak1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.pickerEnd);
			this.groupBox1.Controls.Add(this.pickerStart);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(0, 60);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(1276, 229);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			// 
			// pickerEndBreak4
			// 
			this.pickerEndBreak4.CustomFormat = "HH:mm";
			this.pickerEndBreak4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerEndBreak4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerEndBreak4.Location = new System.Drawing.Point(863, 171);
			this.pickerEndBreak4.Name = "pickerEndBreak4";
			this.pickerEndBreak4.ShowUpDown = true;
			this.pickerEndBreak4.Size = new System.Drawing.Size(147, 40);
			this.pickerEndBreak4.TabIndex = 10;
			// 
			// pickerEndBreak3
			// 
			this.pickerEndBreak3.CustomFormat = "HH:mm";
			this.pickerEndBreak3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerEndBreak3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerEndBreak3.Location = new System.Drawing.Point(863, 121);
			this.pickerEndBreak3.Name = "pickerEndBreak3";
			this.pickerEndBreak3.ShowUpDown = true;
			this.pickerEndBreak3.Size = new System.Drawing.Size(147, 40);
			this.pickerEndBreak3.TabIndex = 8;
			// 
			// pickerEndBreak2
			// 
			this.pickerEndBreak2.CustomFormat = "HH:mm";
			this.pickerEndBreak2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerEndBreak2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerEndBreak2.Location = new System.Drawing.Point(863, 73);
			this.pickerEndBreak2.Name = "pickerEndBreak2";
			this.pickerEndBreak2.ShowUpDown = true;
			this.pickerEndBreak2.Size = new System.Drawing.Size(147, 40);
			this.pickerEndBreak2.TabIndex = 6;
			// 
			// pickerEndBreak1
			// 
			this.pickerEndBreak1.CustomFormat = "HH:mm";
			this.pickerEndBreak1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerEndBreak1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerEndBreak1.Location = new System.Drawing.Point(863, 25);
			this.pickerEndBreak1.Name = "pickerEndBreak1";
			this.pickerEndBreak1.ShowUpDown = true;
			this.pickerEndBreak1.Size = new System.Drawing.Size(147, 40);
			this.pickerEndBreak1.TabIndex = 4;
			// 
			// pickerStartBreak4
			// 
			this.pickerStartBreak4.CustomFormat = "HH:mm";
			this.pickerStartBreak4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerStartBreak4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerStartBreak4.Location = new System.Drawing.Point(657, 171);
			this.pickerStartBreak4.Name = "pickerStartBreak4";
			this.pickerStartBreak4.ShowUpDown = true;
			this.pickerStartBreak4.Size = new System.Drawing.Size(147, 40);
			this.pickerStartBreak4.TabIndex = 9;
			// 
			// pickerStartBreak3
			// 
			this.pickerStartBreak3.CustomFormat = "HH:mm";
			this.pickerStartBreak3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerStartBreak3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerStartBreak3.Location = new System.Drawing.Point(657, 123);
			this.pickerStartBreak3.Name = "pickerStartBreak3";
			this.pickerStartBreak3.ShowUpDown = true;
			this.pickerStartBreak3.Size = new System.Drawing.Size(147, 40);
			this.pickerStartBreak3.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(464, 179);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(174, 32);
			this.label6.TabIndex = 11;
			this.label6.Text = "Time Break 4";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(464, 128);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(174, 32);
			this.label7.TabIndex = 12;
			this.label7.Text = "Time Break 3";
			// 
			// pickerStartBreak2
			// 
			this.pickerStartBreak2.CustomFormat = "HH:mm";
			this.pickerStartBreak2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerStartBreak2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerStartBreak2.Location = new System.Drawing.Point(657, 75);
			this.pickerStartBreak2.Name = "pickerStartBreak2";
			this.pickerStartBreak2.ShowUpDown = true;
			this.pickerStartBreak2.Size = new System.Drawing.Size(147, 40);
			this.pickerStartBreak2.TabIndex = 5;
			// 
			// pickerStartBreak1
			// 
			this.pickerStartBreak1.CustomFormat = "HH:mm";
			this.pickerStartBreak1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerStartBreak1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerStartBreak1.Location = new System.Drawing.Point(657, 27);
			this.pickerStartBreak1.Name = "pickerStartBreak1";
			this.pickerStartBreak1.ShowUpDown = true;
			this.pickerStartBreak1.Size = new System.Drawing.Size(147, 40);
			this.pickerStartBreak1.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(464, 75);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(174, 32);
			this.label4.TabIndex = 7;
			this.label4.Text = "Time Break 2";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(464, 32);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(174, 32);
			this.label5.TabIndex = 8;
			this.label5.Text = "Time Break 1";
			// 
			// pickerEnd
			// 
			this.pickerEnd.CustomFormat = "HH:mm";
			this.pickerEnd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerEnd.Location = new System.Drawing.Point(202, 158);
			this.pickerEnd.Name = "pickerEnd";
			this.pickerEnd.ShowUpDown = true;
			this.pickerEnd.Size = new System.Drawing.Size(195, 40);
			this.pickerEnd.TabIndex = 2;
			// 
			// pickerStart
			// 
			this.pickerStart.CustomFormat = "HH:mm";
			this.pickerStart.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerStart.Location = new System.Drawing.Point(202, 91);
			this.pickerStart.Name = "pickerStart";
			this.pickerStart.ShowUpDown = true;
			this.pickerStart.Size = new System.Drawing.Size(195, 40);
			this.pickerStart.TabIndex = 1;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(202, 30);
			this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(195, 40);
			this.txtName.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(47, 158);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 32);
			this.label3.TabIndex = 0;
			this.label3.Text = "End Time";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 96);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 32);
			this.label2.TabIndex = 0;
			this.label2.Text = "Start Time";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(95, 36);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// grdData
			// 
			this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grdData.Location = new System.Drawing.Point(0, 285);
			this.grdData.MainView = this.grvData;
			this.grdData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grdData.Name = "grdData";
			this.grdData.Size = new System.Drawing.Size(1276, 389);
			this.grdData.TabIndex = 20;
			this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
			// 
			// grvData
			// 
			this.grvData.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grvData.Appearance.HeaderPanel.Options.UseFont = true;
			this.grvData.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grvData.Appearance.Row.Options.UseFont = true;
			this.grvData.ColumnPanelRowHeight = 40;
			this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colStartTime,
            this.colEndTime,
            this.colStartBreak1,
            this.colEndBreak1,
            this.colNumHour,
            this.colStartBreak2,
            this.colStartBreak3,
            this.colStartBreak4,
            this.colEndBreak2,
            this.colEndBreak3,
            this.colEndBreak4});
			this.grvData.GridControl = this.grdData;
			this.grvData.Name = "grvData";
			this.grvData.OptionsBehavior.Editable = false;
			this.grvData.RowHeight = 40;
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			// 
			// colName
			// 
			this.colName.Caption = "Name";
			this.colName.FieldName = "Name";
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 0;
			this.colName.Width = 91;
			// 
			// colStartTime
			// 
			this.colStartTime.Caption = "Start Time";
			this.colStartTime.DisplayFormat.FormatString = "HH:mm";
			this.colStartTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colStartTime.FieldName = "StartTime";
			this.colStartTime.Name = "colStartTime";
			this.colStartTime.Visible = true;
			this.colStartTime.VisibleIndex = 1;
			this.colStartTime.Width = 163;
			// 
			// colEndTime
			// 
			this.colEndTime.Caption = "End Time";
			this.colEndTime.DisplayFormat.FormatString = "HH:mm";
			this.colEndTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colEndTime.FieldName = "EndTime";
			this.colEndTime.Name = "colEndTime";
			this.colEndTime.Visible = true;
			this.colEndTime.VisibleIndex = 2;
			this.colEndTime.Width = 194;
			// 
			// colStartBreak1
			// 
			this.colStartBreak1.Caption = "Start Break";
			this.colStartBreak1.DisplayFormat.FormatString = "HH:mm";
			this.colStartBreak1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colStartBreak1.FieldName = "StartTimeBreak1";
			this.colStartBreak1.Name = "colStartBreak1";
			this.colStartBreak1.Width = 131;
			// 
			// colEndBreak1
			// 
			this.colEndBreak1.Caption = "End Break";
			this.colEndBreak1.DisplayFormat.FormatString = "HH:mm";
			this.colEndBreak1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colEndBreak1.FieldName = "EndTimeBreak1";
			this.colEndBreak1.Name = "colEndBreak1";
			this.colEndBreak1.Width = 117;
			// 
			// colNumHour
			// 
			this.colNumHour.Caption = "gridColumn1";
			this.colNumHour.FieldName = "NumHours";
			this.colNumHour.Name = "colNumHour";
			// 
			// colStartBreak2
			// 
			this.colStartBreak2.Caption = "gridColumn1";
			this.colStartBreak2.FieldName = "StartTimeBreak2";
			this.colStartBreak2.Name = "colStartBreak2";
			// 
			// colStartBreak3
			// 
			this.colStartBreak3.Caption = "gridColumn2";
			this.colStartBreak3.FieldName = "StartTimeBreak3";
			this.colStartBreak3.Name = "colStartBreak3";
			// 
			// colStartBreak4
			// 
			this.colStartBreak4.Caption = "gridColumn3";
			this.colStartBreak4.FieldName = "StartTimeBreak4";
			this.colStartBreak4.Name = "colStartBreak4";
			// 
			// colEndBreak2
			// 
			this.colEndBreak2.Caption = "EndTimeBreak2";
			this.colEndBreak2.FieldName = "EndTimeBreak2";
			this.colEndBreak2.Name = "colEndBreak2";
			// 
			// colEndBreak3
			// 
			this.colEndBreak3.Caption = "EndTimeBreak3";
			this.colEndBreak3.FieldName = "EndTimeBreak3";
			this.colEndBreak3.Name = "colEndBreak3";
			// 
			// colEndBreak4
			// 
			this.colEndBreak4.Caption = "gridColumn6";
			this.colEndBreak4.FieldName = "EndTimeBreak4";
			this.colEndBreak4.Name = "colEndBreak4";
			// 
			// frmShifts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1276, 688);
			this.Controls.Add(this.grdData);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.mnuMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmShifts";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LIST SHIFT";
			this.Load += new System.EventHandler(this.frmShifts_Load);
			((System.ComponentModel.ISupportInitialize)(this.NhomPhong)).EndInit();
			this.mnuMenu.ResumeLayout(false);
			this.mnuMenu.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit NhomPhong;
		private System.Windows.Forms.ToolStrip mnuMenu;
		private System.Windows.Forms.ToolStripButton btnNew;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripButton btnCancel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraGrid.GridControl grdData;
		private DevExpress.XtraGrid.Views.Grid.GridView grvData;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colStartTime;
		private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
		private System.Windows.Forms.DateTimePicker pickerStart;
		private DevExpress.XtraGrid.Columns.GridColumn colNumHour;
		private System.Windows.Forms.DateTimePicker pickerEnd;
		private System.Windows.Forms.DateTimePicker pickerStartBreak2;
		private System.Windows.Forms.DateTimePicker pickerStartBreak1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private DevExpress.XtraGrid.Columns.GridColumn colStartBreak1;
		private DevExpress.XtraGrid.Columns.GridColumn colEndBreak1;
		private System.Windows.Forms.DateTimePicker pickerEndBreak4;
		private System.Windows.Forms.DateTimePicker pickerEndBreak3;
		private System.Windows.Forms.DateTimePicker pickerEndBreak2;
		private System.Windows.Forms.DateTimePicker pickerEndBreak1;
		private System.Windows.Forms.DateTimePicker pickerStartBreak4;
		private System.Windows.Forms.DateTimePicker pickerStartBreak3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private DevExpress.XtraGrid.Columns.GridColumn colStartBreak2;
		private DevExpress.XtraGrid.Columns.GridColumn colStartBreak3;
		private DevExpress.XtraGrid.Columns.GridColumn colStartBreak4;
		private DevExpress.XtraGrid.Columns.GridColumn colEndBreak2;
		private DevExpress.XtraGrid.Columns.GridColumn colEndBreak3;
		private DevExpress.XtraGrid.Columns.GridColumn colEndBreak4;
	}
}