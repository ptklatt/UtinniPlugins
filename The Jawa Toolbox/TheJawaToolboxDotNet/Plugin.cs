using System;
using System.Collections.Generic;
using TJT.UI.SubPanels;
using UtinniCoreDotNet.PluginFramework;
using UtinniCoreDotNet.Utility;

namespace TJT
{
    public class TheJawaToolboxPlugin : IEditorPlugin
    {
        private readonly List<EditorPanelBase> panels = new List<EditorPanelBase>();

        public TheJawaToolboxPlugin()
        {
            Information = new PluginInformation("The Jawa Toolbox"
                , "An SWG Client development toolbox"
                , "Timbab");

            Log.Info("Created: The Jawa Toolbox");

            // ToDo show/hide panels based on avail GroundScene, obj, etc

            panels.AddRange(new EditorPanelBase[]
            {
                new ScenePanel(this),
                new PlayerPanel(),
                new GraphicsPanel(),
                new MiscPanel()
            });
        }

        public PluginInformation Information { get; }

        public EventHandler<AddUndoCommandEventArgs> AddUndoCommand { get; set; }

        public List<EditorPanelBase> GetStandalonePanels()
        {
            return panels;
        }

        public List<EditorPanelBase> GetSubPanels() { return null; }
    }
}
