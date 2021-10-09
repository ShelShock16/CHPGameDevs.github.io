using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvadersPlayerMovement : MonoBehaviour
{
    public Transform firePoint;
    public GameObject pencil;
    private float time = 0;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal")*10 ;
        x *= Time.deltaTime;
        transform.Translate(x, 0f, 0f);

        if (time > 0 && time < 0.3) time += Time.deltaTime;
        if (time > 0.3) time = 0;

        if ( (Input.GetKeyDown(KeyCode.UpArrow)))
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
