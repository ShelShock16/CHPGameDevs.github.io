using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOFILASCRIPT : MonoBehaviour
{
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = gameObject.transform.childCount;
        if (count == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
