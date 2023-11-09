using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using VVN.Core.ScreenLoader;

namespace Game.ScreenLoader.Loading
{
    public class LoadingSceneView : VVNView
    {
        public Image loadingFill;
        public CanvasGroup canvasGroup;

        public void FadeOut(float duration)
        {
            canvasGroup.DOFade(0F, duration = 1F);
        }
    }
}
