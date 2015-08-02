namespace ProjectVanilla
{
    partial class FormTesting
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SubjectInfoLabel = new System.Windows.Forms.Label();
            this.ButtonStartTest = new System.Windows.Forms.Button();
            this.ButtonViewSubjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 328);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SubjectInfoLabel
            // 
            this.SubjectInfoLabel.AutoSize = true;
            this.SubjectInfoLabel.Location = new System.Drawing.Point(195, 12);
            this.SubjectInfoLabel.Name = "SubjectInfoLabel";
            this.SubjectInfoLabel.Size = new System.Drawing.Size(101, 12);
            this.SubjectInfoLabel.TabIndex = 1;
            this.SubjectInfoLabel.Text = "SubjectInfoLabel";
            // 
            // ButtonStartTest
            // 
            this.ButtonStartTest.Location = new System.Drawing.Point(491, 315);
            this.ButtonStartTest.Name = "ButtonStartTest";
            this.ButtonStartTest.Size = new System.Drawing.Size(89, 25);
            this.ButtonStartTest.TabIndex = 2;
            this.ButtonStartTest.Text = "开始测试";
            this.ButtonStartTest.UseVisualStyleBackColor = true;
            // 
            // ButtonViewSubjects
            // 
            this.ButtonViewSubjects.Location = new System.Drawing.Point(396, 315);
            this.ButtonViewSubjects.Name = "ButtonViewSubjects";
            this.ButtonViewSubjects.Size = new System.Drawing.Size(89, 25);
            this.ButtonViewSubjects.TabIndex = 3;
            this.ButtonViewSubjects.Text = "浏览测试点";
            this.ButtonViewSubjects.UseVisualStyleBackColor = true;
            // 
            // FormTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 347);
            this.Controls.Add(this.ButtonViewSubjects);
            this.Controls.Add(this.ButtonStartTest);
            this.Controls.Add(this.SubjectInfoLabel);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormTesting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "TestTitle";
            this.Load += new System.EventHandler(this.FormTesting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label SubjectInfoLabel;
        private System.Windows.Forms.Button ButtonStartTest;
        private System.Windows.Forms.Button ButtonViewSubjects;
    }
}