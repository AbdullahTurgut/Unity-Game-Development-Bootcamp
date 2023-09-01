using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundVector : MonoBehaviour
{
    public AudioClip soundClip;
    // Start is called before the first frame update
    void Start()
    {
        // sesden uzaklaþýnca azalýr, yakýnlaþýnca artar
        AudioSource.PlayClipAtPoint(soundClip,transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
