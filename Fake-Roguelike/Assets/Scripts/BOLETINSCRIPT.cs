using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BOLETINSCRIPT : MonoBehaviour
{
    public Text BOLETIN;

    public Text ANÁLISIS;
    public Text FILOSOFÍA;
    public Text MULTIPLATAFORMAS;
    public Text PROGRAMACIÓN;
    public Text SOCIOLOGÍA;
    public Text ARTE;
    public Text NARRATIVA;
    public Text GESTION;
    public Text NEGOCIOS;
    public Text MATEMÁTICA;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Lang") == 1)
        {
            ANÁLISIS.text = "ANÁLISIS Y DISEÑO DE APLICACIONES";
            FILOSOFÍA.text = "FILOSOFÍA";
            MULTIPLATAFORMAS.text = "MULTIPLATAFORMAS";
            PROGRAMACIÓN.text = "PROGRAMACIÓN";
            SOCIOLOGÍA.text = "SOCIOLOGÍA";
            ARTE.text = "ARTE";
            NARRATIVA.text = "NARRATIVA DE VIDEOJUEGOS";
            GESTION.text = "GESTION DE PROYECTOS";
            NEGOCIOS.text = "NEGOCIOS DIGITALES";
            MATEMÁTICA.text = "MATEMÁTICA";

            BOLETIN.text="BOLETIN";
        }
        else
        {
            ANÁLISIS.text = "ANALYSIS AND DESIGN OF APPLICATIONS";
            FILOSOFÍA.text = "PHILOSOPHY";
            MULTIPLATAFORMAS.text = "MULTIPLATFORMS";
            PROGRAMACIÓN.text = "PROGRAMMING";
            SOCIOLOGÍA.text = "SOCIOLOGY";
            ARTE.text = "ART";
            NARRATIVA.text = "VIDEO GAME NARRATIVE";
            GESTION.text = "PROJECT MANAGEMENT";
            NEGOCIOS.text = "DIGITAL BUSINESS";
            MATEMÁTICA.text = "MATHEMATICS";

            BOLETIN.text = "BOLETIN";
        }
    }
}
