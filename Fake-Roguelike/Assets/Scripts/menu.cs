using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu: MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayGame()
    {

        if(!PlayerPrefs.HasKey("LockedLvl2")) PlayerPrefs.SetInt("LockedLvl2", 1);
        if (!PlayerPrefs.HasKey("LockedLvl3")) PlayerPrefs.SetInt("LockedLvl3", 1);
        if (!PlayerPrefs.HasKey("LockedLvl4")) PlayerPrefs.SetInt("LockedLvl4", 1);
        if (!PlayerPrefs.HasKey("LockedLvl5")) PlayerPrefs.SetInt("LockedLvl5", 1);
        if (!PlayerPrefs.HasKey("LockedLvl6")) PlayerPrefs.SetInt("LockedLvl6", 1);
        if (!PlayerPrefs.HasKey("LockedLvl7")) PlayerPrefs.SetInt("LockedLvl7", 1);
        if (!PlayerPrefs.HasKey("LockedLvl8")) PlayerPrefs.SetInt("LockedLvl8", 1);
        if (!PlayerPrefs.HasKey("LockedLvl9")) PlayerPrefs.SetInt("LockedLvl9", 1);


        SceneManager.LoadScene(7);
        
    }

    

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            Destroy(this.gameObject);
        }
    }
}
