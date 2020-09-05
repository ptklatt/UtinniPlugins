using System.Threading.Tasks;
using TJT.UI.SubPanels;
using UtinniCore.Utinni;
using UtinniCoreDotNet.Callbacks;

namespace TJT.SWG
{
    public class GroundSceneImpl
    {
        private IScenePanel scenePanel;

        public GroundSceneImpl(IScenePanel scenePanel)
        {
            this.scenePanel = scenePanel;

            Task updateView = UpdateView();
        }

        public void Load(string sceneName, string avatarObjectFilename)
        {
            GameCallbacks.AddMainLoopCall(() =>
            {
                Game.LoadScene(sceneName, avatarObjectFilename);
            });
        }

        public void Unload()
        {
            GameCallbacks.AddMainLoopCall(() =>
            {
                Game.CleanupScene();
            });
        }

        public void Reload()
        {
            GameCallbacks.AddMainLoopCall(() =>
            {
                GroundScene.Get().ReloadTerrain();
            });
        }

        public void SetWeatherIndex(int value)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                Terrain.Get().WeatherIndex = value;
            });
        }

        public void SetTimeOfDay(float value)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                Terrain.Get().TimeOfDay = value / 1000f; // divide by 1000f to get the correct decimal value
            });
        }

        public void AllowTargetEverything(bool value)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                UtinniCore.Utinni.CuiHud.cui_hud.PatchAllowTargetEverything(value);
            });
        }

        private async Task UpdateView()
        {
            while (true)
            {
                await Task.Delay(1);
                if (GroundScene.Get() != null && Terrain.Get() != null)
                {
                    GroundSceneCallbacks.AddUpdateLoopCall(() =>
                    {
                        scenePanel.UpdateTimeOfDay((int)(Terrain.Get().TimeOfDay * 1000)); // multiply by 1000f to get the correct trackbar value
                    });
                }
               
            }
        }
    }
}
