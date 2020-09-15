using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerReh : MonoBehaviour
{
    public GameObject SpeakingReh;
   void OnTriggerEnter() {

       SpeakingReh.SetActive(true);

   }
}
