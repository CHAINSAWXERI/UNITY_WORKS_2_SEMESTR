using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionalPanelController : IUIState
{
    private AdditionalPanelView additionalPanelView;
    public AdditionalPanelController(AdditionalPanelView view)
    {
        additionalPanelView = view;
    }

    public void Enter()
    {
        additionalPanelView.gameObject.SetActive(true);
    }

    public void Exit()
    {
        additionalPanelView.gameObject.SetActive(false);
    }
}

/*
fetchedFadeService.FadeOut(image, 1f);
        fetchedSoundPlayer.PlayOpenSound();

fetchedFadeService.FadeIn(image, 1f);
        fetchedSoundPlayer.PlayOpenSound();

*/