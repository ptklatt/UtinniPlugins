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
        }
    }
}
