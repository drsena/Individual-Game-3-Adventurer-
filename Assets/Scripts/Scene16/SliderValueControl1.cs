using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SliderValueControl1 : MonoBehaviour {

    public Slider slider1, slider2;
    public GameObject player, ghost;

	private void Update()
	{
        slider1.value = player.transform.position.z / 1000;
        slider2.value = ghost.transform.position.z / 1000;
	}
}
