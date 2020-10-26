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

            hotkeyManager.Hotkeys.Add("ToggleFreeCam", new Hotkey("ToggleFreeCam", "Shift + Tab", ToggleFreeCam, true));
            hotkeyManager.Hotkeys.Add("CameraHalfSpeed", new Hotkey("CameraHalfSpeed", "F4", HalfSpeed, true));
            hotkeyManager.Hotkeys.Add("CameraDoubleSpeed", new Hotkey("CameraDoubleSpeed", "F5", DoubleSpeed, true));
            // hotkeyManager.Hotkeys.Add(new Hotkey("ToggleDefaultSpeed", "Shift, Control + F6", ToggleFreeCam, false)); ToDo
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
            float value = GetSpeed() / 2;
            SetSpeed(value);
            freeCamPanel.UpdateSpeed(value);
        }

        public void DoubleSpeed()
        {
            float value = GetSpeed() * 2;
            SetSpeed(value);
            freeCamPanel.UpdateSpeed(value);
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
