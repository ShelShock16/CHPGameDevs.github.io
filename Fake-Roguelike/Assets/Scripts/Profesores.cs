using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profesores : MonoBehaviour
{
    public Sprite sprite2;
    private Sprite spriteR;
    public string name = "";

    public string txt1 = "";
    public string txt2 = "";
    public string txt3 = "";

    public string txt1ING = "";
    public string txt2ING = "";
    public string txt3ING = "";

    public Text txt;
    public Text txtname;
    public Image prof;
    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            spriteR = gameObject.GetComponent<SpriteRenderer>().sprite;
            if (spriteR == null)
            {
                prof.sprite = sprite2;
                txtname.text = "?";
            }
            else {
                prof.sprite = spriteR;
                txtname.text = name;
            }
            


            if (PlayerPrefs.GetInt("Lang")==1)
            {
                float random = Random.Range(0, 4);
            if ((int)random == 1 || (int)random == 2 || (int)random == 3)
            {
                if ((int)random == 1)
                {
                    Canvas.SetActive(true);
                    txt.text = txt1;

                }
                if ((int)random == 2)
                {
                    Canvas.SetActive(true);
                    txt.text = txt2;

                }
                if ((int)random == 3)
                {
                    Canvas.SetActive(true);
                    txt.text = txt3;

                }
            }
            else
            {
                Canvas.SetActive(true);
                txt.text = txt1;

            }
            }
            else
            {
                float random = Random.Range(0, 4);
                if ((int)random == 1 || (int)random == 2 || (int)random == 3)
                {
                    if ((int)random == 1)
                    {
                        Canvas.SetActive(true);
                        txt.text = txt1ING;

                    }
                    if ((int)random == 2)
                    {
                        Canvas.SetActive(true);
                        txt.text = txt2ING;

                    }
                    if ((int)random == 3)
                    {
                        Canvas.SetActive(true);
                        txt.text = txt3ING;

                    }
                }
                else
                {
                    Canvas.SetActive(true);
                    txt.text = txt1ING;

                }
            }

        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
         Canvas.SetActive(false);
    }
}
