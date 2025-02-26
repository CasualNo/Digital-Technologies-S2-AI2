using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    bool hit = false;
    public int scoreValue = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("Player"))
        {
            hit = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hit == true)
        {
            GameManager.instance.ChangeScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
