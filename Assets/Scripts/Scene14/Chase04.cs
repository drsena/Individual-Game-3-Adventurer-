using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

public class Chase04 : MonoBehaviour {

    [SerializeField]
    GameObject target;

    NavMeshAgent _navmeshagent;

    private Transform destination;

	void Start () {
        destination = target.GetComponent<Transform>();
        _navmeshagent = this.GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
        destination = target.GetComponent<Transform>();
        SetDestination();
	}

	private void SetDestination()
    {
        if (destination != null) {
            if (InputControl04.pressedE)
            {
                Vector3 targetVector = -destination.transform.position;
                _navmeshagent.SetDestination(targetVector);
            } else {
                Vector3 targetVector = destination.transform.position;
                _navmeshagent.SetDestination(targetVector);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!InputControl04.pressedE)
            {
                other.gameObject.SetActive(false);
                StartCoroutine(restart());
            } else {
                Pass04.remainingGhosts--;
                this.gameObject.SetActive(false);
            }
        }
    }

    IEnumerator restart()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(7);
    }
}
