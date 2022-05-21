using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClipFire;
    public static SoundManager instance;
    // Start is called before the first frame update
    void Awake() 
    { 
        if (SoundManager.instance == null) 
        { 
            SoundManager.instance = this; 
        } 
    }
    public void PlayFireSound() 
    { 
        audioSource.PlayOneShot(audioClipFire); 
    }
}
