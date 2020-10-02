using System.Threading.Tasks;
using TJT.UI.SubPanels;
using UtinniCore.Utinni;
using UtinniCoreDotNet.Callbacks;
using UtinniCoreDotNet.Hotkeys;

namespace TJT.SWG
{
    public class PlayerObjectImpl
    {
        private float defaultSpeed;
        //private float modifiedSpeed;
        private readonly IPlayerPanel playerPanel;
        public PlayerObjectImpl(IPlayerPanel sceneAvailability, HotkeyManager hotkeyManager)
        {
            this.playerPanel = sceneAvailability;
            GameCallbacks.AddSetupSceneCall(OnSetupSceneCallback);
            GameCallbacks.AddCleanupSceneCall(OnCleanupCallback);

            hotkeyManager.Hotkeys.Add(new Hotkey("ToggleFreeCam", "Tab", ToggleFreeCam, false));
            hotkeyManager.Hotkeys.Add(new Hotkey("HalfSpeed", "Shift, Control + F4", HalfSpeed, false));
            hotkeyManager.Hotkeys.Add(new Hotkey("DoubleSpeed", "Shift, Control + F5", DoubleSpeed, false));
            // hotkeyManager.Hotkeys.Add(new Hotkey("ToggleDefaultSpeed", "Shift, Control + F6", ToggleFreeCam, false)); ToDo
        }

        private void OnSetupSceneCallback()
        {
            playerPanel.UpdateSceneAvailability(true);
            Task updateView = UpdateView();
        }

        private void OnCleanupCallback()
        {
            playerPanel.UpdateSceneAvailability(false);
            playerPanel.UpdateSpeed(0);
        }

        public void Teleport(float x, float y, float z)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                UtinniCore.Utinni.PlayerObject.player_object.Teleport(x, y, z);
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

        private async Task UpdateView()
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
    }
}
