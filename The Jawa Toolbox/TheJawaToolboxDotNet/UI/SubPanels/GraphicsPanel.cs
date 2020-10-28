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
