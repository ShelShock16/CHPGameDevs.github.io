using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform lookAt;
    public float boundX = 0.8f;
    public float boundY = 0.4f;

    void LateUpdate()
    {

        Vector3 delta = Vector3.zero;

        float deltaX = lookAt.position.x - transform.position.x;
        if(deltaX > boundX && lookAt.position.x < 31.34 || deltaX < -boundX && lookAt.position.x > -0.78)
        {
            if (transform.position.x < lookAt.position.x)
            {
                delta.x = deltaX - boundX;
            } else
            {
                delta.x = deltaX + boundX;
            }

        }

        float deltaY = lookAt.position.y - transform.position.y;
        if (deltaY > boundY && lookAt.position.y < 1.38 || deltaY < -boundY && lookAt.position.y > -2)
        {
            if (transform.position.y < lookAt.position.y)
            {
                delta.y = deltaY - boundY;
            }
            else
            {
                delta.y = deltaY + boundY;
            }

        }

        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
