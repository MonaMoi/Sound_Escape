using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ShaftPlay : MonoBehaviour
{
    public Animator shaft;
    
    private void OnTriggerStay()
    {
        StartCoroutine(LoadShaftAnimation());
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    private IEnumerator LoadShaftAnimation()
    {
        yield return new WaitForSeconds(5f);
        shaft.SetTrigger("Start");
    }

    IEnumerator LoadLevel(int levelIndex)
    {

        yield return new WaitForSeconds(30f);
         SceneManager.LoadScene(levelIndex);
    }
}
