using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
        public SpriteRenderer render;
        public float speed = 20f;
        public Rigidbody2D rb;

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

}