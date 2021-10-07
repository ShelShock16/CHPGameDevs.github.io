using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CarMovement : MonoBehaviour
{
    public GameObject CarRight;
    public GameObject CarLeft;
    public static int Life=5;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("CarLife", Life);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)&& CarRight.transform.position != transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, CarRight.transform.position,1.1f );
        }

        if (Input.GetKeyDown(KeyCode.A) && CarLeft.transform.position != transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, CarLeft.transform.position,1.1f );
        }
        txt.text= ""+PlayerPrefs.GetInt("CarLife");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
           
        }
    }
    
}
