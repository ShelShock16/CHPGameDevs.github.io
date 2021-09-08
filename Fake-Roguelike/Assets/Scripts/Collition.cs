using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collition : MonoBehaviour
{
    
    public Sprite uno;
    public Sprite dos;
    float random=0;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(-10, 10);
    }

    // Update is called once per frame
    void Update()
    {

        

        if (random >0)
        {
            this.GetComponent<SpriteRenderer>().sprite = dos;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = uno;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
