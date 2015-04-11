using System.IO;

namespace Trending
{
    partial class frmTrending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrending));
            this.RSSBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtWebURL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbAIB = new System.Windows.Forms.PictureBox();
            this.pgGmail = new System.Windows.Forms.PictureBox();
            this.pbGIHub = new System.Windows.Forms.PictureBox();
            this.pbDIT = new System.Windows.Forms.PictureBox();
            this.pbTwitter = new System.Windows.Forms.PictureBox();
            this.pbFacebook = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.NetBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStripNavigate = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tmrTrackHistory = new System.Windows.Forms.Timer(this.components);
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsAddFeed = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsFileAddNews = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsAboutUs = new System.Windows.Forms.ToolStripButton();
            this.tsHelps = new System.Windows.Forms.ToolStripButton();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAIB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgGmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGIHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStripNavigate.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // RSSBrowser
            // 
            this.RSSBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RSSBrowser.Location = new System.Drawing.Point(0, 0);
            this.RSSBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.RSSBrowser.Name = "RSSBrowser";
            this.RSSBrowser.Size = new System.Drawing.Size(1047, 219);
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
            this.groupBox2.Location = new System.Drawing.Point(0, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(1342, 684);
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnOk);
            this.splitContainer1.Panel1.Controls.Add(this.txtWebURL);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1336, 665);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(245, 540);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(29, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Go";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtWebURL
            // 
            this.txtWebURL.Location = new System.Drawing.Point(44, 541);
            this.txtWebURL.Name = "txtWebURL";
            this.txtWebURL.Size = new System.Drawing.Size(200, 20);
            this.txtWebURL.TabIndex = 2;
            this.txtWebURL.Text = "www.johnsg.net";
            this.txtWebURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWebURL_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbAIB);
            this.groupBox1.Controls.Add(this.pgGmail);
            this.groupBox1.Controls.Add(this.pbGIHub);
            this.groupBox1.Controls.Add(this.pbDIT);
            this.groupBox1.Controls.Add(this.pbTwitter);
            this.groupBox1.Controls.Add(this.pbFacebook);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(1, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recommanded website";
            // 
            // pbAIB
            // 
            this.pbAIB.Image = ((System.Drawing.Image)(resources.GetObject("pbAIB.Image")));
            this.pbAIB.Location = new System.Drawing.Point(185, 127);
            this.pbAIB.Margin = new System.Windows.Forms.Padding(2);
            this.pbAIB.Name = "pbAIB";
            this.pbAIB.Size = new System.Drawing.Size(77, 70);
            this.pbAIB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAIB.TabIndex = 13;
            this.pbAIB.TabStop = false;
            this.pbAIB.Click += new System.EventHandler(this.pbAIB_Click);
            // 
            // pgGmail
            // 
            this.pgGmail.Image = ((System.Drawing.Image)(resources.GetObject("pgGmail.Image")));
            this.pgGmail.Location = new System.Drawing.Point(185, 40);
            this.pgGmail.Margin = new System.Windows.Forms.Padding(2);
            this.pgGmail.Name = "pgGmail";
            this.pgGmail.Size = new System.Drawing.Size(77, 70);
            this.pgGmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pgGmail.TabIndex = 12;
            this.pgGmail.TabStop = false;
            this.pgGmail.Click += new System.EventHandler(this.pgGmail_Click);
            // 
            // pbGIHub
            // 
            this.pbGIHub.Image = ((System.Drawing.Image)(resources.GetObject("pbGIHub.Image")));
            this.pbGIHub.Location = new System.Drawing.Point(104, 127);
            this.pbGIHub.Margin = new System.Windows.Forms.Padding(2);
            this.pbGIHub.Name = "pbGIHub";
            this.pbGIHub.Size = new System.Drawing.Size(77, 70);
            this.pbGIHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGIHub.TabIndex = 10;
            this.pbGIHub.TabStop = false;
            this.pbGIHub.Click += new System.EventHandler(this.pbGIHub_Click);
            // 
            // pbDIT
            // 
            this.pbDIT.Image = ((System.Drawing.Image)(resources.GetObject("pbDIT.Image")));
            this.pbDIT.Location = new System.Drawing.Point(11, 127);
            this.pbDIT.Margin = new System.Windows.Forms.Padding(2);
            this.pbDIT.Name = "pbDIT";
            this.pbDIT.Size = new System.Drawing.Size(77, 70);
            this.pbDIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDIT.TabIndex = 9;
            this.pbDIT.TabStop = false;
            this.pbDIT.Click += new System.EventHandler(this.pbDIT_Click);
            // 
            // pbTwitter
            // 
            this.pbTwitter.Image = ((System.Drawing.Image)(resources.GetObject("pbTwitter.Image")));
            this.pbTwitter.Location = new System.Drawing.Point(104, 40);
            this.pbTwitter.Margin = new System.Windows.Forms.Padding(2);
            this.pbTwitter.Name = "pbTwitter";
            this.pbTwitter.Size = new System.Drawing.Size(77, 70);
            this.pbTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTwitter.TabIndex = 8;
            this.pbTwitter.TabStop = false;
            this.pbTwitter.Click += new System.EventHandler(this.pbTwitter_Click);
            // 
            // pbFacebook
            // 
            this.pbFacebook.Image = ((System.Drawing.Image)(resources.GetObject("pbFacebook.Image")));
            this.pbFacebook.Location = new System.Drawing.Point(11, 40);
            this.pbFacebook.Margin = new System.Windows.Forms.Padding(2);
            this.pbFacebook.Name = "pbFacebook";
            this.pbFacebook.Size = new System.Drawing.Size(77, 70);
            this.pbFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFacebook.TabIndex = 7;
            this.pbFacebook.TabStop = false;
            this.pbFacebook.Click += new System.EventHandler(this.pbFacebook_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(313, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.splitContainer2.Size = new System.Drawing.Size(1049, 665);
            this.splitContainer2.SplitterDistance = 221;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // NetBrowser
            // 
            this.NetBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NetBrowser.Location = new System.Drawing.Point(0, 25);
            this.NetBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.NetBrowser.Name = "NetBrowser";
            this.NetBrowser.Size = new System.Drawing.Size(1047, 416);
            this.NetBrowser.TabIndex = 1;
            this.NetBrowser.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.NetBrowser_ProgressChanged);
            // 
            // toolStripNavigate
            // 
            this.toolStripNavigate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnForward,
            this.toolStripProgressBar1});
            this.toolStripNavigate.Location = new System.Drawing.Point(0, 0);
            this.toolStripNavigate.Name = "toolStripNavigate";
            this.toolStripNavigate.Size = new System.Drawing.Size(1047, 25);
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
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tmrTrackHistory
            // 
            this.tmrTrackHistory.Tick += new System.EventHandler(this.tmrTrackHistory_Tick);
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddFeed,
            this.tsRefresh,
            this.tsAboutUs,
            this.tsHelps});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1354, 25);
            this.tsMenu.TabIndex = 3;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsAddFeed
            // 
            this.tsAddFeed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFileAddNews});
            this.tsAddFeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsAddFeed.ForeColor = System.Drawing.Color.Black;
            this.tsAddFeed.Image = ((System.Drawing.Image)(resources.GetObject("tsAddFeed.Image")));
            this.tsAddFeed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddFeed.Name = "tsAddFeed";
            this.tsAddFeed.Size = new System.Drawing.Size(87, 22);
            this.tsAddFeed.Text = "Add feed";
            this.tsAddFeed.Click += new System.EventHandler(this.tsAddFeed_Click);
            // 
            // tsFileAddNews
            // 
            this.tsFileAddNews.Name = "tsFileAddNews";
            this.tsFileAddNews.Size = new System.Drawing.Size(67, 22);
            // 
            // tsRefresh
            // 
            this.tsRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsRefresh.ForeColor = System.Drawing.Color.Black;
            this.tsRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsRefresh.Image")));
            this.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRefresh.Name = "tsRefresh";
            this.tsRefresh.Size = new System.Drawing.Size(71, 22);
            this.tsRefresh.Text = "Refresh";
            this.tsRefresh.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsAboutUs
            // 
            this.tsAboutUs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsAboutUs.ForeColor = System.Drawing.Color.Black;
            this.tsAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("tsAboutUs.Image")));
            this.tsAboutUs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAboutUs.Name = "tsAboutUs";
            this.tsAboutUs.Size = new System.Drawing.Size(78, 22);
            this.tsAboutUs.Text = "About Us";
            this.tsAboutUs.Click += new System.EventHandler(this.tsAboutUs_Click);
            // 
            // tsHelps
            // 
            this.tsHelps.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsHelps.ForeColor = System.Drawing.Color.Black;
            this.tsHelps.Image = ((System.Drawing.Image)(resources.GetObject("tsHelps.Image")));
            this.tsHelps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsHelps.Name = "tsHelps";
            this.tsHelps.Size = new System.Drawing.Size(58, 22);
            this.tsHelps.Text = "Helps";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(330, 4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(329, 20);
            this.txtURL.TabIndex = 4;
            this.txtURL.Visible = false;
            // 
            // frmTrending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTrending";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Tending version 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTrending_Load);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAIB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgGmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGIHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStripNavigate.ResumeLayout(false);
            this.toolStripNavigate.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser RSSBrowser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStripNavigate;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnForward;
        private System.Windows.Forms.WebBrowser NetBrowser;
        private System.Windows.Forms.Timer tmrTrackHistory;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton tsRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbGIHub;
        private System.Windows.Forms.PictureBox pbDIT;
        private System.Windows.Forms.PictureBox pbTwitter;
        private System.Windows.Forms.PictureBox pbFacebook;
        private System.Windows.Forms.PictureBox pbAIB;
        private System.Windows.Forms.PictureBox pgGmail;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtWebURL;
        private System.Windows.Forms.ToolStripButton tsAboutUs;
        private System.Windows.Forms.ToolStripButton tsHelps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripDropDownButton tsAddFeed;
        private System.Windows.Forms.ToolStripMenuItem tsFileAddNews;
    }
}

