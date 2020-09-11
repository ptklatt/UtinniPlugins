using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TJT.UI.SubPanels;
using UtinniCoreDotNet.PluginFramework;
using UtinniCoreDotNet.UI.Controls;
using UtinniCoreDotNet.Utility;

namespace TJT
{
    public class TheJawaToolboxPlugin : IEditorPlugin
    {
        private readonly List<SubPanelContainer> panels = new List<SubPanelContainer>();

        public TheJawaToolboxPlugin()
        {
            Information = new PluginInformation("The Jawa Toolbox"
                , "An SWG Client development toolbox"
                , "Timbab");

            Log.Info("Created: The Jawa Toolbox");

            // ToDo show/hide panels based on avail GroundScene, obj, etc

            panels.Add(new SubPanelContainer("Controls", new SubPanel[]
            {
                new ScenePanel(this),
                new PlayerPanel(),
                new GraphicsPanel(),
                new MiscPanel()
            }));
        }

        public PluginInformation Information { get; }

        public EventHandler<AddUndoCommandEventArgs> AddUndoCommand { get; set; }

        public List<Form> GetForms() { return null; }

        public List<SubPanelContainer> GetStandalonePanels()
        {
            return panels;
        }

        public List<SubPanel> GetSubPanels() { return null; }
    }
}
