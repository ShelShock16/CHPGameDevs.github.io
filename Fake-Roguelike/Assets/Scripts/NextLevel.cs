using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{ 
    public int numScene;
    public string LockedLvl = "LockedLvl";
    public int LckLvlStatus=0;


    void Update()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt(LockedLvl, LckLvlStatus);
            SceneManager.LoadScene(numScene);
        }
    }
}
