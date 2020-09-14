using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElavDown02 : MonoBehaviour
{
    // public GameObject moveElav;
    [SerializeField] private Animator moveObj;

    private void OnTriggerStay()
    {
       // yield return new WaitForSeconds(3f);
        // moveElav.transform.position += -transform.up * 2*Time.deltaTime;
        moveObj.SetBool("character_in", true);

    }
}
