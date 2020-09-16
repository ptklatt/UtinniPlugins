using System;
using TJT.SWG;
using UtinniCore.Utinni;
using UtinniCoreDotNet.UI.Controls;
using UtinniCoreDotNet.Utility;

namespace TJT.UI.SubPanels
{
    public partial class GraphicsPanel : SubPanel
    {
        private readonly GraphicsImpl graphics;

        public GraphicsPanel(UtINI ini) : base("Graphics")
        {
            InitializeComponent();

            graphics = new GraphicsImpl();

            CreateSettings(ini);
            ini.Load();

            Log.InfoSimple(ini.GetString("Scene", "defaultTerrainFilename"));

            chkWireframe.Checked = ini.GetBool("Graphics", "autoEnableWireframe");
        }

        private void CreateSettings(UtINI ini)
        {
            ini.AddSetting("Graphics", "autoEnableWireframe", "false", UtINI.Value.Types.VtBool);
        }

        private void chkWireframe_CheckedChanged(object sender, EventArgs e)
        {
            graphics.EnableWireframe(chkWireframe.Checked);
        }

        private void chkRenderSkeletons_CheckedChanged(object sender, EventArgs e)
        {
            graphics.RenderSkeletons(chkRenderSkeletons.Checked);
        }

        private void btnReloadTextures_Click(object sender, EventArgs e)
        {
            graphics.ReloadTextures();
        }
    }
}
