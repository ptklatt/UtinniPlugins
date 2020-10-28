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
using TJT.SWG;
using UtinniCore.Utinni;
using UtinniCoreDotNet.UI.Controls;

namespace TJT.UI.SubPanels
{
    public partial class MiscPanel : SubPanel, ISceneAvailability
    {
        private readonly CuiImpl cui;
        private readonly MiscImpl misc;

        public MiscPanel(UtINI ini) : base("Misc")
        {
            InitializeComponent();

            cui = new CuiImpl();
            misc = new MiscImpl(this);

            CreateSettings(ini);
            ini.Load();

            txtCreateObject.Text = ini.GetString("Misc", "defaultCreateObjectFilename");
            txtCreateAppearance.Text = ini.GetString("Misc", "defaultCreateAppearanceFilename");
        }

        private void CreateSettings(UtINI ini)
        {
            ini.AddSetting("Misc", "defaultCreateObjectFilename", "object/tangible/furniture/cheap/shared_armoire_s01.iff", UtINI.Value.Types.VtString);
            ini.AddSetting("Misc", "defaultCreateAppearanceFilename", "appearance/frn_all_chep_cabinet_s01.apt", UtINI.Value.Types.VtString);
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            misc.CreateObject(txtCreateObject.Text);
        }

        private void btnCreateAppearance_Click(object sender, EventArgs e)
        {
            misc.CreateAppearance(txtCreateAppearance.Text);
        }

        private void btnReloadUi_Click(object sender, EventArgs e)
        {
            cui.ReloadUi();
        }

        private void btnRestartMusic_Click(object sender, EventArgs e)
        {
            cui.RestartMusic();
        }

        private bool previousIsSceneActive;
        public void UpdateSceneAvailability(bool isSceneActive)
        {
            if (previousIsSceneActive == isSceneActive)
            {
                return;
            }

            btnCreateObject.Enabled = isSceneActive;
            btnCreateAppearance.Enabled = isSceneActive;

            previousIsSceneActive = isSceneActive;
        }
    }
}
