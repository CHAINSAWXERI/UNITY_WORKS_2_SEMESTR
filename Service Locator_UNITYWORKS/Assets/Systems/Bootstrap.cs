using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] Image image;
    private void Start()
    {
        IFadeService fadeService = new FadeService();
        ISoundPlayer soundPlayer = new SoundPlayer(audioSource);

        ServiceLocator serviceLocator = new ServiceLocator(fadeService, soundPlayer);

        FadeService fetchedFadeService = new FadeService();
        SoundPlayer fetchedSoundPlayer = new SoundPlayer(audioSource);

        fetchedFadeService.FadeIn(image, 1f);
        fetchedSoundPlayer.PlayOpenSound();
    }
}