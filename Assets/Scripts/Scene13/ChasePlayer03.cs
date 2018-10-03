using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChasePlayer03 : MonoBehaviour
{
    static public int timesTouched;

    public GameObject Player;
    public float speed;

    private float step;
    private int count;

    void Start()
    {
        step = speed * Time.deltaTime;
        count = 0;
        timesTouched = 0;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, step);
        if (transform.position.y > 1.5f)
        {
            float px = transform.position.x;
            float pz = transform.position.z;
            transform.position = new Vector3(px, 1.5f, pz);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            timesTouched++;
            Transform tt = other.gameObject.GetComponent<Transform>();
            float x = tt.position.x;
            float y = tt.position.y;
            float z = tt.position.z;
            count++;
            if (count % 2 == 0)
            {
                tt.position = new Vector3(x + 10, y + 15, z + 10);
            } else {
                tt.position = new Vector3(x - 10, y + 15, z - 10);
            }
        }
    }
}
