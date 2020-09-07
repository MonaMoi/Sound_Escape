using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Steurung des Players
public class PlayerWalk : MonoBehaviour
{
    // Variable zur Einstellung der Geschwindigkeit 
    public int Speed;
    
    

    // Bei Klicken des Button wird die Position verändert.
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * Speed * Time.deltaTime;
        }
    }
}