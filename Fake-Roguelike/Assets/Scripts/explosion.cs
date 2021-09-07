using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour

{
    float time = 0;

    void Update()
    {
        time += Time.deltaTime;
        if (time > 0.25) Destroy(gameObject);
    }
}
