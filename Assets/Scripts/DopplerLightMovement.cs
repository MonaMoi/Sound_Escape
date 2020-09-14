using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DopplerLightMovement : MonoBehaviour
{
    private bool dirRight = true;
     public float speed = 2.0f;
 
     void Update () {
         if (dirRight)
             transform.Translate (Vector2.right * speed * Time.deltaTime);
         else
             transform.Translate (-Vector2.right * speed * Time.deltaTime);
         
         if(transform.position.x >= 53.27) {
             dirRight = false;
         }
         
         if(transform.position.x <=- 13.63f) {
             dirRight = true;
         }
     }
}
