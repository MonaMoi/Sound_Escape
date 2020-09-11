using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjects : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;
    public GameObject headphones;
    public GameObject Kopfhoerer;
    
    public GameObject voegel;

    // Start is called before the first frame update
    

    void OnTriggerEnter()
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        headphones.SetActive(true);

        voegel.SetActive(true);

        Destroy(Kopfhoerer);
    }

}
