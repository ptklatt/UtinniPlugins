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
            this.nudZ = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.btnTeleport = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.trkbSpeed = new System.Windows.Forms.TrackBar();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.btnToggleModel = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnToggleFreeCam = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // nudZ
            // 
            this.nudZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudZ.DecimalPlaces = 3;
            this.nudZ.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudZ.Location = new System.Drawing.Point(169, 48);
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
            this.nudY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudY.Location = new System.Drawing.Point(86, 48);
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
            this.nudX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudX.Location = new System.Drawing.Point(3, 48);
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
            this.btnTeleport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeleport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTeleport.Location = new System.Drawing.Point(252, 48);
            this.btnTeleport.Name = "btnTeleport";
            this.btnTeleport.Size = new System.Drawing.Size(75, 23);
            this.btnTeleport.TabIndex = 35;
            this.btnTeleport.Text = "Teleport";
            this.btnTeleport.UseVisualStyleBackColor = false;
            this.btnTeleport.Click += new System.EventHandler(this.btnTeleport_Click);
            // 
            // trkbSpeed
            // 
            this.trkbSpeed.LargeChange = 1;
            this.trkbSpeed.Location = new System.Drawing.Point(3, 3);
            this.trkbSpeed.Maximum = 100;
            this.trkbSpeed.Name = "trkbSpeed";
            this.trkbSpeed.Size = new System.Drawing.Size(160, 45);
            this.trkbSpeed.TabIndex = 36;
            this.trkbSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkbSpeed.Scroll += new System.EventHandler(this.trkbSpeed_Scroll);
            // 
            // nudSpeed
            // 
            this.nudSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSpeed.DecimalPlaces = 3;
            this.nudSpeed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudSpeed.Location = new System.Drawing.Point(169, 3);
            this.nudSpeed.Maximum = new decimal(new int[] {
            99999,
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
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(252, 5);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed.TabIndex = 38;
            this.lblSpeed.Text = "Speed";
            // 
            // btnToggleModel
            // 
            this.btnToggleModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnToggleModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToggleModel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnToggleModel.Location = new System.Drawing.Point(3, 74);
            this.btnToggleModel.Name = "btnToggleModel";
            this.btnToggleModel.Size = new System.Drawing.Size(96, 23);
            this.btnToggleModel.TabIndex = 39;
            this.btnToggleModel.Text = "Toggle Model";
            this.btnToggleModel.UseVisualStyleBackColor = false;
            this.btnToggleModel.Click += new System.EventHandler(this.btnToggleModel_Click);
            // 
            // btnToggleFreeCam
            // 
            this.btnToggleFreeCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnToggleFreeCam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToggleFreeCam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnToggleFreeCam.Location = new System.Drawing.Point(105, 74);
            this.btnToggleFreeCam.Name = "btnToggleFreeCam";
            this.btnToggleFreeCam.Size = new System.Drawing.Size(96, 23);
            this.btnToggleFreeCam.TabIndex = 40;
            this.btnToggleFreeCam.Text = "Toggle Free Cam";
            this.btnToggleFreeCam.UseVisualStyleBackColor = false;
            this.btnToggleFreeCam.Click += new System.EventHandler(this.btnToggleFreeCam_Click);
            // 
            // PlayerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnToggleFreeCam);
            this.Controls.Add(this.btnToggleModel);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.trkbSpeed);
            this.Controls.Add(this.btnTeleport);
            this.Controls.Add(this.nudZ);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Name = "PlayerPanel";
            this.Size = new System.Drawing.Size(417, 106);
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.NumericUpDown nudZ;
        internal System.Windows.Forms.NumericUpDown nudY;
        internal System.Windows.Forms.NumericUpDown nudX;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnTeleport;
        private System.Windows.Forms.TrackBar trkbSpeed;
        private System.Windows.Forms.Label lblSpeed;
        internal System.Windows.Forms.NumericUpDown nudSpeed;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnToggleModel;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnToggleFreeCam;
    }
}
