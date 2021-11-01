using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    
    int a = 8;
    int b = 9;
    public static bool isPaused = false;
    public GameObject PauseMenu;
    // Update is called once per frame
    void Update()
    {
        if (isPaused)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
    }

    public void Resume()
    {
        isPaused = !isPaused;
    }

    public void Menu()
    {
        Time.timeScale = 1.0f;

        SceneManager.LoadScene(a);
        isPaused = !isPaused;
    }

    public void lvlSelector()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(b);
        isPaused = !isPaused;
    }
    public void GoToLevel1()
    {
        

        
        PlayerPrefs.SetInt("ProgressSave", PlayerPrefs.GetInt("Progress"));
        PlayerPrefs.SetInt("Progress", 1);
        Time.timeScale = 1.0f;
        isPaused = !isPaused;
        SceneManager.LoadScene("SalonADA");
        
    }


    public void GoToLevel2()
    {
       
        PlayerPrefs.SetInt("ProgressSave", PlayerPrefs.GetInt("Progress"));
        PlayerPrefs.SetInt("Progress", 2);
        Time.timeScale = 1.0f;
        isPaused = !isPaused;
        SceneManager.LoadScene("SalonFilo");
        
    }

    public void GoToLevel3()
    {

        PlayerPrefs.SetInt("ProgressSave", PlayerPrefs.GetInt("Progress"));
        PlayerPrefs.SetInt("Progress", 7);
        Time.timeScale = 1.0f;
        isPaused = !isPaused;
        SceneManager.LoadScene("SalonMultiplat");

    }

    public void GoToLevel4()
    {

        PlayerPrefs.SetInt("ProgressSave", PlayerPrefs.GetInt("Progress"));
        PlayerPrefs.SetInt("Progress", 9);
        Time.timeScale = 1.0f;
        isPaused = !isPaused;
        SceneManager.LoadScene("salonProg");

    }

    public void GoToLevel5()
    {

        PlayerPrefs.SetInt("ProgressSave", PlayerPrefs.GetInt("Progress"));
        PlayerPrefs.SetInt("Progress", 14);
        Time.timeScale = 1.0f;
        isPaused = !isPaused;
        SceneManager.LoadScene("salonSocio");

    }
    public void GoToLevel6()
    {

        PlayerPrefs.SetInt("ProgressSave", PlayerPrefs.GetInt("Progress"));
        PlayerPrefs.SetInt("Progress", 15);
        Time.timeScale = 1.0f;
        isPaused = !isPaused;
        SceneManager.LoadScene("SalonArte");

    }

    public void GoToLevel7()
    {

        PlayerPrefs.SetInt("ProgressSave", PlayerPrefs.GetInt("Progress"));
        PlayerPrefs.SetInt("Progress", 18);
        Time.timeScale = 1.0f;
        isPaused = !isPaused;
        SceneManager.LoadScene("SalonNarrativa");

    }


    public void GoToLevel8()
    {

        PlayerPrefs.SetInt("ProgressSave", PlayerPrefs.GetInt("Progress"));
        PlayerPrefs.SetInt("Progress", 21);
        Time.timeScale = 1.0f;
        isPaused = !isPaused;
        SceneManager.LoadScene("SalonProyecto");

    }

    public void GoToLevel9()
    {

        PlayerPrefs.SetInt("ProgressSave", PlayerPrefs.GetInt("Progress"));
        PlayerPrefs.SetInt("Progress", 23);
        Time.timeScale = 1.0f;
        isPaused = !isPaused;
        SceneManager.LoadScene("SalonNeg");

    }

    public void GoToLevel10()
    {

        PlayerPrefs.SetInt("ProgressSave", PlayerPrefs.GetInt("Progress"));
        PlayerPrefs.SetInt("Progress", 24);
        Time.timeScale = 1.0f;
        isPaused = !isPaused;
        SceneManager.LoadScene("SalonMat");

    }
}
