using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;
namespace AllTools.FProgram
{
    public partial class frmIcon : All.Window.BestWindow
    {
        class IconValue
        {
            public string Url
            { get; set; }
            public string Title
            { get; set; }
            public IconValue(string url, string title)
            {
                this.Url = url;
                this.Title = title;
            }
        }
        const int threadCount = 40;
        const string PngStart = "http://download.easyicon.net/png/";
        const string IcoStart = "http://download.easyicon.net/ico/";
        WebRequest wSend;
        WebResponse wRead;
        System.Threading.Thread[] th;
        int[] allIndex;
        List<IconValue> allUrl;
        frmIconCheck fc;
        bool downContinual = true;
        object lockProgress = new object();
        public frmIcon()
        {
            InitializeComponent();
        }

        private void frmIcon_Load(object sender, EventArgs e)
        {
            txtFile.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            fileSavePath.Description = "请选择保存文件目录";
            fileSavePath.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void Init()
        {
            if (wSend != null)
            {
                wSend.Abort();
                wSend = null;
            }
            if (wRead != null)
            {
                wRead.Close();
                wRead = null;
            }
            allIndex = new int[threadCount];
            for (int i = 0; i < allIndex.Length; i++)
            {
                allIndex[i] = i;
            }
            allUrl = new List<IconValue>();
        }
        private void btnPath_Click(object sender, EventArgs e)
        {
            if (fileSavePath.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = fileSavePath.SelectedPath;
            }
        }
        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            Init();
            wSend = WebRequest.Create(txtNet.Text);
            wSend.Timeout = 2000;
            try
            {
                wRead = (WebResponse)wSend.GetResponse();
                using (StreamReader sr = new StreamReader(wRead.GetResponseStream()))
                {
                    allUrl = GetFileString(GetAllPages(sr.ReadToEnd(), txtNet.Text));
                    if (allUrl != null && allUrl.Count > 0)
                    {
                        if (!CheckPath())
                        {
                            this.CrossThreadDo(() =>
                            {
                                this.txtShow.AppendText("检查文件保存路径失败,不能创建指定路径");
                                this.txtShow.AppendText("\r\n");
                            });
                        }
                        else
                        {
                            this.CrossThreadDo(() =>
                            {
                                this.txtShow.AppendText("开始多线程下载指定文件");
                                this.txtShow.AppendText("\r\n");
                            });
                            th = new System.Threading.Thread[threadCount];
                            for (int i = 0; i < threadCount; i++)
                            {
                                int index = i;
                                th[i] = new System.Threading.Thread(() => DownLoad(allUrl, index, txtFile.Text));
                                th[i].IsBackground = true;
                                th[i].Start();
                            }
                        }
                    }
                }
                wRead.Close();
            }
            catch(WebException webExe)
            {
                MessageBox.Show(webExe.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckPath()
        {
            if(!System.IO.Directory.Exists(txtFile.Text))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(txtFile.Text);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 从主页面获取所有图标页面
        /// </summary>
        /// <param name="str"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        private List<string> GetAllPages(string str,string url)
        {
            List<string> result = new List<string>();
            string[] tmp = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            string pageStr = tmp.ToList().FindLast(tmpStr => tmpStr.Contains(" 翻") && tmpStr.Contains("页可看完"));
            int pageCount = All.Class.Num.GetVisableHex(pageStr.Substring(0,10)).ToInt();
            string countStr = tmp.ToList().FindLast(tmpStr => tmpStr.Contains("找到") && tmpStr.Contains("图标"));
            int count = All.Class.Num.GetVisableHex(countStr).ToInt();
            if (countStr == "" || count <= 0)
            {
                this.CrossThreadDo(() =>
                {
                    this.txtShow.AppendText("当前网页解析错误,没有找到对应的图标数量,错误");
                    this.txtShow.AppendText("\r\n");
                });
                return null;
            }
            else
            {
                this.CrossThreadDo(() =>
                {
                    this.txtShow.AppendText(string.Format("找到网页数量为{0},图标数量为{1}", pageCount, count));
                    this.txtShow.AppendText("\r\n");
                    if (count > 0)
                    {
                        pbValue.Value = 0;
                        pbValue.Maximum = count;
                    }
                });
            }
            if (pageCount > 0)
            {
                for (int i = 0; i < pageCount; i++)
                {
                    result.Add(string.Format("{0}/{1}", url, i + 1));
                }
            }
            return result;
        }
        private List<IconValue> GetFileString(List<string> pags)
        {
            if (pags == null || pags.Count <= 0)
            {
                return new List<IconValue>();
            }
            List<IconValue> result = new List<IconValue>();
            Init();
            try
            {
                for (int i = 0; i < pags.Count; i++)
                {
                    wSend = WebRequest.Create(pags[i]);
                    wSend.Timeout = 2000;
                    wRead = (WebResponse)wSend.GetResponse();
                    using (StreamReader sr = new StreamReader(wRead.GetResponseStream()))
                    {
                        result.AddRange(GetFileStringFromEveryPage(sr.ReadToEnd(), pags[i]));
                    }
                    wRead.Close();
                }
            }
            catch (WebException webExe)
            {
                MessageBox.Show(webExe.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        /// <summary>
        /// 从页面中获取每一个图标下载地址
        /// </summary>
        /// <param name="str"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        private List<IconValue> GetFileStringFromEveryPage(string str, string url)
        {
            List<IconValue> result = new List<IconValue>();
            string startStr = rbtIcon.Checked ? IcoStart.ToUpper() : PngStart.ToUpper();
            string[] tmpUrl = str.Split('"');
            List<string> tmpTitle = str.Split(new char[] { '<', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int count = 0;
            Regex r;
            int titleIndex = -1;
            string id = "";
            string[] tmp;
            for (int i = 0; i < tmpUrl.Length; i++)
            {
                if (tmpUrl[i].ToUpper().StartsWith(startStr))
                {
                    id = tmpUrl[i].Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries)[3];
                    //<a href="/1207294-panties_icon.html" title="panties">
                    r = new Regex(string.Format("^a href=\"/{0}", id));//此处的Regex是不严谨的.正则学的不好
                    titleIndex = tmpTitle.FindIndex(title =>
                          {
                              return r.Match(title).Success;
                          });
                    if (titleIndex >= 0)
                    {
                        tmp = tmpTitle[titleIndex].Split(new char[] { '"' }, StringSplitOptions.RemoveEmptyEntries);
                        result.Add(new IconValue(tmpUrl[i], tmp[tmp.Length - 1]));
                    }
                    else
                    {
                        result.Add(new IconValue(tmpUrl[i], id));
                    }
                    count++;
                }
            }
            this.CrossThreadDo(() =>
            {
                this.txtShow.AppendText(string.Format("找到{0}个图标,在:{1}", count, url));
                this.txtShow.AppendText("\r\n");
            });
            return result;
        }
        private void DownLoad(List<IconValue> file, int index, string dir)
        {
            if (file == null || file.Count == 0)
            {
                return;
            }
            string[] fileName;
            for (int i = allIndex[index]; i < file.Count; i = i + threadCount)
            {
                if (!downContinual)
                {
                    break;
                }
                using (WebClient wb = new WebClient())
                {
                    CheckTooMany(file[i], index, dir);
                    fileName = file[i].Url.Split(new char[] { '/' }, StringSplitOptions.None);
                    int count = 0;
                    do
                    {
                        try
                        {
                            wb.DownloadFile(file[i].Url, string.Format("{0}//{1}.{2}", dir, file[i].Title +" " + fileName[fileName.Length - 3], fileName[fileName.Length - 4]));
                            break;
                        }
                        catch (Exception e)
                        {
                            this.CrossThreadDo(() =>
                            {
                                this.txtShow.AppendText(e.ToString());
                                this.txtShow.AppendText("\r\n");
                            });
                        }
                        count++;
                    } while (count < 3);
                    this.CrossThreadDo(() =>
                    {
                        if (count > 0)
                        {
                            this.txtShow.AppendText(file[i].Title + "\r\n");
                        }
                        if (count >= 3)
                        {
                            this.txtShow.AppendText(string.Format("{0}文件下载失败!!!!!!!", file[i].Title));
                        }
                        else
                        {
                            this.txtShow.AppendText(string.Format("{0}文件下载成功", file[i].Title));
                            this.txtShow.AppendText("\r\n");
                            lock (lockProgress)
                            {
                                pbValue.Value += 1;
                            }
                        }
                    });
                    allIndex[index] = allIndex[index] + threadCount;
                    System.Threading.Thread.Sleep(100);
                }
            }
        }
        object lockObject = new object();
        private void CheckTooMany(IconValue icon, int index, string dir)
        {
            lock (lockObject)
            {
                string html = GetHtmlString(icon.Url);
                if (html.IndexOf("TODAY, Too many download requests.") >= 0)
                {
                    downContinual = false;
                    this.CrossThreadDo(() =>
                        {
                            fc = new frmIconCheck();
                            fc.Url = icon.Url;
                            fc.Dir = dir;
                            fc.FormClosed += fc_FormClosed;
                            for (int i = 0; i < threadCount; i++)
                            {
                                if (i != index)
                                {
                                    switch (th[i].ThreadState)
                                    {
                                        case System.Threading.ThreadState.WaitSleepJoin|System.Threading.ThreadState.Background://线程LOCK时,直接停止
                                            th[i].Abort();
                                            break;
                                        case System.Threading.ThreadState.Running://正在下载时,等待此次下载完成
                                            th[i].Join(5000);
                                            break;
                                        default:
                                            this.txtShow.AppendText("错误的状态" + th[i].ThreadState.ToString());
                                            this.txtShow.AppendText("\r\n");
                                            break;
                                    }
                                }
                            }
                            fc.Show();
                            th[index].Abort();
                        });
                }
            }
        }
        private void fc_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmIconCheck fc = (frmIconCheck)sender;
            if (!fc.CheckOver)
            {
                this.CrossThreadDo(() =>
                {
                    this.txtShow.AppendText("取消验证码输入,停止所有下载线程,等待中...");
                    this.txtShow.AppendText("\r\n");
                });
            }
            else
            {
                downContinual = true;
                th = new System.Threading.Thread[threadCount];
                for (int i = 0; i < threadCount; i++)
                {
                    int index = i;
                    th[i] = new System.Threading.Thread(() => DownLoad(allUrl, index, txtFile.Text));
                    th[i].IsBackground = true;
                    th[i].Start();
                }
            }
            fc.FormClosed -= fc_FormClosed;
            fc.Dispose();
        }
        /// <summary>
        /// 根据URL获取网页代码
        /// </summary>
        /// <param name="strURL">URL地址</param>
        /// <returns>网页代码字符串</returns>
        public static string GetHtmlString(string url)
        {
            try
            {
                using (StreamReader sr = new StreamReader(WebRequest.Create(url).GetResponse().GetResponseStream()))
                {
                    return sr.ReadToEnd();
                }
            }
            catch { }
            return "";
            //Uri uri = new Uri(url);
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //Stream stream = response.GetResponseStream();
            //string strHtml = "";
            //if (stream != null)
            //{
            //    StreamReader sr = new StreamReader(stream);
            //    strHtml = sr.ReadToEnd();
            //    sr.Close();
            //    stream.Close();
            //    response.Close();
            //}
            //return strHtml;
        }

        private void frmIcon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th != null)
            {
                for (int i = 0; i < th.Length; i++)
                {
                    if (th[i] != null)
                    {
                        th[i].Abort();
                    }
                }
            }
        }
        //private List<string> GetFileString(string str)
        //{
        //    List<string> result = new List<string>();
        //    string startStr = rbtIcon.Checked ? startIco : startPng;
        //    string endStr = rbtIcon.Checked ? endIco : endPng;
        //    int start = 0, end = 0;
        //    string[] tmp = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        //    string countStr = tmp.ToList().FindLast(tmpStr => tmpStr.Contains("找到") && tmpStr.Contains("图标"));
        //    int count = All.Class.Num.GetVisableHex(countStr).ToInt();
        //    if (countStr == "" || count <= 0)
        //    {
        //        this.CrossThreadDo(() =>
        //        {
        //            this.txtShow.AppendText("当前网页解析错误,没有找到对应的图标数量,错误");
        //            this.txtShow.AppendText("\r\n");
        //        });
        //        return null;
        //    }
        //    else
        //    {
        //        this.CrossThreadDo(() =>
        //        {
        //            this.txtShow.AppendText(string.Format("找到当前网页图标数量为{0}", count));
        //            this.txtShow.AppendText("\r\n");
        //        });
        //    }
        //    start = str.IndexOf(startStr);
        //    end = str.IndexOf(endStr);
        //    if (start <= 0 || end <= 0)
        //    {
        //        this.CrossThreadDo(() =>
        //        {
        //            this.txtShow.AppendText("当前网页解析错误,没有找到图标链接,错误");
        //            this.txtShow.AppendText("\r\n");
        //        });
        //        return null;
        //    }
        //    string file = str.Substring(start + startStr.Length, end - start - startStr.Length);
        //    tmp = file.Split(new char[] { '/' }, StringSplitOptions.None);
        //    if (tmp.Length <= 4)
        //    {
        //        this.CrossThreadDo(() =>
        //        {
        //            this.txtShow.AppendText("当前网页解析错误,找到的图标链接不正确,错误");
        //            this.txtShow.AppendText("\r\n");
        //        });
        //        return null;
        //    }
        //    int firstIndex = tmp[tmp.Length - 3].ToInt();
        //    string title = "";
        //    for (int i = 0; i < tmp.Length - 3; i++)
        //    {
        //        title = string.Format("{0}{1}/", title, tmp[i]);
        //    }
        //    for (int i = 0; i < count; i++)
        //    {
        //        result.Add(string.Format("{0}{1}/{2}/", title, firstIndex - i, tmp[tmp.Length - 2]));
        //    }
        //    this.CrossThreadDo(() =>
        //    {
        //        this.txtShow.AppendText("已成功找到所有图标地址");
        //        this.txtShow.AppendText("\r\n");
        //    });
        //    return result;
        //}
        //private void GetFileString(string str,out List<string> ico,out List<string> png)
        //{
        //    ico = new List<string>();
        //    png = new List<string>();
        //    List<string> result = new List<string>();
        //    int tmpSpace = 0;
        //    int start = 0, end = 0;
        //    string startStr = "";
        //    string endStr = "";
        //    if (rbtIcon.Checked)
        //    {
        //        startStr = startIco;
        //        endStr = endIco;
        //    }
        //    if (rbtPng.Checked)
        //    {
        //        startStr = startPng;
        //        endStr = endPng;
        //    }
        //    do
        //    {
        //        if (tmpSpace >= str.Length || start < 0 || end < 0)
        //        {
        //            break;
        //        }
        //        start = str.IndexOf(startStr, tmpSpace);
        //        end = str.IndexOf(endStr, tmpSpace);
        //        if (start >= 0 && end >= 0)
        //        {
        //            result.Add(str.Substring(start + startStr.Length, end - start - startStr.Length));
        //            tmpSpace = end + 1;
        //        }
        //    } while (true);
        //    if (rbtIcon.Checked)
        //    {
        //        ico = result;
        //    }
        //    if (rbtPng.Checked)
        //    {
        //        png = result;
        //    }
        //}
    }
}
