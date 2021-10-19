using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BMS;

namespace BMS
{
    public partial class _UserControls : UserControl
    {
        public _UserControls()
        {
            InitializeComponent();
        }

        private void _ucBMSRpt_Load(object sender, EventArgs e)
        {
            Permissions.LoadUserControlPermission(this);
        }
    }
}
