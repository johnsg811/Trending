using System.IO;

namespace CaptureRSS
{
    partial class Form1
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
            File.Delete("C:/tempHTML.html");
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnAddRSS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RSSBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RSSList = new System.Windows.Forms.WebBrowser();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.NetBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStripNavigate = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnForward = new System.Windows.Forms.ToolStripButton();
            this.tmrTrackHistory = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStripNavigate.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtURL.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtURL.Location = new System.Drawing.Point(80, 13);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(460, 18);
            this.txtURL.TabIndex = 2;
            // 
            // btnAddRSS
            // 
            this.btnAddRSS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddRSS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRSS.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnAddRSS.Location = new System.Drawing.Point(546, 11);
            this.btnAddRSS.Name = "btnAddRSS";
            this.btnAddRSS.Size = new System.Drawing.Size(96, 22);
            this.btnAddRSS.TabIndex = 1;
            this.btnAddRSS.Text = "Subscribe";
            this.btnAddRSS.UseVisualStyleBackColor = false;
            this.btnAddRSS.Click += new System.EventHandler(this.btnFetchRSS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSS URL";
            // 
            // RSSBrowser
            // 
            this.RSSBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RSSBrowser.Location = new System.Drawing.Point(0, 0);
            this.RSSBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.RSSBrowser.Name = "RSSBrowser";
            this.RSSBrowser.Size = new System.Drawing.Size(710, 172);
            this.RSSBrowser.TabIndex = 1;
            this.RSSBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.RSSBrowser_Navigating);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(914, 536);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RSSList);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(908, 517);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // RSSList
            // 
            this.RSSList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RSSList.Location = new System.Drawing.Point(0, 0);
            this.RSSList.MinimumSize = new System.Drawing.Size(20, 20);
            this.RSSList.Name = "RSSList";
            this.RSSList.Size = new System.Drawing.Size(193, 515);
            this.RSSList.TabIndex = 0;
            this.RSSList.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.RSSList_Navigating);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.RSSBrowser);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.NetBrowser);
            this.splitContainer2.Panel2.Controls.Add(this.toolStripNavigate);
            this.splitContainer2.Size = new System.Drawing.Size(712, 517);
            this.splitContainer2.SplitterDistance = 174;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // NetBrowser
            // 
            this.NetBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NetBrowser.Location = new System.Drawing.Point(0, 25);
            this.NetBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.NetBrowser.Name = "NetBrowser";
            this.NetBrowser.Size = new System.Drawing.Size(710, 315);
            this.NetBrowser.TabIndex = 1;
            // 
            // toolStripNavigate
            // 
            this.toolStripNavigate.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripNavigate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnForward});
            this.toolStripNavigate.Location = new System.Drawing.Point(0, 0);
            this.toolStripNavigate.Name = "toolStripNavigate";
            this.toolStripNavigate.Size = new System.Drawing.Size(710, 25);
            this.toolStripNavigate.TabIndex = 0;
            this.toolStripNavigate.Text = "toolStrip1";
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 22);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(23, 22);
            this.btnForward.Text = "Forward";
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // tmrTrackHistory
            // 
            this.tmrTrackHistory.Tick += new System.EventHandler(this.tmrTrackHistory_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(938, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddRSS);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Read For Speed";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.toolStripNavigate.ResumeLayout(false);
            this.toolStripNavigate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnAddRSS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser RSSBrowser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStripNavigate;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnForward;
        private System.Windows.Forms.WebBrowser NetBrowser;
        private System.Windows.Forms.Timer tmrTrackHistory;
        private System.Windows.Forms.WebBrowser RSSList;
    }
}

