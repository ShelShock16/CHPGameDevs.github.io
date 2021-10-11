using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarMovement : MonoBehaviour
{
    public GameObject CarRight;
    public GameObject CarLeft;
    public static int Life=5;
    public Text txt;
    public Text txt2;
    public int PointsMax;
    public int SceneToUnlock=16;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("CarLife", Life);
        PlayerPrefs.SetInt("CarPoints", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)&& CarRight.transform.position != transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, CarRight.transform.position, 1.1f );
            
        }

        if (Input.GetKeyDown(KeyCode.A) && CarLeft.transform.position != transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, CarLeft.transform.position,1.1f );
        }
        txt.text= ""+PlayerPrefs.GetInt("CarLife");
        txt2.text = "" + PlayerPrefs.GetInt("CarPoints");
            if (PlayerPrefs.GetInt("CarLife") == 0) SceneManager.LoadScene(15);

        if (PlayerPrefs.GetInt("CarPoints") == PointsMax)
        {

            PlayerPrefs.SetInt("LockedLvl3", 0);
            SceneManager.LoadScene(SceneToUnlock);
        }
    }

   
    
}
