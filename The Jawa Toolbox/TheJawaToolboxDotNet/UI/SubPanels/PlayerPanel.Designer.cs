/**
 * MIT License
 *
 * Copyright (c) 2020 Philip Klatt
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
**/

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
            this.btnResetSpeed = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.txtCell = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            this.lblCell = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.sldSpeed = new UtinniCoreDotNet.UI.Controls.UtinniSlider();
            this.btnToCamera = new UtinniCoreDotNet.UI.Controls.UtinniButton();
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
            // txtCell
            // 
            this.txtCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCell.Enabled = false;
            this.txtCell.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCell.Location = new System.Drawing.Point(302, 3);
            this.txtCell.Name = "txtCell";
            this.txtCell.ReadOnly = true;
            this.txtCell.Size = new System.Drawing.Size(112, 20);
            this.txtCell.TabIndex = 392;
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCell.Location = new System.Drawing.Point(272, 5);
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
            // btnToCamera
            // 
            this.btnToCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnToCamera.DrawOutline = false;
            this.btnToCamera.Enabled = false;
            this.btnToCamera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToCamera.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnToCamera.Location = new System.Drawing.Point(336, 63);
            this.btnToCamera.Name = "btnToCamera";
            this.btnToCamera.Size = new System.Drawing.Size(75, 20);
            this.btnToCamera.TabIndex = 407;
            this.btnToCamera.Text = "To Camera";
            this.btnToCamera.UseDisableColor = true;
            this.btnToCamera.UseVisualStyleBackColor = false;
            this.btnToCamera.Click += new System.EventHandler(this.btnToCamera_Click);
            // 
            // PlayerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnToCamera);
            this.Controls.Add(this.sldSpeed);
            this.Controls.Add(this.lblCell);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.btnResetSpeed);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.btnTeleport);
            this.Controls.Add(this.nudZ);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Name = "PlayerPanel";
            this.Size = new System.Drawing.Size(417, 92);
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
        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtCell;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblCell;
        private UtinniCoreDotNet.UI.Controls.UtinniSlider sldSpeed;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnToCamera;
    }
}
