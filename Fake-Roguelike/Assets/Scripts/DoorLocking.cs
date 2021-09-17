using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLocking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int Locked1 = PlayerPrefs.GetInt("LockedLvl2");
        if (Locked1 == 0) Destroy(this.gameObject); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
