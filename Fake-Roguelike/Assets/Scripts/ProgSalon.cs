using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;
using UnityEngine.SceneManagement;

public class ProgSalon : MonoBehaviour
{
    public float time = 0;
    public void Start()
    {
        //PRIMERA VEZ QUE ENTRAS

        if (PlayerPrefs.GetInt("Progress") == 9)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Luciel",
            "EO",
            "Luciel"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "¿Hola?",
                "Creo que no hay nadie.",
                "Pero se supone que teníamos programación ahora."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 10);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR ESTO A INGLÉS
                "¿Hola?",
                "Creo que no hay nadie.",
                "Pero se supone que teníamos programación ahora."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 10);
            }
        }

        //DESPUÉS DEL JUEGO

        if (PlayerPrefs.GetInt("Progress") == 13)
        {
            int l = PlayerPrefs.GetInt("Lang");
            transform.Translate(0,-3,0);

            string[] names =
            {
            "Gaddi",
            "Luciel",
            "EO",
            "EO",
            "Luciel"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "¡Felicidades! Aprobaron mi materia.",
                "¿En serio no creen que todo es demasiado simple?",
                "Lu, deja de inventarte cosas, nos quedan 5 materias.",
                "¿Seguro que no fumaste lo mismo que la profe de filo?",
                "Perdón, dormí 2 horas anoche, seguro son cosas mías.",
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 14);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR ESTO A INGLÉS
                "¡Felicidades! Aprobaron mi materia.",
                "¿En serio no creen que todo es demasiado simple?",
                "Lu, deja de inventarte cosas, nos quedan 5 materias.",
                "¿Seguro que no fumaste lo mismo que la profe de filo?",
                "Perdón, dormí 2 horas anoche, seguro son cosas mías.",
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 14);
            }
        }
    }



    //UPDATE

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 10 && DialogueTrigger.dialogueActive == false)
        {
            time += Time.deltaTime;
            transform.Translate(0, -0.025f, 0);
            if (time > 2)
            {
                PlayerPrefs.SetInt("Progress", 11);
            }
        }
        if (PlayerPrefs.GetInt("Progress") == 11 && DialogueTrigger.dialogueActive == false)
        {
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
                PlayerPrefs.SetInt("Progress", 12);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR A INGLÉS
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
                PlayerPrefs.SetInt("Progress", 12);
            }
        }
        if (PlayerPrefs.GetInt("Progress") == 12 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("ProgramationGame");
        if (PlayerPrefs.GetInt("Progress") == 14 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("LevelSelector2");
    }
}
