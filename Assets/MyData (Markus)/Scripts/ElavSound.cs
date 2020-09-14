using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElavSound : MonoBehaviour
{
    public AudioSource Source;
    public AudioSource Source2;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Wait");
    }


    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(5.0f);
        Source.Play();
        yield return new WaitForSeconds(3.0f);
        Source2.Play();
    }
}
