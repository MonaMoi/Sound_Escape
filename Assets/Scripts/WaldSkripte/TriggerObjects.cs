using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjects : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;
    public GameObject headphones;
    public GameObject Kopfhoerer;
    public GameObject voegel;
    public GameObject AudioSource;
    public AudioClip Erzaehler;
    
    AudioSource SoundQuelle;

    void Start()
    {
        SoundQuelle=AudioSource.GetComponent<AudioSource>(); //access Prefab audio
    }
    

    void OnTriggerEnter()
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        headphones.SetActive(true);

        voegel.SetActive(true);

        SoundQuelle.clip = Erzaehler;
        SoundQuelle.Play();

        Destroy(Kopfhoerer);
    }

}
