using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ViarWink : MonoBehaviour
{
    public float time = 0;
    public SpriteRenderer render;
    public Sprite viarWink, viar;

    void Update()
    {
        time += Time.deltaTime;
        if (time > 2 && time < 2.2)
        {
            render.sprite = viarWink;
        }
        if (time > 2.2 && time < 2.5)
        {
            render.sprite = viar;
        }
        if (time > 2.5)
        {
            PlayerPrefs.SetInt("Progress", 0);
            SceneManager.LoadScene("Bus");
        }




    }
}
