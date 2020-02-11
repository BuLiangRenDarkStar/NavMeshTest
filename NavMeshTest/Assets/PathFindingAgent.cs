using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathFindingAgent : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    public void GoToGarget()
    {
        navMeshAgent.SetDestination(target.transform.position);
    }
}
