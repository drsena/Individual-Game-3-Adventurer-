﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRotating : MonoBehaviour {

	void Update () {
        transform.Rotate(new Vector3(0, 0.3f, 0), Space.World);
	}
}
