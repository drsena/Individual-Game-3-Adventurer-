using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
	void Update()
	{
        transform.Rotate(Vector3.right * 2, Time.deltaTime);
	}

	private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
