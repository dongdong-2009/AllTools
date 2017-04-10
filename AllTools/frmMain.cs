using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AllTools
{
    public partial class frmMain : All.Window.BestWindow
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            All.Window.AboutWindow aw = new All.Window.AboutWindow(this.Text, true);
            aw.ShowDialog();
        }
    }
}
