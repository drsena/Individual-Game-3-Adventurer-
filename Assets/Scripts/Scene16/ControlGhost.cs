using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGhost : MonoBehaviour {

    private bool matchBegin;

    void Start()
    {
        matchBegin = false;
        StartCoroutine(BeginWait());
    }

    void FixedUpdate()
    {
        if (!matchBegin)
        {
            this.transform.position = new Vector3(1f, 0.5f, 0f);
            this.transform.rotation = Quaternion.identity;
        }
    }

    IEnumerator BeginWait()
    {
        yield return new WaitForSeconds(6f);
        matchBegin = true;
    }
}
