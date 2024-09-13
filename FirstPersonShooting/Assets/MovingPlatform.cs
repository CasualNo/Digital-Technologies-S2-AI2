using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private Vector3 initpos;
    public Vector3 finalpos;
    public float movespeed = 3f;
    private bool fwd = true;
    // Start is called before the first frame update
    void Start()
    {
        initpos = gameObject.transform.position;
    }
    

    // Update is called once per frame
    void Update()
    {
        if ((transform.position == initpos + finalpos && fwd == true) || (transform.position == initpos && fwd == false))
        {
            fwd = !fwd;
        } else if (fwd == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, initpos + finalpos, movespeed * Time.deltaTime);
        } else
        {
            transform.position = Vector3.MoveTowards(transform.position, initpos, movespeed * Time.deltaTime);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.root.CompareTag("Player"))
        {
            CharacterController player = other.GetComponent<CharacterController>();
            if (fwd == true && transform.position != initpos + finalpos && transform.position != initpos)
            {
                player.Move(finalpos.normalized * movespeed * Time.deltaTime);
            }
            else if (transform.position != initpos + finalpos && transform.position != initpos)
            {
                player.Move(-1 * finalpos.normalized * movespeed * Time.deltaTime);
            }
        }
    }
}
