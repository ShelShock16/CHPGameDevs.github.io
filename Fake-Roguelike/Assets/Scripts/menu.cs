using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu: MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayGame()
    {

        PlayerPrefs.SetInt("LockedLvl2",1);


        SceneManager.LoadScene(6);
        
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
