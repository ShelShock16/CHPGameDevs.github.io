using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SummoningManagement : MonoBehaviour
{


    bool check = false;
    float pos;
    public GameObject Summoning;
    public GameObject player;
  
    // Start is called before the first frame update
    void Start()
    {
        // a=scene.isLoaded;
        pos = player.transform.position.x;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (pos != player.transform.position.x ||check==true)
        {

            check = true;
          Summoning.SetActive(true);
        }
        


    }
}
