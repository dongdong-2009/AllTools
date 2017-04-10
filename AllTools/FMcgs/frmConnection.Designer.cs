namespace AllTools.FMcgs
{
    partial class frmConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnection));
            this.panel2 = new All.Control.Metro.Panel(this.components);
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.pbValue = new All.Control.Metro.ProgressBar();
            this.panel1 = new All.Control.Metro.Panel(this.components);
            this.label4 = new All.Control.Metro.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label3 = new All.Control.Metro.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label2 = new All.Control.Metro.Label();
            this.cbbIpAddress = new All.Control.Metro.ComboBox();
            this.btnTest = new All.Control.Metro.Button();
            this.label1 = new All.Control.Metro.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.Location = new System.Drawing.Point(2, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 379);
            this.panel2.TabIndex = 10;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.White;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.Location = new System.Drawing.Point(0, 0);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(794, 377);
            this.txtInfo.TabIndex = 10;
            this.txtInfo.Text = "";
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
            this.pbValue.TabIndex = 8;
            this.pbValue.Text = "progressBar1";
            this.pbValue.Value = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCount);
            this.panel1.Controls.Add(this.txtEnd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbIpAddress);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Location = new System.Drawing.Point(2, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 66);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label4.Location = new System.Drawing.Point(17, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "连续测试数:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(91, 36);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(105, 21);
            this.txtCount.TabIndex = 13;
            this.txtCount.Text = "1";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(291, 36);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(82, 21);
            this.txtEnd.TabIndex = 11;
            this.txtEnd.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label3.Location = new System.Drawing.Point(214, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "测试结束号:";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(291, 9);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(82, 21);
            this.txtStart.TabIndex = 9;
            this.txtStart.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(214, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "测试起始号:";
            // 
            // cbbIpAddress
            // 
            this.cbbIpAddress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbIpAddress.FormattingEnabled = true;
            this.cbbIpAddress.Items.AddRange(new object[] {
            "200.200.200.",
            "192.168.2.",
            "192.168.1.",
            "192.168.0.",
            "127.0.0."});
            this.cbbIpAddress.Location = new System.Drawing.Point(94, 8);
            this.cbbIpAddress.Name = "cbbIpAddress";
            this.cbbIpAddress.Size = new System.Drawing.Size(102, 22);
            this.cbbIpAddress.TabIndex = 3;
            this.cbbIpAddress.Text = "200.200.200.";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTest.BackgroundImage")));
            this.btnTest.Boarder = true;
            this.btnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnTest.Location = new System.Drawing.Point(731, 5);
            this.btnTest.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnTest.Name = "btnTest";
            this.btnTest.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.btnTest.Size = new System.Drawing.Size(55, 55);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "测试";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址前段:";
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbValue);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConnection";
            this.Text = "连接测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConnection_FormClosing);
            this.Load += new System.EventHandler(this.frmConnection_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStart;
        private All.Control.Metro.ProgressBar pbValue;
        private All.Control.Metro.Panel panel1;
        private All.Control.Metro.Label label2;
        private All.Control.Metro.ComboBox cbbIpAddress;
        private All.Control.Metro.Button btnTest;
        private All.Control.Metro.Label label1;
        private System.Windows.Forms.TextBox txtEnd;
        private All.Control.Metro.Label label3;
        private System.Windows.Forms.TextBox txtCount;
        private All.Control.Metro.Panel panel2;
        private System.Windows.Forms.RichTextBox txtInfo;
        private All.Control.Metro.Label label4;
    }
}