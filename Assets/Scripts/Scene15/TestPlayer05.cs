using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TestPlayer05 : MonoBehaviour {

    public GameObject player;

	void Update()
	{
        if (player.gameObject.activeInHierarchy == false && !Pass05.hasPassed) {
            StartCoroutine(restart());
        }
	}

    IEnumerator restart()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(9);
    }
}
