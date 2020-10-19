using UtinniCore.DirectX;
using UtinniCore.Utinni;
using UtinniCoreDotNet.Callbacks;

namespace TJT.SWG
{
    public class GraphicsImpl
    {
        public GraphicsImpl() { }

        public void EnableWireframe(bool value)
        {
            GameCallbacks.AddMainLoopCall(() =>
            {
                directx9.ToggleWireframe();
            });
        }

        public void RenderSkeletons(bool value)
        {
            GameCallbacks.AddMainLoopCall(() =>
            {
                UtinniCore.Utinni.SkeletalAppearance.skeleton.SetRenderSkeleton(value);
            });
        }

        public void ReloadTextures()
        {
            GameCallbacks.AddMainLoopCall(() =>
            {
                Graphics.ReloadTextures();
            });
        }
    }
}
