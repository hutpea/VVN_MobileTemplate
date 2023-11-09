using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using VVN.Core.ScreenLoader;

namespace Game.ScreenLoader.Loading
{
    public class LoadingSceneService
    {
        public float progress = 0F;

        public async UniTask LoadSceneAsync()
        {
            VVNLog.Print("Begin Loading!", color: Color.cyan);
            progress = 0.1F;
            await UniTask.Delay(500);
            progress = 0.2F;
            await UniTask.Delay(500);
            progress = 0.4F;
            await UniTask.Delay(500);
            progress = 0.6F;
            await UniTask.Delay(500);
            progress = 0.8F;
            await UniTask.Delay(500);
            progress = 1F;
            
            VVNLog.Print("Finish Load Next Scene!", color: Color.blue);
        }
    }
}
