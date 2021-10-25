using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevelForStairs : MonoBehaviour
{
    public string nomScene;
    public int progress, progressReq;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player" && PlayerPrefs.GetInt("Progress") == progressReq)
        {
            PlayerPrefs.SetInt("Progress", progress);
            SceneManager.LoadScene(nomScene);
        }

        if (collision.gameObject.tag == "Player" && PlayerPrefs.GetInt("Progress") >= progressReq)
        {
            SceneManager.LoadScene(nomScene);
        }
    }
}
