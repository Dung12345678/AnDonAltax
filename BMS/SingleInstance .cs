using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace BMS
{
    class SingleInstance : WindowsFormsApplicationBase
    {
        private SingleInstance()
        {
            base.IsSingleInstance = true;
        }

        public static void Run(Form f, StartupNextInstanceEventHandler startupHandler)
        {
            SingleInstance app = new SingleInstance();
            app.MainForm = f;
            app.StartupNextInstance += startupHandler;
            app.Run(Environment.GetCommandLineArgs());
        }

        public static void StartupNextInstanceHandler(object sender, StartupNextInstanceEventArgs e)
        {
            foreach (string param in e.CommandLine)
            {
                MessageBox.Show(param + " is running.", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
