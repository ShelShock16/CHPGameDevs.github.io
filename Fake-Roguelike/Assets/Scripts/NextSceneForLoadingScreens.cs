using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextSceneForLoadingScreens : MonoBehaviour
{

    public float time = 0;
    public int numScene;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {    
            time += Time.deltaTime;

        if ( time > 5)
        {
           

            SceneManager.LoadScene(numScene);
        }

    }
}
