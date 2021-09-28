using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvadersPlayerMovement : MonoBehaviour
{

    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        x *= Time.deltaTime;
        transform.Translate(x, 0f, 0f);
    }
}
