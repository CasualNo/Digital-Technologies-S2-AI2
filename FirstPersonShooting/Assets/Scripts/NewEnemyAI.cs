using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewEnemyAI : MonoBehaviour
{
    public Transform player;
    public Target self;
    NavMeshAgent agent;
    public Vector3 target;

    private void Awake()
    {
        self = gameObject.GetComponent<Target>();
        target = self.spawn.transform.position + new Vector3(0.001f,0,0);
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 3f;
        agent.stoppingDistance = 2.5f;

        //find the player's transform
        player = GameObject.Find("Player").transform;
    }
    
    void Update()
    {
        agent.SetDestination(target);
    }
}
