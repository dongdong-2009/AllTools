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
    public partial class ucMcgs : All.Control.Metro.MetroPanel
    {
        public ucMcgs()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            FMcgs.frmConnection fc = new FMcgs.frmConnection();
            fc.Show();
        }
    }
}
