using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaFalling : MonoBehaviour
{
    public bool startfalling = false;
    public float time=1.5f;
    private Rigidbody2D rb;
    public float speed=5f;
    public GameObject colliderDown;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(startfalling==true )
        {
            Destroy(colliderDown);
            time -= Time.deltaTime;
            if (time <= 0)
            {
                
                Vector3 movement = new Vector3(0.0f, -35.0f, 0.0f);
                rb.AddForce(movement * speed);
                //second method
                rb.velocity = transform.up * -speed;
                if (time <= -2) { Destroy(this.gameObject); }
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") )
        {
            startfalling = true;
        }
        if (collision.gameObject.tag.Equals("floor"))
        {
            startfalling = true;
        }
    }
}