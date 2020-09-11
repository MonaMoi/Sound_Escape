using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevTrig : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private Animator anim1;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("openDoor", true);
            anim1.SetBool("openDoor", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("openDoor", false);
            anim1.SetBool("openDoor", false);
        }
    }
}
