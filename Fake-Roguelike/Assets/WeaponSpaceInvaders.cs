using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpaceInvaders : MonoBehaviour
{
    public Transform firePoint;
    public GameObject pencil;
    private float time = 0;
    public AudioSource throwsound;
    void Update()
    {
        if (time > 0 && time < 0.3) time += Time.deltaTime;
        if (time > 0.3) time = 0;

        if (time == 0 && (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            time += Time.deltaTime;
            Shoot();
        }


    }

    void Shoot()
    {
        Instantiate(pencil, firePoint.position, firePoint.rotation);
        throwsound.Play();
    }
}
