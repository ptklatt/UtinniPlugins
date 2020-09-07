namespace TJT.UI.SubPanels
{
    partial class ScenePanel
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
            this.txtAvatarObjectFilename = new System.Windows.Forms.TextBox();
            this.cmbScenes = new System.Windows.Forms.ComboBox();
            this.lblScene = new System.Windows.Forms.Label();
            this.btnLoadScene = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnReloadScene = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnReloadSnapshot = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnLoadSnapshot = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.lblSnapshot = new System.Windows.Forms.Label();
            this.cmbSnapshots = new System.Windows.Forms.ComboBox();
            this.btnUnloadSnapshot = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnSaveSnapshot = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.BtnAddSnapshotNode = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnRemoveSnapshotNode = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.txtSnapshotNodeFilename = new System.Windows.Forms.TextBox();
            this.chkAllowTargetEverything = new System.Windows.Forms.CheckBox();
            this.nudWeatherIndex = new System.Windows.Forms.NumericUpDown();
            this.lblWeatherIndex = new System.Windows.Forms.Label();
            this.trkbTimeOfDay = new System.Windows.Forms.TrackBar();
            this.lblTimeOfDay = new System.Windows.Forms.Label();
            this.btnUnloadScene = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeatherIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbTimeOfDay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAvatarObjectFilename
            // 
            this.txtAvatarObjectFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAvatarObjectFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAvatarObjectFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAvatarObjectFilename.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAvatarObjectFilename.Location = new System.Drawing.Point(3, 3);
            this.txtAvatarObjectFilename.Name = "txtAvatarObjectFilename";
            this.txtAvatarObjectFilename.ReadOnly = true;
            this.txtAvatarObjectFilename.Size = new System.Drawing.Size(411, 20);
            this.txtAvatarObjectFilename.TabIndex = 323;
            this.txtAvatarObjectFilename.Text = "object/creature/player/shared_human_male.iff";
            // 
            // cmbScenes
            // 
            this.cmbScenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbScenes.FormattingEnabled = true;
            this.cmbScenes.Location = new System.Drawing.Point(3, 29);
            this.cmbScenes.Name = "cmbScenes";
            this.cmbScenes.Size = new System.Drawing.Size(237, 21);
            this.cmbScenes.TabIndex = 324;
            // 
            // lblScene
            // 
            this.lblScene.AutoSize = true;
            this.lblScene.Location = new System.Drawing.Point(246, 32);
            this.lblScene.Name = "lblScene";
            this.lblScene.Size = new System.Drawing.Size(40, 13);
            this.lblScene.TabIndex = 325;
            this.lblScene.Text = "Terrain";
            // 
            // btnLoadScene
            // 
            this.btnLoadScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLoadScene.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadScene.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadScene.Location = new System.Drawing.Point(3, 56);
            this.btnLoadScene.Name = "btnLoadScene";
            this.btnLoadScene.Size = new System.Drawing.Size(75, 23);
            this.btnLoadScene.TabIndex = 326;
            this.btnLoadScene.Text = "Load";
            this.btnLoadScene.UseVisualStyleBackColor = false;
            this.btnLoadScene.Click += new System.EventHandler(this.btnLoadScene_Click);
            // 
            // btnReloadScene
            // 
            this.btnReloadScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReloadScene.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReloadScene.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReloadScene.Location = new System.Drawing.Point(165, 56);
            this.btnReloadScene.Name = "btnReloadScene";
            this.btnReloadScene.Size = new System.Drawing.Size(75, 23);
            this.btnReloadScene.TabIndex = 327;
            this.btnReloadScene.Text = "Reload";
            this.btnReloadScene.UseVisualStyleBackColor = false;
            this.btnReloadScene.Click += new System.EventHandler(this.btnReloadScene_Click);
            // 
            // btnReloadSnapshot
            // 
            this.btnReloadSnapshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReloadSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReloadSnapshot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReloadSnapshot.Location = new System.Drawing.Point(165, 124);
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
            this.btnLoadSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadSnapshot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadSnapshot.Location = new System.Drawing.Point(3, 124);
            this.btnLoadSnapshot.Name = "btnLoadSnapshot";
            this.btnLoadSnapshot.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSnapshot.TabIndex = 330;
            this.btnLoadSnapshot.Text = "Load";
            this.btnLoadSnapshot.UseVisualStyleBackColor = false;
            this.btnLoadSnapshot.Click += new System.EventHandler(this.btnLoadSnapshot_Click);
            // 
            // lblSnapshot
            // 
            this.lblSnapshot.AutoSize = true;
            this.lblSnapshot.Location = new System.Drawing.Point(246, 100);
            this.lblSnapshot.Name = "lblSnapshot";
            this.lblSnapshot.Size = new System.Drawing.Size(52, 13);
            this.lblSnapshot.TabIndex = 329;
            this.lblSnapshot.Text = "Snapshot";
            // 
            // cmbSnapshots
            // 
            this.cmbSnapshots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSnapshots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSnapshots.FormattingEnabled = true;
            this.cmbSnapshots.Location = new System.Drawing.Point(3, 97);
            this.cmbSnapshots.Name = "cmbSnapshots";
            this.cmbSnapshots.Size = new System.Drawing.Size(237, 21);
            this.cmbSnapshots.TabIndex = 328;
            // 
            // btnUnloadSnapshot
            // 
            this.btnUnloadSnapshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUnloadSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnloadSnapshot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUnloadSnapshot.Location = new System.Drawing.Point(84, 124);
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
            this.btnSaveSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveSnapshot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveSnapshot.Location = new System.Drawing.Point(336, 95);
            this.btnSaveSnapshot.Name = "btnSaveSnapshot";
            this.btnSaveSnapshot.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSnapshot.TabIndex = 333;
            this.btnSaveSnapshot.Text = "Save";
            this.btnSaveSnapshot.UseVisualStyleBackColor = false;
            this.btnSaveSnapshot.Click += new System.EventHandler(this.btnSaveSnapshot_Click);
            // 
            // BtnAddSnapshotNode
            // 
            this.BtnAddSnapshotNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnAddSnapshotNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddSnapshotNode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAddSnapshotNode.Location = new System.Drawing.Point(3, 179);
            this.BtnAddSnapshotNode.Name = "BtnAddSnapshotNode";
            this.BtnAddSnapshotNode.Size = new System.Drawing.Size(109, 23);
            this.BtnAddSnapshotNode.TabIndex = 334;
            this.BtnAddSnapshotNode.Text = "Add Node";
            this.BtnAddSnapshotNode.UseVisualStyleBackColor = false;
            this.BtnAddSnapshotNode.Click += new System.EventHandler(this.BtnAddSnapshotNode_Click);
            // 
            // btnRemoveSnapshotNode
            // 
            this.btnRemoveSnapshotNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRemoveSnapshotNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveSnapshotNode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveSnapshotNode.Location = new System.Drawing.Point(118, 179);
            this.btnRemoveSnapshotNode.Name = "btnRemoveSnapshotNode";
            this.btnRemoveSnapshotNode.Size = new System.Drawing.Size(109, 23);
            this.btnRemoveSnapshotNode.TabIndex = 335;
            this.btnRemoveSnapshotNode.Text = "Remove Node";
            this.btnRemoveSnapshotNode.UseVisualStyleBackColor = false;
            this.btnRemoveSnapshotNode.Click += new System.EventHandler(this.btnRemoveSnapshotNode_Click);
            // 
            // txtSnapshotNodeFilename
            // 
            this.txtSnapshotNodeFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSnapshotNodeFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSnapshotNodeFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSnapshotNodeFilename.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSnapshotNodeFilename.Location = new System.Drawing.Point(3, 153);
            this.txtSnapshotNodeFilename.Name = "txtSnapshotNodeFilename";
            this.txtSnapshotNodeFilename.ReadOnly = true;
            this.txtSnapshotNodeFilename.Size = new System.Drawing.Size(411, 20);
            this.txtSnapshotNodeFilename.TabIndex = 336;
            this.txtSnapshotNodeFilename.Text = "object/tangible/furniture/cheap/shared_armoire_s01.iff";
            // 
            // chkAllowTargetEverything
            // 
            this.chkAllowTargetEverything.AutoSize = true;
            this.chkAllowTargetEverything.Location = new System.Drawing.Point(3, 278);
            this.chkAllowTargetEverything.Name = "chkAllowTargetEverything";
            this.chkAllowTargetEverything.Size = new System.Drawing.Size(133, 17);
            this.chkAllowTargetEverything.TabIndex = 337;
            this.chkAllowTargetEverything.Text = "Allow target everything";
            this.chkAllowTargetEverything.UseVisualStyleBackColor = true;
            this.chkAllowTargetEverything.CheckedChanged += new System.EventHandler(this.chkAllowTargetEverything_CheckedChanged);
            // 
            // nudWeatherIndex
            // 
            this.nudWeatherIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudWeatherIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudWeatherIndex.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudWeatherIndex.Location = new System.Drawing.Point(3, 208);
            this.nudWeatherIndex.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWeatherIndex.Name = "nudWeatherIndex";
            this.nudWeatherIndex.Size = new System.Drawing.Size(77, 20);
            this.nudWeatherIndex.TabIndex = 339;
            this.nudWeatherIndex.TabStop = false;
            this.nudWeatherIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudWeatherIndex.ValueChanged += new System.EventHandler(this.nudWeatherIndex_ValueChanged);
            // 
            // lblWeatherIndex
            // 
            this.lblWeatherIndex.AutoSize = true;
            this.lblWeatherIndex.Location = new System.Drawing.Point(86, 210);
            this.lblWeatherIndex.Name = "lblWeatherIndex";
            this.lblWeatherIndex.Size = new System.Drawing.Size(76, 13);
            this.lblWeatherIndex.TabIndex = 340;
            this.lblWeatherIndex.Text = "Weather index";
            // 
            // trkbTimeOfDay
            // 
            this.trkbTimeOfDay.LargeChange = 1;
            this.trkbTimeOfDay.Location = new System.Drawing.Point(3, 234);
            this.trkbTimeOfDay.Maximum = 1000;
            this.trkbTimeOfDay.Name = "trkbTimeOfDay";
            this.trkbTimeOfDay.Size = new System.Drawing.Size(160, 45);
            this.trkbTimeOfDay.TabIndex = 341;
            this.trkbTimeOfDay.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkbTimeOfDay.Scroll += new System.EventHandler(this.trkbTimeOfDay_Scroll);
            // 
            // lblTimeOfDay
            // 
            this.lblTimeOfDay.AutoSize = true;
            this.lblTimeOfDay.Location = new System.Drawing.Point(169, 234);
            this.lblTimeOfDay.Name = "lblTimeOfDay";
            this.lblTimeOfDay.Size = new System.Drawing.Size(64, 13);
            this.lblTimeOfDay.TabIndex = 342;
            this.lblTimeOfDay.Text = "Time of Day";
            // 
            // btnUnloadScene
            // 
            this.btnUnloadScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUnloadScene.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnloadScene.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUnloadScene.Location = new System.Drawing.Point(84, 56);
            this.btnUnloadScene.Name = "btnUnloadScene";
            this.btnUnloadScene.Size = new System.Drawing.Size(75, 23);
            this.btnUnloadScene.TabIndex = 343;
            this.btnUnloadScene.Text = "Unlaod";
            this.btnUnloadScene.UseVisualStyleBackColor = false;
            this.btnUnloadScene.Click += new System.EventHandler(this.btnUnloadScene_Click);
            // 
            // ScenePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUnloadScene);
            this.Controls.Add(this.lblTimeOfDay);
            this.Controls.Add(this.trkbTimeOfDay);
            this.Controls.Add(this.lblWeatherIndex);
            this.Controls.Add(this.nudWeatherIndex);
            this.Controls.Add(this.chkAllowTargetEverything);
            this.Controls.Add(this.txtSnapshotNodeFilename);
            this.Controls.Add(this.btnRemoveSnapshotNode);
            this.Controls.Add(this.BtnAddSnapshotNode);
            this.Controls.Add(this.btnSaveSnapshot);
            this.Controls.Add(this.btnUnloadSnapshot);
            this.Controls.Add(this.btnReloadSnapshot);
            this.Controls.Add(this.btnLoadSnapshot);
            this.Controls.Add(this.lblSnapshot);
            this.Controls.Add(this.cmbSnapshots);
            this.Controls.Add(this.btnReloadScene);
            this.Controls.Add(this.btnLoadScene);
            this.Controls.Add(this.lblScene);
            this.Controls.Add(this.cmbScenes);
            this.Controls.Add(this.txtAvatarObjectFilename);
            this.Name = "ScenePanel";
            this.Size = new System.Drawing.Size(417, 304);
            ((System.ComponentModel.ISupportInitialize)(this.nudWeatherIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbTimeOfDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAvatarObjectFilename;
        private System.Windows.Forms.ComboBox cmbScenes;
        private System.Windows.Forms.Label lblScene;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnLoadScene;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnReloadScene;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnReloadSnapshot;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnLoadSnapshot;
        private System.Windows.Forms.Label lblSnapshot;
        private System.Windows.Forms.ComboBox cmbSnapshots;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnUnloadSnapshot;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnSaveSnapshot;
        private UtinniCoreDotNet.UI.Controls.UtinniButton BtnAddSnapshotNode;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnRemoveSnapshotNode;
        private System.Windows.Forms.TextBox txtSnapshotNodeFilename;
        private System.Windows.Forms.CheckBox chkAllowTargetEverything;
        internal System.Windows.Forms.NumericUpDown nudWeatherIndex;
        private System.Windows.Forms.Label lblWeatherIndex;
        private System.Windows.Forms.TrackBar trkbTimeOfDay;
        private System.Windows.Forms.Label lblTimeOfDay;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnUnloadScene;
    }
}
