using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AllTools
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            All.Communicate.AutoReadAndWrite auto = new All.Communicate.AutoReadAndWrite();
            auto.Load("Meter.xml");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
