namespace AllTools.FDebug
{
    partial class ucCommunite
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCommunite));
            this.panel4 = new All.Control.Metro.Panel(this.components);
            this.txtRead = new System.Windows.Forms.RichTextBox();
            this.panel5 = new All.Control.Metro.Panel(this.components);
            this.btnOpen = new All.Control.Metro.Button();
            this.btnSave = new All.Control.Metro.Button();
            this.btnAutoBack = new All.Control.Metro.Button();
            this.btnClear = new All.Control.Metro.Button();
            this.panel2 = new All.Control.Metro.Panel(this.components);
            this.panel3 = new All.Control.Metro.Panel(this.components);
            this.txtSend = new System.Windows.Forms.RichTextBox();
            this.panel6 = new All.Control.Metro.Panel(this.components);
            this.btnAutoSend = new All.Control.Metro.Button();
            this.btnSendList = new All.Control.Metro.Button();
            this.btnSend = new All.Control.Metro.Button();
            this.panel1 = new All.Control.Metro.Panel(this.components);
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtRead);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel4.Location = new System.Drawing.Point(0, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(796, 200);
            this.panel4.TabIndex = 6;
            // 
            // txtRead
            // 
            this.txtRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRead.Location = new System.Drawing.Point(0, 0);
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(699, 198);
            this.txtRead.TabIndex = 1;
            this.txtRead.Text = "";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnOpen);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.btnAutoBack);
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel5.Location = new System.Drawing.Point(699, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(95, 198);
            this.panel5.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpen.BackgroundImage")));
            this.btnOpen.Boarder = true;
            this.btnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnOpen.Location = new System.Drawing.Point(3, 146);
            this.btnOpen.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.btnOpen.Size = new System.Drawing.Size(87, 47);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "打开";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Boarder = true;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSave.Location = new System.Drawing.Point(3, 98);
            this.btnSave.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.btnSave.Size = new System.Drawing.Size(87, 47);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            // 
            // btnAutoBack
            // 
            this.btnAutoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAutoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutoBack.BackgroundImage")));
            this.btnAutoBack.Boarder = true;
            this.btnAutoBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAutoBack.Location = new System.Drawing.Point(3, 50);
            this.btnAutoBack.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnAutoBack.Name = "btnAutoBack";
            this.btnAutoBack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.btnAutoBack.Size = new System.Drawing.Size(87, 47);
            this.btnAutoBack.TabIndex = 1;
            this.btnAutoBack.Text = "自动回复";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.Boarder = true;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnClear.Location = new System.Drawing.Point(3, 2);
            this.btnClear.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.btnClear.Size = new System.Drawing.Size(87, 47);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 1);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtSend);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 150);
            this.panel3.TabIndex = 4;
            // 
            // txtSend
            // 
            this.txtSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSend.Location = new System.Drawing.Point(0, 0);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(699, 148);
            this.txtSend.TabIndex = 0;
            this.txtSend.Text = "";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnAutoSend);
            this.panel6.Controls.Add(this.btnSendList);
            this.panel6.Controls.Add(this.btnSend);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel6.Location = new System.Drawing.Point(699, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(95, 148);
            this.panel6.TabIndex = 0;
            // 
            // btnAutoSend
            // 
            this.btnAutoSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAutoSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutoSend.BackgroundImage")));
            this.btnAutoSend.Boarder = true;
            this.btnAutoSend.Enabled = false;
            this.btnAutoSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAutoSend.Location = new System.Drawing.Point(3, 50);
            this.btnAutoSend.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnAutoSend.Name = "btnAutoSend";
            this.btnAutoSend.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.btnAutoSend.Size = new System.Drawing.Size(87, 47);
            this.btnAutoSend.TabIndex = 1;
            this.btnAutoSend.Text = "循环发送";
            // 
            // btnSendList
            // 
            this.btnSendList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSendList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendList.BackgroundImage")));
            this.btnSendList.Boarder = true;
            this.btnSendList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSendList.Location = new System.Drawing.Point(3, 98);
            this.btnSendList.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnSendList.Name = "btnSendList";
            this.btnSendList.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.btnSendList.Size = new System.Drawing.Size(87, 47);
            this.btnSendList.TabIndex = 2;
            this.btnSendList.Text = "已发列表";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.Boarder = true;
            this.btnSend.Enabled = false;
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSend.Location = new System.Drawing.Point(3, 2);
            this.btnSend.MinimumSize = new System.Drawing.Size(10, 10);
            this.btnSend.Name = "btnSend";
            this.btnSend.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.btnSend.Size = new System.Drawing.Size(87, 47);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "手动发送";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 2);
            this.panel1.TabIndex = 0;
            // 
            // ucCommunite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ucCommunite";
            this.Size = new System.Drawing.Size(796, 353);
            this.Load += new System.EventHandler(this.ucCommunite_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private All.Control.Metro.Panel panel1;
        private System.Windows.Forms.RichTextBox txtSend;
        private All.Control.Metro.Panel panel4;
        private System.Windows.Forms.RichTextBox txtRead;
        private All.Control.Metro.Panel panel5;
        private All.Control.Metro.Button btnOpen;
        private All.Control.Metro.Button btnSave;
        private All.Control.Metro.Button btnAutoBack;
        private All.Control.Metro.Button btnClear;
        private All.Control.Metro.Panel panel2;
        private All.Control.Metro.Panel panel3;
        private All.Control.Metro.Panel panel6;
        private All.Control.Metro.Button btnAutoSend;
        private All.Control.Metro.Button btnSendList;
        private All.Control.Metro.Button btnSend;


    }
}
