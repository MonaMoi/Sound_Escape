using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioSource audio;

    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
    }
}
