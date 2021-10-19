using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmShowAndon : Form
	{
		public frmShowAndon()
		{
			InitializeComponent();
		}

		private void frmShowAndon_Load(object sender, EventArgs e)
		{
			//Andon
			DateTime now = DateTime.Now;
			string sql = string.Format("Select top 10 a.*, s.Name from Andon as a left join Shift as s on a.ShiftID = s.ID " +
				"where ShiftStartTime <= GETDATE() order by ShiftStartTime desc ", now.ToString("yyyy-MM-dd HH:mm"));
			DataTable data = TextUtils.Select(sql);
			grdData.DataSource = data;
		}
	}
}
