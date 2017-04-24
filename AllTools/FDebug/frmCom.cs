using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
namespace AllTools.FDebug
{
    public partial class frmCom : All.Window.BestWindow
    {
        All.Communicate.Com com;
        public frmCom()
        {
            InitializeComponent();
            if (!All.Class.Environment.IsDesignMode)
            {
                cbbBaud.Text = "9600";
                cbbParity.SelectedIndex = 0;
                cbbData.SelectedIndex = 0;
                cbbStop.SelectedIndex = 0;
                List<string> buff = System.IO.Ports.SerialPort.GetPortNames().ToList();
                if (buff.Count > 0)
                {
                    buff.ForEach(str => cbbCom.Items.Add(str));
                    cbbCom.SelectedIndex = 0;
                }
                else
                {
                    btnOpen.Enabled = false;
                }
                ucCommunite1.ReadDataCountChange += ucCommunite1_ReadDataCountChange;
                ucCommunite1.SendDataCountChange += ucCommunite1_SendDataCountChange;
            }
        }
        private void frmCom_Load(object sender, EventArgs e)
        {
        }

        private void ucCommunite1_SendDataCountChange(int count)
        {
            lblSendCount.Text = string.Format("{0}", count);
        }

        private void ucCommunite1_ReadDataCountChange(int count)
        {
            lblGetCount.Text = string.Format("{0}", count);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (btnOpen.Text == "打开")
            {
                OpenCom();
            }
            else
            {
                CloseCom();
            }
        }
        private void OpenCom()
        {
            try
            {
                if (!cbbBaud.Items.Contains(cbbBaud.Text))
                {
                    cbbBaud.Items.Add(cbbBaud.Text);
                }
                cbbBaud.DropDownStyle = ComboBoxStyle.DropDownList;
                com = new All.Communicate.Com();
                com.CommunicateErrorRaise += com_CommunicateErrorRaise;
                Dictionary<string, string> buff = new Dictionary<string, string>();
                com.Init(buff);
                com.Open();
                if (com.IsOpen)
                {
                    ucCommunite1.SetCommunicate(com);
                    btnOpen.Text = "关闭";
                    btnOpen.BackgroundImage = AllTools.Properties.Resources.Close;
                }
                else
                {
                    CloseCom();
                }
            }
            catch (Exception e)
            {
                using (All.Window.MessageWindow mw = new All.Window.MessageWindow(e.Message, "错误", All.Window.MessageWindow.EButton.OK, All.Window.MessageWindow.EIcon.Error))
                {
                    mw.ShowDialog();
                }
            }
        }
        private void CloseCom()
        {
            try
            {
                com.CommunicateErrorRaise -= com_CommunicateErrorRaise;
                if (com != null)
                {
                    com.Close();
                    com = null;
                }
                cbbBaud.DropDownStyle = ComboBoxStyle.DropDown;
                btnOpen.Text = "打开";
                btnOpen.BackgroundImage = AllTools.Properties.Resources.Open;
            }
            catch { }
        }
        private void com_CommunicateErrorRaise(Exception e)
        {
            using (All.Window.MessageWindow mw = new All.Window.MessageWindow(e.Message, "错误", All.Window.MessageWindow.EButton.OK, All.Window.MessageWindow.EIcon.Error))
            {
                mw.ShowDialog();
            }
        }

        private void chkDTR_CheckedChanged(object sender, EventArgs e)
        {
            if (com != null)
            {
                Dictionary<string, string> buff = new Dictionary<string, string>();
                buff.Add("RtsEnable", chkDTR.Checked.ToString());
                com.InitCommunite(buff);
            }
        }

        private void chkRTS_CheckedChanged(object sender, EventArgs e)
        {
            if (com != null)
            {
                Dictionary<string, string> buff = new Dictionary<string, string>();
                buff.Add("DtrEnable", chkRTS.Checked.ToString());
                com.InitCommunite(buff);
            }
        }

        private void cbbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com != null)
            {
                Dictionary<string, string> buff = new Dictionary<string, string>();
                buff.Add("DataBits", cbbData.Text);
                com.InitCommunite(buff);
            }
        }

        private void cbbStop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com != null)
            {
                Dictionary<string, string> buff = new Dictionary<string, string>();
                buff.Add("StopBits", cbbStop.Text);
                com.InitCommunite(buff);
            }
        }

        private void cbbParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com != null)
            {
                Dictionary<string, string> buff = new Dictionary<string, string>();
                buff.Add("Parity", cbbParity.Text);
                com.InitCommunite(buff);
            }
        }
        private void cbbBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com != null)
            {
                Dictionary<string, string> buff = new Dictionary<string, string>();
                buff.Add("BaudRate", cbbBaud.Text);
                com.InitCommunite(buff);
            }
        }

    }
}
