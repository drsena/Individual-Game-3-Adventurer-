using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TrapSphereRotating : MonoBehaviour {

    void Update()
    {
        transform.Rotate(new Vector3(-3f, 2.5f, 1.5f), Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);
            StartCoroutine(Restart());
        }
    }

    IEnumerator Restart() {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(11);
    }
}
