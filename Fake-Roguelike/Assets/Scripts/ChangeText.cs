using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ChangeText : MonoBehaviour
{
    public Text Txt;
    public string Eng;
    public string Esp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Lang") == 0)
        {
            Txt.text = Eng;
        }
        else
        {
            Txt.text = Esp;
        }
    }
}
