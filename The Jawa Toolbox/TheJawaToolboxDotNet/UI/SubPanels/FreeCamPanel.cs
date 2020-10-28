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
using UtinniCoreDotNet.Hotkeys;
using UtinniCoreDotNet.UI.Controls;

namespace TJT.UI.SubPanels
{
    public interface IFreeCamPanel : ISceneAvailability
    {
        void UpdateSpeed(float value);
        void UpdateCellName(string name);
        void UpdateFreecamAvailability(bool isFreeCamActive);
    }

    public partial class FreeCamPanel : SubPanel, IFreeCamPanel
    {
        private readonly FreeCamImpl freeCamImpl;

        public FreeCamPanel(HotkeyManager hotkeyManager) : base("FreeCam")
        {
            InitializeComponent();

            freeCamImpl = new FreeCamImpl(this, hotkeyManager);
        }

        private void btnTeleport_Click(object sender, EventArgs e)
        {
            freeCamImpl.Teleport((float)nudX.Value, (float)nudY.Value, (float)nudZ.Value);
        }

        private void sldSpeed_ValueChanged(object sender, EventArgs e)
        {
            nudSpeed.Value = (decimal) sldSpeed.Value;
        }

        private void nudSpeed_ValueChanged(object sender, EventArgs e)
        {
            sldSpeed.Value = (int) nudSpeed.Value;
            freeCamImpl.SetSpeed((float)nudSpeed.Value);
        }

        private void btnResetSpeed_Click(object sender, EventArgs e)
        {
            freeCamImpl.ResetSpeed();
        }

        private bool previousIsSceneActive;
        public void UpdateSceneAvailability(bool isSceneActive)
        {
            if (previousIsSceneActive == isSceneActive)
            {
                return;
            }

            chkFreeCam.Enabled = isSceneActive;
            txtCellName.Enabled = isSceneActive;

            previousIsSceneActive = isSceneActive;
        }

        public void UpdateSpeed(float value)
        {
            nudSpeed.ValueChanged -= nudSpeed_ValueChanged;
            sldSpeed.ValueChanged -= sldSpeed_ValueChanged;

            nudSpeed.Value = (decimal)value;
            sldSpeed.Value = value;

            nudSpeed.ValueChanged += nudSpeed_ValueChanged;
            sldSpeed.ValueChanged += sldSpeed_ValueChanged;
        }

        public void UpdateCellName(string name)
        {
            txtCellName.Text = name;
        }

        public void UpdateFreecamAvailability(bool isFreeCamActive)
        {
            nudX.Enabled = isFreeCamActive;
            nudY.Enabled = isFreeCamActive;
            nudZ.Enabled = isFreeCamActive;
            nudSpeed.Enabled = isFreeCamActive;
            sldSpeed.Enabled = isFreeCamActive;
            btnResetSpeed.Enabled = isFreeCamActive;
            btnTeleport.Enabled = isFreeCamActive;

            chkPlayerModel.Enabled = isFreeCamActive;
            chkDragPlayer.Enabled = isFreeCamActive;

            if (isFreeCamActive && !chkDragPlayer.Checked)
            {
                btnToPlayer.Enabled = true;
            }
            else
            {
                btnToPlayer.Enabled = false;
            }

            if (!isFreeCamActive)
            {
                chkFreeCam.CheckedChanged -= chkFreeCam_CheckedChanged;
                chkPlayerModel.CheckedChanged -= chkPlayerModel_CheckedChanged;

                chkFreeCam.Checked = false;
                chkPlayerModel.Checked = true;

                chkFreeCam.CheckedChanged += chkFreeCam_CheckedChanged;
                chkPlayerModel.CheckedChanged += chkPlayerModel_CheckedChanged;
            }
        }

        private void chkFreeCam_CheckedChanged(object sender, EventArgs e)
        {
            freeCamImpl.ToggleFreeCam();
        }

        private void chkPlayerModel_CheckedChanged(object sender, EventArgs e)
        {
            freeCamImpl.ToggleModel();
        }

        private void chkDragPlayer_CheckedChanged(object sender, EventArgs e)
        {
            freeCamImpl.EnableDragPlayer(chkDragPlayer.Checked);
            btnToPlayer.Enabled = !chkDragPlayer.Checked;
        }

        private void btnToPlayer_Click(object sender, EventArgs e)
        {
            freeCamImpl.TeleportToPlayer();
        }
    }
}
