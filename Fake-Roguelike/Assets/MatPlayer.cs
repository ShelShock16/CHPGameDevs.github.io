using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MatPlayer : MonoBehaviour
{
    public int playerX, playerY, direction;
    private float damageTime = 0, movementTime = 0;
    public SpriteRenderer render;
    public GameObject explosion;

    private void Start()
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

        if (damageTime > 0)
        {
            damageTime += Time.deltaTime;
        }
        if (damageTime > 0.2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        damageTime += Time.deltaTime;
        Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
    }

    void Movement()
    {
        if (Input.GetKey("a") && playerX > 1)
        {
            gameObject.transform.Translate(new Vector3(-0.24f, 0, 0));
            movementTime += Time.deltaTime;
            playerX--;
            render.flipX = false;
        }

        if (Input.GetKey("d") && playerX < 10)
        {
            gameObject.transform.Translate(new Vector3(0.24f, 0, 0));
            movementTime += Time.deltaTime;
            playerX++;
            render.flipX = true;
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
