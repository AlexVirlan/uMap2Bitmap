namespace uMap2Bitmap.Forms
{
    partial class frmAddTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTag));
            btnCancel = new Button();
            btnAdd = new Button();
            txtTagName = new TextBox();
            txtTagValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblAddDynamicValue = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            toolTips = new ToolTip(components);
            cmsDynamicValues = new ContextMenuStrip(components);
            dateTimeToolStripMenuItem = new ToolStripMenuItem();
            dateToolStripMenuItem = new ToolStripMenuItem();
            timeToolStripMenuItem = new ToolStripMenuItem();
            datetimeToolStripMenuItem1 = new ToolStripMenuItem();
            randomToolStripMenuItem = new ToolStripMenuItem();
            gUIDToolStripMenuItem = new ToolStripMenuItem();
            to10ToolStripMenuItem = new ToolStripMenuItem();
            to100ToolStripMenuItem = new ToolStripMenuItem();
            customIntegersToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            moreInfoToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            cmsDynamicValues.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(17, 17, 17);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 126, 126);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(12, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(64, 26);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(17, 17, 17);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 126, 126);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(148, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(64, 26);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTagName
            // 
            txtTagName.BackColor = Color.FromArgb(17, 17, 17);
            txtTagName.BorderStyle = BorderStyle.FixedSingle;
            txtTagName.ForeColor = Color.White;
            txtTagName.Location = new Point(12, 29);
            txtTagName.MaxLength = 50;
            txtTagName.Name = "txtTagName";
            txtTagName.Size = new Size(200, 23);
            txtTagName.TabIndex = 12;
            txtTagName.TextAlign = HorizontalAlignment.Center;
            toolTips.SetToolTip(txtTagName, resources.GetString("txtTagName.ToolTip"));
            // 
            // txtTagValue
            // 
            txtTagValue.BackColor = Color.FromArgb(17, 17, 17);
            txtTagValue.BorderStyle = BorderStyle.FixedSingle;
            txtTagValue.ForeColor = Color.White;
            txtTagValue.Location = new Point(12, 92);
            txtTagValue.MaxLength = 100;
            txtTagValue.Name = "txtTagValue";
            txtTagValue.Size = new Size(200, 23);
            txtTagValue.TabIndex = 12;
            txtTagValue.TextAlign = HorizontalAlignment.Center;
            toolTips.SetToolTip(txtTagValue, "This field is required. Its value will be trimmed.\r\n(the whitespaces from both ends of the text will be removed).\r\n\r\nDynamic values care case-insensitive.");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 13;
            label1.Text = "Tag name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 13;
            label2.Text = "Tag value:";
            // 
            // lblAddDynamicValue
            // 
            lblAddDynamicValue.AutoSize = true;
            lblAddDynamicValue.Cursor = Cursors.Hand;
            lblAddDynamicValue.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblAddDynamicValue.Location = new Point(103, 74);
            lblAddDynamicValue.Name = "lblAddDynamicValue";
            lblAddDynamicValue.Size = new Size(109, 15);
            lblAddDynamicValue.TabIndex = 13;
            lblAddDynamicValue.Text = "Add dynamic value";
            lblAddDynamicValue.Click += lblAddDynamicValue_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtTagName);
            panel1.Controls.Add(lblAddDynamicValue);
            panel1.Controls.Add(txtTagValue);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 130);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnAdd);
            panel2.Location = new Point(12, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 42);
            panel2.TabIndex = 15;
            // 
            // toolTips
            // 
            toolTips.AutomaticDelay = 26;
            toolTips.AutoPopDelay = 12000;
            toolTips.InitialDelay = 260;
            toolTips.ReshowDelay = 100;
            toolTips.ToolTipIcon = ToolTipIcon.Info;
            toolTips.ToolTipTitle = "Info";
            // 
            // cmsDynamicValues
            // 
            cmsDynamicValues.Items.AddRange(new ToolStripItem[] { dateTimeToolStripMenuItem, randomToolStripMenuItem, toolStripSeparator2, moreInfoToolStripMenuItem });
            cmsDynamicValues.Name = "cmsDynamicValues";
            cmsDynamicValues.Size = new Size(139, 76);
            // 
            // dateTimeToolStripMenuItem
            // 
            dateTimeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dateToolStripMenuItem, timeToolStripMenuItem, datetimeToolStripMenuItem1 });
            dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            dateTimeToolStripMenuItem.Size = new Size(138, 22);
            dateTimeToolStripMenuItem.Text = "Date && time";
            // 
            // dateToolStripMenuItem
            // 
            dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            dateToolStripMenuItem.Size = new Size(127, 22);
            dateToolStripMenuItem.Tag = "{{date}}";
            dateToolStripMenuItem.Text = "Date";
            dateToolStripMenuItem.Click += MenuAddDynamicValue;
            // 
            // timeToolStripMenuItem
            // 
            timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            timeToolStripMenuItem.Size = new Size(127, 22);
            timeToolStripMenuItem.Tag = "{{time}}";
            timeToolStripMenuItem.Text = "Time";
            timeToolStripMenuItem.Click += MenuAddDynamicValue;
            // 
            // datetimeToolStripMenuItem1
            // 
            datetimeToolStripMenuItem1.Name = "datetimeToolStripMenuItem1";
            datetimeToolStripMenuItem1.Size = new Size(127, 22);
            datetimeToolStripMenuItem1.Tag = "{{dateTime}}";
            datetimeToolStripMenuItem1.Text = "Date-time";
            datetimeToolStripMenuItem1.Click += MenuAddDynamicValue;
            // 
            // randomToolStripMenuItem
            // 
            randomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gUIDToolStripMenuItem, to10ToolStripMenuItem, to100ToolStripMenuItem, customIntegersToolStripMenuItem });
            randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            randomToolStripMenuItem.Size = new Size(138, 22);
            randomToolStripMenuItem.Text = "Random";
            // 
            // gUIDToolStripMenuItem
            // 
            gUIDToolStripMenuItem.Name = "gUIDToolStripMenuItem";
            gUIDToolStripMenuItem.Size = new Size(161, 22);
            gUIDToolStripMenuItem.Tag = "{{guid}}";
            gUIDToolStripMenuItem.Text = "GUID";
            gUIDToolStripMenuItem.Click += MenuAddDynamicValue;
            // 
            // to10ToolStripMenuItem
            // 
            to10ToolStripMenuItem.Name = "to10ToolStripMenuItem";
            to10ToolStripMenuItem.Size = new Size(161, 22);
            to10ToolStripMenuItem.Tag = "{{rnd:0-10}}";
            to10ToolStripMenuItem.Text = "0 to 10";
            to10ToolStripMenuItem.Click += MenuAddDynamicValue;
            // 
            // to100ToolStripMenuItem
            // 
            to100ToolStripMenuItem.Name = "to100ToolStripMenuItem";
            to100ToolStripMenuItem.Size = new Size(161, 22);
            to100ToolStripMenuItem.Tag = "{{rnd:0-100}}";
            to100ToolStripMenuItem.Text = "0 to 100";
            to100ToolStripMenuItem.Click += MenuAddDynamicValue;
            // 
            // customIntegersToolStripMenuItem
            // 
            customIntegersToolStripMenuItem.Name = "customIntegersToolStripMenuItem";
            customIntegersToolStripMenuItem.Size = new Size(161, 22);
            customIntegersToolStripMenuItem.Tag = "{{rnd:X-Y}}";
            customIntegersToolStripMenuItem.Text = "Custom integers";
            customIntegersToolStripMenuItem.Click += MenuAddDynamicValue;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(135, 6);
            // 
            // moreInfoToolStripMenuItem
            // 
            moreInfoToolStripMenuItem.Name = "moreInfoToolStripMenuItem";
            moreInfoToolStripMenuItem.Size = new Size(138, 22);
            moreInfoToolStripMenuItem.Text = "More info";
            moreInfoToolStripMenuItem.Click += moreInfoToolStripMenuItem_Click;
            // 
            // frmAddTag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(252, 214);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddTag";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "uMap2Bitmap - Add global tag";
            Load += frmAddTag_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            cmsDynamicValues.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private TextBox txtTagName;
        private TextBox txtTagValue;
        private Label label1;
        private Label label2;
        private Label lblAddDynamicValue;
        private Panel panel1;
        private Panel panel2;
        private ToolTip toolTips;
        private ContextMenuStrip cmsDynamicValues;
        private ToolStripMenuItem dateTimeToolStripMenuItem;
        private ToolStripMenuItem dateToolStripMenuItem;
        private ToolStripMenuItem timeToolStripMenuItem;
        private ToolStripMenuItem datetimeToolStripMenuItem1;
        private ToolStripMenuItem randomToolStripMenuItem;
        private ToolStripMenuItem gUIDToolStripMenuItem;
        private ToolStripMenuItem to10ToolStripMenuItem;
        private ToolStripMenuItem to100ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem moreInfoToolStripMenuItem;
        private ToolStripMenuItem customIntegersToolStripMenuItem;
    }
}