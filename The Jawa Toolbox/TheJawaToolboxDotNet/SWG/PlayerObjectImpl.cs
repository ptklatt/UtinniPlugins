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
    public class PlayerObjectImpl // ToDo have a check on cam and add it to funcs, enable/disable, esp for hotkeys
    {
        private float defaultSpeed;
        //private float modifiedSpeed;
        private readonly IPlayerPanel playerPanel;
        public PlayerObjectImpl(IPlayerPanel sceneAvailability, HotkeyManager hotkeyManager)
        {
            this.playerPanel = sceneAvailability;
            GameCallbacks.AddSetupSceneCall(OnSetupSceneCallback);
            GameCallbacks.AddCleanupSceneCall(OnCleanupCallback);
            GroundSceneCallbacks.AddCameraChangeCallback(OnCameraChangeCallback);

            hotkeyManager.Add(new Hotkey("PlayerHalfSpeed", "Half the Player speed", "F4", HalfSpeed, true, true, true));
            hotkeyManager.Add(new Hotkey("PlayerDoubleSpeed", "Double the Player speed", "F5", DoubleSpeed, true, true, true));
            // hotkeyManager.Add(new Hotkey("ToggleDefaultSpeed", "Shift, Control + F6", ToggleFreeCam, false)); ToDo
        }

        private void OnSetupSceneCallback()
        {
            playerPanel.UpdateSceneAvailability(true);
            Task updateSpeed = UpdateSpeed();
            Task updateCellNames = UpdateCellName();
        }

        private void OnCleanupCallback()
        {
            playerPanel.UpdateSceneAvailability(false);
            playerPanel.UpdateSpeed(0);
            playerPanel.UpdateCellName("");
        }

        private void OnCameraChangeCallback()
        {
            playerPanel.UpdateTeleportToCamera(GroundScene.Get().IsFreeCameraActive);
        }

        public void Teleport(float x, float y, float z)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                if (GroundScene.Get().IsFreeCameraActive)
                {
                    GroundScene.Get().ToggleFreeCamera();
                }

                UtinniCore.Utinni.PlayerObject.player_object.Teleport(x, y, z);
            });
        }

        public void TeleportToCamera()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                var pos = Game.Camera.Transform.Position;
                UtinniCore.Utinni.PlayerObject.player_object.Teleport(pos.X, 0, pos.Y);
            });
        }

        public void SetSpeed(float value)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                //modifiedSpeed = value;
                UtinniCore.Utinni.PlayerObject.player_object.SetSpeed(value);
            });
        }

        public float GetSpeed()
        {
            return UtinniCore.Utinni.PlayerObject.player_object.GetSpeed();
        }

        public void ResetSpeed()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                UtinniCore.Utinni.PlayerObject.player_object.SetSpeed(defaultSpeed);
            });

            playerPanel.UpdateSpeed(defaultSpeed);
        }

        public void HalfSpeed()
        {
            if (!GroundScene.Get().IsFreeCameraActive)
            {
                float value = GetSpeed() / 2;
                SetSpeed(value);
                playerPanel.UpdateSpeed(value);
            }
        }

        public void DoubleSpeed()
        {
            if (!GroundScene.Get().IsFreeCameraActive)
            {
                float value = GetSpeed() * 2;
                SetSpeed(value);
                playerPanel.UpdateSpeed(value);
            }
        }

        public void ToggleDefaultSpeed()
        {
            // ToDo
        }

        private async Task UpdateSpeed()
        {
            while (true)
            {
                await Task.Delay(1);
                if (GroundScene.Get() != null && Game.Player != null && GetSpeed() > 0f)
                {
                    defaultSpeed = GetSpeed();
                    playerPanel.UpdateSpeed(defaultSpeed);
                    break;
                }
            }
        }

        private async Task UpdateCellName()
        {
            while (GroundScene.Get() != null)
            {
                var player = Game.Player;
                if (player != null && player.ParentCell != null)
                {
                    playerPanel.UpdateCellName(player.ParentCell.Name + ": " + player.ParentCell.Index + " (" + 0 + ")"); // ToDo get network id
                }

                await Task.Delay(5);
            }
        }
    }
}
