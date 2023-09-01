using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public AudioClip soundDelay;
    public float delayTime = 2.0f;

    private void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.PlayDelayed(delayTime);
        // audioSource.PlayOneShot();
    }

    // SES
    //public AudioClip clipToPlay;
    //public AudioSource audioSource;
    //void Start()
    //{
    //    audioSource = GetComponent<AudioSource>();
    //    audioSource.clip = clipToPlay;
    //
    //    PlaySound();
    //}
    //public void PlaySound()
    //{
    //    if (!audioSource.isPlaying)
    //    {
    //        audioSource.Play();
    //    }
    //}
    //public void StopSound()
    //{
    //    audioSource.Stop();
    //}
    //

}
