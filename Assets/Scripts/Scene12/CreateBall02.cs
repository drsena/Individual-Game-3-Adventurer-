using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall02 : MonoBehaviour {

    public GameObject ball;

    private bool aset;

	void Start()
	{
        aset = false;
	}

	void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player" && !aset)
        {
            ball.gameObject.SetActive(true);
            aset = true;
        }
    }
}
