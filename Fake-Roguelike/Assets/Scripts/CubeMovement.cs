using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CubeMovement : MonoBehaviour
{
    private float time = 0, redTime = 0;
    public float speed = 10.0f;
    public int hp = 3;
    public int points = 0;
    public SpriteRenderer render;
    public Text lifes;
    public Text point;

    // Start is called before the first frame update
    void Start()
    {
        lifes.text = "" + (int)hp;
        point.text = "" + (int)points;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal")*speed;
        x *= Time.deltaTime;
        transform.Translate(x, 0f,0f);

        if (hp <= 0) SceneManager.LoadScene(5);

        if(points == 3)
        {

            PlayerPrefs.SetInt("LockedLvl3", 0);
            SceneManager.LoadScene(11);
        }

        if (time > 0)
        {
            time += Time.deltaTime;
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

        if (time > 2)
        {
            time = 0;
            render.color = new Color(255, 255, 255, 255);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && time == 0)
        {
            hp = hp - 1;
            Debug.Log("hp = " + hp);
            lifes.text = "" + (int)hp;
            time += Time.deltaTime;
        }

        if(collision.gameObject.tag == "Good")
        {
            points += 1;
            Debug.Log("points = " + points);
            point.text = "" + (int)points;


        }
    }
    }
