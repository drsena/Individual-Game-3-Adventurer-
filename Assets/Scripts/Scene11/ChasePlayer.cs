using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChasePlayer : MonoBehaviour {

    public GameObject Player;
    public float speed;

    private float step;

    void Start()
    {
        step = speed * Time.deltaTime;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, step);
        if (transform.position.y>1.5f) {
            float px = transform.position.x;
            float pz = transform.position.z;
            transform.position = new Vector3(px, 1.5f, pz);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            other.gameObject.SetActive(false);
            StartCoroutine(restart());
        }
    }

    IEnumerator restart()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);
    }
}
