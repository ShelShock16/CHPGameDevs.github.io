using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeSize : MonoBehaviour
{
    private Image rend;
    private Sprite img;
    RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rend = GetComponent<Image>();
        

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        img = rend.sprite;
        rectTransform.sizeDelta = new Vector2(img.rect.width, img.rect.height);
    }
}
