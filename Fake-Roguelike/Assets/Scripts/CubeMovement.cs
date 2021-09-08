using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CubeMovement : MonoBehaviour
{

    public float speed = 10.0f;
    public int hp = 3;
    public int points = 0;

    public Text lifes;
    public Text point;

    // Start is called before the first frame update
    void Start()
    {
        lifes.text = "LIVES " + (int)hp;
        point.text = "POINTS " + (int)points;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal")*speed;
        x *= Time.deltaTime;
        transform.Translate(x, 0f,0f);

        if (hp == 0) Destroy(this.gameObject);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            hp = hp - 1;
            Debug.Log("hp = " + hp);
            lifes.text = "LIVES " + (int)hp;

        }

        if(collision.gameObject.tag == "Good")
        {
            points += 1;
            Debug.Log("points = " + points);
            point.text = "POINTS " + (int)points;
        }
    }
    }
