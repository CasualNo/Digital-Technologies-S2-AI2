using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //information injection
    public SpawnPointData spawn;

    public float maxhealth = 50f;
    public float health;
    public GameObject collectable;
    private void Awake()
    {
        health = maxhealth;
    }
    public void TakeDamage(float amount, Vector3 knockback)
    {
        health -= amount;
        Debug.Log(health);

        if (health <= 0f)
        {
            Instantiate(collectable, gameObject.transform.position, Quaternion.identity);
            Die();
        }
        Rigidbody body = gameObject.GetComponent<Rigidbody>();
        if (body != null)
        {
            body.AddForce(knockback, ForceMode.Impulse);
        }
    }
    void Die()
    {
        if (spawn != null)
        {
            spawn.alive = false;
        }
        Destroy(gameObject);
    }
}
