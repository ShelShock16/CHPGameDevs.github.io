using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBulletScript2 : MonoBehaviour
{
    public float time = 0;
    Transform player;

    private void Update()
    {
        //transform.position = Vector2.MoveTowards(this.transform.position, aim*2, speed * Time.deltaTime);
        transform.Translate(0, -3 * Time.deltaTime, 0);
        
        time += Time.deltaTime;
        if (time > 5 )
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") || collision.gameObject.tag.Equals("Bullet") || collision.gameObject.tag.Equals("floor"))
        {
            Destroy(gameObject);
        }


    }
}
