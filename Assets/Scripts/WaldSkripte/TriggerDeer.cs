using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeer : MonoBehaviour
{
    public GameObject PlayerSource; //reference to audio of the narrator
    
    public GameObject headphones; //headphones to be activated
    public GameObject Kopfhoerer; //headphones to be destroyed

    public AudioClip nextNarrator;

   AudioSource Audio;

    public GameObject oldDeer;
   public GameObject newDeer;

    // Start is called before the first frame update
    void Start()
    {
        Audio=PlayerSource.GetComponent<AudioSource>(); //access Prefab audio

    }

    void OnTriggerEnter()
    {
        headphones.SetActive(true);

        Audio.clip = nextNarrator;
        Audio.Play();

        Destroy(oldDeer);
        newDeer.SetActive(true);

        Destroy(Kopfhoerer);
    }

}