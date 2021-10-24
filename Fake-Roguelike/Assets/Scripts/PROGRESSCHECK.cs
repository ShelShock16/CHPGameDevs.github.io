using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PROGRESSCHECK : MonoBehaviour
{
    public GameObject Nota1;
    public GameObject Nota2;
    public GameObject Nota3;
    public GameObject Nota4;
    public GameObject Nota5;
    public GameObject Nota6;
    public GameObject Nota7;
    public GameObject Nota8;
    public GameObject Nota9;
    public GameObject Nota10;
    // Start is called before the first frame update
    void Start()
    {
        Nota1.SetActive(false);
        Nota2.SetActive(false);
        Nota3.SetActive(false);
        Nota4.SetActive(false);
        Nota5.SetActive(false);
        Nota6.SetActive(false);
        Nota7.SetActive(false);
        Nota8.SetActive(false);
        Nota9.SetActive(false);
        Nota10.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.GetInt("Progress") >= 2)
        {
            Nota1.SetActive(true);
        }
        else
        {
            Nota1.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Progress") >= 7)
        {
            Nota2.SetActive(true);
        }
        else
        {
            Nota2.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Progress") >= 8)
        {
            Nota3.SetActive(true);
        }
        else
        {
            Nota3.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Progress") >= 14)
        {
            Nota4.SetActive(true);
        }
        else
        {
            Nota4.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Progress") >= 15)
        {
            Nota5.SetActive(true);
        }
        else
        {
            Nota5.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Progress") >= 17)
        {
            Nota6.SetActive(true);
        }
        else
        {
            Nota6.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Progress") >= 21)
        {
            Nota7.SetActive(true);
        }
        else
        {
            Nota7.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Progress") >= 23)
        {
            Nota8.SetActive(true);
        }
        else
        {
            Nota8.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Progress") >= 24)
        {
            Nota9.SetActive(true);
        }
        else
        {
            Nota9.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Progress") >= 25)
        {
            Nota10.SetActive(true);
        }
        else
        {
            Nota10.SetActive(false);
        }

    }
}
