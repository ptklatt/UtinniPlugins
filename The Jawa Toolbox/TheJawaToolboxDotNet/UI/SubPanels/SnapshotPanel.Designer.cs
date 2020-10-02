namespace TJT.UI.SubPanels
{
    partial class SnapshotPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReloadSnapshot = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnLoadSnapshot = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.cmbSnapshots = new System.Windows.Forms.ComboBox();
            this.btnUnloadSnapshot = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnSaveSnapshot = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnAddNode = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnRemoveSelectedNode = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.txtNewNodeFilename = new System.Windows.Forms.TextBox();
            this.chkEnableNodeEditing = new System.Windows.Forms.CheckBox();
            this.lblSelectedNode = new System.Windows.Forms.Label();
            this.lblNodePosY = new System.Windows.Forms.Label();
            this.nudNodePosY = new System.Windows.Forms.NumericUpDown();
            this.lblNodePosX = new System.Windows.Forms.Label();
            this.nudNodePosZ = new System.Windows.Forms.NumericUpDown();
            this.lblNodePos = new System.Windows.Forms.Label();
            this.lblNodePosZ = new System.Windows.Forms.Label();
            this.nudNodePosX = new System.Windows.Forms.NumericUpDown();
            this.txtNodeFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNodeType = new System.Windows.Forms.TextBox();
            this.lblNodeCellName = new System.Windows.Forms.Label();
            this.txtNodeCellName = new System.Windows.Forms.TextBox();
            this.lblNodeParentId = new System.Windows.Forms.Label();
            this.txtNodeParentId = new System.Windows.Forms.TextBox();
            this.lblNodeRadius = new System.Windows.Forms.Label();
            this.txtNodeId = new System.Windows.Forms.TextBox();
            this.nudNodeRadius = new System.Windows.Forms.NumericUpDown();
            this.lblObjFile = new System.Windows.Forms.Label();
            this.lblNodeId = new System.Windows.Forms.Label();
            this.lblNodeAxisY = new System.Windows.Forms.Label();
            this.nudNodeRotY = new System.Windows.Forms.NumericUpDown();
            this.nudNodeRotZ = new System.Windows.Forms.NumericUpDown();
            this.lblNodeAxisX = new System.Windows.Forms.Label();
            this.lblNodeAxisZ = new System.Windows.Forms.Label();
            this.lblNodeAxis = new System.Windows.Forms.Label();
            this.nudNodeRotX = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodePosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodePosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodePosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodeRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodeRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodeRotZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodeRotX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReloadSnapshot
            // 
            this.btnReloadSnapshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReloadSnapshot.Enabled = false;
            this.btnReloadSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReloadSnapshot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReloadSnapshot.Location = new System.Drawing.Point(165, 30);
            this.btnReloadSnapshot.Name = "btnReloadSnapshot";
            this.btnReloadSnapshot.Size = new System.Drawing.Size(75, 23);
            this.btnReloadSnapshot.TabIndex = 331;
            this.btnReloadSnapshot.Text = "Reload";
            this.btnReloadSnapshot.UseVisualStyleBackColor = false;
            this.btnReloadSnapshot.Click += new System.EventHandler(this.btnReloadSnapshot_Click);
            // 
            // btnLoadSnapshot
            // 
            this.btnLoadSnapshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLoadSnapshot.Enabled = false;
            this.btnLoadSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadSnapshot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadSnapshot.Location = new System.Drawing.Point(3, 30);
            this.btnLoadSnapshot.Name = "btnLoadSnapshot";
            this.btnLoadSnapshot.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSnapshot.TabIndex = 330;
            this.btnLoadSnapshot.Text = "Load";
            this.btnLoadSnapshot.UseVisualStyleBackColor = false;
            this.btnLoadSnapshot.Click += new System.EventHandler(this.btnLoadSnapshot_Click);
            // 
            // cmbSnapshots
            // 
            this.cmbSnapshots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSnapshots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSnapshots.FormattingEnabled = true;
            this.cmbSnapshots.Location = new System.Drawing.Point(3, 3);
            this.cmbSnapshots.Name = "cmbSnapshots";
            this.cmbSnapshots.Size = new System.Drawing.Size(237, 21);
            this.cmbSnapshots.TabIndex = 328;
            // 
            // btnUnloadSnapshot
            // 
            this.btnUnloadSnapshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUnloadSnapshot.Enabled = false;
            this.btnUnloadSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnloadSnapshot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUnloadSnapshot.Location = new System.Drawing.Point(84, 30);
            this.btnUnloadSnapshot.Name = "btnUnloadSnapshot";
            this.btnUnloadSnapshot.Size = new System.Drawing.Size(75, 23);
            this.btnUnloadSnapshot.TabIndex = 332;
            this.btnUnloadSnapshot.Text = "Unload";
            this.btnUnloadSnapshot.UseVisualStyleBackColor = false;
            this.btnUnloadSnapshot.Click += new System.EventHandler(this.btnUnloadSnapshot_Click);
            // 
            // btnSaveSnapshot
            // 
            this.btnSaveSnapshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSaveSnapshot.Enabled = false;
            this.btnSaveSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveSnapshot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveSnapshot.Location = new System.Drawing.Point(246, 3);
            this.btnSaveSnapshot.Name = "btnSaveSnapshot";
            this.btnSaveSnapshot.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSnapshot.TabIndex = 333;
            this.btnSaveSnapshot.Text = "Save";
            this.btnSaveSnapshot.UseVisualStyleBackColor = false;
            this.btnSaveSnapshot.Click += new System.EventHandler(this.btnSaveSnapshot_Click);
            // 
            // btnAddNode
            // 
            this.btnAddNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddNode.Enabled = false;
            this.btnAddNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddNode.Location = new System.Drawing.Point(3, 97);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(75, 23);
            this.btnAddNode.TabIndex = 334;
            this.btnAddNode.Text = "Add Node";
            this.btnAddNode.UseVisualStyleBackColor = false;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddSnapshotNode_Click);
            // 
            // btnRemoveSelectedNode
            // 
            this.btnRemoveSelectedNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRemoveSelectedNode.Enabled = false;
            this.btnRemoveSelectedNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveSelectedNode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveSelectedNode.Location = new System.Drawing.Point(336, 365);
            this.btnRemoveSelectedNode.Name = "btnRemoveSelectedNode";
            this.btnRemoveSelectedNode.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSelectedNode.TabIndex = 335;
            this.btnRemoveSelectedNode.Text = "Remove";
            this.btnRemoveSelectedNode.UseVisualStyleBackColor = false;
            this.btnRemoveSelectedNode.Click += new System.EventHandler(this.btnRemoveSnapshotNode_Click);
            // 
            // txtNewNodeFilename
            // 
            this.txtNewNodeFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewNodeFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewNodeFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewNodeFilename.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewNodeFilename.Location = new System.Drawing.Point(3, 71);
            this.txtNewNodeFilename.Name = "txtNewNodeFilename";
            this.txtNewNodeFilename.ReadOnly = true;
            this.txtNewNodeFilename.Size = new System.Drawing.Size(411, 20);
            this.txtNewNodeFilename.TabIndex = 336;
            this.txtNewNodeFilename.Text = "object/tangible/furniture/cheap/shared_armoire_s01.iff";
            // 
            // chkEnableNodeEditing
            // 
            this.chkEnableNodeEditing.AutoSize = true;
            this.chkEnableNodeEditing.Location = new System.Drawing.Point(3, 137);
            this.chkEnableNodeEditing.Name = "chkEnableNodeEditing";
            this.chkEnableNodeEditing.Size = new System.Drawing.Size(122, 17);
            this.chkEnableNodeEditing.TabIndex = 344;
            this.chkEnableNodeEditing.Text = "Enable Node editing";
            this.chkEnableNodeEditing.UseVisualStyleBackColor = true;
            this.chkEnableNodeEditing.CheckedChanged += new System.EventHandler(this.chkEnableNodeEditing_CheckedChanged);
            // 
            // lblSelectedNode
            // 
            this.lblSelectedNode.AutoSize = true;
            this.lblSelectedNode.Location = new System.Drawing.Point(0, 163);
            this.lblSelectedNode.Name = "lblSelectedNode";
            this.lblSelectedNode.Size = new System.Drawing.Size(78, 13);
            this.lblSelectedNode.TabIndex = 349;
            this.lblSelectedNode.Text = "Selected Node";
            // 
            // lblNodePosY
            // 
            this.lblNodePosY.AutoSize = true;
            this.lblNodePosY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNodePosY.Location = new System.Drawing.Point(146, 300);
            this.lblNodePosY.Name = "lblNodePosY";
            this.lblNodePosY.Size = new System.Drawing.Size(14, 13);
            this.lblNodePosY.TabIndex = 354;
            this.lblNodePosY.Text = "Y";
            // 
            // nudNodePosY
            // 
            this.nudNodePosY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudNodePosY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNodePosY.DecimalPlaces = 2;
            this.nudNodePosY.Enabled = false;
            this.nudNodePosY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudNodePosY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudNodePosY.Location = new System.Drawing.Point(160, 298);
            this.nudNodePosY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNodePosY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nudNodePosY.Name = "nudNodePosY";
            this.nudNodePosY.Size = new System.Drawing.Size(70, 20);
            this.nudNodePosY.TabIndex = 353;
            this.nudNodePosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNodePosY.ValueChanged += new System.EventHandler(this.nudNodePos_ValueChanged);
            // 
            // lblNodePosX
            // 
            this.lblNodePosX.AutoSize = true;
            this.lblNodePosX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNodePosX.Location = new System.Drawing.Point(56, 300);
            this.lblNodePosX.Name = "lblNodePosX";
            this.lblNodePosX.Size = new System.Drawing.Size(14, 13);
            this.lblNodePosX.TabIndex = 352;
            this.lblNodePosX.Text = "X";
            // 
            // nudNodePosZ
            // 
            this.nudNodePosZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudNodePosZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNodePosZ.DecimalPlaces = 2;
            this.nudNodePosZ.Enabled = false;
            this.nudNodePosZ.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudNodePosZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudNodePosZ.Location = new System.Drawing.Point(250, 298);
            this.nudNodePosZ.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNodePosZ.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nudNodePosZ.Name = "nudNodePosZ";
            this.nudNodePosZ.Size = new System.Drawing.Size(70, 20);
            this.nudNodePosZ.TabIndex = 355;
            this.nudNodePosZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNodePosZ.ValueChanged += new System.EventHandler(this.nudNodePos_ValueChanged);
            // 
            // lblNodePos
            // 
            this.lblNodePos.AutoSize = true;
            this.lblNodePos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNodePos.Location = new System.Drawing.Point(4, 300);
            this.lblNodePos.Name = "lblNodePos";
            this.lblNodePos.Size = new System.Drawing.Size(44, 13);
            this.lblNodePos.TabIndex = 351;
            this.lblNodePos.Text = "Position";
            // 
            // lblNodePosZ
            // 
            this.lblNodePosZ.AutoSize = true;
            this.lblNodePosZ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNodePosZ.Location = new System.Drawing.Point(236, 300);
            this.lblNodePosZ.Name = "lblNodePosZ";
            this.lblNodePosZ.Size = new System.Drawing.Size(14, 13);
            this.lblNodePosZ.TabIndex = 356;
            this.lblNodePosZ.Text = "Z";
            // 
            // nudNodePosX
            // 
            this.nudNodePosX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudNodePosX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNodePosX.DecimalPlaces = 2;
            this.nudNodePosX.Enabled = false;
            this.nudNodePosX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudNodePosX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudNodePosX.Location = new System.Drawing.Point(70, 298);
            this.nudNodePosX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNodePosX.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nudNodePosX.Name = "nudNodePosX";
            this.nudNodePosX.Size = new System.Drawing.Size(70, 20);
            this.nudNodePosX.TabIndex = 350;
            this.nudNodePosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNodePosX.ValueChanged += new System.EventHandler(this.nudNodePos_ValueChanged);
            // 
            // txtNodeFilename
            // 
            this.txtNodeFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNodeFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNodeFilename.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNodeFilename.Location = new System.Drawing.Point(5, 231);
            this.txtNodeFilename.Name = "txtNodeFilename";
            this.txtNodeFilename.ReadOnly = true;
            this.txtNodeFilename.Size = new System.Drawing.Size(406, 20);
            this.txtNodeFilename.TabIndex = 357;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(4, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 360;
            this.label1.Text = "Object Type";
            // 
            // txtNodeType
            // 
            this.txtNodeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNodeType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNodeType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNodeType.Location = new System.Drawing.Point(5, 272);
            this.txtNodeType.Name = "txtNodeType";
            this.txtNodeType.ReadOnly = true;
            this.txtNodeType.Size = new System.Drawing.Size(406, 20);
            this.txtNodeType.TabIndex = 359;
            // 
            // lblNodeCellName
            // 
            this.lblNodeCellName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNodeCellName.AutoSize = true;
            this.lblNodeCellName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNodeCellName.Location = new System.Drawing.Point(184, 207);
            this.lblNodeCellName.Name = "lblNodeCellName";
            this.lblNodeCellName.Size = new System.Drawing.Size(55, 13);
            this.lblNodeCellName.TabIndex = 391;
            this.lblNodeCellName.Text = "Cell Name";
            // 
            // txtNodeCellName
            // 
            this.txtNodeCellName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeCellName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNodeCellName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNodeCellName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNodeCellName.Location = new System.Drawing.Point(242, 205);
            this.txtNodeCellName.Name = "txtNodeCellName";
            this.txtNodeCellName.ReadOnly = true;
            this.txtNodeCellName.Size = new System.Drawing.Size(170, 20);
            this.txtNodeCellName.TabIndex = 390;
            // 
            // lblNodeParentId
            // 
            this.lblNodeParentId.AutoSize = true;
            this.lblNodeParentId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNodeParentId.Location = new System.Drawing.Point(84, 182);
            this.lblNodeParentId.Name = "lblNodeParentId";
            this.lblNodeParentId.Size = new System.Drawing.Size(52, 13);
            this.lblNodeParentId.TabIndex = 389;
            this.lblNodeParentId.Text = "Parent ID";
            // 
            // txtNodeParentId
            // 
            this.txtNodeParentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNodeParentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNodeParentId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNodeParentId.Location = new System.Drawing.Point(136, 179);
            this.txtNodeParentId.Name = "txtNodeParentId";
            this.txtNodeParentId.ReadOnly = true;
            this.txtNodeParentId.Size = new System.Drawing.Size(60, 20);
            this.txtNodeParentId.TabIndex = 388;
            this.txtNodeParentId.Text = "0";
            // 
            // lblNodeRadius
            // 
            this.lblNodeRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNodeRadius.AutoSize = true;
            this.lblNodeRadius.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNodeRadius.Location = new System.Drawing.Point(304, 182);
            this.lblNodeRadius.Name = "lblNodeRadius";
            this.lblNodeRadius.Size = new System.Drawing.Size(40, 13);
            this.lblNodeRadius.TabIndex = 387;
            this.lblNodeRadius.Text = "Radius";
            // 
            // txtNodeId
            // 
            this.txtNodeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNodeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNodeId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNodeId.Location = new System.Drawing.Point(21, 179);
            this.txtNodeId.Name = "txtNodeId";
            this.txtNodeId.ReadOnly = true;
            this.txtNodeId.Size = new System.Drawing.Size(60, 20);
            this.txtNodeId.TabIndex = 382;
            this.txtNodeId.Text = "0";
            // 
            // nudNodeRadius
            // 
            this.nudNodeRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNodeRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudNodeRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNodeRadius.Enabled = false;
            this.nudNodeRadius.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudNodeRadius.Location = new System.Drawing.Point(349, 179);
            this.nudNodeRadius.Maximum = new decimal(new int[] {
            512000,
            0,
            0,
            0});
            this.nudNodeRadius.Name = "nudNodeRadius";
            this.nudNodeRadius.Size = new System.Drawing.Size(63, 20);
            this.nudNodeRadius.TabIndex = 386;
            this.nudNodeRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNodeRadius.ValueChanged += new System.EventHandler(this.nudNodeRadius_ValueChanged);
            // 
            // lblObjFile
            // 
            this.lblObjFile.AutoSize = true;
            this.lblObjFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblObjFile.Location = new System.Drawing.Point(4, 213);
            this.lblObjFile.Name = "lblObjFile";
            this.lblObjFile.Size = new System.Drawing.Size(83, 13);
            this.lblObjFile.TabIndex = 381;
            this.lblObjFile.Text = "Object Filename";
            // 
            // lblNodeId
            // 
            this.lblNodeId.AutoSize = true;
            this.lblNodeId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNodeId.Location = new System.Drawing.Point(4, 182);
            this.lblNodeId.Name = "lblNodeId";
            this.lblNodeId.Size = new System.Drawing.Size(18, 13);
            this.lblNodeId.TabIndex = 384;
            this.lblNodeId.Text = "ID";
            // 
            // lblNodeAxisY
            // 
            this.lblNodeAxisY.AutoSize = true;
            this.lblNodeAxisY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNodeAxisY.Location = new System.Drawing.Point(146, 326);
            this.lblNodeAxisY.Name = "lblNodeAxisY";
            this.lblNodeAxisY.Size = new System.Drawing.Size(14, 13);
            this.lblNodeAxisY.TabIndex = 396;
            this.lblNodeAxisY.Text = "Y";
            // 
            // nudNodeRotY
            // 
            this.nudNodeRotY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudNodeRotY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNodeRotY.DecimalPlaces = 5;
            this.nudNodeRotY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudNodeRotY.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudNodeRotY.Location = new System.Drawing.Point(160, 324);
            this.nudNodeRotY.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudNodeRotY.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudNodeRotY.Name = "nudNodeRotY";
            this.nudNodeRotY.Size = new System.Drawing.Size(70, 20);
            this.nudNodeRotY.TabIndex = 395;
            this.nudNodeRotY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudNodeRotZ
            // 
            this.nudNodeRotZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudNodeRotZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNodeRotZ.DecimalPlaces = 5;
            this.nudNodeRotZ.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudNodeRotZ.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudNodeRotZ.Location = new System.Drawing.Point(250, 324);
            this.nudNodeRotZ.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudNodeRotZ.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudNodeRotZ.Name = "nudNodeRotZ";
            this.nudNodeRotZ.Size = new System.Drawing.Size(70, 20);
            this.nudNodeRotZ.TabIndex = 397;
            this.nudNodeRotZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNodeAxisX
            // 
            this.lblNodeAxisX.AutoSize = true;
            this.lblNodeAxisX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNodeAxisX.Location = new System.Drawing.Point(56, 326);
            this.lblNodeAxisX.Name = "lblNodeAxisX";
            this.lblNodeAxisX.Size = new System.Drawing.Size(14, 13);
            this.lblNodeAxisX.TabIndex = 394;
            this.lblNodeAxisX.Text = "X";
            // 
            // lblNodeAxisZ
            // 
            this.lblNodeAxisZ.AutoSize = true;
            this.lblNodeAxisZ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNodeAxisZ.Location = new System.Drawing.Point(236, 326);
            this.lblNodeAxisZ.Name = "lblNodeAxisZ";
            this.lblNodeAxisZ.Size = new System.Drawing.Size(14, 13);
            this.lblNodeAxisZ.TabIndex = 398;
            this.lblNodeAxisZ.Text = "Z";
            // 
            // lblNodeAxis
            // 
            this.lblNodeAxis.AutoSize = true;
            this.lblNodeAxis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNodeAxis.Location = new System.Drawing.Point(4, 326);
            this.lblNodeAxis.Name = "lblNodeAxis";
            this.lblNodeAxis.Size = new System.Drawing.Size(47, 13);
            this.lblNodeAxis.TabIndex = 393;
            this.lblNodeAxis.Text = "Rotation";
            // 
            // nudNodeRotX
            // 
            this.nudNodeRotX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudNodeRotX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNodeRotX.DecimalPlaces = 5;
            this.nudNodeRotX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudNodeRotX.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudNodeRotX.Location = new System.Drawing.Point(70, 324);
            this.nudNodeRotX.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudNodeRotX.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudNodeRotX.Name = "nudNodeRotX";
            this.nudNodeRotX.Size = new System.Drawing.Size(70, 20);
            this.nudNodeRotX.TabIndex = 392;
            this.nudNodeRotX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SnapshotPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNodeAxisY);
            this.Controls.Add(this.nudNodeRotY);
            this.Controls.Add(this.nudNodeRotZ);
            this.Controls.Add(this.lblNodeAxisX);
            this.Controls.Add(this.lblNodeAxisZ);
            this.Controls.Add(this.lblNodeAxis);
            this.Controls.Add(this.nudNodeRotX);
            this.Controls.Add(this.lblNodeCellName);
            this.Controls.Add(this.txtNodeCellName);
            this.Controls.Add(this.lblNodeParentId);
            this.Controls.Add(this.txtNodeParentId);
            this.Controls.Add(this.lblNodeRadius);
            this.Controls.Add(this.txtNodeId);
            this.Controls.Add(this.nudNodeRadius);
            this.Controls.Add(this.lblObjFile);
            this.Controls.Add(this.lblNodeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNodeType);
            this.Controls.Add(this.txtNodeFilename);
            this.Controls.Add(this.lblNodePosY);
            this.Controls.Add(this.nudNodePosY);
            this.Controls.Add(this.lblNodePosX);
            this.Controls.Add(this.nudNodePosZ);
            this.Controls.Add(this.lblNodePos);
            this.Controls.Add(this.lblNodePosZ);
            this.Controls.Add(this.nudNodePosX);
            this.Controls.Add(this.lblSelectedNode);
            this.Controls.Add(this.chkEnableNodeEditing);
            this.Controls.Add(this.txtNewNodeFilename);
            this.Controls.Add(this.btnRemoveSelectedNode);
            this.Controls.Add(this.btnAddNode);
            this.Controls.Add(this.btnSaveSnapshot);
            this.Controls.Add(this.btnUnloadSnapshot);
            this.Controls.Add(this.btnReloadSnapshot);
            this.Controls.Add(this.btnLoadSnapshot);
            this.Controls.Add(this.cmbSnapshots);
            this.Name = "SnapshotPanel";
            this.Size = new System.Drawing.Size(417, 391);
            ((System.ComponentModel.ISupportInitialize)(this.nudNodePosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodePosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodePosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodeRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodeRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodeRotZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodeRotX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnReloadSnapshot;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnLoadSnapshot;
        private System.Windows.Forms.ComboBox cmbSnapshots;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnUnloadSnapshot;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnSaveSnapshot;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnAddNode;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnRemoveSelectedNode;
        private System.Windows.Forms.TextBox txtNewNodeFilename;
        private System.Windows.Forms.CheckBox chkEnableNodeEditing;
        private System.Windows.Forms.Label lblSelectedNode;
        private System.Windows.Forms.Label lblNodePosY;
        private System.Windows.Forms.NumericUpDown nudNodePosY;
        private System.Windows.Forms.Label lblNodePosX;
        private System.Windows.Forms.NumericUpDown nudNodePosZ;
        private System.Windows.Forms.Label lblNodePos;
        private System.Windows.Forms.Label lblNodePosZ;
        private System.Windows.Forms.NumericUpDown nudNodePosX;
        private System.Windows.Forms.TextBox txtNodeFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNodeType;
        private System.Windows.Forms.Label lblNodeCellName;
        private System.Windows.Forms.TextBox txtNodeCellName;
        private System.Windows.Forms.Label lblNodeParentId;
        private System.Windows.Forms.TextBox txtNodeParentId;
        private System.Windows.Forms.Label lblNodeRadius;
        private System.Windows.Forms.TextBox txtNodeId;
        private System.Windows.Forms.NumericUpDown nudNodeRadius;
        private System.Windows.Forms.Label lblObjFile;
        private System.Windows.Forms.Label lblNodeId;
        private System.Windows.Forms.Label lblNodeAxisY;
        private System.Windows.Forms.NumericUpDown nudNodeRotY;
        private System.Windows.Forms.NumericUpDown nudNodeRotZ;
        private System.Windows.Forms.Label lblNodeAxisX;
        private System.Windows.Forms.Label lblNodeAxisZ;
        private System.Windows.Forms.Label lblNodeAxis;
        private System.Windows.Forms.NumericUpDown nudNodeRotX;
    }
}
