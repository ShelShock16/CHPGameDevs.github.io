using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufoAI : MonoBehaviour
{

    public float speed, vision, range, time=0;
    public Transform player, ufo, shootingPoint;
    public GameObject explosion, bullet, bulletOrigin;

    void Update()
    {
        Vector2 abovePlayer = new Vector2(player.position.x, player.position.y + 1);
        float distanceFromPlayer = Vector2.Distance(abovePlayer, transform.position);
        if (distanceFromPlayer < vision)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, abovePlayer, speed * Time.deltaTime);
        }

        if (time > 0 && time < 0.8) time += Time.deltaTime;
        if (time > 0.8) time = 0;

        if (time == 0)
        {
            time += Time.deltaTime;
            Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            Instantiate(explosion, ufo.position, ufo.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}   
