using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    //public Transform camera;
    public Sprite hp1, hp2, hp3, hp4;
    
    public GameObject player;
    private Player playerInfo;

    void Start()
    {
        playerInfo = player.GetComponent<Player>();
    }

    void Update()
    {
        //transform.position = new Vector3(camera.position.x + 2f, camera.position.y + 1.85f, 0);

        if (playerInfo.hp == 4)
        {
            gameObject.GetComponent<Image>().sprite = hp4;
            // render.sprite = hp4;
        } else if (playerInfo.hp == 3)
        {
            gameObject.GetComponent<Image>().sprite = hp3;
            //render.sprite = hp3;
        } else if (playerInfo.hp == 2)
        {
            gameObject.GetComponent<Image>().sprite = hp2;
            // render.sprite = hp2;
        } else
        {
            gameObject.GetComponent<Image>().sprite = hp1;
            // render.sprite = hp1;
        }

    }
}
