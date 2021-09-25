using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public int LockedLvl2;
    // Start is called before the first frame update
    void Start()
    {

       if(PlayerPrefs.GetInt("LockedLvl2")!= 0) PlayerPrefs.SetInt("LockedLvl2", 1);
        LockedLvl2 = PlayerPrefs.GetInt("LockedLvl2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
