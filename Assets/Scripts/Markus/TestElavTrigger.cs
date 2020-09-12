using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestElavTrigger : MonoBehaviour
{
    [SerializeField] private Animator anim;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("character_nearby", true);
        }
    }

    private IEnumerator OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            yield return new WaitForSeconds(3f);
            anim.SetBool("character_nearby", false);

            
        }
    }
}
