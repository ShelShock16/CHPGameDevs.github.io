using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BOLETINSCRIPT : MonoBehaviour
{
    public Text BOLETIN;

    public Text AN�LISIS;
    public Text FILOSOF�A;
    public Text MULTIPLATAFORMAS;
    public Text PROGRAMACI�N;
    public Text SOCIOLOG�A;
    public Text ARTE;
    public Text NARRATIVA;
    public Text GESTION;
    public Text NEGOCIOS;
    public Text MATEM�TICA;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Lang") == 1)
        {
            AN�LISIS.text = "AN�LISIS Y DISE�O DE APLICACIONES";
            FILOSOF�A.text = "FILOSOF�A";
            MULTIPLATAFORMAS.text = "MULTIPLATAFORMAS";
            PROGRAMACI�N.text = "PROGRAMACI�N";
            SOCIOLOG�A.text = "SOCIOLOG�A";
            ARTE.text = "ARTE";
            NARRATIVA.text = "NARRATIVA DE VIDEOJUEGOS";
            GESTION.text = "GESTION DE PROYECTOS";
            NEGOCIOS.text = "NEGOCIOS DIGITALES";
            MATEM�TICA.text = "MATEM�TICA";

            BOLETIN.text="BOLETIN";
        }
        else
        {
            AN�LISIS.text = "ANALYSIS AND DESIGN OF APPLICATIONS";
            FILOSOF�A.text = "PHILOSOPHY";
            MULTIPLATAFORMAS.text = "MULTIPLATFORMS";
            PROGRAMACI�N.text = "PROGRAMMING";
            SOCIOLOG�A.text = "SOCIOLOGY";
            ARTE.text = "ART";
            NARRATIVA.text = "VIDEO GAME NARRATIVE";
            GESTION.text = "PROJECT MANAGEMENT";
            NEGOCIOS.text = "DIGITAL BUSINESS";
            MATEM�TICA.text = "MATHEMATICS";

            BOLETIN.text = "BOLETIN";
        }
    }
}
