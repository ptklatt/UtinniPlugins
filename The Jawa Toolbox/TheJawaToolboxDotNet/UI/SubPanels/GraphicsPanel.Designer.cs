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
    partial class GraphicsPanel
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
            this.chkWireframe = new UtinniCoreDotNet.UI.Controls.UtinniToggle();
            this.chkRenderSkeletons = new UtinniCoreDotNet.UI.Controls.UtinniToggle();
            this.btnReloadTextures = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.SuspendLayout();
            // 
            // chkWireframe
            // 
            this.chkWireframe.DrawOutline = false;
            this.chkWireframe.Location = new System.Drawing.Point(3, 3);
            this.chkWireframe.Name = "chkWireframe";
            this.chkWireframe.Size = new System.Drawing.Size(115, 17);
            this.chkWireframe.TabIndex = 0;
            this.chkWireframe.Text = "Wireframe";
            this.chkWireframe.UseVisualStyleBackColor = true;
            this.chkWireframe.CheckedChanged += new System.EventHandler(this.chkWireframe_CheckedChanged);
            // 
            // chkRenderSkeletons
            // 
            this.chkRenderSkeletons.DrawOutline = false;
            this.chkRenderSkeletons.Location = new System.Drawing.Point(3, 26);
            this.chkRenderSkeletons.Name = "chkRenderSkeletons";
            this.chkRenderSkeletons.Size = new System.Drawing.Size(152, 17);
            this.chkRenderSkeletons.TabIndex = 1;
            this.chkRenderSkeletons.Text = "Render Skeletons";
            this.chkRenderSkeletons.UseVisualStyleBackColor = true;
            this.chkRenderSkeletons.CheckedChanged += new System.EventHandler(this.chkRenderSkeletons_CheckedChanged);
            // 
            // btnReloadTextures
            // 
            this.btnReloadTextures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReloadTextures.DrawOutline = false;
            this.btnReloadTextures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReloadTextures.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReloadTextures.Location = new System.Drawing.Point(312, 3);
            this.btnReloadTextures.Name = "btnReloadTextures";
            this.btnReloadTextures.Size = new System.Drawing.Size(99, 20);
            this.btnReloadTextures.TabIndex = 328;
            this.btnReloadTextures.Text = "Reload Textures";
            this.btnReloadTextures.UseDisableColor = true;
            this.btnReloadTextures.UseVisualStyleBackColor = false;
            this.btnReloadTextures.Click += new System.EventHandler(this.btnReloadTextures_Click);
            // 
            // GraphicsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReloadTextures);
            this.Controls.Add(this.chkRenderSkeletons);
            this.Controls.Add(this.chkWireframe);
            this.Name = "GraphicsPanel";
            this.Size = new System.Drawing.Size(417, 46);
            this.ResumeLayout(false);

        }

        #endregion

        private UtinniCoreDotNet.UI.Controls.UtinniToggle chkWireframe;
        private UtinniCoreDotNet.UI.Controls.UtinniToggle chkRenderSkeletons;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnReloadTextures;
    }
}
