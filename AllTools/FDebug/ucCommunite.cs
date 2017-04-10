using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AllTools.FDebug
{
    public partial class ucCommunite : UserControl
    {
        /// <summary>
        /// 通讯类
        /// </summary>
        public All.Communicate.Communicate Communicate
        { get; set; }
        /// <summary>
        /// 数据量改变
        /// </summary>
        /// <param name="count"></param>
        public delegate void DataCountChangeHandle(int count);
        /// <summary>
        /// 发送数据量改变
        /// </summary>
        public event DataCountChangeHandle SendDataCountChange;
        /// <summary>
        /// 接收数据量改变
        /// </summary>
        public event DataCountChangeHandle ReadDataCountChange;

        int sendCount = 0;
        /// <summary>
        /// 发送数据量
        /// </summary>
        public int SendCount
        {
            get { return sendCount; }
            set {
                sendCount = value;
                if (SendDataCountChange != null)
                {
                    SendDataCountChange(sendCount);
                }
            }
        }
        int readCount = 0;
        /// <summary>
        /// 接收数据量
        /// </summary>
        public int ReadCount
        {
            get { return readCount; }
            set
            {
                readCount = value;
                if (ReadDataCountChange != null)
                {
                    ReadDataCountChange(readCount);
                }
            }
        }
        public ucCommunite()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRead.Text = "";
            SendCount = 0;
            ReadCount = 0;
            
        }
        /// <summary>
        /// 设置通讯类
        /// </summary>
        /// <param name="communicate"></param>
        public void SetCommunicate(All.Communicate.Communicate communicate)
        {
            this.Communicate = communicate;
            btnSend.Enabled = this.Communicate != null && this.Communicate.IsOpen;
            btnAutoSend.Enabled = this.Communicate != null && this.Communicate.IsOpen;
        }
        private void ucCommunite_Load(object sender, EventArgs e)
        {
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }
    }
}
