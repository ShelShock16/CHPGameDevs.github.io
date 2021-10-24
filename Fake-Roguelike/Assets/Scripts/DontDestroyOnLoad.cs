using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DontDestroyOnLoad : MonoBehaviour
{
    public int a =4;
    public int b = 12;
    public int c = 13;

    public string objectID;
    public GameObject[] Audio;
    // Start is called before the first frame update

    private void Start()
    {
        Audio = GameObject.FindGameObjectsWithTag("Audio");
    }
    void Awake()
    {

        

        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Audio.Length > 1)
        {
            Destroy(this.gameObject);
        }

        int y = SceneManager.GetActiveScene().buildIndex;
        if (y == a || y == b || y == c || y == 20 || y == 21 || y == 23 || y == 24 || y == 25 || y == 26 || y == 27 || y == 28 || y == 29)
        {
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
