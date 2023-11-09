using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UniRx;
using VContainer;
using VContainer.Unity;

namespace Game.ScreenLoader.Loading
{
    public class LoadingScenePresenter : IAsyncStartable
    {
        private readonly LoadingSceneService _loadingSceneService;
        private readonly LoadingSceneView _loadingSceneView;

        [Inject]
        public LoadingScenePresenter(LoadingSceneService loadingSceneService, LoadingSceneView loadingSceneView)
        {
            _loadingSceneService = loadingSceneService;
            _loadingSceneView = loadingSceneView;
        }

        public UniTask StartAsync(CancellationToken cancellation)
        {
            VVNLog.Print("IStartable.Start()", UnityEngine.Color.white);
            _loadingSceneService
                .ObserveEveryValueChanged(x => x.progress)
                .Subscribe(progressValue =>
                {
                    _loadingSceneView.loadingFill.DOFillAmount(progressValue, 0.2F);
                });
            return LoadingScreen();
        }

        private async UniTask LoadingScreen()
        {
            await _loadingSceneService.LoadSceneAsync();
            _loadingSceneView.FadeOut(0.75F);
        }
    }
}
