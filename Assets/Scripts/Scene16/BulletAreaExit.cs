using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAreaExit : MonoBehaviour {

    public GameObject bulletController;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bulletController.SetActive(false);
        }
    }
}
