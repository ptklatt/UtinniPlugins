using TJT.UI;
using UtinniCore.Utinni;
using UtinniCoreDotNet.Callbacks;

namespace TJT.SWG
{
    public class MiscImpl
    {
        private readonly ISceneAvailability sceneAvailability;
        public MiscImpl(ISceneAvailability sceneAvailability)
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

        public void CreateObject(string filename)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                GroundScene.Get().CreateObjectAtPlayer(filename);
            });
        }

        public void CreateAppearance(string filename)
        {
            GroundSceneCallbacks.AddUpdateLoopCall(() =>
            {
                GroundScene.Get().CreateAppearanceAtPlayer(filename);
            });
        }
    }
}
