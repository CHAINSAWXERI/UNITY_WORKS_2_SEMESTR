using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FadeService : IFadeService
{
    public void FadeIn(Image image, float duration)
    {
        image.DOFade(1f, duration);
    }

    public void FadeOut(Image image, float duration)
    {
        image.DOFade(0f, duration);
    }
}
