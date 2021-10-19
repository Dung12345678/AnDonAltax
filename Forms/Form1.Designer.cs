namespace Forms
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblTitleAndon = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.lblTitleTakt = new System.Windows.Forms.Label();
			this.progressBar = new DevExpress.XtraEditors.ProgressBarControl();
			this.lblPlanDayTitle = new System.Windows.Forms.Label();
			this.lblPlanDay = new System.Windows.Forms.Label();
			this.lblPlanCurrentTitle = new System.Windows.Forms.Label();
			this.lblPlanCurrent = new System.Windows.Forms.Label();
			this.lblActualTitle = new System.Windows.Forms.Label();
			this.lblActual = new System.Windows.Forms.Label();
			this.lblDelayTitle = new System.Windows.Forms.Label();
			this.lblDelay = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			// 
			// lblTitleAndon
			// 
			this.lblTitleAndon.BackColor = System.Drawing.Color.Blue;
			this.lblTitleAndon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleAndon.ForeColor = System.Drawing.Color.White;
			this.lblTitleAndon.Location = new System.Drawing.Point(8, 8);
			this.lblTitleAndon.Name = "lblTitleAndon";
			this.lblTitleAndon.Size = new System.Drawing.Size(900, 54);
			this.lblTitleAndon.TabIndex = 1;
			this.lblTitleAndon.Text = "ALTAX LINE ASSEMBLY\'S ANDON";
			this.lblTitleAndon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTime
			// 
			this.lblTime.BackColor = System.Drawing.Color.Blue;
			this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.ForeColor = System.Drawing.Color.White;
			this.lblTime.Location = new System.Drawing.Point(603, 290);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(39, 55);
			this.lblTime.TabIndex = 3;
			this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTitleTakt
			// 
			this.lblTitleTakt.BackColor = System.Drawing.Color.Blue;
			this.lblTitleTakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleTakt.ForeColor = System.Drawing.Color.White;
			this.lblTitleTakt.Location = new System.Drawing.Point(837, 195);
			this.lblTitleTakt.Name = "lblTitleTakt";
			this.lblTitleTakt.Size = new System.Drawing.Size(129, 55);
			this.lblTitleTakt.TabIndex = 4;
			this.lblTitleTakt.Text = "TAKT TIME";
			this.lblTitleTakt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(476, 400);
			this.progressBar.Name = "progressBar";
			this.progressBar.Properties.Appearance.BackColor = System.Drawing.Color.White;
			this.progressBar.Properties.EndColor = System.Drawing.Color.Cyan;
			this.progressBar.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
			this.progressBar.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
			this.progressBar.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
			this.progressBar.Properties.StartColor = System.Drawing.Color.Cyan;
			this.progressBar.Size = new System.Drawing.Size(716, 49);
			this.progressBar.TabIndex = 5;
			// 
			// lblPlanDayTitle
			// 
			this.lblPlanDayTitle.BackColor = System.Drawing.Color.Blue;
			this.lblPlanDayTitle.ForeColor = System.Drawing.Color.White;
			this.lblPlanDayTitle.Location = new System.Drawing.Point(42, 112);
			this.lblPlanDayTitle.Name = "lblPlanDayTitle";
			this.lblPlanDayTitle.Size = new System.Drawing.Size(72, 84);
			this.lblPlanDayTitle.TabIndex = 6;
			this.lblPlanDayTitle.Text = "PLAN DAY     (Unit)";
			this.lblPlanDayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPlanDay
			// 
			this.lblPlanDay.BackColor = System.Drawing.SystemColors.HighlightText;
			this.lblPlanDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlanDay.Location = new System.Drawing.Point(157, 110);
			this.lblPlanDay.Name = "lblPlanDay";
			this.lblPlanDay.Size = new System.Drawing.Size(143, 84);
			this.lblPlanDay.TabIndex = 7;
			this.lblPlanDay.Text = "0";
			this.lblPlanDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPlanCurrentTitle
			// 
			this.lblPlanCurrentTitle.BackColor = System.Drawing.Color.Blue;
			this.lblPlanCurrentTitle.ForeColor = System.Drawing.Color.White;
			this.lblPlanCurrentTitle.Location = new System.Drawing.Point(42, 247);
			this.lblPlanCurrentTitle.Name = "lblPlanCurrentTitle";
			this.lblPlanCurrentTitle.Size = new System.Drawing.Size(72, 84);
			this.lblPlanCurrentTitle.TabIndex = 8;
			this.lblPlanCurrentTitle.Text = "PLAN CURRENT (Unit)";
			this.lblPlanCurrentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPlanCurrent
			// 
			this.lblPlanCurrent.BackColor = System.Drawing.SystemColors.HighlightText;
			this.lblPlanCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlanCurrent.Location = new System.Drawing.Point(169, 247);
			this.lblPlanCurrent.Name = "lblPlanCurrent";
			this.lblPlanCurrent.Size = new System.Drawing.Size(143, 84);
			this.lblPlanCurrent.TabIndex = 9;
			this.lblPlanCurrent.Text = "0";
			this.lblPlanCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblActualTitle
			// 
			this.lblActualTitle.BackColor = System.Drawing.Color.Blue;
			this.lblActualTitle.ForeColor = System.Drawing.Color.White;
			this.lblActualTitle.Location = new System.Drawing.Point(42, 365);
			this.lblActualTitle.Name = "lblActualTitle";
			this.lblActualTitle.Size = new System.Drawing.Size(72, 84);
			this.lblActualTitle.TabIndex = 10;
			this.lblActualTitle.Text = "ACTUAL    (Unit)";
			this.lblActualTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblActual
			// 
			this.lblActual.BackColor = System.Drawing.SystemColors.HighlightText;
			this.lblActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblActual.Location = new System.Drawing.Point(169, 365);
			this.lblActual.Name = "lblActual";
			this.lblActual.Size = new System.Drawing.Size(143, 84);
			this.lblActual.TabIndex = 11;
			this.lblActual.Text = "0";
			this.lblActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDelayTitle
			// 
			this.lblDelayTitle.BackColor = System.Drawing.Color.Blue;
			this.lblDelayTitle.ForeColor = System.Drawing.Color.White;
			this.lblDelayTitle.Location = new System.Drawing.Point(42, 480);
			this.lblDelayTitle.Name = "lblDelayTitle";
			this.lblDelayTitle.Size = new System.Drawing.Size(63, 84);
			this.lblDelayTitle.TabIndex = 12;
			this.lblDelayTitle.Text = "DELAY     (Unit)";
			this.lblDelayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDelay
			// 
			this.lblDelay.BackColor = System.Drawing.SystemColors.HighlightText;
			this.lblDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDelay.Location = new System.Drawing.Point(157, 489);
			this.lblDelay.Name = "lblDelay";
			this.lblDelay.Size = new System.Drawing.Size(154, 84);
			this.lblDelay.TabIndex = 13;
			this.lblDelay.Text = "0";
			this.lblDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1244, 634);
			this.Controls.Add(this.lblDelay);
			this.Controls.Add(this.lblDelayTitle);
			this.Controls.Add(this.lblActual);
			this.Controls.Add(this.lblActualTitle);
			this.Controls.Add(this.lblPlanCurrent);
			this.Controls.Add(this.lblPlanCurrentTitle);
			this.Controls.Add(this.lblPlanDay);
			this.Controls.Add(this.lblPlanDayTitle);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.lblTitleTakt);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.lblTitleAndon);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblTitleAndon;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblTitleTakt;
		private DevExpress.XtraEditors.ProgressBarControl progressBar;
		private System.Windows.Forms.Label lblPlanDayTitle;
		private System.Windows.Forms.Label lblPlanDay;
		private System.Windows.Forms.Label lblPlanCurrentTitle;
		private System.Windows.Forms.Label lblPlanCurrent;
		private System.Windows.Forms.Label lblActualTitle;
		private System.Windows.Forms.Label lblActual;
		private System.Windows.Forms.Label lblDelayTitle;
		private System.Windows.Forms.Label lblDelay;
	}
}