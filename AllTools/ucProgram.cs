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
    public partial class ucProgram : All.Control.Metro.MetroPanel
    {
        public ucProgram()
        {
            InitializeComponent();
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            FProgram.frmIcon fi = new FProgram.frmIcon();
            fi.Show();
        }
    }
}
