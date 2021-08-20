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
        if (frames > 0 && frames < 120) frames++;
        if (frames == 120) frames = 0;

            if (frames == 0 && (Input.GetButton("Fire1") || Input.GetButton("Fire2") || Input.GetButton("Fire3") || Input.GetButton("Jump")))
            {
            frames++;
            Shoot();
            }


    }

    void Shoot()
    {
        Instantiate(pencil, firePoint.position, firePoint.rotation);
    }
}
