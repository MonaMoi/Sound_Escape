using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("LoadNextScene");
    }

    private IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(25.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
