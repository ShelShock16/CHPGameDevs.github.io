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

}
