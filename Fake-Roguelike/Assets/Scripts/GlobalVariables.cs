using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int Locked1 = PlayerPrefs.GetInt("LockedLvl2", 1);
       if(Locked1!=0) PlayerPrefs.SetInt("LockedLvl2", 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
