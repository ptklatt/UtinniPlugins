using System;
using System.Collections.Generic;
using TJT.SWG;
using UtinniCore.Swg.Math;
using UtinniCore.Utinni;
using UtinniCoreDotNet.Hotkeys;
using UtinniCoreDotNet.PluginFramework;
using UtinniCoreDotNet.UI.Controls;

namespace TJT.UI.SubPanels
{
    public interface ISnapshotPanel : ISceneAvailability
    {
        void SetCmbSnapshots(List<string> snapshots);
        void UpdateSnapshotNodeEditingMode(bool enable);
        void UpdateSelectedNodeControls(WorldSnapshotReaderWriter.Node node, string cellName = "", string typeText = "");
        void UpdateSelectedNodeControlsPosition(Vector position);
        void UpdateSelectedNodeControlsRotation(Vector rotation);
    }

    public partial class SnapshotPanel : SubPanel, ISnapshotPanel
    {
        private readonly GroundSceneImpl groundScene;
        private readonly WorldSnapshotImpl worldSnapshot;

        private readonly UtINI ini;

        public SnapshotPanel(IEditorPlugin editorPlugin, HotkeyManager hotkeyManager, UtINI ini) : base("Snapshot")
        {
            InitializeComponent();

            worldSnapshot = new WorldSnapshotImpl(this, editorPlugin, hotkeyManager);

            this.ini = ini;

            CreateSettings();
            ini.Load();

            txtNewNodeFilename.Text = ini.GetString("Snapshot", "defaultNodeObjectFilename");
            chkEnableNodeEditing.Checked = ini.GetBool("Snapshot", "autoEnableSnapshotEditing");
        }

        private void CreateSettings()
        {
            ini.AddSetting("Snapshot", "defaultSnapshotName", "naboo", UtINI.Value.Types.VtString);
            ini.AddSetting("Snapshot", "defaultNodeObjectFilename", "object/tangible/furniture/cheap/shared_armoire_s01.iff", UtINI.Value.Types.VtString);
            ini.AddSetting("Snapshot", "autoEnableSnapshotEditing", "false", UtINI.Value.Types.VtBool);
        }

        private void btnLoadSnapshot_Click(object sender, EventArgs e)
        {
            worldSnapshot.Load(cmbSnapshots.Items[cmbSnapshots.SelectedIndex].ToString());
        }

        private void btnUnloadSnapshot_Click(object sender, EventArgs e)
        {
            worldSnapshot.Unload();
        }

        private void btnReloadSnapshot_Click(object sender, EventArgs e)
        {
            worldSnapshot.Reload();
        }

        private void btnSaveSnapshot_Click(object sender, EventArgs e)
        {
            worldSnapshot.Save();
        }

        private void btnAddSnapshotNode_Click(object sender, EventArgs e)
        {
            worldSnapshot.AddNode(txtNewNodeFilename.Text);
        }

        private void btnRemoveSnapshotNode_Click(object sender, EventArgs e)
        {
            worldSnapshot.RemoveNode();
        }

        private void chkEnableNodeEditing_CheckedChanged(object sender, EventArgs e)
        {
            worldSnapshot.UpdateNodeEditingMode(chkEnableNodeEditing.Checked);
        }

        private void nudNodePos_ValueChanged(object sender, EventArgs e)
        {
            worldSnapshot.SetSelectedNodePosition((float)nudNodePosX.Value, (float)nudNodePosY.Value, (float)nudNodePosZ.Value);
        }

        private void nudNodeRadius_ValueChanged(object sender, EventArgs e)
        {
            worldSnapshot.SetRadius((float)nudNodeRadius.Value);
        }

        public void UpdateSnapshotNodeEditingMode(bool enable)
        {
            chkEnableNodeEditing.CheckedChanged -= chkEnableNodeEditing_CheckedChanged;
            chkEnableNodeEditing.Checked = enable;
            chkEnableNodeEditing.CheckedChanged += chkEnableNodeEditing_CheckedChanged;
        }

        public void SetCmbSnapshots(List<string> snapshots)
        {
            cmbSnapshots.Items.AddRange(snapshots.ToArray());
            int index = cmbSnapshots.Items.IndexOf(ini.GetString("Snapshot", "defaultSnapshotName"));
            if (index >= 0)
            {
                cmbSnapshots.SelectedIndex = index;
            }
            else
            {
                cmbSnapshots.SelectedIndex = 0;
            }
        }

        private bool previousIsSceneActive;
        public void UpdateSceneAvailability(bool isSceneActive)
        {
            if (previousIsSceneActive == isSceneActive)
            {
                return;
            }

            cmbSnapshots.Enabled = isSceneActive;
            btnLoadSnapshot.Enabled = isSceneActive;
            btnSaveSnapshot.Enabled = isSceneActive;
            btnReloadSnapshot.Enabled = isSceneActive;
            btnUnloadSnapshot.Enabled = isSceneActive;

            btnAddNode.Enabled = isSceneActive;

            previousIsSceneActive = isSceneActive;
        }

        public void EnableSelectedNodeControls(bool value)
        {
            nudNodePosX.Enabled = value;
            nudNodePosY.Enabled = value;
            nudNodePosZ.Enabled = value;

            nudNodeRotX.Enabled = value;
            nudNodeRotY.Enabled = value;
            nudNodeRotZ.Enabled = value;

            nudNodeRadius.Enabled = value;
            btnRemoveSelectedNode.Enabled = value;
        }

        public void UpdateSelectedNodeControls(WorldSnapshotReaderWriter.Node node, string cellName, string typeText)
        {
            if (node == null)
            {
                EnableSelectedNodeControls(false);

                UpdateSelectedNodeControlsPosition(new Vector(0, 0, 0));

                txtNodeId.Text = "";
                txtNodeParentId.Text = "";
                txtNodeFilename.Text = "";
                return;
            }

            EnableSelectedNodeControls(chkEnableNodeEditing.Checked);

            nudNodeRadius.Value = (decimal) node.Radius;

            txtNodeId.Text = node.Id.ToString();
            txtNodeParentId.Text = node.ParentId.ToString();
            txtNodeCellName.Text = cellName;
            txtNodeFilename.Text = node.ObjectTemplateName;

            txtNodeType.Text = typeText;

            UpdateSelectedNodeControlsPosition(node.Transform.Position);
        }

        public void UpdateSelectedNodeControlsPosition(Vector position)
        {
            nudNodePosX.ValueChanged -= nudNodePos_ValueChanged;
            nudNodePosY.ValueChanged -= nudNodePos_ValueChanged;
            nudNodePosZ.ValueChanged -= nudNodePos_ValueChanged;

            nudNodePosX.Value = (decimal)position.X;
            nudNodePosY.Value = (decimal)position.Y;
            nudNodePosZ.Value = (decimal)position.Z;

            nudNodePosX.ValueChanged += nudNodePos_ValueChanged;
            nudNodePosY.ValueChanged += nudNodePos_ValueChanged;
            nudNodePosZ.ValueChanged += nudNodePos_ValueChanged;
        }

        public void UpdateSelectedNodeControlsRotation(Vector rotation)
        {
            //throw new NotImplementedException();
        }

    }
}
