using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenePicker : MonoBehaviour
{
    public SpriteRenderer ada, filo, multiplat, prog, socio, arte, narrativa, proyecto, negdig, mat, nombre, info;
    public int cursor = 1;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            if (cursor != 13) cursor++; else cursor=1;
        }
        if (Input.GetKeyDown("a"))
        {
            if (cursor != 1) cursor--; else cursor=13;
        }
        if (Input.GetKeyDown("s"))
        {

        }
        if (Input.GetKeyDown("d"))
        {

        }
        //ada.
        if (cursor == 1)
        {
            if (PlayerPrefs.GetInt("Progress") >= 2) ada.color = new Color(255, 255, 255, 255);
            
        }

    }
}