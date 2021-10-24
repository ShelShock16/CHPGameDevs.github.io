using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusStreetMovement : MonoBehaviour
{ 
    
    public int speed = -15;
    public Transform down;
    public Transform up;
// Start is called before the first frame update
    void Start()
    {

    }

// Update is called once per frame
    void Update()
    {
    transform.Translate(0, speed * Time.deltaTime, 0);

    if (gameObject.transform.position.y > down.transform.position.y)
        {
        transform.Translate(0f, up.transform.position.y, 0f);

        }
    }
}
