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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (btn.isOn)
        {
            lang.text = "Espaniol";
            SOUND.text = "SONIDO";
            OPTIONS.text = "OPCIONES";
            RES.text = "RESOLUCION";
            VIB.text = "VIBRACION";
        }
        
        else
        {
            lang.text = "English";
            SOUND.text = "SOUND";
            OPTIONS.text = "OPTIONS";
            RES.text = "RESOLUTION";
            VIB.text = "VIBRATION";
        }
    }
}
