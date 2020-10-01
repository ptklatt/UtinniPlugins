using TJT.UI.SubPanels;
using UtinniCoreDotNet.Callbacks;
using UtinniCoreDotNet.Hotkeys;

namespace TJT.SWG
{
    public class PlayerObjectImpl
    {
        private float defaultSpeed;
        private readonly IPlayerPanel sceneAvailability;
        public PlayerObjectImpl(IPlayerPanel sceneAvailability, HotkeyManager hotkeyManager)
        {
            this.sceneAvailability = sceneAvailability;
            GameCallbacks.AddSetupSceneCall(OnSetupSceneCallback);
            GameCallbacks.AddCleanupSceneCall(OnCleanupCallback);

            hotkeyManager.Hotkeys.Add(new Hotkey("ToggleFreeCam", "Tab", ToggleFreeCam, false));
            hotkeyManager.Hotkeys.Add(new Hotkey("HalfSpeed", "Shift, Control + F4", HalfSpeed, false));
            hotkeyManager.Hotkeys.Add(new Hotkey("DoubleSpeed", "Shift, Control + F5", DoubleSpeed, false));
        }

        private void OnSetupSceneCallback()
        {
            sceneAvailability.UpdateSceneAvailability(true);
            defaultSpeed = GetSpeed();
            sceneAvailability.UpdateSpeed(defaultSpeed);
        }

        private void OnCleanupCallback()
        {
            sceneAvailability.UpdateSceneAvailability(false);
            sceneAvailability.UpdateSpeed(0);
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
        }

        public void HalfSpeed()
        {
            float value = GetSpeed() / 2;
            SetSpeed(value);
            sceneAvailability.UpdateSpeed(value);
        }

        public void DoubleSpeed()
        {
            float value = GetSpeed() * 2;
            SetSpeed(value);
            sceneAvailability.UpdateSpeed(value);
        }

        public void ToggleFreeCam()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                UtinniCore.Utinni.GroundScene.Get().ToggleFreeCamera();
            });
        }

        public void ToggleModel()
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                UtinniCore.Utinni.PlayerObject.player_object.TogglePlayerAppearance();
            });
        }
    }
}
