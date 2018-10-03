using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRespawn : MonoBehaviour {

    public GameObject kill2, kill3;
    public GameObject donut;

    private bool triggered = false;

	void Start()
	{
        triggered = false;
	}

	void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player" && ExitState1.triggered && !triggered)
        {
            Transform t = col.gameObject.GetComponent<Transform>();
            t.position = new Vector3(0f, 0f, 0f);
            kill2.SetActive(false);
            kill3.SetActive(true);
            donut.SetActive(true);
            triggered = true;
        }
    }
}

