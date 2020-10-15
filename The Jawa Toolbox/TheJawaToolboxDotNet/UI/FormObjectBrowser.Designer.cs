namespace TJT.UI
{
    partial class FormObjectBrowser
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
            this.components = new System.ComponentModel.Container();
            this.tvDirectories = new System.Windows.Forms.TreeView();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.lblFilter = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.txtFilter = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            this.lblCreateSnapshotNodesAtPlayer = new UtinniCoreDotNet.UI.Controls.UtinniLabel();
            this.nudSnapshotNodeCount = new UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown();
            this.btnCreateSnapshotNodesAtPlayer = new UtinniCoreDotNet.UI.Controls.UtinniButton();
            this.cmsObjectFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCreateSnapshotNodeAtPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.chkUsePlayerRotation = new UtinniCoreDotNet.UI.Controls.UtinniToggle();
            this.chkKeepOnTop = new UtinniCoreDotNet.UI.Controls.UtinniToggle();
            this.txtDirectoryPath = new UtinniCoreDotNet.UI.Controls.UtinniTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSnapshotNodeCount)).BeginInit();
            this.cmsObjectFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDirectories
            // 
            this.tvDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvDirectories.HideSelection = false;
            this.tvDirectories.Location = new System.Drawing.Point(12, 37);
            this.tvDirectories.Name = "tvDirectories";
            this.tvDirectories.Size = new System.Drawing.Size(216, 406);
            this.tvDirectories.TabIndex = 0;
            this.tvDirectories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDirectories_AfterSelect);
            // 
            // lbFiles
            // 
            this.lbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.IntegralHeight = false;
            this.lbFiles.Location = new System.Drawing.Point(234, 63);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(279, 380);
            this.lbFiles.TabIndex = 1;
            this.lbFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFiles_MouseDoubleClick);
            this.lbFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbFiles_MouseDown);
            this.lbFiles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbFiles_MouseMove);
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFilter.AutoSize = true;
            this.lblFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFilter.Location = new System.Drawing.Point(11, 481);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(29, 13);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFilter.Location = new System.Drawing.Point(46, 478);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(467, 20);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lblCreateSnapshotNodesAtPlayer
            // 
            this.lblCreateSnapshotNodesAtPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCreateSnapshotNodesAtPlayer.AutoSize = true;
            this.lblCreateSnapshotNodesAtPlayer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCreateSnapshotNodesAtPlayer.Location = new System.Drawing.Point(175, 455);
            this.lblCreateSnapshotNodesAtPlayer.Name = "lblCreateSnapshotNodesAtPlayer";
            this.lblCreateSnapshotNodesAtPlayer.Size = new System.Drawing.Size(167, 13);
            this.lblCreateSnapshotNodesAtPlayer.TabIndex = 42;
            this.lblCreateSnapshotNodesAtPlayer.Text = "Create Snapshot node(s) at player";
            // 
            // nudSnapshotNodeCount
            // 
            this.nudSnapshotNodeCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudSnapshotNodeCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudSnapshotNodeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSnapshotNodeCount.DrawOutline = false;
            this.nudSnapshotNodeCount.Enabled = false;
            this.nudSnapshotNodeCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudSnapshotNodeCount.Location = new System.Drawing.Point(345, 452);
            this.nudSnapshotNodeCount.Margin = new System.Windows.Forms.Padding(0);
            this.nudSnapshotNodeCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSnapshotNodeCount.Name = "nudSnapshotNodeCount";
            this.nudSnapshotNodeCount.Size = new System.Drawing.Size(40, 20);
            this.nudSnapshotNodeCount.TabIndex = 340;
            this.nudSnapshotNodeCount.TabStop = false;
            this.nudSnapshotNodeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSnapshotNodeCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCreateSnapshotNodesAtPlayer
            // 
            this.btnCreateSnapshotNodesAtPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateSnapshotNodesAtPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCreateSnapshotNodesAtPlayer.DrawOutline = false;
            this.btnCreateSnapshotNodesAtPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateSnapshotNodesAtPlayer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateSnapshotNodesAtPlayer.Location = new System.Drawing.Point(388, 452);
            this.btnCreateSnapshotNodesAtPlayer.Name = "btnCreateSnapshotNodesAtPlayer";
            this.btnCreateSnapshotNodesAtPlayer.Size = new System.Drawing.Size(82, 20);
            this.btnCreateSnapshotNodesAtPlayer.TabIndex = 41;
            this.btnCreateSnapshotNodesAtPlayer.Text = "Create";
            this.btnCreateSnapshotNodesAtPlayer.UseDisableColor = true;
            this.btnCreateSnapshotNodesAtPlayer.UseVisualStyleBackColor = false;
            this.btnCreateSnapshotNodesAtPlayer.Click += new System.EventHandler(this.btnCreateSnapshotNodesAtPlayer_Click);
            // 
            // cmsObjectFile
            // 
            this.cmsObjectFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateSnapshotNodeAtPlayer});
            this.cmsObjectFile.Name = "cmsObjectFile";
            this.cmsObjectFile.Size = new System.Drawing.Size(239, 26);
            // 
            // tsmiCreateSnapshotNodeAtPlayer
            // 
            this.tsmiCreateSnapshotNodeAtPlayer.Name = "tsmiCreateSnapshotNodeAtPlayer";
            this.tsmiCreateSnapshotNodeAtPlayer.Size = new System.Drawing.Size(238, 22);
            this.tsmiCreateSnapshotNodeAtPlayer.Text = "Create Snapshot node at player";
            this.tsmiCreateSnapshotNodeAtPlayer.Click += new System.EventHandler(this.tsmiCreateSnapshotNodeAtPlayer_Click);
            // 
            // chkUsePlayerRotation
            // 
            this.chkUsePlayerRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUsePlayerRotation.DrawOutline = false;
            this.chkUsePlayerRotation.Location = new System.Drawing.Point(14, 452);
            this.chkUsePlayerRotation.Name = "chkUsePlayerRotation";
            this.chkUsePlayerRotation.Size = new System.Drawing.Size(155, 20);
            this.chkUsePlayerRotation.TabIndex = 341;
            this.chkUsePlayerRotation.Text = "Use player rotation";
            this.chkUsePlayerRotation.UseVisualStyleBackColor = true;
            // 
            // chkKeepOnTop
            // 
            this.chkKeepOnTop.DrawOutline = false;
            this.chkKeepOnTop.Location = new System.Drawing.Point(204, 11);
            this.chkKeepOnTop.Name = "chkKeepOnTop";
            this.chkKeepOnTop.Size = new System.Drawing.Size(125, 20);
            this.chkKeepOnTop.TabIndex = 342;
            this.chkKeepOnTop.Text = "Keep on top";
            this.chkKeepOnTop.UseVisualStyleBackColor = true;
            this.chkKeepOnTop.CheckedChanged += new System.EventHandler(this.chkKeepOnTop_CheckedChanged);
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectoryPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDirectoryPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirectoryPath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDirectoryPath.Location = new System.Drawing.Point(234, 37);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(279, 20);
            this.txtDirectoryPath.TabIndex = 343;
            // 
            // FormObjectBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 510);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.chkKeepOnTop);
            this.Controls.Add(this.chkUsePlayerRotation);
            this.Controls.Add(this.nudSnapshotNodeCount);
            this.Controls.Add(this.lblCreateSnapshotNodesAtPlayer);
            this.Controls.Add(this.btnCreateSnapshotNodesAtPlayer);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.tvDirectories);
            this.DrawName = true;
            this.Name = "FormObjectBrowser";
            this.Text = "Object Browser";
            ((System.ComponentModel.ISupportInitialize)(this.nudSnapshotNodeCount)).EndInit();
            this.cmsObjectFile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDirectories;
        private System.Windows.Forms.ListBox lbFiles;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblFilter;
        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtFilter;
        private UtinniCoreDotNet.UI.Controls.UtinniButton btnCreateSnapshotNodesAtPlayer;
        private UtinniCoreDotNet.UI.Controls.UtinniLabel lblCreateSnapshotNodesAtPlayer;
        internal UtinniCoreDotNet.UI.Controls.UtinniNumericUpDown nudSnapshotNodeCount;
        private System.Windows.Forms.ContextMenuStrip cmsObjectFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateSnapshotNodeAtPlayer;
        private UtinniCoreDotNet.UI.Controls.UtinniToggle chkUsePlayerRotation;
        private UtinniCoreDotNet.UI.Controls.UtinniToggle chkKeepOnTop;
        private UtinniCoreDotNet.UI.Controls.UtinniTextbox txtDirectoryPath;
    }
}