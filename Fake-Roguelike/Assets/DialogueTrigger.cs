using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public bool start = true;
    public bool dialogueActive = false;
    public GameObject dialogueCanvas;
    public Animator animator;

    public void Update()
    {
        //interface management
        if (dialogueActive)
        {
            dialogueCanvas.SetActive(true);
            animator.SetBool("isOpen", true);
            Time.timeScale = 0f;
        }
        else
        {
            animator.SetBool("isOpen", false);
            dialogueCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetButtonUp("Debug"))
        {
            dialogueActive = !dialogueActive;
        }

        //text management
        if (Input.GetButtonUp("Debug") && dialogueActive)
        {
            TriggerDialogue();
        }

        if (Input.GetButtonUp("Interact") && dialogueActive)
        {
            TriggerNextSentence();
            if (FindObjectOfType<DialogueManager>().end)
            {
                dialogueActive = !dialogueActive;
            }
        }
    }

    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void TriggerNextSentence()
    {
        FindObjectOfType<DialogueManager>().DisplayNextSentence();
    }

}
