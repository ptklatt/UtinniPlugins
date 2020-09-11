using System;
using System.Collections.Generic;
using TJT.SWG;
using UtinniCoreDotNet.PluginFramework;
using UtinniCoreDotNet.UI.Controls;

namespace TJT.UI.SubPanels
{
    public interface IScenePanel
    {
        void SetCmbScenes(List<string> scenes);
        void SetCmbSnapshots(List<string> snapshots);
        void UpdateTimeOfDay(int timeOfDay);
    }

    public partial class ScenePanel : SubPanel, IScenePanel
    {
        private readonly GroundSceneImpl groundScene;
        private readonly WorldSnapshotImpl worldSnapshot;

        public ScenePanel(IEditorPlugin editorPlugin) : base("Scene")
        {
            InitializeComponent();

            groundScene = new GroundSceneImpl(this);
            worldSnapshot = new WorldSnapshotImpl(this, editorPlugin);
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

        private void BtnAddSnapshotNode_Click(object sender, EventArgs e)
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

        private void chkEnableNodeEditing_CheckedChanged(object sender, EventArgs e)
        {
            worldSnapshot.EnableNodeEditing = chkEnableNodeEditing.Checked;
            worldSnapshot.OnTarget();
        }
    }
}
