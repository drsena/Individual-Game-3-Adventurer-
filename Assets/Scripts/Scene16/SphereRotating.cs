using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRotating : MonoBehaviour {

	void Update()
    {
        transform.Rotate(new Vector3(1f, 1f, 1f), Space.World);
    }

	void OnTriggerEnter(Collider other)
	{
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
        }
	}
}
