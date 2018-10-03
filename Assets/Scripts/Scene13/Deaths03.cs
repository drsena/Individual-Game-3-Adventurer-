using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deaths03 : MonoBehaviour {

    static public int deaths = 0;
    public int internalDeaths;
    public GameObject cam1, cam2;
    public GameObject ghost;
    public GameObject player;
    public GameObject fireball, waterball;

    private bool summoned;

	void Start()
	{
        summoned = false;
	}

	void Update () {
        internalDeaths = deaths;
        if (internalDeaths % 5 == 0 && internalDeaths!=0 && player.gameObject.activeInHierarchy == true && !summoned) {
            deaths++;
            internalDeaths = deaths;
            StartCoroutine(SummonWater());
            summoned = true;
        }
        if (internalDeaths % 5 == 0) {
            summoned = false;
        }
	}

    IEnumerator SummonWater() {
        yield return new WaitForSeconds(2f);
        cam1.SetActive(false);
        cam2.SetActive(true);
        yield return new WaitForSeconds(5f);
        cam2.SetActive(false);
        cam1.SetActive(true);
        ghost.SetActive(true);
        yield return new WaitForSeconds(15f);
        Transform tt = ghost.gameObject.GetComponent<Transform>();
        tt.position = new Vector3(0, 1, 0);
        yield return new WaitForSeconds(18f);
        tt = ghost.gameObject.GetComponent<Transform>();
        tt.position = new Vector3(0, 1, 0);
        yield return new WaitForSeconds(22f);
        ghost.SetActive(false);
        fireball.SetActive(false);
        waterball.SetActive(true);
    }
}
