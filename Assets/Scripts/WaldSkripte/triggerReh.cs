using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerReh : MonoBehaviour
{
    public GameObject SpeakingReh;
    public GameObject Trigger;

   void OnTriggerEnter() {

       SpeakingReh.SetActive(true);
       Destroy(Trigger);

   }
}
