using System;
using System.Collections.Generic;
using TJT.SWG;
using UtinniCoreDotNet.Hotkeys;
using UtinniCoreDotNet.PluginFramework;
using UtinniCoreDotNet.UI.Controls;

namespace TJT.UI.SubPanels
{
    public interface IScenePanel : ISceneAvailability
    {
        void UpdateSnapshotNodeEditingMode(bool enable);
        void SetCmbScenes(List<string> scenes);
        void SetCmbSnapshots(List<string> snapshots);
        void UpdateTimeOfDay(int timeOfDay);
    }

    public partial class ScenePanel : SubPanel, IScenePanel
    {
        private readonly GroundSceneImpl groundScene;
        private readonly WorldSnapshotImpl worldSnapshot;

        public ScenePanel(HotkeyManager hotkeyManager, IEditorPlugin editorPlugin) : base("Scene", true)
        {
            InitializeComponent();

            groundScene = new GroundSceneImpl(this, hotkeyManager);
            worldSnapshot = new WorldSnapshotImpl(this, editorPlugin, hotkeyManager);
        }

        private void btnLoadScene_Click(object sender, EventArgs e)
        {
            groundScene.Load(cmbScenes.Items[cmbScenes.SelectedIndex].ToString(), txtAvatarObjectFilename.Text);
        }

        private void btnUnloadScene_Click(object sender, EventArgs e)
        {
            groundScene.Unload();;
        }

        private void btnReloadScene_Click(object sender, EventArgs e)
        {
            groundScene.Reload();
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
            worldSnapshot.AddNode(txtSnapshotNodeFilename.Text);
        }

        private void btnRemoveSnapshotNode_Click(object sender, EventArgs e)
        {
            worldSnapshot.RemoveNode();
        }

        private void nudWeatherIndex_ValueChanged(object sender, EventArgs e)
        {
            groundScene.SetWeatherIndex((int)nudWeatherIndex.Value);
        }

        private void trkbTimeOfDay_Scroll(object sender, EventArgs e)
        {
            groundScene.SetTimeOfDay(trkbTimeOfDay.Value);
        }

        private void chkAllowTargetEverything_CheckedChanged(object sender, EventArgs e)
        {
            groundScene.AllowTargetEverything(chkAllowTargetEverything.Checked);
        }

        private void chkEnableNodeEditing_CheckedChanged(object sender, EventArgs e)
        {
            worldSnapshot.UpdateNodeEditingMode(chkEnableNodeEditing.Checked);
        }

        public void UpdateSnapshotNodeEditingMode(bool enable)
        {
            chkEnableNodeEditing.CheckedChanged -= chkEnableNodeEditing_CheckedChanged;
            chkEnableNodeEditing.Checked = enable;
            chkEnableNodeEditing.CheckedChanged += chkEnableNodeEditing_CheckedChanged;
        }

        public void SetCmbScenes(List<string> scenes)
        {
            cmbScenes.Items.AddRange(scenes.ToArray());
            cmbScenes.SelectedIndex = 0;
        }

        public void SetCmbSnapshots(List<string> snapshots)
        {
            cmbSnapshots.Items.AddRange(snapshots.ToArray());
            cmbSnapshots.SelectedIndex = 0;
        }

        private bool previousIsSceneActive;
        public void UpdateSceneAvailability(bool isSceneActive)
        {
            if (previousIsSceneActive == isSceneActive)
            {
                return;
            }

            btnUnloadScene.Enabled = isSceneActive;
            btnReloadScene.Enabled = isSceneActive;

            cmbSnapshots.Enabled = isSceneActive;
            btnLoadSnapshot.Enabled = isSceneActive;
            btnSaveSnapshot.Enabled = isSceneActive;
            btnReloadSnapshot.Enabled = isSceneActive;
            btnUnloadSnapshot.Enabled = isSceneActive;

            btnAddSnapshotNode.Enabled = isSceneActive;
            btnRemoveSnapshotNode.Enabled = isSceneActive;
            nudWeatherIndex.Enabled = isSceneActive;
            trkbTimeOfDay.Enabled = isSceneActive;

            previousIsSceneActive = isSceneActive;
        }

        public void UpdateTimeOfDay(int timeOfDay)
        {
            if (trkbTimeOfDay.Created)
            {
                BeginInvoke((Action)(() =>
                {
                    trkbTimeOfDay.Value = timeOfDay;
                }));
            }
        }

    }
}
