using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDialogueTrigger : MonoBehaviour
{
    void Start()
    {
        string[] names =
        {
            "Luciel",
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
        DialogueTrigger.dialogue.names = names;
        DialogueTrigger.dialogue.sentences = sentences;
        //FindObjectOfType<Dialogue>().SetDialogue(names, sentences);
        DialogueTrigger.dialogueActive = !DialogueTrigger.dialogueActive;
        //FindObjectOfType<DialogueTrigger>().dialogueActive = !FindObjectOfType<DialogueTrigger>().dialogueActive;
    }
}
