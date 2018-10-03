using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureShine02 : MonoBehaviour
{

    private MeshRenderer rend;

    void Start()
    {
        rend = this.gameObject.GetComponent<MeshRenderer>();
    }

    void Update()
    {
        // Find out whether current second is odd or even
        bool oddeven = Mathf.FloorToInt(Time.time) % 2 == 1;

        // Enable renderer accordingly
        rend.enabled = oddeven;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
        }
    }
}
