﻿namespace Trending
{
    partial class frmAddNews
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRssWeblink = new System.Windows.Forms.TextBox();
            this.btnAddFeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSS Weblink";
            // 
            // txtRssWeblink
            // 
            this.txtRssWeblink.Location = new System.Drawing.Point(98, 18);
            this.txtRssWeblink.Name = "txtRssWeblink";
            this.txtRssWeblink.Size = new System.Drawing.Size(336, 20);
            this.txtRssWeblink.TabIndex = 1;
            // 
            // btnAddFeed
            // 
            this.btnAddFeed.Location = new System.Drawing.Point(98, 44);
            this.btnAddFeed.Name = "btnAddFeed";
            this.btnAddFeed.Size = new System.Drawing.Size(59, 23);
            this.btnAddFeed.TabIndex = 2;
            this.btnAddFeed.Text = "Add feed";
            this.btnAddFeed.UseVisualStyleBackColor = true;
            this.btnAddFeed.Click += new System.EventHandler(this.btnAddFeed_Click);
            // 
            // frmAddNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 79);
            this.Controls.Add(this.btnAddFeed);
            this.Controls.Add(this.txtRssWeblink);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddNews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new news RSS feed";
            this.Load += new System.EventHandler(this.frmAddNews_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRssWeblink;
        private System.Windows.Forms.Button btnAddFeed;
    }
}