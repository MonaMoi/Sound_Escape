using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
   
   public GameObject AudioSource;
    public GameObject Prefab;
    public GameObject Kopfhoerer;

    public AudioClip Erzaehler;
    
    AudioSource SoundQuelle;

    void Start()
    {
        SoundQuelle=AudioSource.GetComponent<AudioSource>(); //access Prefab audio
    }
    
    

    void OnTriggerEnter()
    {
        Prefab.SetActive(true);
        
        SoundQuelle.clip = Erzaehler;
        SoundQuelle.Play();

        Destroy(Kopfhoerer);
    }

}
