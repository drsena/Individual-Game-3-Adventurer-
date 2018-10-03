using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTexture02 : MonoBehaviour {

    public GameObject board1, board2;

    private MeshRenderer rend;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            rend = this.gameObject.GetComponent<MeshRenderer>();
            rend.enabled = true;
            board1.SetActive(true);
            board2.SetActive(true);
        }
    }
}
