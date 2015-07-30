namespace ProjectVanilla
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTestCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labeldesc = new System.Windows.Forms.Label();
            this.ButtonInstall = new System.Windows.Forms.Button();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 278);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前拥有的测试数：";
            // 
            // LabelTestCount
            // 
            this.LabelTestCount.AutoSize = true;
            this.LabelTestCount.Location = new System.Drawing.Point(367, 12);
            this.LabelTestCount.Name = "LabelTestCount";
            this.LabelTestCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelTestCount.Size = new System.Drawing.Size(65, 12);
            this.LabelTestCount.TabIndex = 2;
            this.LabelTestCount.Text = "2147483647";
            this.LabelTestCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "详细信息:";
            // 
            // labeldesc
            // 
            this.labeldesc.AutoSize = true;
            this.labeldesc.Location = new System.Drawing.Point(326, 66);
            this.labeldesc.Name = "labeldesc";
            this.labeldesc.Size = new System.Drawing.Size(77, 12);
            this.labeldesc.TabIndex = 4;
            this.labeldesc.Text = "详细信息标签";
            // 
            // ButtonInstall
            // 
            this.ButtonInstall.Location = new System.Drawing.Point(355, 261);
            this.ButtonInstall.Name = "ButtonInstall";
            this.ButtonInstall.Size = new System.Drawing.Size(82, 31);
            this.ButtonInstall.TabIndex = 5;
            this.ButtonInstall.Text = "安装新竞赛";
            this.ButtonInstall.UseVisualStyleBackColor = true;
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(443, 261);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(82, 31);
            this.ButtonLoad.TabIndex = 6;
            this.ButtonLoad.Text = "载入";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 297);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.ButtonInstall);
            this.Controls.Add(this.labeldesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelTestCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "Vanilla - 本地竞赛评测姬";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelTestCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeldesc;
        private System.Windows.Forms.Button ButtonInstall;
        private System.Windows.Forms.Button ButtonLoad;

    }
}

