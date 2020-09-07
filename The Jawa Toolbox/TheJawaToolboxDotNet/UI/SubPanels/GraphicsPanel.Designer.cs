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
            this.chkWireframe = new System.Windows.Forms.CheckBox();
            this.chkRenderSkeletons = new System.Windows.Forms.CheckBox();
            this.btnReloadTextures = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.SuspendLayout();
            // 
            // chkWireframe
            // 
            this.chkWireframe.AutoSize = true;
            this.chkWireframe.Location = new System.Drawing.Point(3, 3);
            this.chkWireframe.Name = "chkWireframe";
            this.chkWireframe.Size = new System.Drawing.Size(74, 17);
            this.chkWireframe.TabIndex = 0;
            this.chkWireframe.Text = "Wireframe";
            this.chkWireframe.UseVisualStyleBackColor = true;
            this.chkWireframe.CheckedChanged += new System.EventHandler(this.chkWireframe_CheckedChanged);
            // 
            // chkRenderSkeletons
            // 
            this.chkRenderSkeletons.AutoSize = true;
            this.chkRenderSkeletons.Location = new System.Drawing.Point(3, 26);
            this.chkRenderSkeletons.Name = "chkRenderSkeletons";
            this.chkRenderSkeletons.Size = new System.Drawing.Size(111, 17);
            this.chkRenderSkeletons.TabIndex = 1;
            this.chkRenderSkeletons.Text = "Render Skeletons";
            this.chkRenderSkeletons.UseVisualStyleBackColor = true;
            this.chkRenderSkeletons.CheckedChanged += new System.EventHandler(this.chkRenderSkeletons_CheckedChanged);
            // 
            // btnReloadTextures
            // 
            this.btnReloadTextures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReloadTextures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReloadTextures.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReloadTextures.Location = new System.Drawing.Point(312, 3);
            this.btnReloadTextures.Name = "btnReloadTextures";
            this.btnReloadTextures.Size = new System.Drawing.Size(99, 23);
            this.btnReloadTextures.TabIndex = 328;
            this.btnReloadTextures.Text = "Reload Textures";
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
            this.Size = new System.Drawing.Size(414, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkWireframe;
        private System.Windows.Forms.CheckBox chkRenderSkeletons;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnReloadTextures;
    }
}
