using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using TJT.UI;
using TJT.UI.SubPanels;
using UtinniCore.Utinni;
using UtinniCoreDotNet.Hotkeys;
using UtinniCoreDotNet.PluginFramework;
using UtinniCoreDotNet.UI.Controls;
using UtinniCoreDotNet.UI.Forms;
using UtinniCoreDotNet.Utility;

namespace TJT
{
    public class TheJawaToolboxPlugin : IEditorPlugin
    {
        private readonly HotkeyManager hotkeyManager = new HotkeyManager(false);
        private readonly List<IEditorForm> forms = new List<IEditorForm>();
        private readonly List<SubPanelContainer> panels = new List<SubPanelContainer>();
        private readonly UtINI ini;

        public TheJawaToolboxPlugin()
        {
            Information = new PluginInformation("The Jawa Toolbox"
                , "An SWG Client development toolbox"
                , "Timbab");

            Log.Info("Created: The Jawa Toolbox");

            ini = new UtINI(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\settings.ini");

            forms.Add(new FormObjectBrowser(this));

            panels.Add(new SubPanelContainer("Controls", new SubPanel[]
            {
                new ScenePanel(this, hotkeyManager, ini),
                new PlayerPanel(hotkeyManager),
                new GraphicsPanel(ini),
                new MiscPanel(ini)
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

        public List<IEditorForm> GetForms()
        {
            return forms;
        }

        public List<SubPanelContainer> GetStandalonePanels()
        {
            return panels;
        }

        public List<SubPanel> GetSubPanels() { return null; }
    }
}
