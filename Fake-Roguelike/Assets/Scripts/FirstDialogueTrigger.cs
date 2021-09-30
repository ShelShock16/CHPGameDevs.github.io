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

        int l = PlayerPrefs.GetInt("Lang");

        if (l==1) { 
        string[] sentences =
        {
            "¿A dónde se fue Viar?",
            "No está.",
            "¿No se supone que estaba yendo a la UTU?",
            "Creo…",
            "BO.",
            "CREO QUE HAY UN PERRO EN PATINETA.",
            "¿Qué?",
            "Masi, ¿estás bien?",
            "…",
            "Estamos a unas cuadras de la UTU.",
            "Creo que llegamos a tiempo si caminamos."
        };

            
        Dialogue.names = names;
        Dialogue.sentences = sentences;
        DialogueTrigger.dialogueActive = true;

        }

        if (l == 0)
        {
            string[] sentences =
            {
            "Where did Viar go?",
            "He isn't here",
            "Wasn't he supposed to be going to UTU?",
            "I believe",
            "HEY.",
            "I THINK THERE'S A SKATEBOARDING DOG.",
            "What?",
            "Masi, are you okay?",
            "…",
            "We are a few blocks from the UTU.",
            "I think we will arrive on time if we start walking."
        };


            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;

        }
        //FindObjectOfType<Dialogue>().SetDialogue(names, sentences);
        //FindObjectOfType<DialogueTrigger>().dialogueActive = !FindObjectOfType<DialogueTrigger>().dialogueActive;
    }
}
