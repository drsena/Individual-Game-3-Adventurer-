using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureShine01 : MonoBehaviour {

    public GameObject newplatform;

    private MeshRenderer rend;
    private bool untouched;

	void Start()
	{
        rend = this.gameObject.GetComponent<MeshRenderer>();
        untouched = true;
	}

    void Update()
    {
        if (untouched)
        {
            bool oddeven = Mathf.FloorToInt(Time.time) % 2 == 0;

            // Enable renderer accordingly
            rend.enabled = oddeven;
        } else {
            rend.enabled = true;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            untouched = false;
            newplatform.SetActive(true);
        }
    }
}
