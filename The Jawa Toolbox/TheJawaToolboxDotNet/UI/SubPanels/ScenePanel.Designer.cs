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
            this.sldTimeOfDay = new UtinniCoreDotNet.UI.Controls.UtinniSlider();
            this.btnUnloadScene = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.lblWeatherIndex = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.nudWeatherIndex = new UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown();
            this.chkAllowTargetEverything = new UtinniCoreDotNet.UI.Controls.UtinniToggle();
            this.btnReloadScene = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnLoadScene = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.cmbScenes = new UtinniCoreDotNet.UI.Controls.UtinniComboBox();
            this.txtAvatarObjectFilename = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeatherIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // sldTimeOfDay
            // 
            this.sldTimeOfDay.DrawOutline = false;
            this.sldTimeOfDay.Location = new System.Drawing.Point(3, 114);
            this.sldTimeOfDay.Maximum = 100F;
            this.sldTimeOfDay.MaximumSize = new System.Drawing.Size(100000, 20);
            this.sldTimeOfDay.Minimum = 0F;
            this.sldTimeOfDay.Name = "sldTimeOfDay";
            this.sldTimeOfDay.Size = new System.Drawing.Size(174, 20);
            this.sldTimeOfDay.TabIndex = 344;
            this.sldTimeOfDay.Text = "Time of Day";
            this.sldTimeOfDay.Value = 0F;
            this.sldTimeOfDay.ValueChanged += new System.EventHandler(this.sldTimeOfDay_ValueChanged);
            // 
            // btnUnloadScene
            // 
            this.btnUnloadScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUnloadScene.DrawOutline = false;
            this.btnUnloadScene.Enabled = false;
            this.btnUnloadScene.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnloadScene.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUnloadScene.Location = new System.Drawing.Point(84, 56);
            this.btnUnloadScene.Name = "btnUnloadScene";
            this.btnUnloadScene.Size = new System.Drawing.Size(75, 20);
            this.btnUnloadScene.TabIndex = 343;
            this.btnUnloadScene.Text = "Unlaod";
            this.btnUnloadScene.UseDisableColor = true;
            this.btnUnloadScene.UseVisualStyleBackColor = false;
            this.btnUnloadScene.Click += new System.EventHandler(this.btnUnloadScene_Click);
            // 
            // lblWeatherIndex
            // 
            this.lblWeatherIndex.AutoSize = true;
            this.lblWeatherIndex.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWeatherIndex.Location = new System.Drawing.Point(86, 87);
            this.lblWeatherIndex.Name = "lblWeatherIndex";
            this.lblWeatherIndex.Size = new System.Drawing.Size(76, 13);
            this.lblWeatherIndex.TabIndex = 340;
            this.lblWeatherIndex.Text = "Weather index";
            // 
            // nudWeatherIndex
            // 
            this.nudWeatherIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudWeatherIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudWeatherIndex.DrawOutline = false;
            this.nudWeatherIndex.Enabled = false;
            this.nudWeatherIndex.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudWeatherIndex.Location = new System.Drawing.Point(3, 85);
            this.nudWeatherIndex.Margin = new System.Windows.Forms.Padding(0);
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
            // chkAllowTargetEverything
            // 
            this.chkAllowTargetEverything.DrawOutline = false;
            this.chkAllowTargetEverything.Location = new System.Drawing.Point(3, 140);
            this.chkAllowTargetEverything.Name = "chkAllowTargetEverything";
            this.chkAllowTargetEverything.Size = new System.Drawing.Size(174, 17);
            this.chkAllowTargetEverything.TabIndex = 337;
            this.chkAllowTargetEverything.Text = "Allow target everything";
            this.chkAllowTargetEverything.UseVisualStyleBackColor = true;
            this.chkAllowTargetEverything.CheckedChanged += new System.EventHandler(this.chkAllowTargetEverything_CheckedChanged);
            // 
            // btnReloadScene
            // 
            this.btnReloadScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReloadScene.DrawOutline = false;
            this.btnReloadScene.Enabled = false;
            this.btnReloadScene.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReloadScene.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReloadScene.Location = new System.Drawing.Point(165, 56);
            this.btnReloadScene.Name = "btnReloadScene";
            this.btnReloadScene.Size = new System.Drawing.Size(75, 20);
            this.btnReloadScene.TabIndex = 327;
            this.btnReloadScene.Text = "Reload";
            this.btnReloadScene.UseDisableColor = true;
            this.btnReloadScene.UseVisualStyleBackColor = false;
            this.btnReloadScene.Click += new System.EventHandler(this.btnReloadScene_Click);
            // 
            // btnLoadScene
            // 
            this.btnLoadScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLoadScene.DrawOutline = false;
            this.btnLoadScene.Enabled = false;
            this.btnLoadScene.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadScene.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadScene.Location = new System.Drawing.Point(3, 56);
            this.btnLoadScene.Name = "btnLoadScene";
            this.btnLoadScene.Size = new System.Drawing.Size(75, 20);
            this.btnLoadScene.TabIndex = 326;
            this.btnLoadScene.Text = "Load";
            this.btnLoadScene.UseDisableColor = true;
            this.btnLoadScene.UseVisualStyleBackColor = false;
            this.btnLoadScene.Click += new System.EventHandler(this.btnLoadScene_Click);
            // 
            // cmbScenes
            // 
            this.cmbScenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbScenes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbScenes.DrawOutline = true;
            this.cmbScenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbScenes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbScenes.FormattingEnabled = true;
            this.cmbScenes.Location = new System.Drawing.Point(3, 29);
            this.cmbScenes.Name = "cmbScenes";
            this.cmbScenes.Size = new System.Drawing.Size(237, 21);
            this.cmbScenes.TabIndex = 324;
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
            // ScenePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sldTimeOfDay);
            this.Controls.Add(this.btnUnloadScene);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtAvatarObjectFilename;
        private UtinniCoreDotNet.UI.Controls.UtinniComboBox cmbScenes;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnLoadScene;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnReloadScene;
        private UtinniCoreDotNet.UI.Controls.UtinniToggle chkAllowTargetEverything;
        internal UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudWeatherIndex;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblWeatherIndex;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnUnloadScene;
        private UtinniCoreDotNet.UI.Controls.UtinniSlider sldTimeOfDay;
    }
}
