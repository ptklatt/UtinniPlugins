namespace TJT.UI.SubPanels
{
    partial class FreeCamPanel
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
            this.btnResetSpeed = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.txtCellName = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            this.lblCell = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.sldSpeed = new UtinniCoreDotNet.UI.Controls.UtinniSlider();
            this.chkPlayerModel = new UtinniCoreDotNet.UI.Controls.UtinniToggle();
            this.chkFreeCam = new UtinniCoreDotNet.UI.Controls.UtinniToggle();
            this.chkDragPlayer = new UtinniCoreDotNet.UI.Controls.UtinniToggle();
            this.btnToPlayer = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // nudZ
            // 
            this.nudZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudZ.DrawOutline = false;
            this.nudZ.Enabled = false;
            this.nudZ.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudZ.Location = new System.Drawing.Point(172, 63);
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
            this.nudY.DrawOutline = false;
            this.nudY.Enabled = false;
            this.nudY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudY.Location = new System.Drawing.Point(89, 63);
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
            this.nudY.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudX
            // 
            this.nudX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudX.DrawOutline = false;
            this.nudX.Enabled = false;
            this.nudX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudX.Location = new System.Drawing.Point(6, 63);
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
            this.btnTeleport.Location = new System.Drawing.Point(255, 63);
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
            this.nudSpeed.Location = new System.Drawing.Point(172, 33);
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
            // btnResetSpeed
            // 
            this.btnResetSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnResetSpeed.DrawOutline = false;
            this.btnResetSpeed.Enabled = false;
            this.btnResetSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetSpeed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnResetSpeed.Location = new System.Drawing.Point(255, 33);
            this.btnResetSpeed.Name = "btnResetSpeed";
            this.btnResetSpeed.Size = new System.Drawing.Size(75, 20);
            this.btnResetSpeed.TabIndex = 41;
            this.btnResetSpeed.Text = "Reset";
            this.btnResetSpeed.UseDisableColor = true;
            this.btnResetSpeed.UseVisualStyleBackColor = false;
            this.btnResetSpeed.Click += new System.EventHandler(this.btnResetSpeed_Click);
            // 
            // txtCellName
            // 
            this.txtCellName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCellName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCellName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCellName.Enabled = false;
            this.txtCellName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCellName.Location = new System.Drawing.Point(302, 3);
            this.txtCellName.Name = "txtCellName";
            this.txtCellName.ReadOnly = true;
            this.txtCellName.Size = new System.Drawing.Size(112, 20);
            this.txtCellName.TabIndex = 392;
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCell.Location = new System.Drawing.Point(272, 7);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(24, 13);
            this.lblCell.TabIndex = 394;
            this.lblCell.Text = "Cell";
            // 
            // sldSpeed
            // 
            this.sldSpeed.DrawOutline = false;
            this.sldSpeed.Enabled = false;
            this.sldSpeed.Location = new System.Drawing.Point(6, 33);
            this.sldSpeed.Maximum = 1000F;
            this.sldSpeed.MaximumSize = new System.Drawing.Size(100000, 20);
            this.sldSpeed.Minimum = 0F;
            this.sldSpeed.Name = "sldSpeed";
            this.sldSpeed.Size = new System.Drawing.Size(160, 20);
            this.sldSpeed.TabIndex = 397;
            this.sldSpeed.Text = "Speed";
            this.sldSpeed.Value = 0F;
            this.sldSpeed.ValueChanged += new System.EventHandler(this.sldSpeed_ValueChanged);
            // 
            // chkPlayerModel
            // 
            this.chkPlayerModel.Checked = true;
            this.chkPlayerModel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlayerModel.DrawOutline = false;
            this.chkPlayerModel.Enabled = false;
            this.chkPlayerModel.Location = new System.Drawing.Point(121, 3);
            this.chkPlayerModel.Name = "chkPlayerModel";
            this.chkPlayerModel.Size = new System.Drawing.Size(128, 20);
            this.chkPlayerModel.TabIndex = 405;
            this.chkPlayerModel.Text = "Player Model";
            this.chkPlayerModel.UseVisualStyleBackColor = true;
            this.chkPlayerModel.CheckedChanged += new System.EventHandler(this.chkPlayerModel_CheckedChanged);
            // 
            // chkFreeCam
            // 
            this.chkFreeCam.DrawOutline = false;
            this.chkFreeCam.Enabled = false;
            this.chkFreeCam.Location = new System.Drawing.Point(6, 3);
            this.chkFreeCam.Name = "chkFreeCam";
            this.chkFreeCam.Size = new System.Drawing.Size(109, 20);
            this.chkFreeCam.TabIndex = 406;
            this.chkFreeCam.Text = "FreeCam";
            this.chkFreeCam.UseVisualStyleBackColor = true;
            this.chkFreeCam.CheckedChanged += new System.EventHandler(this.chkFreeCam_CheckedChanged);
            // 
            // chkDragPlayer
            // 
            this.chkDragPlayer.DrawOutline = false;
            this.chkDragPlayer.Enabled = false;
            this.chkDragPlayer.Location = new System.Drawing.Point(6, 93);
            this.chkDragPlayer.Name = "chkDragPlayer";
            this.chkDragPlayer.Size = new System.Drawing.Size(122, 20);
            this.chkDragPlayer.TabIndex = 407;
            this.chkDragPlayer.Text = "Drag Player";
            this.chkDragPlayer.UseVisualStyleBackColor = true;
            this.chkDragPlayer.CheckedChanged += new System.EventHandler(this.chkDragPlayer_CheckedChanged);
            // 
            // btnToPlayer
            // 
            this.btnToPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnToPlayer.DrawOutline = false;
            this.btnToPlayer.Enabled = false;
            this.btnToPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToPlayer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnToPlayer.Location = new System.Drawing.Point(336, 63);
            this.btnToPlayer.Name = "btnToPlayer";
            this.btnToPlayer.Size = new System.Drawing.Size(75, 20);
            this.btnToPlayer.TabIndex = 408;
            this.btnToPlayer.Text = "To Player";
            this.btnToPlayer.UseDisableColor = true;
            this.btnToPlayer.UseVisualStyleBackColor = false;
            this.btnToPlayer.Click += new System.EventHandler(this.btnToPlayer_Click);
            // 
            // FreeCamPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnToPlayer);
            this.Controls.Add(this.chkDragPlayer);
            this.Controls.Add(this.chkFreeCam);
            this.Controls.Add(this.chkPlayerModel);
            this.Controls.Add(this.sldSpeed);
            this.Controls.Add(this.lblCell);
            this.Controls.Add(this.txtCellName);
            this.Controls.Add(this.btnResetSpeed);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.btnTeleport);
            this.Controls.Add(this.nudZ);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Name = "FreeCamPanel";
            this.Size = new System.Drawing.Size(417, 119);
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudZ;
        internal UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudY;
        internal UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudX;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnTeleport;
        internal UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudSpeed;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnResetSpeed;
        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtCellName;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblCell;
        private UtinniCoreDotNet.UI.Controls.UtinniSlider sldSpeed;
        private UtinniCoreDotNet.UI.Controls.UtinniToggle chkPlayerModel;
        private UtinniCoreDotNet.UI.Controls.UtinniToggle chkFreeCam;
        private UtinniCoreDotNet.UI.Controls.UtinniToggle chkDragPlayer;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnToPlayer;
    }
}
