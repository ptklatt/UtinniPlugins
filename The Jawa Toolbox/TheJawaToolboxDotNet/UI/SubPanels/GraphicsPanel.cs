using System;
using TJT.SWG;
using UtinniCoreDotNet.UI.Controls;

namespace TJT.UI.SubPanels
{
    public partial class GraphicsPanel : SubPanel
    {
        private readonly GraphicsImpl graphics;
        public GraphicsPanel() : base("Graphics")
        {
            InitializeComponent();
            graphics = new GraphicsImpl();
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
