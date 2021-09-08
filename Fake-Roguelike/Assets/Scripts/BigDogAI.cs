using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDogAI : MonoBehaviour
{
    public int doglife = 5;
    public float speed, vision;
    public Transform player;
    public Transform dog;
    public GameObject explosion;

    void Update()
    {
        float oldPosition = transform.position.x;
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer < vision)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }

        if (oldPosition > transform.position.x)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        oldPosition = transform.position.x;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            Instantiate(explosion, collision.gameObject.transform.position, dog.rotation);
            Destroy(collision.gameObject);
            doglife -= 1;
            if (doglife == 0) Destroy(gameObject);

        }
    }

}