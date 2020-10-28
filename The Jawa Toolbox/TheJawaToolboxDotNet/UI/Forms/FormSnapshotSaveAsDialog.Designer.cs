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

namespace TJT.UI.Forms
{
    partial class FormSnapshotSaveAsDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.btnCancel = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.txtSnapshotName = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.DrawOutline = false;
            this.btnOk.Location = new System.Drawing.Point(255, 61);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 20);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseDisableColor = true;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DrawOutline = false;
            this.btnCancel.Location = new System.Drawing.Point(3, 61);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 20);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseDisableColor = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtSnapshotName
            // 
            this.txtSnapshotName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSnapshotName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSnapshotName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSnapshotName.Location = new System.Drawing.Point(3, 35);
            this.txtSnapshotName.Name = "txtSnapshotName";
            this.txtSnapshotName.Size = new System.Drawing.Size(327, 20);
            this.txtSnapshotName.TabIndex = 6;
            this.txtSnapshotName.TabStop = false;
            this.txtSnapshotName.TextChanged += new System.EventHandler(this.txtSnapshotName_TextChanged);
            // 
            // FormSnapshotSaveAsDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(333, 84);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSnapshotName);
            this.DrawName = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSnapshotSaveAsDialog";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Snapshot Save As...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UtinniCoreDotNet.UI.Controls.UtinniButton btnOk;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnCancel;
        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtSnapshotName;
    }
}