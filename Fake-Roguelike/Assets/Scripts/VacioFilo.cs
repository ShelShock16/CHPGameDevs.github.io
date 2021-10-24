using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;
using UnityEngine.SceneManagement;

public class VacioFilo : MonoBehaviour
{
    public void Start()
    {
        int l = PlayerPrefs.GetInt("Lang");

        string[] names =
        {
        "Luciel",
        "Masinha",
        "Masinha",
        "EO",
        "Brun",
        "Luciel",
        "Luciel",
        "Masinha"
        };


        if (l == 1)
        {
            string[] sentences =
            {
            "Creo que podemos ap�",
            "QU�",
            "�D�NDE ESTAMOS?",
            "Afuera del sal�n, creo, pero el resto del mundo parece haber desaparecido.",
            "�Eso significa que perdimos el curso? �Literalmente?",
            "Jaja, buena.",
            "Creo que lo �nico que podemos hacer es volver a entrar.",
            "Por favor, s�."
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 4);
        }


        if (l == 0)
        {
            string[] sentences =
            {
            //TRADUCIR ESTO A INGL�S
            "Creo que podemos ap�",
            "QU�",
            "�D�NDE ESTAMOS?",
            "Afuera del sal�n, creo, pero el resto del mundo parece haber desaparecido.",
            "�Eso significa que perdimos el curso? �Literalmente?",
            "Jaja, buena.",
            "Creo que lo �nico que podemos hacer es volver a entrar.",
            "Por favor, s�."
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 4);
        }
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 4 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("SalonFilo");
    }
}
