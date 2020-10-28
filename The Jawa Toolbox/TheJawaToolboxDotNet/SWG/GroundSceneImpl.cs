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

using System.Collections.Generic;
using System.Threading.Tasks;
using TJT.UI.SubPanels;
using UtinniCore.Utinni;
using UtinniCoreDotNet.Callbacks;
using UtinniCoreDotNet.Hotkeys;

namespace TJT.SWG
{
    public class GroundSceneImpl
    {
        private readonly IScenePanel scenePanel;

        public GroundSceneImpl(IScenePanel scenePanel, HotkeyManager hotkeyManager)
        {
            this.scenePanel = scenePanel;

            GameCallbacks.AddInstallCallback(OnInstallCallback);
            GameCallbacks.AddSetupSceneCall(OnSetupSceneCallback);
            GameCallbacks.AddCleanupSceneCall(OnCleanupCallback);

            Task updateView = UpdateView();
        }

        private void OnInstallCallback()
        {
            var dirInfo = Game.Repository.GetDirectoryInfo("terrain");

            List<string> terrains = new List<string>();

            for (int i = 0; i < dirInfo.Size; i++)
            {
                string terrainFile = Game.Repository.GetFilenameAt(dirInfo.StartIndex + i);

                if (terrainFile.EndsWith(".trn"))
                {
                    terrains.Add(terrainFile);
                }
            }

            scenePanel.SetCmbScenes(terrains);
        }

        private void OnSetupSceneCallback()
        {
            scenePanel.UpdateSceneAvailability(true);
        }

        private void OnCleanupCallback()
        {
            scenePanel.UpdateSceneAvailability(false);
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

        public void ForceModalChat()
        {
            UtinniCore.Swg.Config.config.EnableModalChat(true); // ToDo move this elsewhere
        }
    }
}
