using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Progress", 0);
        PlayerPrefs.SetInt("ProgressSave", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
