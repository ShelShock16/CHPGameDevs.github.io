using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public Transform camera;
    public Sprite hp1, hp2, hp3, hp4;
    public SpriteRenderer render;
    public GameObject player;
    private Player playerInfo;

    void Start()
    {
        playerInfo = player.GetComponent<Player>();
    }

    void Update()
    {
        transform.position = new Vector3(camera.position.x + 2f, camera.position.y + 1.85f, 0);

        if (playerInfo.hp == 4)
        {
            render.sprite = hp4;
        } else if (playerInfo.hp == 3)
        {
            render.sprite = hp3;
        } else if (playerInfo.hp == 2)
        {
            render.sprite = hp2;
        } else
        {
            render.sprite = hp1;
        }

    }
}
