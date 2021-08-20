using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.UnloadSceneAsync("Game Over");
            SceneManager.LoadSceneAsync("Level 1");
        }
    }

}
