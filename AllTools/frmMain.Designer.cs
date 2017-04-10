namespace AllTools
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new All.Control.Metro.TabControl(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucDebug1 = new AllTools.ucDebug();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucProgram2 = new AllTools.ucProgram();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ucPlc1 = new AllTools.ucPlc();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.ucValue1 = new AllTools.ucValue();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.ucEelect2 = new AllTools.ucEelect();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.ucAnGui1 = new AllTools.ucAnGui();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ucMcgs1 = new AllTools.ucMcgs();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.ucEelect1 = new AllTools.ucEelect();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControl1.Location = new System.Drawing.Point(2, 29);
            this.tabControl1.MinimumSize = new System.Drawing.Size(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 449);
            this.tabControl1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.关于AToolStripMenuItem.Text = "关于[&A]";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(788, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "文件";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucDebug1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 419);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "调试工具";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucDebug1
            // 
            this.ucDebug1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucDebug1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDebug1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucDebug1.Location = new System.Drawing.Point(3, 3);
            this.ucDebug1.Name = "ucDebug1";
            this.ucDebug1.Size = new System.Drawing.Size(782, 413);
            this.ucDebug1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucProgram2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 419);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "编程工具";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucProgram2
            // 
            this.ucProgram2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucProgram2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProgram2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucProgram2.Location = new System.Drawing.Point(3, 3);
            this.ucProgram2.Name = "ucProgram2";
            this.ucProgram2.Size = new System.Drawing.Size(782, 413);
            this.ucProgram2.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ucPlc1);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(788, 419);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "PLC";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ucPlc1
            // 
            this.ucPlc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucPlc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlc1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucPlc1.Location = new System.Drawing.Point(3, 3);
            this.ucPlc1.Name = "ucPlc1";
            this.ucPlc1.Size = new System.Drawing.Size(782, 413);
            this.ucPlc1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.ucValue1);
            this.tabPage6.Location = new System.Drawing.Point(4, 26);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(788, 419);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "模拟量";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // ucValue1
            // 
            this.ucValue1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucValue1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucValue1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucValue1.Location = new System.Drawing.Point(3, 3);
            this.ucValue1.Name = "ucValue1";
            this.ucValue1.Size = new System.Drawing.Size(782, 413);
            this.ucValue1.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.ucEelect2);
            this.tabPage7.Location = new System.Drawing.Point(4, 26);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(788, 419);
            this.tabPage7.TabIndex = 8;
            this.tabPage7.Text = "电参数";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // ucEelect2
            // 
            this.ucEelect2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucEelect2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEelect2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucEelect2.Location = new System.Drawing.Point(0, 0);
            this.ucEelect2.Name = "ucEelect2";
            this.ucEelect2.Size = new System.Drawing.Size(788, 419);
            this.ucEelect2.TabIndex = 1;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.ucAnGui1);
            this.tabPage8.Location = new System.Drawing.Point(4, 26);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(788, 419);
            this.tabPage8.TabIndex = 9;
            this.tabPage8.Text = "安规";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // ucAnGui1
            // 
            this.ucAnGui1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucAnGui1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAnGui1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucAnGui1.Location = new System.Drawing.Point(3, 3);
            this.ucAnGui1.Name = "ucAnGui1";
            this.ucAnGui1.Size = new System.Drawing.Size(782, 413);
            this.ucAnGui1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ucMcgs1);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(788, 419);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "小屏控制";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ucMcgs1
            // 
            this.ucMcgs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucMcgs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMcgs1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ucMcgs1.Location = new System.Drawing.Point(3, 3);
            this.ucMcgs1.Name = "ucMcgs1";
            this.ucMcgs1.Size = new System.Drawing.Size(782, 413);
            this.ucMcgs1.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 26);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(788, 419);
            this.tabPage9.TabIndex = 10;
            this.tabPage9.Text = "其他";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 26);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(788, 419);
            this.tabPage10.TabIndex = 11;
            this.tabPage10.Text = "指令生成";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // ucEelect1
            // 
            this.ucEelect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucEelect1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEelect1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ucEelect1.Location = new System.Drawing.Point(0, 0);
            this.ucEelect1.Name = "ucEelect1";
            this.ucEelect1.Size = new System.Drawing.Size(780, 378);
            this.ucEelect1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "调试,测试,编程工具集合           ";
            this.Theme = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ucEelect ucEelect1;
        private All.Control.Metro.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private ucEelect ucEelect2;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private ucPlc ucPlc1;
        private ucAnGui ucAnGui1;
        private ucValue ucValue1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private ucDebug ucDebug1;
        private System.Windows.Forms.TabPage tabPage2;
        private ucProgram ucProgram2;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage3;
        private ucMcgs ucMcgs1;
















    }
}