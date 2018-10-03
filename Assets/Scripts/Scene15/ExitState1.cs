using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitState1 : MonoBehaviour {

    static public bool triggered = false;
    public GameObject donut;
    public GameObject part2;
    public GameObject kill1, kill2;

	void Start()
	{
        triggered = false;
	}

	void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player" && !triggered)
        {
            triggered = true;
            donut.SetActive(false);
            part2.SetActive(true);
            kill1.SetActive(false);
            kill2.SetActive(true);
        }
    }
}
