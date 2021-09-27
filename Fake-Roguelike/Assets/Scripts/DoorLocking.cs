using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLocking : MonoBehaviour
{

    public string LockedLvlx;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
       
        if (PlayerPrefs.GetInt(LockedLvlx) == 0) Destroy(door); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
