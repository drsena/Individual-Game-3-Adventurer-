using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTrigger : MonoBehaviour {

    public int movementSpeed;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            float x = col.transform.position.x;
            float y = col.transform.position.y;
            float z = col.transform.position.z;
            Vector3 newTransform = new Vector3(x, y, z-50);
            col.transform.position = newTransform;
        }
    }
}
