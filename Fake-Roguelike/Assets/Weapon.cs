using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject pencil;
    private int frames = 0;
    void Update()
    {
        frames++;

            if (frames % 120 == 0 && (Input.GetButton("Fire1") || Input.GetButton("Fire2") || Input.GetButton("Fire3") || Input.GetButton("Jump")))
        {
            Shoot();
            frames = 0;
        }


    }

    void Shoot()
    {
        Instantiate(pencil, firePoint.position, firePoint.rotation);
    }
}
