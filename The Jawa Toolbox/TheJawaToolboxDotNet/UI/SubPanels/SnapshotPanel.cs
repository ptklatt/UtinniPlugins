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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TJT.SWG;
using TJT.UI.Forms;
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
        void UpdateNodeEditingMode(bool enable);
        void UpdateSelectedNodeControls(WorldSnapshotReaderWriter.Node node, string cellName = "", string typeText = "");
        void UpdateSelectedNodeControlsPosition(Vector position);
        void UpdateGizmoModeControls(bool value);
        void UpdateGizmoOperationControls(bool value);
        void UpdateGizmoSnapControl(bool value);
    }

    public partial class SnapshotPanel : SubPanel, ISnapshotPanel
    {
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
            chkAllowTargetEverything.Checked = ini.GetBool("Snapshot", "autoAllowTargetEverything");
        }

        private void CreateSettings()
        {
            ini.AddSetting("Snapshot", "defaultSnapshotName", "naboo", UtINI.Value.Types.VtString);
            ini.AddSetting("Snapshot", "defaultNodeObjectFilename", "object/tangible/furniture/cheap/shared_armoire_s01.iff", UtINI.Value.Types.VtString);
            ini.AddSetting("Snapshot", "autoEnableSnapshotEditing", "false", UtINI.Value.Types.VtBool);
            ini.AddSetting("Snapshot", "autoAllowTargetEverything", "false", UtINI.Value.Types.VtBool);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            worldSnapshot.Load(cmbSnapshots.Items[cmbSnapshots.SelectedIndex].ToString());
        }

        private void btnUnload_Click(object sender, EventArgs e)
        {
            worldSnapshot.Unload();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            worldSnapshot.Reload();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            worldSnapshot.Save();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            FormSnapshotSaveAsDialog form = new FormSnapshotSaveAsDialog(GroundScene.Get().Name)
            {
                Location = new System.Drawing.Point(MousePosition.X - 200, MousePosition.Y - 40)
            };

            DialogResult dialogResult = form.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                worldSnapshot.SaveAs(form.SaveAsName);
            }
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            worldSnapshot.AddNode(txtNewNodeFilename.Text);
        }

        private void btnRemoveNode_Click(object sender, EventArgs e)
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

        public void UpdateNodeEditingMode(bool enable)
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
            btnLoad.Enabled = isSceneActive;
            btnSave.Enabled = isSceneActive;
            btnSaveAs.Enabled = isSceneActive;
            btnReload.Enabled = isSceneActive;
            btnUnload.Enabled = isSceneActive;

            btnAddNode.Enabled = isSceneActive;

            previousIsSceneActive = isSceneActive;
        }

        public void EnableSelectedNodeControls(bool value)
        {
            nudNodePosX.Enabled = value;
            nudNodePosY.Enabled = value;
            nudNodePosZ.Enabled = value;

            btnRotationPitchawAdd45.Enabled = value;
            btnRotationPitchawAdd1.Enabled = value;
            btnRotationPitchawSub1.Enabled = value;
            btnRotationPitchawSub45.Enabled = value;

            btnRotationPitchAdd45.Enabled = value;
            btnRotationPitchAdd1.Enabled = value;
            btnRotationPitchSub1.Enabled = value;
            btnRotationPitchSub45.Enabled = value;

            btnRotationRollAdd45.Enabled = value;
            btnRotationRollAdd1.Enabled = value;
            btnRotationRollSub1.Enabled = value;
            btnRotationRollSub45.Enabled = value;

            btnRotationYawRandom.Enabled = value;
            btnRotationPitchRandom.Enabled = value;
            btnRotationRollRandom.Enabled = value;

            btnRotationReset.Enabled = value;

            nudNodeRadius.Enabled = value;
            btnRemoveSelectedNode.Enabled = value;

            //chkSnap.Checked = IsSnap
            chkSnap.Enabled = value;
            nudSnapScale.Enabled = value;

            chkbtnOperation.Enabled = value;
            chkbtnMode.Enabled = value;
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

        private void btnRotationPitchawAdd45_Click(object sender, EventArgs e)
        {
            worldSnapshot.RotateYaw(45);
        }

        private void btnRotationPitchawSub45_Click(object sender, EventArgs e)
        {
            worldSnapshot.RotateYaw(-45);
        }

        private void btnRotationPitchawAdd1_Click(object sender, EventArgs e)
        {
            worldSnapshot.RotateYaw(1);
        }

        private void btnRotationPitchawSub1_Click(object sender, EventArgs e)
        {
            worldSnapshot.RotateYaw(-1);
        }

        private void btnRotationPitchAdd45_Click(object sender, EventArgs e)
        {
            worldSnapshot.RotatePitch(45);
        }

        private void btnRotationPitchSub45_Click(object sender, EventArgs e)
        {
            worldSnapshot.RotatePitch(-45);
        }

        private void btnRotationPitchAdd1_Click(object sender, EventArgs e)
        {
            worldSnapshot.RotatePitch(1);
        }

        private void btnRotationPitchSub1_Click(object sender, EventArgs e)
        {
            worldSnapshot.RotatePitch(-1);
        }

        private void btnRotationRollAdd45_Click(object sender, EventArgs e)
        {
            worldSnapshot.RotateRoll(45);
        }

        private void btnRotationRollSub45_Click(object sender, EventArgs e)
        {
            worldSnapshot.RotateRoll(-45);
        }

        private void btnRotationRollAdd1_Click(object sender, EventArgs e)
        {
            worldSnapshot.RotateRoll(1);
        }

        private void btnRotationRollSub1_Click(object sender, EventArgs e)
        {
            worldSnapshot.RotateRoll(-1);
        }

        private void btnRotationYawRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            worldSnapshot.RotateYaw(rnd.Next(-180, 180));
        }

        private void btnRotationPitchRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            worldSnapshot.RotatePitch(rnd.Next(-180, 180));
        }

        private void btnRotationRollRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            worldSnapshot.RotateRoll(rnd.Next(-180, 180));
        }

        private void btnRotationReset_Click(object sender, EventArgs e)
        {
            worldSnapshot.ResetRotation();
        }

        private void chkSnap_CheckedChanged(object sender, EventArgs e)
        {
            worldSnapshot.SetGizmoSnap(chkSnap.Checked);
        }

        private void nudSnapScale_ValueChanged(object sender, EventArgs e)
        {
            worldSnapshot.SetSnapScale((float) nudSnapScale.Value);
        }

        private void chkbtnMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbtnMode.Checked)
            {
                chkbtnMode.Text = "Local";
                worldSnapshot.SetGizmoToLocal();
            }
            else
            {
                chkbtnMode.Text = "World";
                worldSnapshot.SetGizmoToWorld();
            }
        }

        private void chkbtnOperation_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbtnOperation.Checked)
            {
                chkbtnOperation.Text = "Translate";
                worldSnapshot.SetOperationModeToTranslate();
            }
            else
            {

                chkbtnOperation.Text = "Rotation";
                worldSnapshot.SetOperationModeToRotation();
            }
        }

        public void UpdateGizmoModeControls(bool value)
        {
            chkbtnMode.CheckedChanged -= chkbtnMode_CheckedChanged;
            chkbtnMode.Checked = value;
            chkbtnMode.CheckedChanged += chkbtnMode_CheckedChanged;

            if (value)
            {
                chkbtnMode.Text = "Local";
            }
            else
            {

                chkbtnMode.Text = "World";
            }
        }

        public void UpdateGizmoOperationControls(bool value)
        {

            chkbtnOperation.CheckedChanged -= chkbtnOperation_CheckedChanged;
            chkbtnOperation.Checked = value;
            chkbtnOperation.CheckedChanged += chkbtnOperation_CheckedChanged;

            if (value)
            {
                chkbtnOperation.Text = "Translate";
            }
            else
            {

                chkbtnOperation.Text = "Rotation";
            }
        } 

        public void UpdateGizmoSnapControl(bool value)
        {
            chkSnap.CheckedChanged -= chkSnap_CheckedChanged;
            chkSnap.Checked = value;
            chkSnap.CheckedChanged += chkSnap_CheckedChanged;
        }

        private void chkAllowTargetEverything_CheckedChanged(object sender, EventArgs e)
        {
            worldSnapshot.AllowTargetEverything(chkAllowTargetEverything.Checked);
        }
    }

}
