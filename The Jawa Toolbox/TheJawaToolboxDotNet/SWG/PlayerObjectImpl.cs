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

            hotkeyManager.Hotkeys.Add("PlayerHalfSpeed", new Hotkey("PlayerHalfSpeed", "F4", HalfSpeed, true));
            hotkeyManager.Hotkeys.Add("PlayerDoubleSpeed", new Hotkey("PlayerDoubleSpeed", "F5", DoubleSpeed, true));
            // hotkeyManager.Hotkeys.Add(new Hotkey("ToggleDefaultSpeed", "Shift, Control + F6", ToggleFreeCam, false)); ToDo
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
            float value = GetSpeed() / 2;
            SetSpeed(value);
            playerPanel.UpdateSpeed(value);
        }

        public void DoubleSpeed()
        {
            float value = GetSpeed() * 2;
            SetSpeed(value);
            playerPanel.UpdateSpeed(value);
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
