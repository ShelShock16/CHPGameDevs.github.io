using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profesores : MonoBehaviour
{
    public string txt1 = "";
    public string txt2 = "";
    public string txt3 = "";
    public Text txt;
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
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
         Canvas.SetActive(false);
    }
}
