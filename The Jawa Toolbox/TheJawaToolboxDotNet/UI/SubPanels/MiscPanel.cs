using System;
using TJT.SWG;
using UtinniCoreDotNet.PluginFramework;

namespace TJT.UI.SubPanels
{
    public partial class MiscPanel : EditorPanelBase
    {
        private readonly CuiImpl cui;
        private readonly MiscImpl misc;

        public MiscPanel() : base("Misc")
        {
            InitializeComponent();

            cui = new CuiImpl();;
            misc = new MiscImpl();
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
    }
}
