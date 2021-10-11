using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UFOSCRIPT : MonoBehaviour
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
            PlayerPrefs.SetInt("LockedLvl4", 0);
            SceneManager.LoadScene(6);
        }
    }
}
