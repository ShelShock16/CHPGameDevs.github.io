using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckBox : MonoBehaviour
{
    public Toggle btn;
    public Text lang;
    public Text SOUND;public Text OPTIONS; public Text VIB; public Text RES;
    // Start is called before the first frame update
    void Start()
    {
        
        if (PlayerPrefs.GetInt("Lang") != 0)
        {
            PlayerPrefs.SetInt("Lang", 1);
            btn.isOn = true;
        }
        else
        {
            PlayerPrefs.SetInt("Lang", 0);
            btn.isOn = false;
        }

    }

    // Update is called once per frame
    void Update()
    {



        if (btn.isOn)
        {
            PlayerPrefs.SetInt("Lang", 1);
            lang.text = "Esp";
            SOUND.text = "SONIDO";
            OPTIONS.text = "OPCIONES";
            //RES.text = "RESOLUCION";
            //VIB.text = "VIBRACION";
        }
        
        else
        {
            PlayerPrefs.SetInt("Lang", 0);
            lang.text = "Eng";
            SOUND.text = "SOUND";
            OPTIONS.text = "OPTIONS";
            //RES.text = "RESOLUTION";
            //VIB.text = "VIBRATION";
        }
    }
}
