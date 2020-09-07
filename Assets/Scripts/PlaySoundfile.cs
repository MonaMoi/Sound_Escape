using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundfile : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    public bool a_audio = true;

    void Start()
    {
        audio = GetComponent <AudioSource>();
    }

    void OnTriggerEnter()
    {
        if(a_audio == true)
        {
            audio.Play();
            a_audio = false;  
        }
    }

    void OnTriggerExit()
    {
        if(a_audio == false)        
        {
            audio.Stop(); 
            a_audio = true; 
        }
    }  
}

