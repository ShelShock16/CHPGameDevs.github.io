using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour

{
    int frames = 0;

    void Update()
    {
        frames++;
        if (frames == 144) Destroy(gameObject);
    }
}
