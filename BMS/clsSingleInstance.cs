using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace BMS
{
    class clsSingleInstance : WindowsFormsApplicationBase
    {
        public clsSingleInstance()
        {
            base.IsSingleInstance = true;
            this.StartupNextInstance += new StartupNextInstanceEventHandler(startupNextHandle);
            this.EnableVisualStyles = true;
            this.ShutdownStyle = Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses;
        }

        public static void Run(Form form)
        {
            clsSingleInstance myApp = new clsSingleInstance();
            myApp.MainForm = form;
            myApp.Run(Environment.GetCommandLineArgs());
        }

        private void startupNextHandle(object sender, StartupNextInstanceEventArgs e)
        {
            MessageBox.Show("Another instance is running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

//        <?xml version="1.0"?>
//<configuration>
//    <startup>
//        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.0"/>
//    </startup>
//</configuration>
    }
}
