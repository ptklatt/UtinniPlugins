using System;
using TJT.SWG;
using UtinniCoreDotNet.Hotkeys;
using UtinniCoreDotNet.UI.Controls;

namespace TJT.UI.SubPanels
{
    public interface IPlayerPanel : ISceneAvailability
    {
        void UpdateSpeed(float value);
    }

    public partial class PlayerPanel : SubPanel, IPlayerPanel
    {
        private readonly PlayerObjectImpl playerObject;

        public PlayerPanel(HotkeyManager hotkeyManager) : base("Player")
        {
            InitializeComponent();

            playerObject = new PlayerObjectImpl(this, hotkeyManager);
        }

        private void btnTeleport_Click(object sender, EventArgs e)
        {
            playerObject.Teleport((float)nudX.Value, (float)nudY.Value, (float)nudZ.Value);
        }

        private void trkbSpeed_Scroll(object sender, EventArgs e)
        {
            nudSpeed.Value = trkbSpeed.Value;
        }

        private void nudSpeed_ValueChanged(object sender, EventArgs e)
        {
            trkbSpeed.Value = (int) nudSpeed.Value;
            playerObject.SetSpeed((float)nudSpeed.Value);
        }

        private void btnResetSpeed_Click(object sender, EventArgs e)
        {
            playerObject.ResetSpeed();
        }

        private void btnToggleFreeCam_Click(object sender, EventArgs e)
        {
            playerObject.ToggleFreeCam();
        }

        private void btnToggleModel_Click(object sender, EventArgs e)
        {
            playerObject.ToggleModel();
        }

        private bool previousIsSceneActive;
        public void UpdateSceneAvailability(bool isSceneActive)
        {
            if (previousIsSceneActive == isSceneActive)
            {
                return;
            }

            btnTeleport.Enabled = isSceneActive;
            btnToggleFreeCam.Enabled = isSceneActive;
            btnToggleModel.Enabled = isSceneActive;

            nudX.Enabled = isSceneActive;
            nudY.Enabled = isSceneActive;
            nudZ.Enabled = isSceneActive;

            nudSpeed.Enabled = isSceneActive;
            trkbSpeed.Enabled = isSceneActive;

            previousIsSceneActive = isSceneActive;
        }

        public void UpdateSpeed(float value)
        {
            BeginInvoke((Action)(() =>
            {
                nudSpeed.ValueChanged -= nudSpeed_ValueChanged;
                trkbSpeed.ValueChanged -= trkbSpeed_Scroll;

                nudSpeed.Value = (decimal) value;
                trkbSpeed.Value = (int) value;

                nudSpeed.ValueChanged += nudSpeed_ValueChanged;
                trkbSpeed.ValueChanged += trkbSpeed_Scroll;
            }));
        }

    }
}
