using System;
using TJT.SWG;
using UtinniCoreDotNet.Hotkeys;
using UtinniCoreDotNet.UI.Controls;

namespace TJT.UI.SubPanels
{
    public interface IPlayerPanel : ISceneAvailability
    {
        void UpdateSpeed(float value);
        void UpdateCellName(string name);
        void UpdateTeleportToCamera(bool value);
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

        private void sldSpeed_ValueChanged(object sender, EventArgs e)
        {
            nudSpeed.Value = (decimal) sldSpeed.Value;
        }

        private void nudSpeed_ValueChanged(object sender, EventArgs e)
        {
            sldSpeed.Value = (int) nudSpeed.Value;
            playerObject.SetSpeed((float)nudSpeed.Value);
        }

        private void btnResetSpeed_Click(object sender, EventArgs e)
        {
            playerObject.ResetSpeed();
        }

        private bool previousIsSceneActive;
        public void UpdateSceneAvailability(bool isSceneActive)
        {
            if (previousIsSceneActive == isSceneActive)
            {
                return;
            }

            btnTeleport.Enabled = isSceneActive;

            nudX.Enabled = isSceneActive;
            nudY.Enabled = isSceneActive;
            nudZ.Enabled = isSceneActive;
            nudSpeed.Enabled = isSceneActive;
            sldSpeed.Enabled = isSceneActive;
            btnResetSpeed.Enabled = isSceneActive;
            btnToCamera.Enabled = isSceneActive;
            txtCell.Enabled = isSceneActive;

            previousIsSceneActive = isSceneActive;
        }

        private void btnToCamera_Click(object sender, EventArgs e)
        {
            playerObject.TeleportToCamera();
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
            txtCell.Text = name;
        }

        public void UpdateTeleportToCamera(bool value)
        {
            btnToCamera.Enabled = value;
        }

    }
}
