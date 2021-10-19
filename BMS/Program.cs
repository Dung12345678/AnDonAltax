using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.AccessControl;
using System.IO;
using DevExpress.XtraGrid.Localization;
using Forms;

namespace BMS
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		public static List<int> RequestIDList = new List<int>();
		private static Mutex mutex = null;

		[STAThread]
		static void Main(string[] args)
		{
			const string appName = "AnDon";
			bool createdNew;
			mutex = new Mutex(true, appName, out createdNew);
			if (!createdNew)
			{
				MessageBox.Show("App is already running! Exiting the application", "Warning", MessageBoxButtons.OK);
				//app is already running! Exiting the application  
				return;
			}
			Application.EnableVisualStyles();

			GridLocalizer.Active = new NVGridLocalizer();
			Application.SetCompatibleTextRenderingDefault(false);

			Application.Run(new frmAndonDetailVer4());
		}
	}
}