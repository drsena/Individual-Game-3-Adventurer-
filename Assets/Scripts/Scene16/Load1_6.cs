using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Load1_6 : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(LoadNew());
    }

    IEnumerator LoadNew()
    {
        yield return new WaitForSeconds(3.25f);
        SceneManager.LoadScene(12);
    }
}
