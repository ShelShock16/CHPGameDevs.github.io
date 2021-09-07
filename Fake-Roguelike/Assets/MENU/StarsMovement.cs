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

        if (gameObject.transform.position.x<-3840)
        {
            Destroy(gameObject);
            Instantiate(stars, new Vector3(3840, 686.0004f, 0), Quaternion.Euler(0, 0, 0));
        }
    }
}
