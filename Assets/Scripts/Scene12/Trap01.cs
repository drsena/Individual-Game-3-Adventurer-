using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap01 : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            this.gameObject.SetActive(false);
        }
    }
}
