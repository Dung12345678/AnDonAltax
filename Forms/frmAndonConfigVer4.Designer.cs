namespace BMS
{
	partial class frmAndonConfigVer4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAndonConfigVer4));
			this.mnuMenu = new System.Windows.Forms.ToolStrip();
			this.btnNew = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.btnCancel = new System.Windows.Forms.ToolStripButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pickerStartBreak4 = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.pickerEndBreak4 = new System.Windows.Forms.DateTimePicker();
			this.pickerStartBreak3 = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.pickerEndBreak3 = new System.Windows.Forms.DateTimePicker();
			this.pickerStartBreak2 = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.pickerEndBreak2 = new System.Windows.Forms.DateTimePicker();
			this.pickerStartBreak1 = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.pickerEndBreak1 = new System.Windows.Forms.DateTimePicker();
			this.pickerStartTime = new System.Windows.Forms.DateTimePicker();
			this.txtTakt = new System.Windows.Forms.TextBox();
			this.txtPlanDay = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pickerEndTime = new System.Windows.Forms.DateTimePicker();
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
			this.colStartBreak1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEndBreak1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStartBreak2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStartBreak3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStartBreak4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEndBreak2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEndBreak3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEndBreak4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.mnuMenu.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
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
            this.btnCancel});
			this.mnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.mnuMenu.Location = new System.Drawing.Point(0, 0);
			this.mnuMenu.Name = "mnuMenu";
			this.mnuMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuMenu.Size = new System.Drawing.Size(1766, 65);
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
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.groupBox1.Controls.Add(this.pickerStartBreak4);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.pickerEndBreak4);
			this.groupBox1.Controls.Add(this.pickerStartBreak3);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.pickerEndBreak3);
			this.groupBox1.Controls.Add(this.pickerStartBreak2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.pickerEndBreak2);
			this.groupBox1.Controls.Add(this.pickerStartBreak1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.pickerEndBreak1);
			this.groupBox1.Controls.Add(this.pickerStartTime);
			this.groupBox1.Controls.Add(this.txtTakt);
			this.groupBox1.Controls.Add(this.txtPlanDay);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.pickerEndTime);
			this.groupBox1.Controls.Add(this.pickerStartDate);
			this.groupBox1.Controls.Add(this.cbxShiftType);
			this.groupBox1.Controls.Add(this.Now);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(3, 70);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(1788, 485);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// pickerStartBreak4
			// 
			this.pickerStartBreak4.CustomFormat = "HH:mm";
			this.pickerStartBreak4.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerStartBreak4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerStartBreak4.Location = new System.Drawing.Point(1246, 307);
			this.pickerStartBreak4.Name = "pickerStartBreak4";
			this.pickerStartBreak4.ShowUpDown = true;
			this.pickerStartBreak4.Size = new System.Drawing.Size(211, 72);
			this.pickerStartBreak4.TabIndex = 10;
			this.pickerStartBreak4.Value = new System.DateTime(2020, 1, 8, 8, 0, 0, 0);
			this.pickerStartBreak4.ValueChanged += new System.EventHandler(this.pickerStartBreak4_ValueChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(966, 310);
			this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(234, 63);
			this.label8.TabIndex = 56;
			this.label8.Text = "Break 4:";
			// 
			// pickerEndBreak4
			// 
			this.pickerEndBreak4.CustomFormat = "HH:mm";
			this.pickerEndBreak4.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerEndBreak4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerEndBreak4.Location = new System.Drawing.Point(1486, 307);
			this.pickerEndBreak4.Name = "pickerEndBreak4";
			this.pickerEndBreak4.ShowUpDown = true;
			this.pickerEndBreak4.Size = new System.Drawing.Size(216, 72);
			this.pickerEndBreak4.TabIndex = 11;
			this.pickerEndBreak4.Value = new System.DateTime(2020, 1, 8, 8, 0, 0, 0);
			this.pickerEndBreak4.ValueChanged += new System.EventHandler(this.pickerEndBreak4_ValueChanged);
			// 
			// pickerStartBreak3
			// 
			this.pickerStartBreak3.CustomFormat = "HH:mm";
			this.pickerStartBreak3.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerStartBreak3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerStartBreak3.Location = new System.Drawing.Point(1246, 219);
			this.pickerStartBreak3.Name = "pickerStartBreak3";
			this.pickerStartBreak3.ShowUpDown = true;
			this.pickerStartBreak3.Size = new System.Drawing.Size(211, 72);
			this.pickerStartBreak3.TabIndex = 8;
			this.pickerStartBreak3.Value = new System.DateTime(2020, 1, 8, 8, 0, 0, 0);
			this.pickerStartBreak3.ValueChanged += new System.EventHandler(this.pickerStartBreak3_ValueChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(966, 215);
			this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(234, 63);
			this.label7.TabIndex = 53;
			this.label7.Text = "Break 3:";
			// 
			// pickerEndBreak3
			// 
			this.pickerEndBreak3.CustomFormat = "HH:mm";
			this.pickerEndBreak3.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerEndBreak3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerEndBreak3.Location = new System.Drawing.Point(1486, 219);
			this.pickerEndBreak3.Name = "pickerEndBreak3";
			this.pickerEndBreak3.ShowUpDown = true;
			this.pickerEndBreak3.Size = new System.Drawing.Size(216, 72);
			this.pickerEndBreak3.TabIndex = 9;
			this.pickerEndBreak3.Value = new System.DateTime(2020, 1, 8, 8, 0, 0, 0);
			this.pickerEndBreak3.ValueChanged += new System.EventHandler(this.pickerEndBreak3_ValueChanged);
			// 
			// pickerStartBreak2
			// 
			this.pickerStartBreak2.CustomFormat = "HH:mm";
			this.pickerStartBreak2.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerStartBreak2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerStartBreak2.Location = new System.Drawing.Point(1246, 121);
			this.pickerStartBreak2.Name = "pickerStartBreak2";
			this.pickerStartBreak2.ShowUpDown = true;
			this.pickerStartBreak2.Size = new System.Drawing.Size(211, 72);
			this.pickerStartBreak2.TabIndex = 6;
			this.pickerStartBreak2.Value = new System.DateTime(2020, 1, 8, 8, 0, 0, 0);
			this.pickerStartBreak2.ValueChanged += new System.EventHandler(this.pickerStartBreak2_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(966, 121);
			this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(234, 63);
			this.label6.TabIndex = 50;
			this.label6.Text = "Break 2:";
			// 
			// pickerEndBreak2
			// 
			this.pickerEndBreak2.CustomFormat = "HH:mm";
			this.pickerEndBreak2.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerEndBreak2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerEndBreak2.Location = new System.Drawing.Point(1486, 121);
			this.pickerEndBreak2.Name = "pickerEndBreak2";
			this.pickerEndBreak2.ShowUpDown = true;
			this.pickerEndBreak2.Size = new System.Drawing.Size(216, 72);
			this.pickerEndBreak2.TabIndex = 7;
			this.pickerEndBreak2.Value = new System.DateTime(2020, 1, 8, 8, 0, 0, 0);
			this.pickerEndBreak2.ValueChanged += new System.EventHandler(this.pickerEndBreak2_ValueChanged);
			// 
			// pickerStartBreak1
			// 
			this.pickerStartBreak1.CustomFormat = "HH:mm";
			this.pickerStartBreak1.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerStartBreak1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerStartBreak1.Location = new System.Drawing.Point(1246, 24);
			this.pickerStartBreak1.Name = "pickerStartBreak1";
			this.pickerStartBreak1.ShowUpDown = true;
			this.pickerStartBreak1.Size = new System.Drawing.Size(211, 72);
			this.pickerStartBreak1.TabIndex = 4;
			this.pickerStartBreak1.Value = new System.DateTime(2020, 1, 8, 8, 0, 0, 0);
			this.pickerStartBreak1.ValueChanged += new System.EventHandler(this.pickerStartBreak_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(966, 24);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(234, 63);
			this.label4.TabIndex = 47;
			this.label4.Text = "Break 1:";
			// 
			// pickerEndBreak1
			// 
			this.pickerEndBreak1.CustomFormat = "HH:mm";
			this.pickerEndBreak1.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerEndBreak1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerEndBreak1.Location = new System.Drawing.Point(1486, 24);
			this.pickerEndBreak1.Name = "pickerEndBreak1";
			this.pickerEndBreak1.ShowUpDown = true;
			this.pickerEndBreak1.Size = new System.Drawing.Size(216, 72);
			this.pickerEndBreak1.TabIndex = 5;
			this.pickerEndBreak1.Value = new System.DateTime(2020, 1, 8, 8, 0, 0, 0);
			this.pickerEndBreak1.ValueChanged += new System.EventHandler(this.pickerEndBreak_ValueChanged);
			// 
			// pickerStartTime
			// 
			this.pickerStartTime.CustomFormat = "HH:mm";
			this.pickerStartTime.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerStartTime.Location = new System.Drawing.Point(395, 394);
			this.pickerStartTime.Name = "pickerStartTime";
			this.pickerStartTime.ShowUpDown = true;
			this.pickerStartTime.Size = new System.Drawing.Size(211, 72);
			this.pickerStartTime.TabIndex = 2;
			this.pickerStartTime.Value = new System.DateTime(2020, 1, 8, 8, 0, 0, 0);
			this.pickerStartTime.ValueChanged += new System.EventHandler(this.pickerStartTime_ValueChanged);
			// 
			// txtTakt
			// 
			this.txtTakt.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTakt.Location = new System.Drawing.Point(395, 121);
			this.txtTakt.Name = "txtTakt";
			this.txtTakt.ReadOnly = true;
			this.txtTakt.Size = new System.Drawing.Size(457, 72);
			this.txtTakt.TabIndex = 44;
			this.txtTakt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPlanDay
			// 
			this.txtPlanDay.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlanDay.Location = new System.Drawing.Point(395, 207);
			this.txtPlanDay.Name = "txtPlanDay";
			this.txtPlanDay.ReadOnly = true;
			this.txtPlanDay.Size = new System.Drawing.Size(457, 72);
			this.txtPlanDay.TabIndex = 43;
			this.txtPlanDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(4, 121);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(366, 63);
			this.label2.TabIndex = 41;
			this.label2.Text = "Takt time (s): ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(91, 206);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(279, 63);
			this.label3.TabIndex = 42;
			this.label3.Text = "Plan Day: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(199, 400);
			this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(171, 63);
			this.label5.TabIndex = 40;
			this.label5.Text = "Time:";
			// 
			// pickerEndTime
			// 
			this.pickerEndTime.CustomFormat = "HH:mm";
			this.pickerEndTime.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerEndTime.Location = new System.Drawing.Point(636, 394);
			this.pickerEndTime.Name = "pickerEndTime";
			this.pickerEndTime.ShowUpDown = true;
			this.pickerEndTime.Size = new System.Drawing.Size(216, 72);
			this.pickerEndTime.TabIndex = 3;
			this.pickerEndTime.Value = new System.DateTime(2020, 1, 8, 8, 0, 0, 0);
			this.pickerEndTime.ValueChanged += new System.EventHandler(this.pickerEndTime_ValueChanged);
			// 
			// pickerStartDate
			// 
			this.pickerStartDate.CustomFormat = "dd/MM/yyyy";
			this.pickerStartDate.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.pickerStartDate.Location = new System.Drawing.Point(395, 301);
			this.pickerStartDate.Name = "pickerStartDate";
			this.pickerStartDate.Size = new System.Drawing.Size(457, 72);
			this.pickerStartDate.TabIndex = 1;
			this.pickerStartDate.ValueChanged += new System.EventHandler(this.pickerStartDate_ValueChanged);
			// 
			// cbxShiftType
			// 
			this.cbxShiftType.DisplayMember = "da";
			this.cbxShiftType.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxShiftType.FormattingEnabled = true;
			this.cbxShiftType.Location = new System.Drawing.Point(394, 24);
			this.cbxShiftType.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.cbxShiftType.Name = "cbxShiftType";
			this.cbxShiftType.Size = new System.Drawing.Size(457, 71);
			this.cbxShiftType.TabIndex = 0;
			this.cbxShiftType.SelectedIndexChanged += new System.EventHandler(this.cbxShiftType_SelectedIndexChanged);
			// 
			// Now
			// 
			this.Now.AutoSize = true;
			this.Now.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Now.Location = new System.Drawing.Point(212, 302);
			this.Now.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.Now.Name = "Now";
			this.Now.Size = new System.Drawing.Size(158, 63);
			this.Now.TabIndex = 39;
			this.Now.Text = "Date:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(194, 24);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 63);
			this.label1.TabIndex = 38;
			this.label1.Text = "Type: ";
			// 
			// grdData
			// 
			this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grdData.Location = new System.Drawing.Point(0, 565);
			this.grdData.MainView = this.grvData;
			this.grdData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grdData.Name = "grdData";
			this.grdData.Size = new System.Drawing.Size(1766, 289);
			this.grdData.TabIndex = 20;
			this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
			// 
			// grvData
			// 
			this.grvData.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grvData.Appearance.HeaderPanel.Options.UseFont = true;
			this.grvData.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grvData.Appearance.Row.Options.UseFont = true;
			this.grvData.ColumnPanelRowHeight = 50;
			this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShiftID,
            this.colID,
            this.colType,
            this.colStartTime,
            this.colEndTime,
            this.colQtyPlanDay,
            this.colStartBreak1,
            this.colEndBreak1,
            this.colStartBreak2,
            this.colStartBreak3,
            this.colStartBreak4,
            this.colEndBreak2,
            this.colEndBreak3,
            this.colEndBreak4});
			this.grvData.GridControl = this.grdData;
			this.grvData.Name = "grvData";
			this.grvData.OptionsBehavior.Editable = false;
			this.grvData.RowHeight = 50;
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
			this.colStartTime.DisplayFormat.FormatString = "HH:mm dd/MM/yyyy";
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
			this.colEndTime.DisplayFormat.FormatString = "HH:mm dd/MM/yyyy";
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
			// colStartBreak1
			// 
			this.colStartBreak1.Caption = "gridColumn1";
			this.colStartBreak1.DisplayFormat.FormatString = "HH:mm yyyy-MM-dd";
			this.colStartBreak1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colStartBreak1.FieldName = "StartTimeBreak1";
			this.colStartBreak1.Name = "colStartBreak1";
			// 
			// colEndBreak1
			// 
			this.colEndBreak1.Caption = "gridColumn2";
			this.colEndBreak1.DisplayFormat.FormatString = "HH:mm yyyy-MM-dd";
			this.colEndBreak1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colEndBreak1.FieldName = "EndTimeBreak1";
			this.colEndBreak1.Name = "colEndBreak1";
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
			this.colEndBreak2.Caption = "gridColumn4";
			this.colEndBreak2.FieldName = "EndTimeBreak2";
			this.colEndBreak2.Name = "colEndBreak2";
			// 
			// colEndBreak3
			// 
			this.colEndBreak3.Caption = "gridColumn5";
			this.colEndBreak3.FieldName = "EndTimeBreak3";
			this.colEndBreak3.Name = "colEndBreak3";
			// 
			// colEndBreak4
			// 
			this.colEndBreak4.Caption = "gridColumn6";
			this.colEndBreak4.FieldName = "EndTimeBreak4";
			this.colEndBreak4.Name = "colEndBreak4";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(931, 105);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 26);
			this.textBox1.TabIndex = 58;
			// 
			// frmAndonConfigVer4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1766, 856);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grdData);
			this.Controls.Add(this.mnuMenu);
			this.Controls.Add(this.textBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAndonConfigVer4";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CONFIGURATION SHIFT";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmAndonConfigVer3_Load);
			this.mnuMenu.ResumeLayout(false);
			this.mnuMenu.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip mnuMenu;
		private System.Windows.Forms.ToolStripButton btnNew;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripButton btnCancel;
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
		private System.Windows.Forms.DateTimePicker pickerStartDate;
		private System.Windows.Forms.ComboBox cbxShiftType;
		private System.Windows.Forms.Label Now;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTakt;
		private System.Windows.Forms.TextBox txtPlanDay;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private DevExpress.XtraGrid.Columns.GridColumn colShiftID;
		private System.Windows.Forms.DateTimePicker pickerStartBreak1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker pickerEndBreak1;
		private System.Windows.Forms.DateTimePicker pickerStartTime;
		private DevExpress.XtraGrid.Columns.GridColumn colStartBreak1;
		private DevExpress.XtraGrid.Columns.GridColumn colEndBreak1;
		private System.Windows.Forms.DateTimePicker pickerStartBreak4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker pickerEndBreak4;
		private System.Windows.Forms.DateTimePicker pickerStartBreak3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker pickerEndBreak3;
		private System.Windows.Forms.DateTimePicker pickerStartBreak2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker pickerEndBreak2;
		private DevExpress.XtraGrid.Columns.GridColumn colStartBreak2;
		private DevExpress.XtraGrid.Columns.GridColumn colStartBreak3;
		private DevExpress.XtraGrid.Columns.GridColumn colStartBreak4;
		private DevExpress.XtraGrid.Columns.GridColumn colEndBreak2;
		private DevExpress.XtraGrid.Columns.GridColumn colEndBreak3;
		private DevExpress.XtraGrid.Columns.GridColumn colEndBreak4;
		private System.Windows.Forms.TextBox textBox1;
	}
}