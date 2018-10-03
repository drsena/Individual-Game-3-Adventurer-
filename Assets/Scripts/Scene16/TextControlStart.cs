using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextControlStart : MonoBehaviour {

    public GameObject text1, text2, text3, text4, text5, slider1, slider2;

	void Start () {
        StartCoroutine(TextLoad());
	}
	
    IEnumerator TextLoad() {
        yield return new WaitForSeconds(1f);
        text1.SetActive(true);
        yield return new WaitForSeconds(1f);
        text1.SetActive(false);
        text2.SetActive(true);
        yield return new WaitForSeconds(1f);
        text2.SetActive(false);
        text3.SetActive(true);
        yield return new WaitForSeconds(1f);
        text3.SetActive(false);
        text4.SetActive(true);
        yield return new WaitForSeconds(1f);
        text4.SetActive(false);
        text5.SetActive(true);
        yield return new WaitForSeconds(1f);
        text5.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        slider1.SetActive(true);
        slider2.SetActive(true);
    }
}
