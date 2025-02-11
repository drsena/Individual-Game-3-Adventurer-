﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRun : MonoBehaviour {

    public float speed;

    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (this.transform.position.z < 0f) {
            Destroy(this.gameObject);
        }
    }

}
