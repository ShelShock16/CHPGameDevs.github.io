using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Progress") < PlayerPrefs.GetInt("ProgressSave"))
        {
            PlayerPrefs.SetInt("Progress", PlayerPrefs.GetInt("ProgressSave"));
        }

        if (PlayerPrefs.GetInt("Progress") <=0)
        {
            PlayerPrefs.SetInt("Progress", 1);
        }

        if (PlayerPrefs.GetInt("Progress") <= 0)
        {
            PlayerPrefs.SetInt("Progress", 1);
        }
        if (PlayerPrefs.GetInt("Progress") <= 6 && PlayerPrefs.GetInt("Progress") >=3){
            PlayerPrefs.SetInt("Progress", 2);
        }
        if (PlayerPrefs.GetInt("Progress") < 14 && PlayerPrefs.GetInt("Progress") > 9)
        {
            PlayerPrefs.SetInt("Progress", 9);
        }

         if (PlayerPrefs.GetInt("Progress") < 21 && PlayerPrefs.GetInt("Progress") > 18)
         {
             PlayerPrefs.SetInt("Progress", 18);
         }
        
        if (PlayerPrefs.GetInt("Progress") < 23 && PlayerPrefs.GetInt("Progress") > 21)
         {
             PlayerPrefs.SetInt("Progress", 21);
         }

        if (PlayerPrefs.GetInt("Progress") ==16)
         {
             PlayerPrefs.SetInt("Progress", 15);
         }

        if (PlayerPrefs.GetInt("Progress") > 24 && PlayerPrefs.GetInt("Progress") < 35)
        {
            PlayerPrefs.SetInt("Progress", 24);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
