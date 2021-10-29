using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaddispawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 14)
        {
            transform.position = new Vector3(6.90f, 0.23f, 0);
        }
    }
}
