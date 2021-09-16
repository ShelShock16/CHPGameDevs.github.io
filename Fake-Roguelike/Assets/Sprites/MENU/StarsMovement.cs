using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsMovement : MonoBehaviour
{

    public Transform delimiter_1;
    public Transform delimiter_2;
   

    void Start()
    {
    }

    void Update()
    {
        transform.Translate(-100 * Time.deltaTime, 0, 0);
        
        if (gameObject.transform.position.x < delimiter_1.transform.position.x)
        {
            transform.Translate(delimiter_2.transform.position.x, 0f,0f);
            
        }
    }
}
