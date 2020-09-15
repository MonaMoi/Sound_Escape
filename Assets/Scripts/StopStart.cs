using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopStart : MonoBehaviour
{
    public Animator animator;


    public AudioSource SoundToPlay1;
    public AudioSource SoundToPlay2;
    public AudioSource SoundToPlay3;
    public AudioSource SoundToPlay4;
    public AudioSource SoundToPlay5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("player_nearby", true);
        }

        StartCoroutine(PlaySounds());



    }

    private IEnumerator PlaySounds()
    {
        yield return new WaitForSeconds(4);
        SoundToPlay1.Play();
        yield return new WaitForSeconds(3f);
        SoundToPlay2.Play();
        yield return new WaitForSeconds(6f);
        SoundToPlay3.Play();
        yield return new WaitForSeconds(6f);
        SoundToPlay4.Play();
        yield return new WaitForSeconds(7.5f);
        SoundToPlay5.Play();
    }

}
