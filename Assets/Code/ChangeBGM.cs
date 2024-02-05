using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeBGM : MonoBehaviour
{
    public AudioClip newClip;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource musicPlayer = FindObjectOfType<AudioSource>();
            if (musicPlayer != null && newClip != null)
            {
                musicPlayer.clip = newClip;
                musicPlayer.Play();
            }
        }
    }
}