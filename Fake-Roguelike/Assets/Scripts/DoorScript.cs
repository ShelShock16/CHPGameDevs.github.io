using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    private Animator Door;

    void Start()
    {
        Door = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(Player.transform.position, this.transform.position);


        if (dist <0.6f) {


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
