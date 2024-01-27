namespace uMap2Bitmap.Forms
{
    partial class frmStart
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            lblLoading = new Label();
            tmrLoading = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(74, 31);
            label1.TabIndex = 0;
            label1.Text = "uMap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(71, 3);
            label2.Name = "label2";
            label2.Size = new Size(26, 31);
            label2.TabIndex = 0;
            label2.Text = "2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F);
            label3.Location = new Point(91, 3);
            label3.Name = "label3";
            label3.Size = new Size(87, 31);
            label3.TabIndex = 0;
            label3.Text = "Bitmap";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 10F);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(3, 25);
            label4.Name = "label4";
            label4.Size = new Size(175, 14);
            label4.TabIndex = 0;
            label4.Text = "_____________________";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(8, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 42);
            panel1.TabIndex = 1;
            // 
            // lblLoading
            // 
            lblLoading.Location = new Point(8, 52);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(181, 20);
            lblLoading.TabIndex = 2;
            lblLoading.Text = "l o a d i n g";
            lblLoading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmrLoading
            // 
            tmrLoading.Tick += tmrLoading_Tick;
            // 
            // frmStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(197, 81);
            ControlBox = false;
            Controls.Add(lblLoading);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStart";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            Load += frmStart_Load;
            Shown += frmStart_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label lblLoading;
        private System.Windows.Forms.Timer tmrLoading;
    }
}