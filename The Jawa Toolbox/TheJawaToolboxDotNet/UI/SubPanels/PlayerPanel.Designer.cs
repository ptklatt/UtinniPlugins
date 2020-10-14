namespace TJT.UI.SubPanels
{
    partial class PlayerPanel
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
            this.nudZ = new UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown();
            this.nudY = new UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown();
            this.nudX = new UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown();
            this.btnTeleport = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.nudSpeed = new UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown();
            this.btnToggleModel = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnToggleFreeCam = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnResetSpeed = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.lblCamera = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.lblPlayer = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.txtCameraCell = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            this.txtPlayerCell = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            this.lblCameraCell = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.lblPlayerCell = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.utinniButton1 = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.numericUpDown1 = new UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown();
            this.sldSpeed = new UtinniCoreDotNet.UI.Controls.UtinniSlider();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudZ
            // 
            this.nudZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudZ.DecimalPlaces = 3;
            this.nudZ.DrawOutline = false;
            this.nudZ.Enabled = false;
            this.nudZ.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudZ.Location = new System.Drawing.Point(169, 70);
            this.nudZ.Margin = new System.Windows.Forms.Padding(0);
            this.nudZ.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudZ.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.nudZ.Name = "nudZ";
            this.nudZ.Size = new System.Drawing.Size(77, 20);
            this.nudZ.TabIndex = 34;
            this.nudZ.TabStop = false;
            this.nudZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudY
            // 
            this.nudY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudY.DecimalPlaces = 3;
            this.nudY.DrawOutline = false;
            this.nudY.Enabled = false;
            this.nudY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudY.Location = new System.Drawing.Point(86, 70);
            this.nudY.Margin = new System.Windows.Forms.Padding(0);
            this.nudY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudY.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(77, 20);
            this.nudY.TabIndex = 33;
            this.nudY.TabStop = false;
            this.nudY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudX
            // 
            this.nudX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudX.DecimalPlaces = 3;
            this.nudX.DrawOutline = false;
            this.nudX.Enabled = false;
            this.nudX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudX.Location = new System.Drawing.Point(3, 70);
            this.nudX.Margin = new System.Windows.Forms.Padding(0);
            this.nudX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudX.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(77, 20);
            this.nudX.TabIndex = 32;
            this.nudX.TabStop = false;
            this.nudX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTeleport
            // 
            this.btnTeleport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTeleport.DrawOutline = false;
            this.btnTeleport.Enabled = false;
            this.btnTeleport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeleport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTeleport.Location = new System.Drawing.Point(252, 70);
            this.btnTeleport.Name = "btnTeleport";
            this.btnTeleport.Size = new System.Drawing.Size(75, 20);
            this.btnTeleport.TabIndex = 35;
            this.btnTeleport.Text = "Teleport";
            this.btnTeleport.UseDisableColor = true;
            this.btnTeleport.UseVisualStyleBackColor = false;
            this.btnTeleport.Click += new System.EventHandler(this.btnTeleport_Click);
            // 
            // nudSpeed
            // 
            this.nudSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSpeed.DecimalPlaces = 3;
            this.nudSpeed.DrawOutline = false;
            this.nudSpeed.Enabled = false;
            this.nudSpeed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudSpeed.Location = new System.Drawing.Point(166, 28);
            this.nudSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.nudSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(77, 20);
            this.nudSpeed.TabIndex = 37;
            this.nudSpeed.TabStop = false;
            this.nudSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSpeed.ValueChanged += new System.EventHandler(this.nudSpeed_ValueChanged);
            // 
            // btnToggleModel
            // 
            this.btnToggleModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnToggleModel.DrawOutline = false;
            this.btnToggleModel.Enabled = false;
            this.btnToggleModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToggleModel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnToggleModel.Location = new System.Drawing.Point(307, 99);
            this.btnToggleModel.Name = "btnToggleModel";
            this.btnToggleModel.Size = new System.Drawing.Size(107, 20);
            this.btnToggleModel.TabIndex = 39;
            this.btnToggleModel.Text = "Toggle Model";
            this.btnToggleModel.UseDisableColor = true;
            this.btnToggleModel.UseVisualStyleBackColor = false;
            this.btnToggleModel.Click += new System.EventHandler(this.btnToggleModel_Click);
            // 
            // btnToggleFreeCam
            // 
            this.btnToggleFreeCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnToggleFreeCam.DrawOutline = false;
            this.btnToggleFreeCam.Enabled = false;
            this.btnToggleFreeCam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToggleFreeCam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnToggleFreeCam.Location = new System.Drawing.Point(307, 141);
            this.btnToggleFreeCam.Name = "btnToggleFreeCam";
            this.btnToggleFreeCam.Size = new System.Drawing.Size(107, 20);
            this.btnToggleFreeCam.TabIndex = 40;
            this.btnToggleFreeCam.Text = "Toggle Free Cam";
            this.btnToggleFreeCam.UseDisableColor = true;
            this.btnToggleFreeCam.UseVisualStyleBackColor = false;
            this.btnToggleFreeCam.Click += new System.EventHandler(this.btnToggleFreeCam_Click);
            // 
            // btnResetSpeed
            // 
            this.btnResetSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnResetSpeed.DrawOutline = false;
            this.btnResetSpeed.Enabled = false;
            this.btnResetSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetSpeed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnResetSpeed.Location = new System.Drawing.Point(252, 27);
            this.btnResetSpeed.Name = "btnResetSpeed";
            this.btnResetSpeed.Size = new System.Drawing.Size(75, 20);
            this.btnResetSpeed.TabIndex = 41;
            this.btnResetSpeed.Text = "Reset";
            this.btnResetSpeed.UseDisableColor = true;
            this.btnResetSpeed.UseVisualStyleBackColor = false;
            this.btnResetSpeed.Click += new System.EventHandler(this.btnResetSpeed_Click);
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCamera.Location = new System.Drawing.Point(3, 191);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(43, 13);
            this.lblCamera.TabIndex = 361;
            this.lblCamera.Text = "Camera";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPlayer.Location = new System.Drawing.Point(3, 3);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer.TabIndex = 362;
            this.lblPlayer.Text = "Player";
            // 
            // txtCameraCell
            // 
            this.txtCameraCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCameraCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCameraCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCameraCell.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCameraCell.Location = new System.Drawing.Point(102, 210);
            this.txtCameraCell.Name = "txtCameraCell";
            this.txtCameraCell.ReadOnly = true;
            this.txtCameraCell.Size = new System.Drawing.Size(170, 20);
            this.txtCameraCell.TabIndex = 391;
            // 
            // txtPlayerCell
            // 
            this.txtPlayerCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayerCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPlayerCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerCell.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPlayerCell.Location = new System.Drawing.Point(102, 131);
            this.txtPlayerCell.Name = "txtPlayerCell";
            this.txtPlayerCell.ReadOnly = true;
            this.txtPlayerCell.Size = new System.Drawing.Size(170, 20);
            this.txtPlayerCell.TabIndex = 392;
            // 
            // lblCameraCell
            // 
            this.lblCameraCell.AutoSize = true;
            this.lblCameraCell.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCameraCell.Location = new System.Drawing.Point(72, 212);
            this.lblCameraCell.Name = "lblCameraCell";
            this.lblCameraCell.Size = new System.Drawing.Size(24, 13);
            this.lblCameraCell.TabIndex = 393;
            this.lblCameraCell.Text = "Cell";
            // 
            // lblPlayerCell
            // 
            this.lblPlayerCell.AutoSize = true;
            this.lblPlayerCell.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPlayerCell.Location = new System.Drawing.Point(72, 133);
            this.lblPlayerCell.Name = "lblPlayerCell";
            this.lblPlayerCell.Size = new System.Drawing.Size(24, 13);
            this.lblPlayerCell.TabIndex = 394;
            this.lblPlayerCell.Text = "Cell";
            // 
            // utinniButton1
            // 
            this.utinniButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.utinniButton1.DrawOutline = false;
            this.utinniButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.utinniButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.utinniButton1.Location = new System.Drawing.Point(296, 191);
            this.utinniButton1.Name = "utinniButton1";
            this.utinniButton1.Size = new System.Drawing.Size(107, 20);
            this.utinniButton1.TabIndex = 395;
            this.utinniButton1.Text = "Test";
            this.utinniButton1.UseDisableColor = true;
            this.utinniButton1.UseVisualStyleBackColor = false;
            this.utinniButton1.Click += new System.EventHandler(this.utinniButton1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.DrawOutline = false;
            this.numericUpDown1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown1.Location = new System.Drawing.Point(294, 220);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown1.TabIndex = 396;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sldSpeed
            // 
            this.sldSpeed.DrawOutline = false;
            this.sldSpeed.Location = new System.Drawing.Point(13, 28);
            this.sldSpeed.Maximum = 100F;
            this.sldSpeed.MaximumSize = new System.Drawing.Size(100000, 20);
            this.sldSpeed.Minimum = 0F;
            this.sldSpeed.Name = "sldSpeed";
            this.sldSpeed.Size = new System.Drawing.Size(150, 20);
            this.sldSpeed.TabIndex = 397;
            this.sldSpeed.Text = "Speed";
            this.sldSpeed.Value = 50F;
            this.sldSpeed.ValueChanged += new System.EventHandler(this.sldSpeed_ValueChanged);
            // 
            // PlayerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sldSpeed);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.utinniButton1);
            this.Controls.Add(this.lblPlayerCell);
            this.Controls.Add(this.lblCameraCell);
            this.Controls.Add(this.txtPlayerCell);
            this.Controls.Add(this.txtCameraCell);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.btnResetSpeed);
            this.Controls.Add(this.btnToggleFreeCam);
            this.Controls.Add(this.btnToggleModel);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.btnTeleport);
            this.Controls.Add(this.nudZ);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Name = "PlayerPanel";
            this.Size = new System.Drawing.Size(417, 281);
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudZ;
        internal UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudY;
        internal UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudX;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnTeleport;
        internal UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudSpeed;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnToggleModel;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnToggleFreeCam;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnResetSpeed;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblCamera;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblPlayer;
        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtCameraCell;
        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtPlayerCell;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblCameraCell;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblPlayerCell;
        private UtinniCoreDotNet.UI.Controls.UtinniButton utinniButton1;
        internal UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown numericUpDown1;
        private UtinniCoreDotNet.UI.Controls.UtinniSlider sldSpeed;
    }
}
