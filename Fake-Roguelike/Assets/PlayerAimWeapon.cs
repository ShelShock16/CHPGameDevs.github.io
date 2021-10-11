using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerAimWeapon : MonoBehaviour
{

    Rigidbody2D rb;
    bool hasHit;
    float time = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasHit == false)
        {
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

         time -= Time.deltaTime;
        if (time <= 0) Destroy(this.gameObject);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hasHit = true;
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
        Object.Destroy(gameObject, 2.0f);

        if (collision.gameObject.tag == "Basket")
        {
            int a = PlayerPrefs.GetInt("BBPoints")+1;
            PlayerPrefs.SetInt("BBPoints",a);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "wall")
        {
            Destroy(this.gameObject);
        }
    }
}
