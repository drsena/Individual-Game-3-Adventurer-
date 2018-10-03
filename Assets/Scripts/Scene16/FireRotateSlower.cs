using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRotateSlower : MonoBehaviour {

    void Update()
    {
        transform.Rotate(new Vector3(0, 0.15f, 0), Space.World);
        float x = this.transform.position.x;
        float z = this.transform.position.z;
        this.transform.position = new Vector3(x, 1.3f, z);
    }
}
