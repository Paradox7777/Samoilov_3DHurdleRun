using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Runner
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class Enemy : MonoBehaviour
    {
        private NavMeshAgent agent;
        [SerializeField] List <Transform> targets;
        private int randomPositionPoints;
        void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
        }

  
        void Update()
        {
            if(agent.remainingDistance == agent.stoppingDistance)
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
}
