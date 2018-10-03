using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour {

    static public int Points06;

    private bool matchBegin;

	void Start()
	{
        Points06 = 0;
        matchBegin = false;
        StartCoroutine(BeginWait());
	}

	void FixedUpdate()
	{
        if (!matchBegin)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
            this.transform.rotation = Quaternion.identity;
        }
	}

	void OnTriggerEnter(Collider other)
	{
        if (other.gameObject.tag == "Point") {
            Points06++;
        }
	}

	IEnumerator BeginWait() {
        yield return new WaitForSeconds(6f);
        matchBegin = true;
    }

}
