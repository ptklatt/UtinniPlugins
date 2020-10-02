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
            this.btnLoadScene = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnReloadScene = new UtinniCoreDotNet.UI.Controls.UtinniButton();
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
            // btnLoadScene
            // 
            this.btnLoadScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLoadScene.Enabled = false;
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
            this.btnReloadScene.Enabled = false;
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
            // chkAllowTargetEverything
            // 
            this.chkAllowTargetEverything.AutoSize = true;
            this.chkAllowTargetEverything.Location = new System.Drawing.Point(3, 155);
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
            this.nudWeatherIndex.Enabled = false;
            this.nudWeatherIndex.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudWeatherIndex.Location = new System.Drawing.Point(3, 85);
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
            this.lblWeatherIndex.Location = new System.Drawing.Point(86, 87);
            this.lblWeatherIndex.Name = "lblWeatherIndex";
            this.lblWeatherIndex.Size = new System.Drawing.Size(76, 13);
            this.lblWeatherIndex.TabIndex = 340;
            this.lblWeatherIndex.Text = "Weather index";
            // 
            // trkbTimeOfDay
            // 
            this.trkbTimeOfDay.Enabled = false;
            this.trkbTimeOfDay.LargeChange = 1;
            this.trkbTimeOfDay.Location = new System.Drawing.Point(3, 111);
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
            this.lblTimeOfDay.Location = new System.Drawing.Point(169, 111);
            this.lblTimeOfDay.Name = "lblTimeOfDay";
            this.lblTimeOfDay.Size = new System.Drawing.Size(64, 13);
            this.lblTimeOfDay.TabIndex = 342;
            this.lblTimeOfDay.Text = "Time of Day";
            // 
            // btnUnloadScene
            // 
            this.btnUnloadScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUnloadScene.Enabled = false;
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
            this.Controls.Add(this.btnReloadScene);
            this.Controls.Add(this.btnLoadScene);
            this.Controls.Add(this.cmbScenes);
            this.Controls.Add(this.txtAvatarObjectFilename);
            this.Name = "ScenePanel";
            this.Size = new System.Drawing.Size(417, 189);
            ((System.ComponentModel.ISupportInitialize)(this.nudWeatherIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbTimeOfDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAvatarObjectFilename;
        private System.Windows.Forms.ComboBox cmbScenes;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnLoadScene;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnReloadScene;
        private System.Windows.Forms.CheckBox chkAllowTargetEverything;
        internal System.Windows.Forms.NumericUpDown nudWeatherIndex;
        private System.Windows.Forms.Label lblWeatherIndex;
        private System.Windows.Forms.TrackBar trkbTimeOfDay;
        private System.Windows.Forms.Label lblTimeOfDay;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnUnloadScene;
    }
}
