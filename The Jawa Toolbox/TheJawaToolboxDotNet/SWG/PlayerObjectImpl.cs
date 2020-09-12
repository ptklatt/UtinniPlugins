﻿using TJT.UI;
using UtinniCoreDotNet.Callbacks;

namespace TJT.SWG
{
    public class PlayerObjectImpl
    {
        public PlayerObjectImpl() { }
        private readonly ISceneAvailability sceneAvailability;
        public PlayerObjectImpl(ISceneAvailability sceneAvailability, HotkeyManager hotkeyManager)
        {
            this.sceneAvailability = sceneAvailability;
            GameCallbacks.AddSetupSceneCall(OnSetupSceneCallback);
            GameCallbacks.AddCleanupSceneCall(OnCleanupCallback);

        }

        private void OnSetupSceneCallback()
        {
            sceneAvailability.UpdateSceneAvailability(true);
        }

        private void OnCleanupCallback()
        {
            sceneAvailability.UpdateSceneAvailability(false);
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