using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

public class GhostRun : MonoBehaviour
{
    NavMeshAgent _navmeshagent;

    void Start()
    {
        _navmeshagent = this.GetComponent<NavMeshAgent>();
        _navmeshagent.SetDestination(new Vector3(0f, 0f, 997f));
    }
}
