using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class IAudio : MonoBehaviour
{
    private AudioSource audioSource;
    bool play = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Play()
    {
        if (!play)
        {
            audioSource.Play();
            play = true;
        }
    }

    public void Stop()
    {
        audioSource.Stop();
        play = false;
    }
}
