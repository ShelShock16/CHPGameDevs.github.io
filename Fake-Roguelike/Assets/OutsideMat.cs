using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;
using UnityEngine.SceneManagement;

public class OutsideMat : MonoBehaviour
{
    public SpriteRenderer profs;
    public void Start()
    {
        //PRIMERA VEZ QUE ENTRAS
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Karen & Jaime",
            "EO",
            "Luciel"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "Karen & Jaime",
                "Creo que no hay nadie.",
                "Pero se supone que teníamos programación ahora."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 33);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR ESTO A INGLÉS
                "Hi?",
                "I think there’s nobody here.",
                "But we were supposed to have programming class now."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 33);
        }
    }

    //UPDATE

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 33 && DialogueTrigger.dialogueActive == false)
        {
            profs.color = new Color(255, 255, 255, 255);
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Gaddi",
            "EO",
            "Luciel",
            "Brun",
            "Gaddi",
            "Gaddi",
            "Masinha",
            "Gaddi",
            "Gaddi"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "¡Hola! Perdonen, vengo del médico.",
                "Sí, claro, el médico.",
                "En fin.",
                "¿Cómo podemos aprobar tu materia?",
                "Eehhhh.",
                "¿Saben código binario?",
                "¿Es eso de los unos y ceros?",
                "Sí, básicamente.",
                "Supongo que pueden hacer esta prueba entonces."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 34);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR A INGLÉS
                "Hi! Sorry, I come from the doctor.",
                "Yeah, of course, the doctor.",
                "Anyways.",
                "How can we approve your subject?",
                "Mmmm.",
                "Do you know binary code?",
                "That weird thing of the 1s and 0s?",
                "Yes, basically..",
                "I suppose you can do this test then."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 34);
            }
        }

        if (PlayerPrefs.GetInt("Progress") == 34 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("BusEnd");
    }
}
