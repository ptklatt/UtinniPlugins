using System;
using TJT.SWG;
using UtinniCoreDotNet.PluginFramework;

namespace TJT.UI.SubPanels
{
    public partial class PlayerPanel : EditorPanelBase
    {
        private readonly PlayerObjectImpl playerObject;

        public PlayerPanel() : base("Player")
        {
            InitializeComponent();

            playerObject = new PlayerObjectImpl();
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

        private void btnToggleFreeCam_Click(object sender, EventArgs e)
        {
            playerObject.ToggleFreeCam();
        }

        private void btnToggleModel_Click(object sender, EventArgs e)
        {
            playerObject.ToggleModel();
        }
    }
}
