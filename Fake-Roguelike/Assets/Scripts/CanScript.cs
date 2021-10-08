using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanScript : MonoBehaviour
{
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
            int a = PlayerPrefs.GetInt("CarPoints") +1;
            PlayerPrefs.SetInt("CarPoints", a);
            Destroy(this.gameObject);
        }
    }
}
