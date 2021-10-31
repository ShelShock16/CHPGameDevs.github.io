using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu: MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayGame()
    {

        if (PlayerPrefs.GetInt("Progress") == 0)
        {
            SceneManager.LoadScene(31);
        }
        else
        {
            SceneManager.LoadScene(6);
        }

        
        
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
