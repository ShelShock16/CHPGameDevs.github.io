using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckSceneLoad : MonoBehaviour
{

    
    

    public GameObject EnemiesSpawing;
    public GameObject PointsSpawing;
    // Start is called before the first frame update
    void Start()
    {
        // a=scene.isLoaded;

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "ProgramationGame")
        {
            PointsSpawing.SetActive(true);
            EnemiesSpawing.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
