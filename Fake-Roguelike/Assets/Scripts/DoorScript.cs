using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public int numSalon;
    public GameObject Player;
    private Animator Door;

    void Start()
    {
        Door = GetComponent<Animator>();
    }

    void Update()
    {
        float dist = Vector3.Distance(Player.transform.position, this.transform.position);


        if (dist <1f && PlayerPrefs.GetInt("Progress") == numSalon) {


            Door.SetBool("isNear", true);
            Door.SetBool("isFar", false);
            

        }
        else
        {
            Door.SetBool("isNear", false);
            Door.SetBool("isFar", true);


        }
        //m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Default")
    }
}
