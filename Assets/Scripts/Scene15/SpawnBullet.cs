using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{

    public GameObject bullet;
    public float spawnWait;
    public float startWait;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            Vector3 spawnPosition = this.GetComponent<Transform>().position;
            Quaternion spawnRotation = Quaternion.identity;
            spawnRotation.eulerAngles = new Vector3(0f, 0f, 0f);
            Instantiate(bullet, spawnPosition + new Vector3(0f, 1f, 0f), spawnRotation);
            yield return new WaitForSeconds(spawnWait);
        }
    }

}
