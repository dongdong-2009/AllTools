using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AllTools
{
    public partial class ucDebug : All.Control.Metro.MetroPanel
    {
        public ucDebug()
        {
            InitializeComponent();
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            FDebug.frmCom f = new FDebug.frmCom();
            f.Show();
        }

        private void btnUdp_Click(object sender, EventArgs e)
        {
            FDebug.frmUdp f = new FDebug.frmUdp();
            f.Show();
        }

        private void btnTcpServer_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
