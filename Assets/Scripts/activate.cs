using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate : MonoBehaviour
{

    public GameObject headphones1;
    public GameObject headphones2;
    public GameObject headphones3;

    // Start is called before the first frame update
    void Start()
    {
        headphones1.SetActive(false);
        headphones2.SetActive(false);
        headphones3.SetActive(false);
    }

}
