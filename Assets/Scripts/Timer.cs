using UnityEngine;
 using System.Collections;
 
 public class Timer: MonoBehaviour {
 
   public float targetTime = 15.0f;
   public GameObject Birds;

   public AudioSource sound;
   
   void Update(){
      
      //verringert das Volumen um den Wert je Frame-Update
      sound.volume -= 0.0015f;

      //transform.position += Vector3.right * Time.deltaTime*20;
      targetTime -= Time.deltaTime;
      if (targetTime <= 0.0f){
         timerEnded();
       }

      }
 
 void timerEnded()
 {
    Destroy(Birds);
 }
 
 
 }