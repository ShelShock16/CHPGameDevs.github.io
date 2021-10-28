using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbove : MonoBehaviour
{
    public GameObject Player;
    private SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.y > gameObject.transform.position.y)
        {
            rend.sortingLayerName = "Foreground";
        }
        else
        {
            rend.sortingLayerName = "Object";
        }
    }
}
