using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelSelectorMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       if(PlayerPrefs.GetInt("Progress")>=9 && PlayerPrefs.GetInt("Progress") < 18){
            SceneManager.LoadScene("LevelSelector2");

                }
        if (PlayerPrefs.GetInt("Progress") >= 18 && PlayerPrefs.GetInt("Progress") < 25)
        {
            SceneManager.LoadScene("LevelSelector3");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
