using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBulletScript : MonoBehaviour
{

    public float speed, time=0;
    Transform player;
    private Vector2 aim;

    private void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        //aim = player.position;
    }

    private void Update()
    {
        //transform.position = Vector2.MoveTowards(this.transform.position, aim*2, speed * Time.deltaTime);
        transform.Translate(0, -1 * Time.deltaTime, 0);

        time += Time.deltaTime;
        if (time > 2)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionStay2D (Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
        }
    }

}