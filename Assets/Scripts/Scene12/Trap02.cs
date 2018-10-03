using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Trap02 : MonoBehaviour {

    public GameObject goodSphere;

	void Start()
	{
        StartCoroutine(wakeGood());
	}

	private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Transform t = other.gameObject.GetComponent<Transform>();
            t.position = new Vector3(0f, 100f, 38.5f);
        }
    }

    IEnumerator wakeGood() {
        yield return new WaitForSeconds(15f);
        goodSphere.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
