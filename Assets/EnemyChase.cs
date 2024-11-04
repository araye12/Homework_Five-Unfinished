using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyChase : MonoBehaviour
{
    public Transform player; // Drag the player (first-person controller) here in the Inspector
    public float chaseRange = 10f;
    private NavMeshAgent agent;
    private bool isChasing;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= chaseRange)
        {
            StartChase();
        }
        else
        {
            StopChase();
        }
    }

    void StartChase()
    {
        if (!isChasing)
        {
            isChasing = true;
            Debug.Log("Chasing the player!");
        }
        agent.SetDestination(player.position);
    }

    void StopChase()
    {
        if (isChasing)
        {
            isChasing = false;
            Debug.Log("Stopped chasing.");
            agent.ResetPath();
        }
    }
}

