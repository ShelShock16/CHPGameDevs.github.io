using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketBallPlayerScript : MonoBehaviour
{
    public Text points;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("BBPoints", 0);
    }

    // Update is called once per frame
    void Update()
    {
        points.text="" + PlayerPrefs.GetInt("BBPoints");
    }
}
