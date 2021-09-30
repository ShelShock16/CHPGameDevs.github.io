using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
        public SpriteRenderer render;
        public float speed = 20f;
        public Rigidbody2D rb;
        private float time = 0;

    void Start()
    {
        if (Input.GetButton("Fire1"))
        {
            rb.velocity = transform.up * speed;
        } else if (Input.GetButton("Fire2"))
        {
            rb.velocity = transform.right * speed;
        } else if (Input.GetButton("Fire3"))
        {
            rb.velocity = -transform.up * speed;
        } else
        {
            rb.velocity = -transform.right * speed;
        }

        // Fake3d
        if (transform.position.y > -0.58)
        {
            render.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Player");

        }
        else
        {
            render.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Player Above");
        }

    }

    void Update ()
    {
        time += Time.deltaTime;
        if (time > 1.2)
        {
            Destroy(gameObject);
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Fruit")
        {
            Destroy(this.gameObject);
        }
    }

}