using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    private CharacterInput controls;
    public float damage = 10f;
    public float range = 100f;
    public float knockback = 10f;
    public Camera fpsCam;

    private void Awake()
    {
        controls = new CharacterInput();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
    
    void Update()
    {
        if (controls.Player.Shoot.triggered)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;

        //Casts ray from Camera's position in its direction over a distance of range
        //Returns a bool value and the object info of what was hit and stores it in 'hit'
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target enemy = hit.transform.GetComponent<Target>();
            Vector3 kbDirection = fpsCam.transform.forward * knockback * 10;

            if (enemy != null)
            {
                enemy.TakeDamage(damage, kbDirection);
            }
        }
    }
}
