using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;
using UnityEngine.SceneManagement;

public class MultiplatSalon : MonoBehaviour
{
    public void Start()
    {
        int l = PlayerPrefs.GetInt("Lang");

        string[] names =
        {
            "Luciel",
            "Mr. Derecho",
            "Mr. Derecho",
            "Brun",
            "Brun",
            "Mr. Derecho",
            "EO",
            "Mr. Derecho",
            "Mr. Derecho",
            "Luciel",
            "Luciel",
            "Masinha",
            "Mr. Derecho",
            "EO",
            "Brun"
        };


        if (l == 1)
        {
            string[] sentences =
            {
                "�Hola! �Venimos a aprobar tu materia!",
                "Vienen a�",
                "�Qu�?",
                "Aprobar tu materia.",
                "Nos vas a poner un escrito o algo?",
                "�Escrito? Justo estaba por irme.",
                "�C�mo que irte? Acaba de empezar tu hora.",
                "S�, sobre eso�",
                "�Les sirve si les doy un 8 y listo?",
                "�No!",
                "Digo�",
                "S�, m�s bien que nos sirve.",
                "Bien, chau.",
                "Eso fue f�cil�",
                "No se conf�en, quedan 6 materias."
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 8);
        }


        if (l == 0)
        {
            string[] sentences =
            {
                //TRADUCIR ESTO A INGL�S
                "�Hola! �Venimos a aprobar tu materia!",
                "Vienen a�",
                "�Qu�?",
                "Aprobar tu materia.",
                "Nos vas a poner un escrito o algo?",
                "�Escrito? Justo estaba por irme.",
                "�C�mo que irte? Acaba de empezar tu hora.",
                "S�, sobre eso�",
                "�Les sirve si les doy un 8 y listo?",
                "�No!",
                "Digo�",
                "S�, m�s bien que nos sirve.",
                "Bien, chau.",
                "Eso fue f�cil�",
                "No se conf�en, quedan 6 materias."
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 8);
        }
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 8 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene(4);
    }
}
