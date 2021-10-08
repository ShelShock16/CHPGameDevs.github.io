using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConeScript : MonoBehaviour
{
    public Text txt;
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
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag.Equals("Player"))
        {
            int a= PlayerPrefs.GetInt("CarLife") - 1;
            PlayerPrefs.SetInt("CarLife", a);
            Destroy(this.gameObject);
        }
    }

   
}
