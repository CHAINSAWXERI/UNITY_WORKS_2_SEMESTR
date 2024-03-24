using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : ISoundPlayer
{
    private AudioSource audioSource;

    public SoundPlayer(AudioSource source)
    {
        audioSource = source;
    }

    public void PlayOpenSound()
    {
        audioSource.Play();
    }

    public void PlayCloseSound()
    {
        audioSource.Play();
    }
}
