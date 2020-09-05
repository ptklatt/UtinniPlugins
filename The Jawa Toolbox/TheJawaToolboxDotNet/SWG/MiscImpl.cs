using UtinniCore.Utinni;
using UtinniCoreDotNet.Callbacks;

namespace TJT.SWG
{
    public class MiscImpl
    {
        public MiscImpl() { }

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
