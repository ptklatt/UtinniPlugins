using UtinniCore.Utinni;
using UtinniCoreDotNet.Callbacks;

namespace TJT.SWG
{
    public class CuiImpl
    {
        public CuiImpl() { }

        public void ReloadUi()
        {
            GameCallbacks.AddMainLoopCall(() =>
            {
                UtinniCore.Utinni.CuiMisc.cui_misc.ReloadUi();
            });
        }

        public void RestartMusic()
        {
            GameCallbacks.AddMainLoopCall(() =>
            {
                CuiManager.RestartMusic();
            });
        }
    }
}
