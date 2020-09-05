using UtinniCoreDotNet.Callbacks;

namespace TJT.SWG
{
    public class PlayerObjectImpl
    {
        public PlayerObjectImpl() { }

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
