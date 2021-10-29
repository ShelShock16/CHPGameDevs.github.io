using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatPlayer : MonoBehaviour
{
    public int playerX, playerY;
    private float damageTime = 0, damageRedTime = 0, movementTime = 0;
    public SpriteRenderer render;
    void Start()
    {
        playerX = 6;
        playerY = 10;
    }

    void Update()
    {
        if (movementTime == 0 && DialogueTrigger.dialogueActive == false)
        {
            Movement();
        }
        if (movementTime > 0)
        {
            movementTime += Time.deltaTime;
        }
        if (movementTime > 0.2)
        {
            movementTime = 0;
        }
    }

    void Damage()
    {
        if (damageTime > 0)
        {
            damageTime += Time.deltaTime;
            damageRedTime += Time.deltaTime;
            render.color = new Color(255, 0, 0, 128);
            if (damageRedTime > 0.25 && damageRedTime < 0.5)
            {
                render.color = new Color(255, 255, 255, 255);
            }
            else if (damageRedTime > 0.5)
            {
                render.color = new Color(255, 0, 0, 128);
                damageRedTime = 0;
            }
        }

        if (damageTime > 1)
        {
            damageTime = 0;
            render.color = new Color(255, 255, 255, 255);
        }
    }
    void Movement()
    {
        if (Input.GetKey("a") && playerX > 1)
        {
            gameObject.transform.Translate(new Vector3(-0.24f, 0, 0));
            movementTime += Time.deltaTime;
            playerX--;
        }

        if (Input.GetKey("d") && playerX < 10)
        {
            gameObject.transform.Translate(new Vector3(0.24f, 0, 0));
            movementTime += Time.deltaTime;
            playerX++;
        }

        if (Input.GetKey("s") && playerY < 10)
        {
            gameObject.transform.Translate(new Vector3(0, -0.13f, 0));
            movementTime += Time.deltaTime;
            playerY++;
        }

        if (Input.GetKey("w") && playerY > 1)
        {
            gameObject.transform.Translate(new Vector3(0, 0.13f, 0));
            movementTime += Time.deltaTime;
            playerY--;
        }
    }
}
