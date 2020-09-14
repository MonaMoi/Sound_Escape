using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokePlay : MonoBehaviour
{

    public ParticleSystem smoke;


    public void Start()
    {
        StartCoroutine("SmokeStart");
    }

    private IEnumerator SmokeStart()
    {
        yield return new WaitForSeconds(10);
        smoke.Play();
            
    }
}
