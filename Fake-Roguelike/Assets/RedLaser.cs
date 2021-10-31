using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLaser : MonoBehaviour
{
    private float time = 0;

    void Update()
    {
        time += Time.deltaTime;
        if (time > 1)
        {
            Destroy(gameObject);
        }
    }
}
