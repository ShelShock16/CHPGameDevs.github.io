using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Retry : MonoBehaviour
{
    float time = 0;
    public int numScene;
    public Image img;
    public Sprite eng;
    public Sprite esp;
    void Update()
    {

        if (PlayerPrefs.GetInt("Lang") == 0)
        {
            img.sprite = eng;
        }

        if (PlayerPrefs.GetInt("Lang") == 1)
        {
            img.sprite = esp;
        }

        if (time < 3) time += Time.deltaTime;

        if (Input.anyKey && time > 3)
        {
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());

            SceneManager.LoadScene(numScene);
        }
    }

}
