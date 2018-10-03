using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountJumps : MonoBehaviour {
    
    static public int jumps;

	void Start () {
        jumps = 0;
	}

	void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.transform.tag == "Player") {
            jumps++;
        }
    }
}
