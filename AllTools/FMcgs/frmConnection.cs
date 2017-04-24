using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AllTools.FMcgs
{
    public partial class frmConnection : All.Window.BestWindow
    {
        All.Class.Net net = new All.Class.Net();
        object lockObject = new object();
        int overCount = 0;
        public frmConnection()
        {
            InitializeComponent();
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            net.PingResultArgs += net_PingResultArgs;
            net.PingAllResultArgs += net_PingAllResultArgs;
        }
        private void frmConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            net.PingResultArgs -= net_PingResultArgs;
            net.PingAllResultArgs -= net_PingAllResultArgs;
            Stop();
        }
        void net_PingAllResultArgs(List<All.Class.Net.PingResult> obj)
        {
            this.CrossThreadDo(() =>
                {
                    btnTest.Enabled = true;
                    txtInfo.Text = "";
                    if (obj != null)
                    {
                        IEnumerable<All.Class.Net.PingResult> tmp = obj.OrderBy(result => result.Index);
                        string tmpStr = "";
                        int tempCount = 0;
                        tmp.ToList().ForEach(value =>
                            {
                                if (value.Result)
                                {
                                    tmpStr = string.Format("       {0}{1} -> {2}", value.IpAddress,
                                         string.Empty.PadLeft(15 - value.IpAddress.Length),
                                         value.Result ? "成功" : "失败");
                                    Append(tmpStr, value.Result ? Color.Green : Color.Red);
                                    tempCount++;
                                    if ((tempCount % 4) == 0)
                                    {
                                        txtInfo.AppendText("\r\n");
                                    }
                                }
                            });
                        txtInfo.AppendText("\r\n");
                        tmpStr = "";
                        tempCount = 0;
                        tmp.ToList().ForEach(value =>
                        {
                            if (!value.Result)
                            {
                                tmpStr = string.Format("       {0}{1} -> {2}", value.IpAddress,
                                     string.Empty.PadLeft(15 - value.IpAddress.Length),
                                     value.Result ? "成功" : "失败");
                                Append(tmpStr, value.Result ? Color.Green : Color.Red);
                                tempCount++;
                                if ((tempCount % 4) == 0)
                                {
                                    txtInfo.AppendText("\r\n");
                                }
                            }
                        });
                    }
                });
        }

        void net_PingResultArgs(All.Class.Net.PingResult obj)
        {
            lock (lockObject)
            {
                this.CrossThreadDo(() =>
                    {
                        string value = string.Format("       {0}{1} -> {2}", obj.IpAddress,
                            string.Empty.PadLeft(15 - obj.IpAddress.Length),
                            obj.Result ? "成功" : "失败");
                        Append(value, obj.Result ? Color.Green : Color.Red);
                        overCount++;
                        pbValue.Value = overCount;
                        if ((overCount % 4) == 0)
                        {
                            txtInfo.AppendText("\r\n");
                        }
                    });
            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            Stop();
            btnTest.Enabled = false;
            int start = txtStart.Text.ToInt();
            int end = txtEnd.Text.ToInt();
            if (end - start >= 0)
            {
                pbValue.Maximum = end - start + 1;
            }
            try
            {
                net.Ping(string.Format("{0}{1}", cbbIpAddress.Text, txtStart.Text),
                    string.Format("{0}{1}", cbbIpAddress.Text, txtEnd.Text));
            }
            catch (Exception exc)
            {
                string error = string.Format("{0}\r\n", exc.Message);
                Append(error, Color.Red);
            }
        }
        private void Append(string value,Color color)
        {
            txtInfo.AppendText(value);
            txtInfo.Select(txtInfo.Text.Length - value.Replace("\r", "").Length, value.Replace("\r", "").Length);
            txtInfo.SelectionColor = color;
        }
        private void Stop()
        {
            pbValue.Value = 0;
            txtInfo.Text = "";
            overCount = 0;
            net.Stop();
        }


    }
}
