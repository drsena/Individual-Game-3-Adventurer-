using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour {

    public float rotateSpeed;

	void Update()
    {
        Vector3 rotateValue = new Vector3(0f, rotateSpeed, 0f);
        transform.eulerAngles = transform.eulerAngles + rotateValue;
    }
}
