namespace uMap2Bitmap.Forms
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            pnlMain = new Panel();
            pnlTags = new Panel();
            pnlGlobalTags = new Panel();
            dgvGlobalTags = new DataGridView();
            TagName = new DataGridViewTextBoxColumn();
            TagValue = new DataGridViewTextBoxColumn();
            chkRemoveUnusedTags = new CheckBox();
            btnDeleteAllGlobalTags = new Button();
            btnDeleteGlobalTag = new Button();
            btnAddGlobalTag = new Button();
            chkIgnoreTagCase = new CheckBox();
            lblGlobalTagsInfo = new Label();
            label21 = new Label();
            pnlExport = new Panel();
            btnRUN = new Button();
            pnlTemplates = new Panel();
            cmbTemplates = new ComboBox();
            cmbTextEditors = new ComboBox();
            btnOpenTemplate = new Button();
            label24 = new Label();
            lblTemplatesTitle = new Label();
            lblOpenTemplatesDir = new Label();
            pnlUMapProperties = new Panel();
            lblUMapZoomMax = new Label();
            lblUMapZoomMin = new Label();
            label18 = new Label();
            label11 = new Label();
            lblUMapTileLayerUrl = new Label();
            lblUMapTileLayerName = new Label();
            label12 = new Label();
            lblUMapDescription = new Label();
            label10 = new Label();
            lblUMapName = new Label();
            label4 = new Label();
            label2 = new Label();
            pnlMapSettings = new Panel();
            lblMapSizeCustomPropertyValue = new Label();
            lblGetCurrentMapWindowSize = new Label();
            chkBorderlessMapWindow = new CheckBox();
            lblMapDefaultBackgroundColor = new Label();
            txtMapSizeCustomProperty = new TextBox();
            numMapHeight = new NumericUpDown();
            numMapWidth = new NumericUpDown();
            label17 = new Label();
            label16 = new Label();
            label19 = new Label();
            lblMapWinowSize = new Label();
            chkMapSizeCustomPropertyIgnoreCase = new CheckBox();
            chkMapSizeCustomProperty = new CheckBox();
            label9 = new Label();
            lblTagsInfo = new Label();
            label20 = new Label();
            lblTemplatesInfo = new Label();
            label1 = new Label();
            label14 = new Label();
            lblStatistics = new Label();
            label15 = new Label();
            btnUncheckAll = new Button();
            label13 = new Label();
            btnCheckAll = new Button();
            lblPropertiesNote = new Label();
            btnCollapseAll = new Button();
            lblPropertiesInfo = new Label();
            btnExpandAll = new Button();
            pnlPolygonProperties = new Panel();
            dgvProperties = new DataGridView();
            PropertyName = new DataGridViewTextBoxColumn();
            PropertyValue = new DataGridViewTextBoxColumn();
            pnlLayerProperties = new Panel();
            lblPolyColor = new Controls.CustomLabel();
            lblPolyFillOpacity = new Controls.CustomLabel();
            txtPolyDescription = new TextBox();
            label6 = new Label();
            lblPolyFillColor = new Controls.CustomLabel();
            label8 = new Label();
            label3 = new Label();
            label7 = new Label();
            lblPolyFill = new Controls.CustomLabel();
            label5 = new Label();
            treeView = new Controls.CustomTreeView();
            btnMODEL = new Button();
            toolTips = new ToolTip(components);
            fswTemplates = new FileSystemWatcher();
            pnlDragDrop = new Panel();
            pnlAppSettings = new Panel();
            colorDialog = new ColorDialog();
            label22 = new Label();
            pnlMain.SuspendLayout();
            pnlTags.SuspendLayout();
            pnlGlobalTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGlobalTags).BeginInit();
            pnlExport.SuspendLayout();
            pnlTemplates.SuspendLayout();
            pnlUMapProperties.SuspendLayout();
            pnlMapSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMapHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMapWidth).BeginInit();
            pnlPolygonProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            pnlLayerProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fswTemplates).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlTags);
            pnlMain.Controls.Add(pnlExport);
            pnlMain.Controls.Add(pnlTemplates);
            pnlMain.Controls.Add(pnlUMapProperties);
            pnlMain.Controls.Add(pnlMapSettings);
            pnlMain.Controls.Add(label9);
            pnlMain.Controls.Add(lblTagsInfo);
            pnlMain.Controls.Add(label20);
            pnlMain.Controls.Add(lblTemplatesInfo);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(label14);
            pnlMain.Controls.Add(lblStatistics);
            pnlMain.Controls.Add(label15);
            pnlMain.Controls.Add(btnUncheckAll);
            pnlMain.Controls.Add(label13);
            pnlMain.Controls.Add(btnCheckAll);
            pnlMain.Controls.Add(lblPropertiesNote);
            pnlMain.Controls.Add(btnCollapseAll);
            pnlMain.Controls.Add(lblPropertiesInfo);
            pnlMain.Controls.Add(btnExpandAll);
            pnlMain.Controls.Add(pnlPolygonProperties);
            pnlMain.Controls.Add(pnlLayerProperties);
            pnlMain.Controls.Add(treeView);
            pnlMain.Location = new Point(5, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(921, 760);
            pnlMain.TabIndex = 0;
            pnlMain.Visible = false;
            // 
            // pnlTags
            // 
            pnlTags.BorderStyle = BorderStyle.FixedSingle;
            pnlTags.Controls.Add(pnlGlobalTags);
            pnlTags.Controls.Add(chkRemoveUnusedTags);
            pnlTags.Controls.Add(btnDeleteAllGlobalTags);
            pnlTags.Controls.Add(btnDeleteGlobalTag);
            pnlTags.Controls.Add(btnAddGlobalTag);
            pnlTags.Controls.Add(chkIgnoreTagCase);
            pnlTags.Controls.Add(lblGlobalTagsInfo);
            pnlTags.Controls.Add(label22);
            pnlTags.Controls.Add(label21);
            pnlTags.Location = new Point(403, 514);
            pnlTags.Name = "pnlTags";
            pnlTags.Size = new Size(511, 177);
            pnlTags.TabIndex = 15;
            // 
            // pnlGlobalTags
            // 
            pnlGlobalTags.BorderStyle = BorderStyle.FixedSingle;
            pnlGlobalTags.Controls.Add(dgvGlobalTags);
            pnlGlobalTags.Location = new Point(10, 53);
            pnlGlobalTags.Name = "pnlGlobalTags";
            pnlGlobalTags.Size = new Size(417, 111);
            pnlGlobalTags.TabIndex = 7;
            // 
            // dgvGlobalTags
            // 
            dgvGlobalTags.AllowUserToAddRows = false;
            dgvGlobalTags.AllowUserToDeleteRows = false;
            dgvGlobalTags.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            dgvGlobalTags.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dgvGlobalTags.BackgroundColor = Color.FromArgb(17, 17, 17);
            dgvGlobalTags.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvGlobalTags.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvGlobalTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGlobalTags.Columns.AddRange(new DataGridViewColumn[] { TagName, TagValue });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dgvGlobalTags.DefaultCellStyle = dataGridViewCellStyle15;
            dgvGlobalTags.Dock = DockStyle.Fill;
            dgvGlobalTags.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvGlobalTags.EnableHeadersVisualStyles = false;
            dgvGlobalTags.Location = new Point(0, 0);
            dgvGlobalTags.MultiSelect = false;
            dgvGlobalTags.Name = "dgvGlobalTags";
            dgvGlobalTags.ReadOnly = true;
            dgvGlobalTags.RowHeadersVisible = false;
            dgvGlobalTags.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGlobalTags.Size = new Size(415, 109);
            dgvGlobalTags.TabIndex = 5;
            dgvGlobalTags.CellDoubleClick += dgvGlobalTags_CellDoubleClick;
            // 
            // TagName
            // 
            TagName.HeaderText = "Tag name";
            TagName.Name = "TagName";
            TagName.ReadOnly = true;
            TagName.Width = 170;
            // 
            // TagValue
            // 
            TagValue.HeaderText = "Tag value";
            TagValue.Name = "TagValue";
            TagValue.ReadOnly = true;
            TagValue.Width = 217;
            // 
            // chkRemoveUnusedTags
            // 
            chkRemoveUnusedTags.AutoSize = true;
            chkRemoveUnusedTags.Location = new Point(187, 7);
            chkRemoveUnusedTags.Name = "chkRemoveUnusedTags";
            chkRemoveUnusedTags.Size = new Size(201, 19);
            chkRemoveUnusedTags.TabIndex = 1;
            chkRemoveUnusedTags.Text = "Remove unused/unavailable tags";
            toolTips.SetToolTip(chkRemoveUnusedTags, resources.GetString("chkRemoveUnusedTags.ToolTip"));
            chkRemoveUnusedTags.UseVisualStyleBackColor = true;
            chkRemoveUnusedTags.CheckedChanged += TagsSettingsChanged;
            // 
            // btnDeleteAllGlobalTags
            // 
            btnDeleteAllGlobalTags.BackColor = Color.FromArgb(17, 17, 17);
            btnDeleteAllGlobalTags.Cursor = Cursors.Hand;
            btnDeleteAllGlobalTags.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnDeleteAllGlobalTags.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 126, 126);
            btnDeleteAllGlobalTags.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnDeleteAllGlobalTags.FlatStyle = FlatStyle.Flat;
            btnDeleteAllGlobalTags.Location = new Point(433, 138);
            btnDeleteAllGlobalTags.Name = "btnDeleteAllGlobalTags";
            btnDeleteAllGlobalTags.Size = new Size(66, 26);
            btnDeleteAllGlobalTags.TabIndex = 1;
            btnDeleteAllGlobalTags.Text = "Delete all";
            btnDeleteAllGlobalTags.UseVisualStyleBackColor = false;
            btnDeleteAllGlobalTags.Click += btnDeleteAllGlobalTags_Click;
            // 
            // btnDeleteGlobalTag
            // 
            btnDeleteGlobalTag.BackColor = Color.FromArgb(17, 17, 17);
            btnDeleteGlobalTag.Cursor = Cursors.Hand;
            btnDeleteGlobalTag.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnDeleteGlobalTag.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 126, 126);
            btnDeleteGlobalTag.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnDeleteGlobalTag.FlatStyle = FlatStyle.Flat;
            btnDeleteGlobalTag.Location = new Point(433, 95);
            btnDeleteGlobalTag.Name = "btnDeleteGlobalTag";
            btnDeleteGlobalTag.Size = new Size(66, 26);
            btnDeleteGlobalTag.TabIndex = 1;
            btnDeleteGlobalTag.Text = "Delete";
            btnDeleteGlobalTag.UseVisualStyleBackColor = false;
            btnDeleteGlobalTag.Click += btnDeleteGlobalTag_Click;
            // 
            // btnAddGlobalTag
            // 
            btnAddGlobalTag.BackColor = Color.FromArgb(17, 17, 17);
            btnAddGlobalTag.Cursor = Cursors.Hand;
            btnAddGlobalTag.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnAddGlobalTag.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 126, 126);
            btnAddGlobalTag.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAddGlobalTag.FlatStyle = FlatStyle.Flat;
            btnAddGlobalTag.Location = new Point(433, 53);
            btnAddGlobalTag.Name = "btnAddGlobalTag";
            btnAddGlobalTag.Size = new Size(66, 26);
            btnAddGlobalTag.TabIndex = 1;
            btnAddGlobalTag.Text = "Add";
            btnAddGlobalTag.UseVisualStyleBackColor = false;
            btnAddGlobalTag.Click += btnAddGlobalTag_Click;
            // 
            // chkIgnoreTagCase
            // 
            chkIgnoreTagCase.AutoSize = true;
            chkIgnoreTagCase.Location = new Point(10, 7);
            chkIgnoreTagCase.Name = "chkIgnoreTagCase";
            chkIgnoreTagCase.Size = new Size(157, 19);
            chkIgnoreTagCase.TabIndex = 1;
            chkIgnoreTagCase.Text = "Ignore cases (for all tags)";
            toolTips.SetToolTip(chkIgnoreTagCase, "Self-explanatory, determines if tags \r\nare treated as case insensitive.\r\nEg.: {{myTag}} will be the same as \r\n{{mytag}} or {{MYTAG}}, etc.");
            chkIgnoreTagCase.UseVisualStyleBackColor = true;
            chkIgnoreTagCase.CheckedChanged += TagsSettingsChanged;
            // 
            // lblGlobalTagsInfo
            // 
            lblGlobalTagsInfo.AutoSize = true;
            lblGlobalTagsInfo.Cursor = Cursors.Hand;
            lblGlobalTagsInfo.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblGlobalTagsInfo.Location = new Point(125, 35);
            lblGlobalTagsInfo.Name = "lblGlobalTagsInfo";
            lblGlobalTagsInfo.Size = new Size(28, 15);
            lblGlobalTagsInfo.TabIndex = 10;
            lblGlobalTagsInfo.Text = "Info";
            lblGlobalTagsInfo.Click += lblGlobalTagsInfo_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(7, 35);
            label21.Name = "label21";
            label21.Size = new Size(112, 15);
            label21.TabIndex = 8;
            label21.Text = "Global custom tags:";
            // 
            // pnlExport
            // 
            pnlExport.BorderStyle = BorderStyle.FixedSingle;
            pnlExport.Controls.Add(btnRUN);
            pnlExport.Location = new Point(8, 708);
            pnlExport.Name = "pnlExport";
            pnlExport.Size = new Size(906, 45);
            pnlExport.TabIndex = 16;
            // 
            // btnRUN
            // 
            btnRUN.BackColor = Color.FromArgb(17, 17, 17);
            btnRUN.Cursor = Cursors.Hand;
            btnRUN.Enabled = false;
            btnRUN.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnRUN.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 126, 126);
            btnRUN.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnRUN.FlatStyle = FlatStyle.Flat;
            btnRUN.Location = new Point(828, 10);
            btnRUN.Name = "btnRUN";
            btnRUN.Size = new Size(66, 23);
            btnRUN.TabIndex = 1;
            btnRUN.Text = "R U N";
            toolTips.SetToolTip(btnRUN, "Process all the selected polygons \r\nand transform them into bitmaps (images).");
            btnRUN.UseVisualStyleBackColor = false;
            btnRUN.Click += btnRUN_Click;
            // 
            // pnlTemplates
            // 
            pnlTemplates.BorderStyle = BorderStyle.FixedSingle;
            pnlTemplates.Controls.Add(cmbTemplates);
            pnlTemplates.Controls.Add(cmbTextEditors);
            pnlTemplates.Controls.Add(btnOpenTemplate);
            pnlTemplates.Controls.Add(label24);
            pnlTemplates.Controls.Add(lblTemplatesTitle);
            pnlTemplates.Controls.Add(lblOpenTemplatesDir);
            pnlTemplates.Location = new Point(403, 256);
            pnlTemplates.Name = "pnlTemplates";
            pnlTemplates.Size = new Size(511, 57);
            pnlTemplates.TabIndex = 13;
            // 
            // cmbTemplates
            // 
            cmbTemplates.BackColor = Color.FromArgb(17, 17, 17);
            cmbTemplates.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTemplates.ForeColor = Color.White;
            cmbTemplates.FormattingEnabled = true;
            cmbTemplates.Location = new Point(7, 22);
            cmbTemplates.Name = "cmbTemplates";
            cmbTemplates.Size = new Size(285, 23);
            cmbTemplates.TabIndex = 9;
            cmbTemplates.SelectedIndexChanged += cmbTemplates_SelectedIndexChanged;
            // 
            // cmbTextEditors
            // 
            cmbTextEditors.BackColor = Color.FromArgb(17, 17, 17);
            cmbTextEditors.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTextEditors.ForeColor = Color.White;
            cmbTextEditors.FormattingEnabled = true;
            cmbTextEditors.Location = new Point(300, 22);
            cmbTextEditors.Name = "cmbTextEditors";
            cmbTextEditors.Size = new Size(141, 23);
            cmbTextEditors.TabIndex = 9;
            toolTips.SetToolTip(cmbTextEditors, "Supported text editors:\r\n- Visual Studio Code\r\n- Sublime Text\r\n- Notepad++\r\n- Atom\r\n- Microsoft Notepad");
            // 
            // btnOpenTemplate
            // 
            btnOpenTemplate.BackColor = Color.FromArgb(17, 17, 17);
            btnOpenTemplate.Cursor = Cursors.Hand;
            btnOpenTemplate.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnOpenTemplate.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 126, 126);
            btnOpenTemplate.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnOpenTemplate.FlatStyle = FlatStyle.Flat;
            btnOpenTemplate.Location = new Point(447, 21);
            btnOpenTemplate.Name = "btnOpenTemplate";
            btnOpenTemplate.Size = new Size(52, 26);
            btnOpenTemplate.TabIndex = 1;
            btnOpenTemplate.Text = "Open";
            btnOpenTemplate.UseVisualStyleBackColor = false;
            btnOpenTemplate.Click += btnOpenTemplate_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(297, 4);
            label24.Name = "label24";
            label24.Size = new Size(141, 15);
            label24.TabIndex = 10;
            label24.Text = "Open the template file in:";
            // 
            // lblTemplatesTitle
            // 
            lblTemplatesTitle.AutoSize = true;
            lblTemplatesTitle.Location = new Point(4, 4);
            lblTemplatesTitle.Name = "lblTemplatesTitle";
            lblTemplatesTitle.Size = new Size(86, 15);
            lblTemplatesTitle.TabIndex = 10;
            lblTemplatesTitle.Text = "Templates (00):";
            // 
            // lblOpenTemplatesDir
            // 
            lblOpenTemplatesDir.AutoSize = true;
            lblOpenTemplatesDir.Cursor = Cursors.Hand;
            lblOpenTemplatesDir.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblOpenTemplatesDir.Location = new Point(134, 4);
            lblOpenTemplatesDir.Name = "lblOpenTemplatesDir";
            lblOpenTemplatesDir.Size = new Size(161, 15);
            lblOpenTemplatesDir.TabIndex = 10;
            lblOpenTemplatesDir.Text = "Open the templates directory";
            lblOpenTemplatesDir.Click += lblOpenTemplatesDir_Click;
            // 
            // pnlUMapProperties
            // 
            pnlUMapProperties.BorderStyle = BorderStyle.FixedSingle;
            pnlUMapProperties.Controls.Add(lblUMapZoomMax);
            pnlUMapProperties.Controls.Add(lblUMapZoomMin);
            pnlUMapProperties.Controls.Add(label18);
            pnlUMapProperties.Controls.Add(label11);
            pnlUMapProperties.Controls.Add(lblUMapTileLayerUrl);
            pnlUMapProperties.Controls.Add(lblUMapTileLayerName);
            pnlUMapProperties.Controls.Add(label12);
            pnlUMapProperties.Controls.Add(lblUMapDescription);
            pnlUMapProperties.Controls.Add(label10);
            pnlUMapProperties.Controls.Add(lblUMapName);
            pnlUMapProperties.Controls.Add(label4);
            pnlUMapProperties.Controls.Add(label2);
            pnlUMapProperties.Location = new Point(8, 514);
            pnlUMapProperties.Name = "pnlUMapProperties";
            pnlUMapProperties.Size = new Size(378, 177);
            pnlUMapProperties.TabIndex = 12;
            // 
            // lblUMapZoomMax
            // 
            lblUMapZoomMax.AutoSize = true;
            lblUMapZoomMax.Cursor = Cursors.Hand;
            lblUMapZoomMax.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUMapZoomMax.Location = new Point(77, 155);
            lblUMapZoomMax.Name = "lblUMapZoomMax";
            lblUMapZoomMax.Size = new Size(12, 15);
            lblUMapZoomMax.TabIndex = 0;
            lblUMapZoomMax.Tag = "{{mapZoomMax}}";
            lblUMapZoomMax.Text = "-";
            toolTips.SetToolTip(lblUMapZoomMax, "Click to copy as a tag. \r\nCTRL + click to copy the value.");
            lblUMapZoomMax.Click += UMapPropertiesLabelsCopyTag;
            // 
            // lblUMapZoomMin
            // 
            lblUMapZoomMin.AutoSize = true;
            lblUMapZoomMin.Cursor = Cursors.Hand;
            lblUMapZoomMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUMapZoomMin.Location = new Point(77, 125);
            lblUMapZoomMin.Name = "lblUMapZoomMin";
            lblUMapZoomMin.Size = new Size(12, 15);
            lblUMapZoomMin.TabIndex = 0;
            lblUMapZoomMin.Tag = "{{mapZoomMin}}";
            lblUMapZoomMin.Text = "-";
            toolTips.SetToolTip(lblUMapZoomMin, "Click to copy as a tag. \r\nCTRL + click to copy the value.");
            lblUMapZoomMin.Click += UMapPropertiesLabelsCopyTag;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 155);
            label18.Name = "label18";
            label18.Size = new Size(69, 15);
            label18.TabIndex = 0;
            label18.Text = "Max. zoom:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 125);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 0;
            label11.Text = "Min. zoom:";
            // 
            // lblUMapTileLayerUrl
            // 
            lblUMapTileLayerUrl.AutoSize = true;
            lblUMapTileLayerUrl.Cursor = Cursors.Hand;
            lblUMapTileLayerUrl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUMapTileLayerUrl.Location = new Point(77, 95);
            lblUMapTileLayerUrl.Name = "lblUMapTileLayerUrl";
            lblUMapTileLayerUrl.Size = new Size(12, 15);
            lblUMapTileLayerUrl.TabIndex = 0;
            lblUMapTileLayerUrl.Tag = "{{mapTileLayerUrl}}";
            lblUMapTileLayerUrl.Text = "-";
            toolTips.SetToolTip(lblUMapTileLayerUrl, "Click to copy as a tag. \r\nCTRL + click to copy the value.");
            lblUMapTileLayerUrl.Click += UMapPropertiesLabelsCopyTag;
            // 
            // lblUMapTileLayerName
            // 
            lblUMapTileLayerName.AutoSize = true;
            lblUMapTileLayerName.Cursor = Cursors.Hand;
            lblUMapTileLayerName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUMapTileLayerName.Location = new Point(77, 65);
            lblUMapTileLayerName.Name = "lblUMapTileLayerName";
            lblUMapTileLayerName.Size = new Size(12, 15);
            lblUMapTileLayerName.TabIndex = 0;
            lblUMapTileLayerName.Tag = "{{mapTileLayer}}";
            lblUMapTileLayerName.Text = "-";
            toolTips.SetToolTip(lblUMapTileLayerName, "Click to copy as a tag. \r\nCTRL + click to copy the value.");
            lblUMapTileLayerName.Click += UMapPropertiesLabelsCopyTag;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 95);
            label12.Name = "label12";
            label12.Size = new Size(56, 15);
            label12.TabIndex = 0;
            label12.Text = "Tile layer:";
            // 
            // lblUMapDescription
            // 
            lblUMapDescription.AutoSize = true;
            lblUMapDescription.Cursor = Cursors.Hand;
            lblUMapDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUMapDescription.Location = new Point(77, 35);
            lblUMapDescription.Name = "lblUMapDescription";
            lblUMapDescription.Size = new Size(12, 15);
            lblUMapDescription.TabIndex = 0;
            lblUMapDescription.Tag = "{{mapDescription}}";
            lblUMapDescription.Text = "-";
            toolTips.SetToolTip(lblUMapDescription, "Click to copy as a tag. \r\nCTRL + click to copy the value.");
            lblUMapDescription.Click += UMapPropertiesLabelsCopyTag;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 65);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 0;
            label10.Text = "Tile layer:";
            // 
            // lblUMapName
            // 
            lblUMapName.AutoSize = true;
            lblUMapName.Cursor = Cursors.Hand;
            lblUMapName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUMapName.Location = new Point(77, 5);
            lblUMapName.Name = "lblUMapName";
            lblUMapName.Size = new Size(12, 15);
            lblUMapName.TabIndex = 0;
            lblUMapName.Tag = "{{mapName}}";
            lblUMapName.Text = "-";
            toolTips.SetToolTip(lblUMapName, "Click to copy as a tag. \r\nCTRL + click to copy the value.");
            lblUMapName.Click += UMapPropertiesLabelsCopyTag;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 35);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 0;
            label4.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 5);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // pnlMapSettings
            // 
            pnlMapSettings.BorderStyle = BorderStyle.FixedSingle;
            pnlMapSettings.Controls.Add(lblMapSizeCustomPropertyValue);
            pnlMapSettings.Controls.Add(lblGetCurrentMapWindowSize);
            pnlMapSettings.Controls.Add(chkBorderlessMapWindow);
            pnlMapSettings.Controls.Add(lblMapDefaultBackgroundColor);
            pnlMapSettings.Controls.Add(txtMapSizeCustomProperty);
            pnlMapSettings.Controls.Add(numMapHeight);
            pnlMapSettings.Controls.Add(numMapWidth);
            pnlMapSettings.Controls.Add(label17);
            pnlMapSettings.Controls.Add(label16);
            pnlMapSettings.Controls.Add(label19);
            pnlMapSettings.Controls.Add(lblMapWinowSize);
            pnlMapSettings.Controls.Add(chkMapSizeCustomPropertyIgnoreCase);
            pnlMapSettings.Controls.Add(chkMapSizeCustomProperty);
            pnlMapSettings.Location = new Point(403, 343);
            pnlMapSettings.Name = "pnlMapSettings";
            pnlMapSettings.Size = new Size(511, 141);
            pnlMapSettings.TabIndex = 13;
            // 
            // lblMapSizeCustomPropertyValue
            // 
            lblMapSizeCustomPropertyValue.AutoSize = true;
            lblMapSizeCustomPropertyValue.Location = new Point(196, 111);
            lblMapSizeCustomPropertyValue.Name = "lblMapSizeCustomPropertyValue";
            lblMapSizeCustomPropertyValue.Size = new Size(0, 15);
            lblMapSizeCustomPropertyValue.TabIndex = 16;
            // 
            // lblGetCurrentMapWindowSize
            // 
            lblGetCurrentMapWindowSize.AutoSize = true;
            lblGetCurrentMapWindowSize.Cursor = Cursors.Hand;
            lblGetCurrentMapWindowSize.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblGetCurrentMapWindowSize.Location = new Point(107, 7);
            lblGetCurrentMapWindowSize.Name = "lblGetCurrentMapWindowSize";
            lblGetCurrentMapWindowSize.Size = new Size(88, 15);
            lblGetCurrentMapWindowSize.TabIndex = 15;
            lblGetCurrentMapWindowSize.Text = "Get current size";
            toolTips.SetToolTip(lblGetCurrentMapWindowSize, "Gets the current map window size \r\nand sets it in the below boxes.\r\n\r\nSince you can manually adjust the \r\nmap windows size - it helps sometimes \r\nso you won't have to manually set it.");
            lblGetCurrentMapWindowSize.Click += lblGetCurrentMapWindowSize_Click;
            // 
            // chkBorderlessMapWindow
            // 
            chkBorderlessMapWindow.AutoSize = true;
            chkBorderlessMapWindow.Location = new Point(225, 57);
            chkBorderlessMapWindow.Name = "chkBorderlessMapWindow";
            chkBorderlessMapWindow.Size = new Size(125, 19);
            chkBorderlessMapWindow.TabIndex = 14;
            chkBorderlessMapWindow.Text = "Borderless window";
            toolTips.SetToolTip(chkBorderlessMapWindow, resources.GetString("chkBorderlessMapWindow.ToolTip"));
            chkBorderlessMapWindow.UseVisualStyleBackColor = true;
            chkBorderlessMapWindow.CheckedChanged += chkBorderlessMapWindow_CheckedChanged;
            // 
            // lblMapDefaultBackgroundColor
            // 
            lblMapDefaultBackgroundColor.BorderStyle = BorderStyle.FixedSingle;
            lblMapDefaultBackgroundColor.Cursor = Cursors.Hand;
            lblMapDefaultBackgroundColor.Location = new Point(225, 28);
            lblMapDefaultBackgroundColor.Name = "lblMapDefaultBackgroundColor";
            lblMapDefaultBackgroundColor.Size = new Size(138, 23);
            lblMapDefaultBackgroundColor.TabIndex = 13;
            lblMapDefaultBackgroundColor.Text = "RGB(26,26,26)";
            lblMapDefaultBackgroundColor.TextAlign = ContentAlignment.MiddleCenter;
            toolTips.SetToolTip(lblMapDefaultBackgroundColor, "Left click to choose a new color.\r\nRight click to copy the HEX value. \r\nCTRL + right click to copy the RGB value.");
            lblMapDefaultBackgroundColor.MouseClick += lblMapDefaultBackgroundColor_MouseClick;
            // 
            // txtMapSizeCustomProperty
            // 
            txtMapSizeCustomProperty.BackColor = Color.FromArgb(17, 17, 17);
            txtMapSizeCustomProperty.BorderStyle = BorderStyle.FixedSingle;
            txtMapSizeCustomProperty.Enabled = false;
            txtMapSizeCustomProperty.ForeColor = Color.White;
            txtMapSizeCustomProperty.Location = new Point(10, 107);
            txtMapSizeCustomProperty.Name = "txtMapSizeCustomProperty";
            txtMapSizeCustomProperty.Size = new Size(180, 23);
            txtMapSizeCustomProperty.TabIndex = 11;
            txtMapSizeCustomProperty.TextAlign = HorizontalAlignment.Center;
            toolTips.SetToolTip(txtMapSizeCustomProperty, resources.GetString("txtMapSizeCustomProperty.ToolTip"));
            txtMapSizeCustomProperty.TextChanged += txtMapSizeCustomProperty_TextChanged;
            txtMapSizeCustomProperty.DoubleClick += txtMapSizeCustomProperty_DoubleClick;
            // 
            // numMapHeight
            // 
            numMapHeight.BackColor = Color.FromArgb(17, 17, 17);
            numMapHeight.BorderStyle = BorderStyle.FixedSingle;
            numMapHeight.ForeColor = Color.White;
            numMapHeight.Location = new Point(127, 28);
            numMapHeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numMapHeight.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            numMapHeight.Name = "numMapHeight";
            numMapHeight.Size = new Size(64, 23);
            numMapHeight.TabIndex = 9;
            numMapHeight.TextAlign = HorizontalAlignment.Center;
            toolTips.SetToolTip(numMapHeight, "Height");
            numMapHeight.Value = new decimal(new int[] { 400, 0, 0, 0 });
            numMapHeight.ValueChanged += numMapWidthHeight_ValueChanged;
            // 
            // numMapWidth
            // 
            numMapWidth.BackColor = Color.FromArgb(17, 17, 17);
            numMapWidth.BorderStyle = BorderStyle.FixedSingle;
            numMapWidth.ForeColor = Color.White;
            numMapWidth.Location = new Point(29, 28);
            numMapWidth.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numMapWidth.Minimum = new decimal(new int[] { 60, 0, 0, 0 });
            numMapWidth.Name = "numMapWidth";
            numMapWidth.Size = new Size(64, 23);
            numMapWidth.TabIndex = 9;
            numMapWidth.TextAlign = HorizontalAlignment.Center;
            toolTips.SetToolTip(numMapWidth, "Width");
            numMapWidth.Value = new decimal(new int[] { 600, 0, 0, 0 });
            numMapWidth.ValueChanged += numMapWidthHeight_ValueChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(8, 31);
            label17.Name = "label17";
            label17.Size = new Size(21, 15);
            label17.TabIndex = 8;
            label17.Text = "W:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(108, 31);
            label16.Name = "label16";
            label16.Size = new Size(19, 15);
            label16.TabIndex = 8;
            label16.Text = "H:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(222, 7);
            label19.Name = "label19";
            label19.Size = new Size(145, 15);
            label19.TabIndex = 8;
            label19.Text = "Default background color:";
            toolTips.SetToolTip(label19, "It can be useful, in case your template \r\ndoes not change the page's background color.\r\nSo you can better read the text.");
            // 
            // lblMapWinowSize
            // 
            lblMapWinowSize.AutoSize = true;
            lblMapWinowSize.Location = new Point(8, 7);
            lblMapWinowSize.Name = "lblMapWinowSize";
            lblMapWinowSize.Size = new Size(30, 15);
            lblMapWinowSize.TabIndex = 8;
            lblMapWinowSize.Text = "Size:";
            toolTips.SetToolTip(lblMapWinowSize, "In pixels.");
            // 
            // chkMapSizeCustomPropertyIgnoreCase
            // 
            chkMapSizeCustomPropertyIgnoreCase.AutoSize = true;
            chkMapSizeCustomPropertyIgnoreCase.Checked = true;
            chkMapSizeCustomPropertyIgnoreCase.CheckState = CheckState.Checked;
            chkMapSizeCustomPropertyIgnoreCase.Enabled = false;
            chkMapSizeCustomPropertyIgnoreCase.Location = new Point(10, 82);
            chkMapSizeCustomPropertyIgnoreCase.Name = "chkMapSizeCustomPropertyIgnoreCase";
            chkMapSizeCustomPropertyIgnoreCase.Size = new Size(175, 19);
            chkMapSizeCustomPropertyIgnoreCase.TabIndex = 10;
            chkMapSizeCustomPropertyIgnoreCase.Text = "Ignore case (recommended)";
            toolTips.SetToolTip(chkMapSizeCustomPropertyIgnoreCase, "Sets whether the search (for the below-mentioned property name) \r\nin a polygon's properties is case-sensitive or not.");
            chkMapSizeCustomPropertyIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // chkMapSizeCustomProperty
            // 
            chkMapSizeCustomProperty.AutoSize = true;
            chkMapSizeCustomProperty.Location = new Point(10, 57);
            chkMapSizeCustomProperty.Name = "chkMapSizeCustomProperty";
            chkMapSizeCustomProperty.Size = new Size(188, 19);
            chkMapSizeCustomProperty.TabIndex = 10;
            chkMapSizeCustomProperty.Text = "Use a polygon's property value";
            toolTips.SetToolTip(chkMapSizeCustomProperty, resources.GetString("chkMapSizeCustomProperty.ToolTip"));
            chkMapSizeCustomProperty.UseVisualStyleBackColor = true;
            chkMapSizeCustomProperty.CheckedChanged += chkMapSizeCustomProperty_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 495);
            label9.Name = "label9";
            label9.Size = new Size(255, 15);
            label9.TabIndex = 8;
            label9.Text = "uMap file properties (they can be used as tags):";
            // 
            // lblTagsInfo
            // 
            lblTagsInfo.AutoSize = true;
            lblTagsInfo.Cursor = Cursors.Hand;
            lblTagsInfo.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblTagsInfo.Location = new Point(483, 494);
            lblTagsInfo.Name = "lblTagsInfo";
            lblTagsInfo.Size = new Size(28, 15);
            lblTagsInfo.TabIndex = 10;
            lblTagsInfo.Text = "Info";
            lblTagsInfo.Click += lblTagsInfo_Click;
            // 
            // label20
            // 
            label20.Location = new Point(403, 29);
            label20.Name = "label20";
            label20.Size = new Size(511, 17);
            label20.TabIndex = 2;
            label20.Text = "Settings / configurations";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTemplatesInfo
            // 
            lblTemplatesInfo.AutoSize = true;
            lblTemplatesInfo.Cursor = Cursors.Hand;
            lblTemplatesInfo.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblTemplatesInfo.Location = new Point(470, 236);
            lblTemplatesInfo.Name = "lblTemplatesInfo";
            lblTemplatesInfo.Size = new Size(28, 15);
            lblTemplatesInfo.TabIndex = 10;
            lblTemplatesInfo.Text = "Info";
            lblTemplatesInfo.Click += lblTemplatesInfo_Click;
            // 
            // label1
            // 
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(378, 17);
            label1.TabIndex = 2;
            label1.Text = "Layers and polygons";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(401, 236);
            label14.Name = "label14";
            label14.Size = new Size(63, 15);
            label14.TabIndex = 8;
            label14.Text = "Templates:";
            // 
            // lblStatistics
            // 
            lblStatistics.Location = new Point(8, 29);
            lblStatistics.Name = "lblStatistics";
            lblStatistics.Size = new Size(378, 17);
            lblStatistics.TabIndex = 1;
            lblStatistics.Text = "Checked layers: 0/0  |  Checked polygons: 0/0";
            lblStatistics.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(400, 494);
            label15.Name = "label15";
            label15.Size = new Size(77, 15);
            label15.TabIndex = 8;
            label15.Text = "Tags settings:";
            // 
            // btnUncheckAll
            // 
            btnUncheckAll.BackColor = Color.FromArgb(17, 17, 17);
            btnUncheckAll.Cursor = Cursors.Hand;
            btnUncheckAll.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnUncheckAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 126, 126);
            btnUncheckAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnUncheckAll.FlatStyle = FlatStyle.Flat;
            btnUncheckAll.Location = new Point(104, 53);
            btnUncheckAll.Name = "btnUncheckAll";
            btnUncheckAll.Size = new Size(90, 26);
            btnUncheckAll.TabIndex = 1;
            btnUncheckAll.Text = "Uncheck all";
            btnUncheckAll.UseVisualStyleBackColor = false;
            btnUncheckAll.Click += btnUncheckAll_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(400, 323);
            label13.Name = "label13";
            label13.Size = new Size(123, 15);
            label13.TabIndex = 8;
            label13.Text = "Map window settings:";
            // 
            // btnCheckAll
            // 
            btnCheckAll.BackColor = Color.FromArgb(17, 17, 17);
            btnCheckAll.Cursor = Cursors.Hand;
            btnCheckAll.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnCheckAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 126, 126);
            btnCheckAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCheckAll.FlatStyle = FlatStyle.Flat;
            btnCheckAll.Location = new Point(8, 53);
            btnCheckAll.Name = "btnCheckAll";
            btnCheckAll.Size = new Size(90, 26);
            btnCheckAll.TabIndex = 1;
            btnCheckAll.Text = "Check all";
            btnCheckAll.UseVisualStyleBackColor = false;
            btnCheckAll.Click += btnCheckAll_Click;
            // 
            // lblPropertiesNote
            // 
            lblPropertiesNote.Location = new Point(556, 59);
            lblPropertiesNote.Name = "lblPropertiesNote";
            lblPropertiesNote.Size = new Size(358, 15);
            lblPropertiesNote.TabIndex = 8;
            lblPropertiesNote.Text = "-";
            lblPropertiesNote.TextAlign = ContentAlignment.MiddleRight;
            toolTips.SetToolTip(lblPropertiesNote, "See the 'Tags' section below for more info.");
            // 
            // btnCollapseAll
            // 
            btnCollapseAll.BackColor = Color.FromArgb(17, 17, 17);
            btnCollapseAll.Cursor = Cursors.Hand;
            btnCollapseAll.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnCollapseAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 126, 126);
            btnCollapseAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCollapseAll.FlatStyle = FlatStyle.Flat;
            btnCollapseAll.Location = new Point(296, 53);
            btnCollapseAll.Name = "btnCollapseAll";
            btnCollapseAll.Size = new Size(90, 26);
            btnCollapseAll.TabIndex = 1;
            btnCollapseAll.Text = "Collapse all";
            btnCollapseAll.UseVisualStyleBackColor = false;
            btnCollapseAll.Click += btnCollapseAll_Click;
            // 
            // lblPropertiesInfo
            // 
            lblPropertiesInfo.AutoSize = true;
            lblPropertiesInfo.Location = new Point(400, 59);
            lblPropertiesInfo.Name = "lblPropertiesInfo";
            lblPropertiesInfo.Size = new Size(63, 15);
            lblPropertiesInfo.TabIndex = 8;
            lblPropertiesInfo.Text = "Properties:";
            // 
            // btnExpandAll
            // 
            btnExpandAll.BackColor = Color.FromArgb(17, 17, 17);
            btnExpandAll.Cursor = Cursors.Hand;
            btnExpandAll.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnExpandAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 126, 126);
            btnExpandAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnExpandAll.FlatStyle = FlatStyle.Flat;
            btnExpandAll.Location = new Point(200, 53);
            btnExpandAll.Name = "btnExpandAll";
            btnExpandAll.Size = new Size(90, 26);
            btnExpandAll.TabIndex = 1;
            btnExpandAll.Text = "Expand all";
            btnExpandAll.UseVisualStyleBackColor = false;
            btnExpandAll.Click += btnExpandAll_Click;
            // 
            // pnlPolygonProperties
            // 
            pnlPolygonProperties.BorderStyle = BorderStyle.FixedSingle;
            pnlPolygonProperties.Controls.Add(dgvProperties);
            pnlPolygonProperties.Location = new Point(403, 85);
            pnlPolygonProperties.Name = "pnlPolygonProperties";
            pnlPolygonProperties.Size = new Size(511, 139);
            pnlPolygonProperties.TabIndex = 6;
            pnlPolygonProperties.Visible = false;
            // 
            // dgvProperties
            // 
            dgvProperties.AllowUserToAddRows = false;
            dgvProperties.AllowUserToDeleteRows = false;
            dgvProperties.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle16.ForeColor = Color.White;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            dgvProperties.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dgvProperties.BackgroundColor = Color.FromArgb(17, 17, 17);
            dgvProperties.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle17.ForeColor = Color.White;
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle17.SelectionForeColor = Color.White;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dgvProperties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperties.Columns.AddRange(new DataGridViewColumn[] { PropertyName, PropertyValue });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = Color.White;
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle18.SelectionForeColor = Color.White;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dgvProperties.DefaultCellStyle = dataGridViewCellStyle18;
            dgvProperties.Dock = DockStyle.Fill;
            dgvProperties.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProperties.EnableHeadersVisualStyles = false;
            dgvProperties.Location = new Point(0, 0);
            dgvProperties.MultiSelect = false;
            dgvProperties.Name = "dgvProperties";
            dgvProperties.ReadOnly = true;
            dgvProperties.RowHeadersVisible = false;
            dgvProperties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProperties.Size = new Size(509, 137);
            dgvProperties.TabIndex = 5;
            dgvProperties.CellDoubleClick += dgvProperties_CellDoubleClick;
            // 
            // PropertyName
            // 
            PropertyName.HeaderText = "Property name";
            PropertyName.Name = "PropertyName";
            PropertyName.ReadOnly = true;
            PropertyName.Width = 200;
            // 
            // PropertyValue
            // 
            PropertyValue.HeaderText = "Property value";
            PropertyValue.Name = "PropertyValue";
            PropertyValue.ReadOnly = true;
            PropertyValue.Width = 260;
            // 
            // pnlLayerProperties
            // 
            pnlLayerProperties.BorderStyle = BorderStyle.FixedSingle;
            pnlLayerProperties.Controls.Add(lblPolyColor);
            pnlLayerProperties.Controls.Add(lblPolyFillOpacity);
            pnlLayerProperties.Controls.Add(txtPolyDescription);
            pnlLayerProperties.Controls.Add(label6);
            pnlLayerProperties.Controls.Add(lblPolyFillColor);
            pnlLayerProperties.Controls.Add(label8);
            pnlLayerProperties.Controls.Add(label3);
            pnlLayerProperties.Controls.Add(label7);
            pnlLayerProperties.Controls.Add(lblPolyFill);
            pnlLayerProperties.Controls.Add(label5);
            pnlLayerProperties.Location = new Point(403, 85);
            pnlLayerProperties.Name = "pnlLayerProperties";
            pnlLayerProperties.Size = new Size(511, 139);
            pnlLayerProperties.TabIndex = 7;
            pnlLayerProperties.Visible = false;
            // 
            // lblPolyColor
            // 
            lblPolyColor.AutoSize = true;
            lblPolyColor.Cursor = Cursors.Hand;
            lblPolyColor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPolyColor.HoverColor = Color.White;
            lblPolyColor.Location = new Point(378, 23);
            lblPolyColor.Name = "lblPolyColor";
            lblPolyColor.Size = new Size(12, 15);
            lblPolyColor.TabIndex = 9;
            lblPolyColor.Text = "-";
            toolTips.SetToolTip(lblPolyColor, "Click to copy the HEX value. \r\nCTRL + click to copy the RGB value.");
            lblPolyColor.Click += CopyCustomLabelHoverColor;
            // 
            // lblPolyFillOpacity
            // 
            lblPolyFillOpacity.AutoSize = true;
            lblPolyFillOpacity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPolyFillOpacity.HoverColor = Color.White;
            lblPolyFillOpacity.Location = new Point(378, 113);
            lblPolyFillOpacity.Name = "lblPolyFillOpacity";
            lblPolyFillOpacity.Size = new Size(12, 15);
            lblPolyFillOpacity.TabIndex = 12;
            lblPolyFillOpacity.Text = "-";
            // 
            // txtPolyDescription
            // 
            txtPolyDescription.BackColor = Color.FromArgb(17, 17, 17);
            txtPolyDescription.BorderStyle = BorderStyle.FixedSingle;
            txtPolyDescription.ForeColor = Color.White;
            txtPolyDescription.Location = new Point(7, 23);
            txtPolyDescription.Multiline = true;
            txtPolyDescription.Name = "txtPolyDescription";
            txtPolyDescription.ReadOnly = true;
            txtPolyDescription.ScrollBars = ScrollBars.Vertical;
            txtPolyDescription.Size = new Size(275, 106);
            txtPolyDescription.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 5);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 0;
            label6.Text = "Description:";
            // 
            // lblPolyFillColor
            // 
            lblPolyFillColor.AutoSize = true;
            lblPolyFillColor.Cursor = Cursors.Hand;
            lblPolyFillColor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPolyFillColor.HoverColor = Color.White;
            lblPolyFillColor.Location = new Point(378, 83);
            lblPolyFillColor.Name = "lblPolyFillColor";
            lblPolyFillColor.Size = new Size(12, 15);
            lblPolyFillColor.TabIndex = 11;
            lblPolyFillColor.Text = "-";
            toolTips.SetToolTip(lblPolyFillColor, "Click to copy the HEX value. \r\nCTRL + click to copy the RGB value.");
            lblPolyFillColor.Click += CopyCustomLabelHoverColor;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(306, 23);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 0;
            label8.Text = "Color:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 83);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 0;
            label3.Text = "Fill color:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(306, 53);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 0;
            label7.Text = "Fill:";
            // 
            // lblPolyFill
            // 
            lblPolyFill.AutoSize = true;
            lblPolyFill.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPolyFill.HoverColor = Color.White;
            lblPolyFill.Location = new Point(378, 53);
            lblPolyFill.Name = "lblPolyFill";
            lblPolyFill.Size = new Size(12, 15);
            lblPolyFill.TabIndex = 10;
            lblPolyFill.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 113);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 0;
            label5.Text = "Fill opacity:";
            // 
            // treeView
            // 
            treeView.BackColor = Color.FromArgb(17, 17, 17);
            treeView.BorderStyle = BorderStyle.FixedSingle;
            treeView.CheckBoxes = true;
            treeView.ForeColor = Color.White;
            treeView.Location = new Point(8, 85);
            treeView.Name = "treeView";
            treeView.Size = new Size(378, 399);
            treeView.TabIndex = 0;
            treeView.AfterCheck += treeView_AfterCheck;
            treeView.AfterSelect += treeView_AfterSelect;
            // 
            // btnMODEL
            // 
            btnMODEL.BackColor = Color.FromArgb(17, 17, 17);
            btnMODEL.Cursor = Cursors.Hand;
            btnMODEL.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnMODEL.FlatAppearance.MouseDownBackColor = Color.FromArgb(126, 126, 126);
            btnMODEL.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnMODEL.FlatStyle = FlatStyle.Flat;
            btnMODEL.Location = new Point(1068, 644);
            btnMODEL.Name = "btnMODEL";
            btnMODEL.Size = new Size(100, 27);
            btnMODEL.TabIndex = 1;
            btnMODEL.Text = "MODEL";
            btnMODEL.UseVisualStyleBackColor = false;
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
            // fswTemplates
            // 
            fswTemplates.EnableRaisingEvents = true;
            fswTemplates.SynchronizingObject = this;
            fswTemplates.Changed += fswTemplates_CreatedChangedDeleted;
            fswTemplates.Created += fswTemplates_CreatedChangedDeleted;
            fswTemplates.Deleted += fswTemplates_CreatedChangedDeleted;
            fswTemplates.Renamed += fswTemplates_Renamed;
            // 
            // pnlDragDrop
            // 
            pnlDragDrop.Location = new Point(1102, 170);
            pnlDragDrop.Name = "pnlDragDrop";
            pnlDragDrop.Size = new Size(66, 72);
            pnlDragDrop.TabIndex = 2;
            pnlDragDrop.Visible = false;
            // 
            // pnlAppSettings
            // 
            pnlAppSettings.Location = new Point(1102, 306);
            pnlAppSettings.Name = "pnlAppSettings";
            pnlAppSettings.Size = new Size(66, 72);
            pnlAppSettings.TabIndex = 2;
            pnlAppSettings.Visible = false;
            // 
            // colorDialog
            // 
            colorDialog.Color = Color.FromArgb(26, 26, 26);
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(187, 35);
            label22.Name = "label22";
            label22.Size = new Size(244, 15);
            label22.TabIndex = 8;
            label22.Text = "(double click on a row to copy the tag name)";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(929, 768);
            Controls.Add(pnlAppSettings);
            Controls.Add(pnlDragDrop);
            Controls.Add(btnMODEL);
            Controls.Add(pnlMain);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "uMap2Bitmap";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            Shown += frmMain_Shown;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlTags.ResumeLayout(false);
            pnlTags.PerformLayout();
            pnlGlobalTags.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGlobalTags).EndInit();
            pnlExport.ResumeLayout(false);
            pnlTemplates.ResumeLayout(false);
            pnlTemplates.PerformLayout();
            pnlUMapProperties.ResumeLayout(false);
            pnlUMapProperties.PerformLayout();
            pnlMapSettings.ResumeLayout(false);
            pnlMapSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMapHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMapWidth).EndInit();
            pnlPolygonProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProperties).EndInit();
            pnlLayerProperties.ResumeLayout(false);
            pnlLayerProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fswTemplates).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Controls.CustomTreeView treeView;
        private Button btnMODEL;
        private Label lblStatistics;
        private Button btnRUN;
        private Button btnCollapseAll;
        private Button btnExpandAll;
        private Button btnUncheckAll;
        private Button btnCheckAll;
        private Label label1;
        private Panel pnlPolygonProperties;
        private DataGridView dgvProperties;
        private Panel pnlLayerProperties;
        private Label lblPropertiesInfo;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txtPolyDescription;
        private Controls.CustomLabel lblPolyColor;
        private Controls.CustomLabel lblPolyFill;
        private Controls.CustomLabel lblPolyFillOpacity;
        private Controls.CustomLabel lblPolyFillColor;
        private Label label7;
        private Label label8;
        private ToolTip toolTips;
        private ComboBox cmbTextEditors;
        private Button btnOpenTemplate;
        private Label label24;
        private ComboBox cmbTemplates;
        private Label lblTemplatesTitle;
        private Label lblOpenTemplatesDir;
        private Label lblTemplatesInfo;
        private FileSystemWatcher fswTemplates;
        private Panel pnlUMapProperties;
        private Label label9;
        private DataGridViewTextBoxColumn PropertyName;
        private DataGridViewTextBoxColumn PropertyValue;
        private Label lblPropertiesNote;
        private Label label4;
        private Label label2;
        private Label lblUMapZoomMin;
        private Label label11;
        private Label lblUMapTileLayerUrl;
        private Label lblUMapTileLayerName;
        private Label label12;
        private Label lblUMapDescription;
        private Label label10;
        private Label lblUMapName;
        private Panel pnlMapSettings;
        private Label label13;
        private Panel pnlTemplates;
        private Label label14;
        private Label lblMapWinowSize;
        private NumericUpDown numMapHeight;
        private NumericUpDown numMapWidth;
        private Label label17;
        private Label label16;
        private CheckBox chkMapSizeCustomProperty;
        private TextBox txtMapSizeCustomProperty;
        private Panel pnlDragDrop;
        private Panel pnlAppSettings;
        private Panel pnlTags;
        private Label label15;
        private Label lblUMapZoomMax;
        private Label label18;
        private Label lblTagsInfo;
        private ColorDialog colorDialog;
        private Label label19;
        private Label lblMapDefaultBackgroundColor;
        private CheckBox chkBorderlessMapWindow;
        private CheckBox chkIgnoreTagCase;
        private CheckBox chkRemoveUnusedTags;
        private Label lblGetCurrentMapWindowSize;
        private Label lblMapSizeCustomPropertyValue;
        private CheckBox chkMapSizeCustomPropertyIgnoreCase;
        private Panel pnlGlobalTags;
        private DataGridView dgvGlobalTags;
        private Label lblGlobalTagsInfo;
        private Label label21;
        private Button btnAddGlobalTag;
        private Button btnDeleteAllGlobalTags;
        private Button btnDeleteGlobalTag;
        private Panel pnlExport;
        private DataGridViewTextBoxColumn TagName;
        private DataGridViewTextBoxColumn TagValue;
        private Label label20;
        private Label label22;
    }
}