using System;
using TJT.SWG;
using UtinniCoreDotNet.PluginFramework;

namespace TJT.UI.SubPanels
{
    public interface IScenePanel
    {
        void UpdateTimeOfDay(int timeOfDay);
    }

    public partial class ScenePanel : EditorPanelBase, IScenePanel
    {
        private readonly GroundSceneImpl groundScene;
        private readonly WorldSnapshotImpl worldSnapshot;

        public ScenePanel(IEditorPlugin editorPlugin) : base("Scene")
        {
            InitializeComponent();

            groundScene = new GroundSceneImpl(this);
            worldSnapshot = new WorldSnapshotImpl(editorPlugin);
        }

        private void btnLoadScene_Click(object sender, EventArgs e)
        {
            groundScene.Load(cmbScenes.SelectedText, txtAvatarObjectFilename.Text);
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
            worldSnapshot.Load(cmbSnapshots.SelectedText);
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
