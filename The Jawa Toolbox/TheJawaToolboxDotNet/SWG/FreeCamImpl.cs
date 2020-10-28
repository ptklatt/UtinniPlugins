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

using System.Threading.Tasks;
using TJT.UI.SubPanels;
using UtinniCore.Utinni;
using UtinniCoreDotNet.Callbacks;
using UtinniCoreDotNet.Hotkeys;

namespace TJT.SWG
{
    public class FreeCamImpl // ToDo have a check on cam and add it to funcs, enable/disable, esp for hotkeys
    {
        private float defaultSpeed;
        //private float modifiedSpeed;
        private readonly IFreeCamPanel freeCamPanel;
        public FreeCamImpl(IFreeCamPanel sceneAvailability, HotkeyManager hotkeyManager)
        {
            this.freeCamPanel = sceneAvailability;
            GameCallbacks.AddSetupSceneCall(OnSetupSceneCallback);
            GameCallbacks.AddCleanupSceneCall(OnCleanupCallback);
            GroundSceneCallbacks.AddCameraChangeCallback(OnCameraChangeCallback);

            hotkeyManager.Add(new Hotkey("ToggleFreeCam", "Toggle FreeCam", "Shift + Tab", ToggleFreeCam, true));
            hotkeyManager.Add(new Hotkey("CameraHalfSpeed", "Half the Camera speed", "F4", HalfSpeed, true));
            hotkeyManager.Add(new Hotkey("CameraDoubleSpeed", "Double the Camera speed", "F5", DoubleSpeed, true));
            // hotkeyManager.Add(new Hotkey("ToggleDefaultSpeed", "Shift, Control + F6", ToggleFreeCam, false)); ToDo
        }

        private void OnSetupSceneCallback()
        {
            freeCamPanel.UpdateSceneAvailability(true);
            Task updateSpeed = UpdateSpeed();
            Task updateCellNames = UpdateCellName();
        }

        private void OnCleanupCallback()
        {
            freeCamPanel.UpdateSceneAvailability(false); 
            freeCamPanel.UpdateFreecamAvailability(false);
            freeCamPanel.UpdateSpeed(0);
            freeCamPanel.UpdateCellName("");

        }

        private void OnCameraChangeCallback()
        {
            freeCamPanel.UpdateFreecamAvailability(GroundScene.Get().IsFreeCameraActive);
        }

        public void Teleport(float x, float y, float z)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                Game.Camera.Transform.SetPosition(x, y, z);
            });
        }

        public void TeleportToPlayer()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                var pos = Game.Player.Transform.Position;

                Game.Camera.Transform.SetPosition(pos.X, pos.Y + 10, pos.Z);
            });
        }

        public void SetSpeed(float value)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                //modifiedSpeed = value;
                UtinniCore.Utinni.DebugCamera.debug_camera.SetSpeed(value);
            });
        }

        public float GetSpeed() 
        {
            return UtinniCore.Utinni.DebugCamera.debug_camera.GetSpeed();
        }

        public void ResetSpeed()  // ToDo
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                UtinniCore.Utinni.DebugCamera.debug_camera.SetSpeed(defaultSpeed);
            });

            freeCamPanel.UpdateSpeed(defaultSpeed);
        }

        public void HalfSpeed()
        {
            if (GroundScene.Get().IsFreeCameraActive)
            {
                float value = GetSpeed() / 2;
                SetSpeed(value);
                freeCamPanel.UpdateSpeed(value);
            }
        }

        public void DoubleSpeed()
        {
            if (GroundScene.Get().IsFreeCameraActive)
            {
                float value = GetSpeed() * 2;
                SetSpeed(value);
                freeCamPanel.UpdateSpeed(value);
            }
        }

        public void ToggleDefaultSpeed()
        {
            // ToDo
        }

        public void ToggleFreeCam()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                GroundScene.Get().ToggleFreeCamera();
            });
        }

        public void ToggleModel()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                UtinniCore.Utinni.PlayerObject.player_object.TogglePlayerAppearance();
            });
        }

        public void EnableDragPlayer(bool value)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                UtinniCore.Utinni.DebugCamera.debug_camera.EnableDragPlayer(value);
            });
        }

        private async Task UpdateSpeed()
        {
            while (true)
            {
                await Task.Delay(1);
                if (GroundScene.Get() != null && Game.Camera != null && GetSpeed() > 0f)
                {
                    defaultSpeed = GetSpeed();
                    freeCamPanel.UpdateSpeed(defaultSpeed);
                    break;
                }
            }
        }

        private async Task UpdateCellName()
        {
            while (GroundScene.Get() != null)
            {
                var camera = Game.Camera;
                if (camera != null && camera.ParentCell != null)
                {
                    freeCamPanel.UpdateCellName(camera.ParentCell.Name + ": " + camera.ParentCell.Index + " (" + 0 + ")"); // ToDo get network id
                }

                await Task.Delay(5);
            }
        }
    }
}
