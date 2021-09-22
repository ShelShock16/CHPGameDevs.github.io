using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Dialogue;

public class NextLevel : MonoBehaviour
{
    public bool talked = false;
    public int numScene;
    public GameObject Player;

    void Update()
    {
        if (talked && !DialogueTrigger.dialogueActive)
        {
            SceneManager.LoadScene(numScene);
            PlayerPrefs.SetInt("LockedLvl2", 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string[] names =
        {
            "AAAAAAA",
            "Brun",
            "Luciel",
            "EO",
            "Masinha",
            "Masinha",
            "Luciel",
            "EO",
            "Masinha",
            "Brun",
            "Brun"
        };

        string[] sentences =
        {
            "A d�nde se fue Viar?",
            "No est�.",
            "No se supone que estaba yendo a la UTU?",
            "Creo�",
            "BO.",
            "CREO QUE HAY UN PERRO EN PATINETA.",
            "Qu�?",
            "Masi, est�s bien?",
            "�",
            "Estamos a unas cuadras de la UTU.",
            "Creo que llegamos a tiempo si caminamos."
        };

        if (collision.gameObject.tag == "Player")
        {
            DialogueTrigger.dialogue.names = names;
            DialogueTrigger.dialogue.sentences = sentences;
            //FindObjectOfType<Dialogue>().SetDialogue(names, sentences);
            DialogueTrigger.dialogueActive = !DialogueTrigger.dialogueActive;
            //FindObjectOfType<DialogueTrigger>().dialogueActive = !FindObjectOfType<DialogueTrigger>().dialogueActive;
            talked = true;
        }
    }
}
