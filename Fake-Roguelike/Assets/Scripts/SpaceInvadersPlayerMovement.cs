using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SpaceInvadersPlayerMovement : MonoBehaviour
{
    public SpriteRenderer render;
    public float time2 = 0, redTime = 0;
    public Transform firePoint;
    public GameObject pencil;
    private float time = 0;
    public float speed = 10.0f;
    public int life=5;
    public Image head;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time2 > 0)
        {
            time2 += Time.deltaTime;
            redTime += Time.deltaTime;
            render.color = new Color(255, 0, 0, 128);
            if (redTime > 0.25 && redTime < 0.5)
            {
                render.color = new Color(255, 255, 255, 255);
            }
            else if (redTime > 0.5)
            {
                render.color = new Color(255, 0, 0, 128);
                redTime = 0;
            }
        }

        if (time2 > 1)
        {
            time2 = 0;
            render.color = new Color(255, 255, 255, 255);
        } 

        float x = Input.GetAxis("Horizontal")*10 ;
        x *= Time.deltaTime;
        transform.Translate(x, 0f, 0f);


        if (life == 0)
        {
            SceneManager.LoadScene(18);
        }

        if (life == 5)
        {
            head.fillAmount = 1;
        }
        if (life == 4)
        {
            head.fillAmount = 0.8f;
        }
        if (life == 3)
        {
            head.fillAmount = 0.6f;
        }
        if (life == 2)
        {
            head.fillAmount = 0.4f;
        }
        if (life == 1)
        {
            head.fillAmount = 0.2f;
        }
        if (life == 0)
        {
            head.fillAmount = 0f;
        }


    }

    void Shoot()
    {
        Instantiate(pencil, firePoint.position, firePoint.rotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Enemy" && time2 == 0)
        {
            time2 += Time.deltaTime;
            life -= 1;
        }
    }
}
