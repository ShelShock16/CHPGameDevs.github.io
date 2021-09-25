using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLocking : MonoBehaviour
{

    public string LockedLvlx;
    // Start is called before the first frame update
    void Start()
    {
       
        if (PlayerPrefs.GetInt(LockedLvlx) == 0) Destroy(this.gameObject); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
