using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsMovement : MonoBehaviour
{

    private float time = 0;
    public GameObject stars;

    void Start()
    {
    }

    void Update()
    {
        transform.Translate(-160 * Time.deltaTime, 0, 0);
        
        if (gameObject.transform.position.x < -1920f)
        {
            transform.Translate(7680, 0, 0);
            
        }
    }
}
