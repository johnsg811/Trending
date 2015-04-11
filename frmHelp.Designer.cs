namespace Trending
{
    partial class frmHelp
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(33, 51);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(16, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "1.";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(127, 51);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(322, 20);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "Select Any News Websites given on the right side to read news";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "User can click on any news link to read the full news below";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(322, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "User can add news websites by giving url of rss in ADD FEED";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(167, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(282, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Press the REFRESH button on the top to view the website";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(127, 211);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(322, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "User can also browse through recommed website in the app";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(127, 263);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(322, 20);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "You can search any URL to browse in textbox below ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(394, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 355);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Name = "frmHelp";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnClose;
    }
}