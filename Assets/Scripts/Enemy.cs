using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] List<Transform> targets;
    private int randomPositionPoints;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.transform.position == agent.pathEndPosition)
        {
            TargetUpdate();
        }
        agent.SetDestination(targets[randomPositionPoints].position);
    }

    void TargetUpdate()
    {
        randomPositionPoints = Random.Range(0, targets.Count);
    }
}
