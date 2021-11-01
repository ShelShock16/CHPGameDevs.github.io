using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBigHorizontal : MonoBehaviour
{
    private float time = 0;
    public GameObject hole;

    void Update()
    {
        time += Time.deltaTime;
        if (time > PlayerPrefs.GetFloat("MatSpeed"))
        {
            float y = 0.01f;
            float x = 0.01f;
            for (int i = 0; i < 3; i++)
            {
                for (int h = 0; h < 10; h++)
                {
                    Instantiate(hole, new Vector3(gameObject.transform.position.x + x, gameObject.transform.position.y - y, 0), gameObject.transform.rotation);
                    x = x + 0.24f;
                }
                y = y + 0.13f;
                x = 0.01f;
            }
            Destroy(gameObject);
        }
    }
}
