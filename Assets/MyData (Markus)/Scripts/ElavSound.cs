using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElavSound : MonoBehaviour
{
    public AudioSource Source;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Wait");
    }


    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(5.0f);
        Source.Play();
    }
}
