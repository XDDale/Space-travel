using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic1()
    {
        if (audioSource.isPlaying == false)
        {
            audioSource.Play();
        }
    }

    public void StopMusic1()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }

    public void PauseMusic1()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
    }
}