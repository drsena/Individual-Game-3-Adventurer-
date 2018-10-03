using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Load1_7 : MonoBehaviour {

    public GameObject camera1, camera2;

    void Start()
    {
        StartCoroutine(LoadNew());
    }

    IEnumerator LoadNew()
    {
        yield return new WaitForSeconds(2f);
        camera1.SetActive(false);
        camera2.SetActive(true);
        yield return new WaitForSeconds(11f);
        SceneManager.LoadScene(14);
    }
}
