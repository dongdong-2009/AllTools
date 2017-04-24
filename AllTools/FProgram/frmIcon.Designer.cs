namespace AllTools.FProgram
{
    partial class frmIcon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIcon));
            this.fileSavePath = new System.Windows.Forms.FolderBrowserDialog();
            this.pbValue = new All.Control.Metro.ProgressBar();
            this.panel1 = new All.Control.Metro.Panel(this.components);
            this.rbtPng = new All.Control.Metro.RadioButton();
            this.rbtIcon = new All.Control.Metro.RadioButton();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label2 = new All.Control.Metro.Label();
            this.btnDownLoad = new All.Control.Metro.Button();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.label1 = new All.Control.Metro.Label();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbValue
            // 
            this.pbValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbValue.Location = new System.Drawing.Point(2, 474);
            this.pbValue.MaxiColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.pbValue.Maximum = 100;
            this.pbValue.MiniColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(204)))));
            this.pbValue.Minimum = 0;
            this.pbValue.Name = "pbValue";
            this.pbValue.OwnerDraw = false;
            this.pbValue.Size = new System.Drawing.Size(796, 4);
            this.pbValue.TabIndex = 5;
            this.pbValue.Text = "progressBar1";
            this.pbValue.Value = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbtPng);
            this.panel1.Controls.Add(this.rbtIcon);
            this.panel1.Controls.Add(this.btnPath);
            this.panel1.Controls.Add(this.txtFile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDownLoad);
            this.panel1.Controls.Add(this.txtNet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("宋体", 9F);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Location = new System.Drawing.Point(2, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 66);
            this.panel1.TabIndex = 0;
            // 
            // rbtPng
            // 
            this.rbtPng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtPng.AutoSize = true;
            this.rbtPng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rbtPng.Checked = true;
            this.rbtPng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.rbtPng.Location = new System.Drawing.Point(654, 37);
            this.rbtPng.Name = "rbtPng";
            this.rbtPng.Size = new System.Drawing.Size(65, 16);
            this.rbtPng.TabIndex = 7;
            this.rbtPng.TabStop = true;
            this.rbtPng.Text = "PNG格式";
            this.rbtPng.UseVisualStyleBackColor = false;
            // 
            // rbtIcon
            // 
            this.rbtIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtIcon.AutoSize = true;
            this.rbtIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rbtIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.rbtIcon.Location = new System.Drawing.Point(654, 11);
            this.rbtIcon.Name = "rbtIcon";
            this.rbtIcon.Size = new System.Drawing.Size(71, 16);
            this.rbtIcon.TabIndex = 6;
            this.rbtIcon.Text = "ICON格式";
            this.rbtIcon.UseVisualStyleBackColor = false;
            // 
            // btnPath
            // 
            this.btnPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath.Location = new System.Drawing.Point(607, 34);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(34, 23);
            this.btnPath.TabIndex = 5;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(148, 35);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(463, 21);
            this.txtFile.TabIndex = 4;
            this.txtFile.Text = "http://www.easyicon.net/iconsearch/iconset:trendy-icons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "本地Icon文件保存目录";
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDownLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDownLoad.BackgroundImage")));
            this.btnDownLoad.Boarder = true;
            this.btnDownLoad.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDownLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnDownLoad.Location = new System.Drawing.Point(731, 5);
            this.btnDownLoad.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.btnDownLoad.Size = new System.Drawing.Size(55, 55);
            this.btnDownLoad.TabIndex = 2;
            this.btnDownLoad.Text = "下载";
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // txtNet
            // 
            this.txtNet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNet.Location = new System.Drawing.Point(150, 9);
            this.txtNet.Name = "txtNet";
            this.txtNet.Size = new System.Drawing.Size(491, 21);
            this.txtNet.TabIndex = 1;
            this.txtNet.Text = "http://www.easyicon.net/iconsearch/iconset:Flatastic-icons/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "EasyIcon系列图标地址";
            // 
            // txtShow
            // 
            this.txtShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShow.Location = new System.Drawing.Point(2, 95);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShow.Size = new System.Drawing.Size(796, 379);
            this.txtShow.TabIndex = 6;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Close.png");
            this.imageList1.Images.SetKeyName(1, "Open.png");
            // 
            // frmIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.pbValue);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIcon";
            this.Text = "图标下载";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIcon_FormClosing);
            this.Load += new System.EventHandler(this.frmIcon_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pbValue, 0);
            this.Controls.SetChildIndex(this.txtShow, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private All.Control.Metro.Panel panel1;
        private All.Control.Metro.Button btnDownLoad;
        private System.Windows.Forms.TextBox txtNet;
        private All.Control.Metro.Label label1;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtFile;
        private All.Control.Metro.Label label2;
        private System.Windows.Forms.FolderBrowserDialog fileSavePath;
        private All.Control.Metro.RadioButton rbtPng;
        private All.Control.Metro.RadioButton rbtIcon;
        private All.Control.Metro.ProgressBar pbValue;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.ImageList imageList1;
    }
}