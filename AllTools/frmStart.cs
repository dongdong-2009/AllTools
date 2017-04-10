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
    public partial class frmStart :All.Window.StartWindow
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            this.Info = "正在启动程序,请稍候......";
            //System.Threading.Thread.Sleep(3000);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        private void frmStart_LoadOver(object sender, EventArgs e)
        {
            frmMain fs = new frmMain();
            fs.ShowDialog();
        }
    }
}
