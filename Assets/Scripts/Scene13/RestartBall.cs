using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartBall : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            col.gameObject.SetActive(false);
            Deaths03.deaths++;
            StartCoroutine(restart());
        }
    }

    IEnumerator restart()
    {
        yield return new WaitForSeconds(1.5f);
        ChasePlayer03.timesTouched = 0;
        SceneManager.LoadScene(5);
    }
}