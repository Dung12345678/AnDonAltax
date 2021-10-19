namespace BMS
{
	partial class frmShowAndon
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
			this.grdData = new DevExpress.XtraGrid.GridControl();
			this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colShiftID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQtyPlanDay = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQtyActual = new DevExpress.XtraGrid.Columns.GridColumn();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
			this.SuspendLayout();
			// 
			// grdData
			// 
			this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grdData.Location = new System.Drawing.Point(13, 77);
			this.grdData.MainView = this.grvData;
			this.grdData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grdData.Name = "grdData";
			this.grdData.Size = new System.Drawing.Size(1004, 381);
			this.grdData.TabIndex = 21;
			this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
			// 
			// grvData
			// 
			this.grvData.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold);
			this.grvData.Appearance.HeaderPanel.Options.UseFont = true;
			this.grvData.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold);
			this.grvData.Appearance.Row.Options.UseFont = true;
			this.grvData.ColumnPanelRowHeight = 60;
			this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShiftID,
            this.colID,
            this.colType,
            this.colStartTime,
            this.colEndTime,
            this.colQtyPlanDay,
            this.colQtyActual});
			this.grvData.GridControl = this.grdData;
			this.grvData.Name = "grvData";
			this.grvData.OptionsBehavior.Editable = false;
			this.grvData.RowHeight = 60;
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
			this.colType.Width = 131;
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
			this.colStartTime.Width = 167;
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
			this.colEndTime.Width = 178;
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
			this.colQtyPlanDay.Width = 119;
			// 
			// colQtyActual
			// 
			this.colQtyActual.AppearanceCell.Options.UseTextOptions = true;
			this.colQtyActual.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQtyActual.AppearanceHeader.Options.UseTextOptions = true;
			this.colQtyActual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQtyActual.Caption = "Actual";
			this.colQtyActual.FieldName = "QtyActual";
			this.colQtyActual.Name = "colQtyActual";
			this.colQtyActual.Visible = true;
			this.colQtyActual.VisibleIndex = 4;
			this.colQtyActual.Width = 101;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1030, 76);
			this.label1.TabIndex = 22;
			this.label1.Text = "LIST ANDON";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmShowAndon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1030, 472);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.grdData);
			this.Name = "frmShowAndon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmShowAndon";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmShowAndon_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl grdData;
		private DevExpress.XtraGrid.Views.Grid.GridView grvData;
		private DevExpress.XtraGrid.Columns.GridColumn colShiftID;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colType;
		private DevExpress.XtraGrid.Columns.GridColumn colStartTime;
		private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
		private DevExpress.XtraGrid.Columns.GridColumn colQtyPlanDay;
		private DevExpress.XtraGrid.Columns.GridColumn colQtyActual;
		private System.Windows.Forms.Label label1;
	}
}