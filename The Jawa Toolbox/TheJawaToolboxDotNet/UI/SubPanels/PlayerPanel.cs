using System;
using TJT.SWG;
using UtinniCore.Utinni;
using UtinniCoreDotNet.Hotkeys;
using UtinniCoreDotNet.UI.Controls;
using UtinniCoreDotNet.Utility;

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
            sldSpeed.Enabled = isSceneActive;

            btnResetSpeed.Enabled = isSceneActive;

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

        private bool hideCell;

        private void utinniButton1_Click(object sender, EventArgs e)
        {
            //var cell = Game.Player.ParentCell.AppearanceObject;

            //RenderWorldCamera.ClearExcludedObjects();

            //hideCell = !hideCell;
            //if (hideCell)
            //{
            //    RenderWorldCamera.AddExcludedObject(cell);
            //}

            string result = Game.Camera.ParentCell.Name + ": " + Game.Camera.ParentCell.Index;
            Log.InfoSimple(result);

        }
    }
}
