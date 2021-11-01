using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleBigVertical : MonoBehaviour
{
    private float time = 0;
    public GameObject hole;

    void Update()
    {
        time += Time.deltaTime;
        if (time > 1)
        {
            Instantiate(hole, new Vector3(gameObject.transform.position.x - 0.01f, gameObject.transform.position.y + 0.01f, 0), gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
}
