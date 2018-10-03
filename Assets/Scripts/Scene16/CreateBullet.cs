using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullet : MonoBehaviour
{
    public GameObject bullet;
    public float interval;

	void Start()
	{
        StartCoroutine(spawnWaves());
	}

    IEnumerator spawnWaves() {
        while (true) {
            Vector3 spawnPosition = new Vector3(Random.Range(-2.85f, 2.85f), 0.75f, 920f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(bullet, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(interval);
        }
    }
}
