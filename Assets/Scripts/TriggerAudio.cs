using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour
{
    public GameObject AudioSource; //reference to object that will get a new audio
    public GameObject headphones; //headphones to be activated
    public GameObject Kopfhoerer; //headphones to be destroyed
    public AudioClip newAudio; //<---drag mp3 into the inspector here
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio=AudioSource.GetComponent<AudioSource>(); //access Prefab audio
    }

    void OnTriggerEnter()
    {
        headphones.SetActive(true);

        audio.clip = newAudio;
        audio.Play();

        Destroy(Kopfhoerer);
    }

}
