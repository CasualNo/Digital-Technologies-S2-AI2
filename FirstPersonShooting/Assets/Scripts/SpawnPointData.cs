using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointData : MonoBehaviour
{
    // Data that the spawn point needs to store:
    // enemy prefab that it spawns
    // if it respawns
    public GameObject prefab;
    public bool respawn;
    public bool alive = true;
}
