using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRoom : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        LoadNext();
    }

    public void LoadNext()
    {
        StartCoroutine(LoadEnd(SceneManager.GetActiveScene().buildIndex + 1));

    }

    private IEnumerator LoadEnd(int levelIndex)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(levelIndex);
    }
}
