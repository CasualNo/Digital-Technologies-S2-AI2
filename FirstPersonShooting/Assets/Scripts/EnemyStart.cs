using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStart : MonoBehaviour
{
    void Start()
    {
        Destroy(GetComponent<Rigidbody>());
        gameObject.AddComponent<NavMeshAgent>();
        gameObject.AddComponent<NewEnemyAI>();
    }
}
