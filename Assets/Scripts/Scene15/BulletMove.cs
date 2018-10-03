using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

    public float speed;

    private Vector3 playerTrans;

	void Start () {
        GameObject pl = GameObject.FindGameObjectWithTag("Player");
        if (pl != null)
        {
            Transform playerT = pl.GetComponent<Transform>();
            float x = playerT.position.x;
            float z = playerT.position.z;
            playerTrans = new Vector3(x, 1f, z);
        }
	}
	
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, playerTrans, step);
        if (transform.position == playerTrans) {
            Destroy(this.gameObject);
        }
    }
}
