using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMenu : MonoBehaviour
{
    float time;
    public GameObject sound1;
    public Animator m_Animator;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       /* time += Time.deltaTime;

        if (time > 2.8f) sound1.SetActive(true);*/

        //Get the Animator, which you attach to the GameObject you intend to animate.



        if (m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Default"))
        {
            sound1.SetActive(true);
            
        }
        if (!m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Default"))
        {
            sound1.SetActive(false);
            
        }
    }

   
}
