using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    public bool IsPaused;
    public GameObject PauseMenu;
    // Update is called once per frame
    void Update()
    {
        if (IsPaused)
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
            IsPaused = !IsPaused;
        }


    }

    public void Resume()
    {
        IsPaused = !IsPaused;
    }

    public void Menu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
    }

    public void lvlSelector()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("LevelSelector");
    }

}
