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
using TJT.SWG;
using UtinniCore.Utinni;
using UtinniCoreDotNet.Hotkeys;
using UtinniCoreDotNet.PluginFramework;
using UtinniCoreDotNet.UI.Controls;

namespace TJT.UI.SubPanels
{
    public interface IScenePanel : ISceneAvailability
    {
        void SetCmbScenes(List<string> scenes);
        void UpdateTimeOfDay(int timeOfDay);
    }

    public partial class ScenePanel : SubPanel, IScenePanel
    {
        private readonly GroundSceneImpl groundScene;

        private readonly UtINI ini;

        public ScenePanel(IEditorPlugin editorPlugin, HotkeyManager hotkeyManager, UtINI ini) : base("Scene", false)
        {
            InitializeComponent();

            groundScene = new GroundSceneImpl(this, hotkeyManager);

            this.ini = ini;

            CreateSettings();
            ini.Load();

            txtAvatarObjectFilename.Text = ini.GetString("Scene", "defaultAvatarFilename");
        }

        private void CreateSettings()
        {
            ini.AddSetting("Scene", "defaultAvatarFilename", "object/creature/player/shared_human_male.iff", UtINI.Value.Types.VtString);
            ini.AddSetting("Scene", "defaultTerrainFilename", "terrain/naboo.trn", UtINI.Value.Types.VtString);
            ini.AddSetting("Scene", "forceModalChat", "true", UtINI.Value.Types.VtBool);
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

        private void nudWeatherIndex_ValueChanged(object sender, EventArgs e)
        {
            groundScene.SetWeatherIndex((int)nudWeatherIndex.Value);
        }

        private void sldTimeOfDay_ValueChanged(object sender, EventArgs e)
        {
            groundScene.SetTimeOfDay(sldTimeOfDay.Value);

        }

        public void SetCmbScenes(List<string> scenes)
        {
            cmbScenes.Items.AddRange(scenes.ToArray());
            int index = cmbScenes.Items.IndexOf(ini.GetString("Scene", "defaultTerrainFilename"));
            if (index >= 0)
            {
                cmbScenes.SelectedIndex = index;
            }
            else
            {
                cmbScenes.SelectedIndex = 0;
            }

            btnLoadScene.Enabled = true;
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

            nudWeatherIndex.Enabled = isSceneActive;
            sldTimeOfDay.Enabled = isSceneActive;

            if (!isSceneActive)
            {
                lblHoursAndMinute.Text = "00:00";
            }

            previousIsSceneActive = isSceneActive;

            if (ini.GetBool("Scene", "forceModalChat"))
            {
                groundScene.ForceModalChat(); // ToDo move this elsewhere
            }
        }

        public void UpdateTimeOfDay(int timeOfDay)
        {
            if (sldTimeOfDay.Created)
            {
                BeginInvoke((Action)(() =>
                {
                    sldTimeOfDay.ValueChanged -= sldTimeOfDay_ValueChanged;
                    sldTimeOfDay.Value = timeOfDay;

                    var terrain = Terrain.Get();
                    lblHoursAndMinute.Text = terrain.TimeOfDayHours.ToString("00") + ":" + terrain.TimeOfDayMinutes.ToString("00");
                    sldTimeOfDay.ValueChanged += sldTimeOfDay_ValueChanged;
                }));
            }
        }

    }
}
