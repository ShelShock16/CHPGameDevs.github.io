using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject pencil;
    private float time = 0;
    void Update()
    {
        if (time > 0 && time < 0.3) time += Time.deltaTime;
        if (time > 0.3) time = 0;

            if (time == 0 && (Input.GetButton("Fire1") || Input.GetButton("Fire2") || Input.GetButton("Fire3") || Input.GetButton("Jump")))
            {
            time += Time.deltaTime;
            Shoot();
            }


    }

    void Shoot()
    {
        Instantiate(pencil, firePoint.position, firePoint.rotation);
    }
}
