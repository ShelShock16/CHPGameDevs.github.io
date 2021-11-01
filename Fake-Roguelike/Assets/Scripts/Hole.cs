using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private float time = 0;

    void Update()
    {
        time += Time.deltaTime;
        if (time > 0.3)
        {
            Destroy(gameObject);
        }
    }
}
