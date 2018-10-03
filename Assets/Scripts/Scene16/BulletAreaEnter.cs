using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAreaEnter : MonoBehaviour {

    public GameObject bulletController;

	void OnTriggerEnter(Collider other)
	{
        if (other.gameObject.tag == "Player")
        {
            bulletController.SetActive(true);
        }
	}
}
