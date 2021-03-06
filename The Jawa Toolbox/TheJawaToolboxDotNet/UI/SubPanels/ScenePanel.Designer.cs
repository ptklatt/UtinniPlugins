﻿/**
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
            this.btnReloadScene = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnLoadScene = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.cmbScenes = new UtinniCoreDotNet.UI.Controls.UtinniComboBox();
            this.txtAvatarObjectFilename = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            this.lblHoursAndMinute = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeatherIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // sldTimeOfDay
            // 
            this.sldTimeOfDay.DrawOutline = false;
            this.sldTimeOfDay.Enabled = false;
            this.sldTimeOfDay.Location = new System.Drawing.Point(3, 114);
            this.sldTimeOfDay.Maximum = 1000F;
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
            this.btnUnloadScene.Text = "Unload";
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
            this.cmbScenes.TabStop = false;
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
            this.txtAvatarObjectFilename.Size = new System.Drawing.Size(411, 20);
            this.txtAvatarObjectFilename.TabIndex = 323;
            this.txtAvatarObjectFilename.TabStop = false;
            this.txtAvatarObjectFilename.Text = "object/creature/player/shared_human_male.iff";
            // 
            // lblHoursAndMinute
            // 
            this.lblHoursAndMinute.AutoSize = true;
            this.lblHoursAndMinute.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHoursAndMinute.Location = new System.Drawing.Point(180, 117);
            this.lblHoursAndMinute.Name = "lblHoursAndMinute";
            this.lblHoursAndMinute.Size = new System.Drawing.Size(34, 13);
            this.lblHoursAndMinute.TabIndex = 345;
            this.lblHoursAndMinute.Text = "00:00";
            // 
            // ScenePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHoursAndMinute);
            this.Controls.Add(this.sldTimeOfDay);
            this.Controls.Add(this.btnUnloadScene);
            this.Controls.Add(this.lblWeatherIndex);
            this.Controls.Add(this.nudWeatherIndex);
            this.Controls.Add(this.btnReloadScene);
            this.Controls.Add(this.btnLoadScene);
            this.Controls.Add(this.cmbScenes);
            this.Controls.Add(this.txtAvatarObjectFilename);
            this.Name = "ScenePanel";
            this.Size = new System.Drawing.Size(417, 139);
            ((System.ComponentModel.ISupportInitialize)(this.nudWeatherIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtAvatarObjectFilename;
        private UtinniCoreDotNet.UI.Controls.UtinniComboBox cmbScenes;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnLoadScene;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnReloadScene;
        internal UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudWeatherIndex;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblWeatherIndex;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnUnloadScene;
        private UtinniCoreDotNet.UI.Controls.UtinniSlider sldTimeOfDay;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblHoursAndMinute;
    }
}
