using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteKey("LockedLvl2");
        PlayerPrefs.DeleteKey("LockedLvl3");
        PlayerPrefs.DeleteKey("LockedLvl4");
        PlayerPrefs.DeleteKey("LockedLvl5");
        PlayerPrefs.DeleteKey("LockedLvl6");
        PlayerPrefs.DeleteKey("LockedLvl7");
        PlayerPrefs.DeleteKey("LockedLvl8");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
