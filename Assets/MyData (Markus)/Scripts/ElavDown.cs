using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.EventSystems;

public class ElavDown : MonoBehaviour //, IPointerClickHandler
{


    // public GameObject moveElav;
    [SerializeField] private Animator moveObj;

    private IEnumerator OnTriggerStay()
    {
        yield return new WaitForSeconds(3f);
        // moveElav.transform.position += -transform.up * 2*Time.deltaTime;
        moveObj.SetBool("character_nearby", true);

    }


    // Performance verbessern durch Vector3.Lerp() ??


}




    //[SerializeField] private Animator anim;

    //Detect if a click occurs
    /*  public void OnPointerClick(PointerEventData pointerEventData)
      {
          //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
          //Debug.Log(name + " Game Object Clicked!");
          anim.Play("ElavDown");
  }


  /*
  // Start is called before the first frame update
  void Start()
  {
      anim = GetComponent<Animator>();
  }

  // Update is called once per frame
  public void Update()
  {

       if (Input.GetButton("Fire1"))
       {

          anim.SetTrigger("Active");
          anim.Play("ElavDown");

       }
  }*/

