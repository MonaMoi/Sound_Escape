using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour
{
    public GameObject PlayerSource; //reference to audio of the narrator
    
    public GameObject AudioSourceToChange; //reference to object that will get a new audio
    public GameObject headphones; //headphones to be activated
    public GameObject Kopfhoerer; //headphones to be destroyed
    public AudioClip newAudio; //<---drag mp3 into the inspector here

    public AudioClip nextNarrator;
    AudioSource audio;

    AudioSource narratorAudio;

    // Start is called before the first frame update
    void Start()
    {
        audio=PlayerSource.GetComponent<AudioSource>(); //access Prefab audio

        narratorAudio=AudioSourceToChange.GetComponent<AudioSource>();
    }

    void OnTriggerEnter()
    {
        headphones.SetActive(true);

        audio.clip = nextNarrator;
        audio.Play();

        narratorAudio.clip = newAudio;
        audio.Play();

        Destroy(Kopfhoerer);
    }

}
