using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public static bool start = true;
    public static bool dialogueActive = false;
    public GameObject dialogueCanvas;
    public Animator animator;
    public Dialogue dialogue;


    public void Start()
    {
        //dialogueActive = !dialogueActive;
    }

    public void Update()
    {

        if (dialogueActive && start)
        {
            TriggerDialogue();
            start = false;
        }

        if (dialogueActive)
        {
            dialogueCanvas.SetActive(true);
            animator.SetBool("isOpen", true);
        }

        else
        {
            animator.SetBool("isOpen", false);
            dialogueCanvas.SetActive(false);
          
        }

        if (Input.GetButtonUp("Interact") && dialogueActive && !Pause.isPaused)
        {
            TriggerNextSentence();
            if (FindObjectOfType<DialogueManager>().end)
            {
                dialogueActive = !dialogueActive;
                start = true;
            }
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue();
    }

    public void TriggerNextSentence()
    {
        FindObjectOfType<DialogueManager>().DisplayNextSentence();
    }

}
