namespace Trending
{
    partial class frmAboutUs
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.txtProject1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtProject2 = new System.Windows.Forms.TextBox();
            this.txtProject3 = new System.Windows.Forms.TextBox();
            this.txtProject4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(23, 130);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 2;
            this.lblProject.Text = "Project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lecturer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Due Date";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(138, 39);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(80, 20);
            this.txtname.TabIndex = 5;
            this.txtname.Text = "Johns George";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(23, 85);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(64, 13);
            this.lblStudent.TabIndex = 6;
            this.lblStudent.Text = "Student No.";
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(138, 85);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.ReadOnly = true;
            this.txtStudent.Size = new System.Drawing.Size(80, 20);
            this.txtStudent.TabIndex = 7;
            this.txtStudent.Text = "C13391936";
            // 
            // txtProject1
            // 
            this.txtProject1.Location = new System.Drawing.Point(138, 130);
            this.txtProject1.Name = "txtProject1";
            this.txtProject1.ReadOnly = true;
            this.txtProject1.Size = new System.Drawing.Size(80, 20);
            this.txtProject1.TabIndex = 8;
            this.txtProject1.Text = "Trending";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 262);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(80, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Bryan Duggan";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(138, 303);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(80, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "15/04/2015";
            // 
            // txtProject2
            // 
            this.txtProject2.Location = new System.Drawing.Point(138, 156);
            this.txtProject2.Name = "txtProject2";
            this.txtProject2.ReadOnly = true;
            this.txtProject2.Size = new System.Drawing.Size(154, 20);
            this.txtProject2.TabIndex = 11;
            this.txtProject2.Text = "An application for reading news";
            // 
            // txtProject3
            // 
            this.txtProject3.Location = new System.Drawing.Point(138, 182);
            this.txtProject3.Name = "txtProject3";
            this.txtProject3.ReadOnly = true;
            this.txtProject3.Size = new System.Drawing.Size(230, 20);
            this.txtProject3.TabIndex = 12;
            this.txtProject3.Text = "Can read news from many website as possible";
            // 
            // txtProject4
            // 
            this.txtProject4.Location = new System.Drawing.Point(138, 208);
            this.txtProject4.Name = "txtProject4";
            this.txtProject4.ReadOnly = true;
            this.txtProject4.Size = new System.Drawing.Size(164, 20);
            this.txtProject4.TabIndex = 13;
            this.txtProject4.Text = "Can also browse through internet";
            // 
            // frmAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 335);
            this.Controls.Add(this.txtProject4);
            this.Controls.Add(this.txtProject3);
            this.Controls.Add(this.txtProject2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtProject1);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblName);
            this.Name = "frmAboutUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutUs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.TextBox txtProject1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtProject2;
        private System.Windows.Forms.TextBox txtProject3;
        private System.Windows.Forms.TextBox txtProject4;


    }
}