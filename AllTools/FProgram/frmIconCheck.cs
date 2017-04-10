using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
namespace AllTools.FProgram
{
    public partial class frmIconCheck : All.Window.BestWindow
    {
        public string Url
        { get; set; }
        public string Dir
        { get; set; }
        /// <summary>
        /// 是否校验完成
        /// </summary>
        public bool CheckOver
        { get; set; }
        Cookie cc = new Cookie();
        public frmIconCheck()
        {
            CheckOver = false;
            InitializeComponent();
        }

        private void frmIconCheck_Load(object sender, EventArgs e)
        {
            this.CrossThreadDo(() =>
            {
                webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
                webBrowser1.Url = new Uri("http://download.easyicon.net/png/1205858/524/");
            });
        }
        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument dc = webBrowser1.Document;
            if (dc.Title.IndexOf("图标搜索下载 | EASYICON.NET") >= 0)
            {
                CheckOver = true;
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //if (Check())
            //{
            Check();
            CheckOver = true;
            this.DialogResult = DialogResult.Yes;
            this.Close();
            //}
            //else
            //{
            //    lblTitle.Text = "输入的校验码不正确,请重新输入...";
            //    pictureBox1.Image.Dispose();
            //    DownLoadCheckImage();
            //}
        }
        private void Check()
        {
            HtmlDocument dc = webBrowser1.Document;
            //获取所有表单
            HtmlElementCollection es = dc.GetElementsByTagName("input");
            //获取验证码输入
            HtmlElement code = dc.GetElementById("secode");
            code.SetAttribute("value", txtCode.Text);
            //找到提交按钮
            foreach (HtmlElement e1 in es)
            {
                if (e1.GetAttribute("type").ToLower() == "submit")
                {
                    //执行提交事件
                    e1.InvokeMember("Click");
                    break;
                }
            }
            //if (txtCode.Text.Length < 4)
            //{ return false; }
            //HttpWebRequest wr = (HttpWebRequest)HttpWebRequest.Create("http://www.easyicon.net/download/index.php?type=png&id=1205858&size=524");
            //wr.Method = "POST";
            //wr.Headers.Add("Accept-Language", "zh-CN");
            //wr.Headers.Add("secode", txtCode.Text);
            //wr.Headers.Add("nextUrl", "http://www.easyicon.net");
            //wr.Headers.Add("%E6%8F%90%E4%BA%A4", "Continue");
            ////wr.Headers.Add("secode",string.Format("{0}&nextUrl=http%3A%2F%2Fwww.easyicon.net&%E6%8F%90%E4%BA%A4=Continue", txtCode.Text));
            //wr.ContentType = "application/x-www-form-urlencoded";
            //wr.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            //StreamReader sr = new StreamReader(wr.GetResponse().GetResponseStream());
            //string ss = sr.ReadToEnd();
            //return false;
        }
    
    }
}
