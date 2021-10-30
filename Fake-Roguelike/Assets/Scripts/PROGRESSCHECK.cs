using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PROGRESSCHECK : MonoBehaviour
{
    public GameObject ADA;
    public GameObject FILO;
    public GameObject MULT;
    public GameObject PROG;
    public GameObject SOCIO;
    public GameObject ART;
    public GameObject NARR;
    public GameObject GESTION;
    public GameObject NEG;
    public GameObject MATE;
    // Start is called before the first frame update
    void Start()
    {
        if (ADA != null) ADA.SetActive(false);
        if (FILO != null) FILO.SetActive(false);
        if (MULT != null) MULT.SetActive(false);
        if (PROG != null) PROG.SetActive(false);
        if (SOCIO != null) SOCIO.SetActive(false);
        if (ART != null) ART.SetActive(false);
        if (NARR != null) NARR.SetActive(false);
        if (GESTION != null) GESTION.SetActive(false);
        if (NEG != null) NEG.SetActive(false);
        if (MATE != null) MATE.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ADA != null) {
        if (PlayerPrefs.GetInt("Progress") >= 2)
        {
            ADA.SetActive(true);
        }
        else
        {
            ADA.SetActive(false);
        }
        }

        if (FILO != null)
        {
            if (PlayerPrefs.GetInt("Progress") >= 7)
        {
            FILO.SetActive(true);
        }
        else
        {
            FILO.SetActive(false);
        }
        }

          if (MULT != null) {
        if (PlayerPrefs.GetInt("Progress") >= 8)
        {
            MULT.SetActive(true);
        }
        else
        {
            MULT.SetActive(false);
        }
        }

        if (PROG != null)
        {
            if (PlayerPrefs.GetInt("Progress") >= 14)
        {
            PROG.SetActive(true);
        }
        else
        {
            PROG.SetActive(false);
        }
        }

        if (SOCIO != null)
        {
            if (PlayerPrefs.GetInt("Progress") >= 15)
        {
            SOCIO.SetActive(true);
        }
        else
        {
            SOCIO.SetActive(false);
        }
        }

        if (ART != null)
        {
            if (PlayerPrefs.GetInt("Progress") >= 17)
        {
            ART.SetActive(true);
        }
        else
        {
            ART.SetActive(false);
        }
        }

        if (NARR != null)
        {
            if (PlayerPrefs.GetInt("Progress") >= 21)
        {
            NARR.SetActive(true);
        }
        else
        {
            NARR.SetActive(false);
        }
        }

        if (GESTION != null)
        {
            if (PlayerPrefs.GetInt("Progress") >= 23)
        {
            GESTION.SetActive(true);
        }
        else
        {
            GESTION.SetActive(false);
        }
        }

        if (NEG != null)
        {
            if (PlayerPrefs.GetInt("Progress") >= 24)
        {
            NEG.SetActive(true);
        }
        else
        {
            NEG.SetActive(false);
        }
        }
        if (MATE != null)
        {
            if (PlayerPrefs.GetInt("Progress") >= 25)
        {
            MATE.SetActive(true);
        }
        else
        {
            MATE.SetActive(false);
        }
        }
    }
}
