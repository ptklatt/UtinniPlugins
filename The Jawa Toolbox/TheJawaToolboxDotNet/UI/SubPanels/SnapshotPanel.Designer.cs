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
            this.cmbSnapshots = new UtinniCoreDotNet.UI.Controls.UtinniComboBox();
            this.btnUnloadSnapshot = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnSaveSnapshot = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnAddNode = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnRemoveSelectedNode = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.txtNewNodeFilename = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            this.chkEnableNodeEditing = new UtinniCoreDotNet.UI.Controls.UtinniToggle();
            this.lblSelectedNode = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.lblNodePosY = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.nudNodePosY = new UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown();
            this.lblNodePosX = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.nudNodePosZ = new UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown();
            this.lblNodePos = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.lblNodePosZ = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.nudNodePosX = new UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown();
            this.txtNodeFilename = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            this.lblObjectType = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.txtNodeType = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            this.lblNodeCellName = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.txtNodeCellName = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            this.lblNodeParentId = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.txtNodeParentId = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            this.lblNodeRadius = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.txtNodeId = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            this.nudNodeRadius = new UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown();
            this.lblObjFile = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.lblNodeId = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.lblNodeAxisY = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.nudNodeRotY = new UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown();
            this.nudNodeRotZ = new UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown();
            this.lblNodeAxisX = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.lblNodeAxisZ = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.lblNodeAxis = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.nudNodeRotX = new UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown();
            this.lblId = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
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
            this.btnReloadSnapshot.DrawOutline = false;
            this.btnReloadSnapshot.Enabled = false;
            this.btnReloadSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReloadSnapshot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReloadSnapshot.Location = new System.Drawing.Point(165, 30);
            this.btnReloadSnapshot.Name = "btnReloadSnapshot";
            this.btnReloadSnapshot.Size = new System.Drawing.Size(75, 20);
            this.btnReloadSnapshot.TabIndex = 331;
            this.btnReloadSnapshot.Text = "Reload";
            this.btnReloadSnapshot.UseDisableColor = true;
            this.btnReloadSnapshot.UseVisualStyleBackColor = false;
            this.btnReloadSnapshot.Click += new System.EventHandler(this.btnReloadSnapshot_Click);
            // 
            // btnLoadSnapshot
            // 
            this.btnLoadSnapshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLoadSnapshot.DrawOutline = false;
            this.btnLoadSnapshot.Enabled = false;
            this.btnLoadSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadSnapshot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadSnapshot.Location = new System.Drawing.Point(3, 30);
            this.btnLoadSnapshot.Name = "btnLoadSnapshot";
            this.btnLoadSnapshot.Size = new System.Drawing.Size(75, 20);
            this.btnLoadSnapshot.TabIndex = 330;
            this.btnLoadSnapshot.Text = "Load";
            this.btnLoadSnapshot.UseDisableColor = true;
            this.btnLoadSnapshot.UseVisualStyleBackColor = false;
            this.btnLoadSnapshot.Click += new System.EventHandler(this.btnLoadSnapshot_Click);
            // 
            // cmbSnapshots
            // 
            this.cmbSnapshots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbSnapshots.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSnapshots.DrawOutline = true;
            this.cmbSnapshots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSnapshots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSnapshots.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSnapshots.FormattingEnabled = true;
            this.cmbSnapshots.Location = new System.Drawing.Point(3, 3);
            this.cmbSnapshots.Name = "cmbSnapshots";
            this.cmbSnapshots.Size = new System.Drawing.Size(237, 21);
            this.cmbSnapshots.TabIndex = 328;
            // 
            // btnUnloadSnapshot
            // 
            this.btnUnloadSnapshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUnloadSnapshot.DrawOutline = false;
            this.btnUnloadSnapshot.Enabled = false;
            this.btnUnloadSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnloadSnapshot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUnloadSnapshot.Location = new System.Drawing.Point(84, 30);
            this.btnUnloadSnapshot.Name = "btnUnloadSnapshot";
            this.btnUnloadSnapshot.Size = new System.Drawing.Size(75, 20);
            this.btnUnloadSnapshot.TabIndex = 332;
            this.btnUnloadSnapshot.Text = "Unload";
            this.btnUnloadSnapshot.UseDisableColor = true;
            this.btnUnloadSnapshot.UseVisualStyleBackColor = false;
            this.btnUnloadSnapshot.Click += new System.EventHandler(this.btnUnloadSnapshot_Click);
            // 
            // btnSaveSnapshot
            // 
            this.btnSaveSnapshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSaveSnapshot.DrawOutline = false;
            this.btnSaveSnapshot.Enabled = false;
            this.btnSaveSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveSnapshot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveSnapshot.Location = new System.Drawing.Point(246, 3);
            this.btnSaveSnapshot.Name = "btnSaveSnapshot";
            this.btnSaveSnapshot.Size = new System.Drawing.Size(75, 20);
            this.btnSaveSnapshot.TabIndex = 333;
            this.btnSaveSnapshot.Text = "Save";
            this.btnSaveSnapshot.UseDisableColor = true;
            this.btnSaveSnapshot.UseVisualStyleBackColor = false;
            this.btnSaveSnapshot.Click += new System.EventHandler(this.btnSaveSnapshot_Click);
            // 
            // btnAddNode
            // 
            this.btnAddNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddNode.DrawOutline = false;
            this.btnAddNode.Enabled = false;
            this.btnAddNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddNode.Location = new System.Drawing.Point(3, 97);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(75, 20);
            this.btnAddNode.TabIndex = 334;
            this.btnAddNode.Text = "Add Node";
            this.btnAddNode.UseDisableColor = true;
            this.btnAddNode.UseVisualStyleBackColor = false;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddSnapshotNode_Click);
            // 
            // btnRemoveSelectedNode
            // 
            this.btnRemoveSelectedNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRemoveSelectedNode.DrawOutline = false;
            this.btnRemoveSelectedNode.Enabled = false;
            this.btnRemoveSelectedNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveSelectedNode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveSelectedNode.Location = new System.Drawing.Point(339, 292);
            this.btnRemoveSelectedNode.Name = "btnRemoveSelectedNode";
            this.btnRemoveSelectedNode.Size = new System.Drawing.Size(75, 20);
            this.btnRemoveSelectedNode.TabIndex = 335;
            this.btnRemoveSelectedNode.Text = "Remove";
            this.btnRemoveSelectedNode.UseDisableColor = true;
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
            this.chkEnableNodeEditing.DrawOutline = false;
            this.chkEnableNodeEditing.Location = new System.Drawing.Point(249, 100);
            this.chkEnableNodeEditing.Name = "chkEnableNodeEditing";
            this.chkEnableNodeEditing.Size = new System.Drawing.Size(161, 17);
            this.chkEnableNodeEditing.TabIndex = 344;
            this.chkEnableNodeEditing.Text = "Enable node editing";
            this.chkEnableNodeEditing.UseVisualStyleBackColor = true;
            this.chkEnableNodeEditing.CheckedChanged += new System.EventHandler(this.chkEnableNodeEditing_CheckedChanged);
            // 
            // lblSelectedNode
            // 
            this.lblSelectedNode.AutoSize = true;
            this.lblSelectedNode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSelectedNode.Location = new System.Drawing.Point(0, 133);
            this.lblSelectedNode.Name = "lblSelectedNode";
            this.lblSelectedNode.Size = new System.Drawing.Size(78, 13);
            this.lblSelectedNode.TabIndex = 349;
            this.lblSelectedNode.Text = "Selected Node";
            // 
            // lblNodePosY
            // 
            this.lblNodePosY.AutoSize = true;
            this.lblNodePosY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNodePosY.Location = new System.Drawing.Point(146, 270);
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
            this.nudNodePosY.DrawOutline = false;
            this.nudNodePosY.Enabled = false;
            this.nudNodePosY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudNodePosY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudNodePosY.Location = new System.Drawing.Point(160, 268);
            this.nudNodePosY.Margin = new System.Windows.Forms.Padding(0);
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
            this.lblNodePosX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNodePosX.Location = new System.Drawing.Point(56, 270);
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
            this.nudNodePosZ.DrawOutline = false;
            this.nudNodePosZ.Enabled = false;
            this.nudNodePosZ.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudNodePosZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudNodePosZ.Location = new System.Drawing.Point(250, 268);
            this.nudNodePosZ.Margin = new System.Windows.Forms.Padding(0);
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
            this.lblNodePos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNodePos.Location = new System.Drawing.Point(4, 270);
            this.lblNodePos.Name = "lblNodePos";
            this.lblNodePos.Size = new System.Drawing.Size(44, 13);
            this.lblNodePos.TabIndex = 351;
            this.lblNodePos.Text = "Position";
            // 
            // lblNodePosZ
            // 
            this.lblNodePosZ.AutoSize = true;
            this.lblNodePosZ.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNodePosZ.Location = new System.Drawing.Point(236, 270);
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
            this.nudNodePosX.DrawOutline = false;
            this.nudNodePosX.Enabled = false;
            this.nudNodePosX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudNodePosX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudNodePosX.Location = new System.Drawing.Point(70, 268);
            this.nudNodePosX.Margin = new System.Windows.Forms.Padding(0);
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
            this.txtNodeFilename.Location = new System.Drawing.Point(5, 201);
            this.txtNodeFilename.Name = "txtNodeFilename";
            this.txtNodeFilename.ReadOnly = true;
            this.txtNodeFilename.Size = new System.Drawing.Size(406, 20);
            this.txtNodeFilename.TabIndex = 357;
            // 
            // lblObjectType
            // 
            this.lblObjectType.AutoSize = true;
            this.lblObjectType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblObjectType.Location = new System.Drawing.Point(4, 224);
            this.lblObjectType.Name = "lblObjectType";
            this.lblObjectType.Size = new System.Drawing.Size(65, 13);
            this.lblObjectType.TabIndex = 360;
            this.lblObjectType.Text = "Object Type";
            // 
            // txtNodeType
            // 
            this.txtNodeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNodeType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNodeType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNodeType.Location = new System.Drawing.Point(5, 242);
            this.txtNodeType.Name = "txtNodeType";
            this.txtNodeType.ReadOnly = true;
            this.txtNodeType.Size = new System.Drawing.Size(406, 20);
            this.txtNodeType.TabIndex = 359;
            // 
            // lblNodeCellName
            // 
            this.lblNodeCellName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNodeCellName.AutoSize = true;
            this.lblNodeCellName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNodeCellName.Location = new System.Drawing.Point(184, 177);
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
            this.txtNodeCellName.Location = new System.Drawing.Point(242, 175);
            this.txtNodeCellName.Name = "txtNodeCellName";
            this.txtNodeCellName.ReadOnly = true;
            this.txtNodeCellName.Size = new System.Drawing.Size(170, 20);
            this.txtNodeCellName.TabIndex = 390;
            // 
            // lblNodeParentId
            // 
            this.lblNodeParentId.AutoSize = true;
            this.lblNodeParentId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNodeParentId.Location = new System.Drawing.Point(84, 152);
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
            this.txtNodeParentId.Location = new System.Drawing.Point(136, 149);
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
            this.lblNodeRadius.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNodeRadius.Location = new System.Drawing.Point(304, 152);
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
            this.txtNodeId.Location = new System.Drawing.Point(21, 149);
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
            this.nudNodeRadius.DrawOutline = false;
            this.nudNodeRadius.Enabled = false;
            this.nudNodeRadius.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudNodeRadius.Location = new System.Drawing.Point(349, 149);
            this.nudNodeRadius.Margin = new System.Windows.Forms.Padding(0);
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
            this.lblObjFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblObjFile.Location = new System.Drawing.Point(4, 183);
            this.lblObjFile.Name = "lblObjFile";
            this.lblObjFile.Size = new System.Drawing.Size(83, 13);
            this.lblObjFile.TabIndex = 381;
            this.lblObjFile.Text = "Object Filename";
            // 
            // lblNodeId
            // 
            this.lblNodeId.AutoSize = true;
            this.lblNodeId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNodeId.Location = new System.Drawing.Point(4, 182);
            this.lblNodeId.Name = "lblNodeId";
            this.lblNodeId.Size = new System.Drawing.Size(18, 13);
            this.lblNodeId.TabIndex = 384;
            this.lblNodeId.Text = "ID";
            // 
            // lblNodeAxisY
            // 
            this.lblNodeAxisY.AutoSize = true;
            this.lblNodeAxisY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNodeAxisY.Location = new System.Drawing.Point(146, 296);
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
            this.nudNodeRotY.DrawOutline = false;
            this.nudNodeRotY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudNodeRotY.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudNodeRotY.Location = new System.Drawing.Point(160, 294);
            this.nudNodeRotY.Margin = new System.Windows.Forms.Padding(0);
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
            this.nudNodeRotZ.DrawOutline = false;
            this.nudNodeRotZ.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudNodeRotZ.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudNodeRotZ.Location = new System.Drawing.Point(250, 294);
            this.nudNodeRotZ.Margin = new System.Windows.Forms.Padding(0);
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
            this.lblNodeAxisX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNodeAxisX.Location = new System.Drawing.Point(56, 296);
            this.lblNodeAxisX.Name = "lblNodeAxisX";
            this.lblNodeAxisX.Size = new System.Drawing.Size(14, 13);
            this.lblNodeAxisX.TabIndex = 394;
            this.lblNodeAxisX.Text = "X";
            // 
            // lblNodeAxisZ
            // 
            this.lblNodeAxisZ.AutoSize = true;
            this.lblNodeAxisZ.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNodeAxisZ.Location = new System.Drawing.Point(236, 296);
            this.lblNodeAxisZ.Name = "lblNodeAxisZ";
            this.lblNodeAxisZ.Size = new System.Drawing.Size(14, 13);
            this.lblNodeAxisZ.TabIndex = 398;
            this.lblNodeAxisZ.Text = "Z";
            // 
            // lblNodeAxis
            // 
            this.lblNodeAxis.AutoSize = true;
            this.lblNodeAxis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNodeAxis.Location = new System.Drawing.Point(4, 296);
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
            this.nudNodeRotX.DrawOutline = false;
            this.nudNodeRotX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudNodeRotX.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudNodeRotX.Location = new System.Drawing.Point(70, 294);
            this.nudNodeRotX.Margin = new System.Windows.Forms.Padding(0);
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
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblId.Location = new System.Drawing.Point(3, 152);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 399;
            this.lblId.Text = "ID";
            // 
            // SnapshotPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblId);
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
            this.Controls.Add(this.lblObjectType);
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
            this.Size = new System.Drawing.Size(417, 323);
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
        private UtinniCoreDotNet.UI.Controls.UtinniComboBox cmbSnapshots;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnUnloadSnapshot;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnSaveSnapshot;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnAddNode;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnRemoveSelectedNode;
        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtNewNodeFilename;
        private UtinniCoreDotNet.UI.Controls.UtinniToggle chkEnableNodeEditing;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblSelectedNode;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblNodePosY;
        private UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudNodePosY;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblNodePosX;
        private UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudNodePosZ;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblNodePos;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblNodePosZ;
        private UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudNodePosX;
        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtNodeFilename;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblObjectType;
        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtNodeType;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblNodeCellName;
        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtNodeCellName;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblNodeParentId;
        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtNodeParentId;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblNodeRadius;
        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtNodeId;
        private UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudNodeRadius;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblObjFile;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblNodeId;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblNodeAxisY;
        private UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudNodeRotY;
        private UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudNodeRotZ;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblNodeAxisX;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblNodeAxisZ;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblNodeAxis;
        private UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudNodeRotX;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblId;
    }
}
