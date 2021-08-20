using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    int frames = 0;

    void Update()
    {

        if (frames < 241) frames++;

        if (Input.anyKey && frames > 240)
        {
            SceneManager.UnloadSceneAsync("Game Over");
            SceneManager.LoadSceneAsync("Level 1");
        }
    }

}
