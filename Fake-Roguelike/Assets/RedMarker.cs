using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMarker : MonoBehaviour
{
    private float time = 0;

    void Update()
    {
        time += Time.deltaTime;
        if (time > 1)
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (time > 2)
        {
            Destroy(gameObject);
        }

    }
}
