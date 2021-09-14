using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    float time = 0;
    public int numScene;

    void Update()
    {

        if (time < 3) time += Time.deltaTime;

        if (Input.anyKey && time > 3)
        {
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());

            SceneManager.LoadScene(numScene);
        }
    }

}
