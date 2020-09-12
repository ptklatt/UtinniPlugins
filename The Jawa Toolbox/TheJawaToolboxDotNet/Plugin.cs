using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TJT.UI.SubPanels;
using UtinniCoreDotNet.Hotkeys;
using UtinniCoreDotNet.PluginFramework;
using UtinniCoreDotNet.UI.Controls;
using UtinniCoreDotNet.Utility;

namespace TJT
{
    public class TheJawaToolboxPlugin : IEditorPlugin
    {
        private readonly HotkeyManager hotkeyManager = new HotkeyManager(false);
        private readonly List<SubPanelContainer> panels = new List<SubPanelContainer>();

        public TheJawaToolboxPlugin()
        {
            Information = new PluginInformation("The Jawa Toolbox"
                , "An SWG Client development toolbox"
                , "Timbab");

            Log.Info("Created: The Jawa Toolbox");

            panels.Add(new SubPanelContainer("Controls", new SubPanel[]
            {
                new ScenePanel(hotkeyManager, this),
                new PlayerPanel(hotkeyManager),
                new GraphicsPanel(),
                new MiscPanel()
            }));
            
            hotkeyManager.CreateSettings();
            hotkeyManager.Load();
        }

        public PluginInformation Information { get; }

        public EventHandler<AddUndoCommandEventArgs> AddUndoCommand { get; set; }

        public HotkeyManager GetHotkeyManager()
        {
            return hotkeyManager;
        }

        public List<Form> GetForms() { return null; }

        public List<SubPanelContainer> GetStandalonePanels()
        {
            return panels;
        }

        public List<SubPanel> GetSubPanels() { return null; }
    }
}
