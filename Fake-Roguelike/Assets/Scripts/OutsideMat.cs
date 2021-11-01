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
            "Luciel",
            "Brun",
             "Masinha",
            "EO",
            };


            if (l == 1)
            {
                string[] sentences =
                {
                            "No les parece un poco injusto que una sola pregunta defina el resultado del escrito?",
                            "Mhm, encima estaba re difícil.",
                            "Dejen de pensar tanto",
                            "Lo tengamos bien o no, ya es tarde para cambiarlo.",
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
                "Don’t you find it unfair that a person defines the result of the test?",
                            "Mhm, and it was really difficult.",
                            "Stop thinking so much.",
                            "Right or wrong, we can’t do anything right now.",
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
            "Karen",
            "Karen",
            "Karen",
            "Luciel",
            "Masinha",
            "EO",
            "Brun",
            "Brun",
            "Luciel",
            };


            if (l == 1)
            {
                string[] sentences =
                {
            "Es de mi desagrado informarles que…",
            "Todos aprobaron el escrito con 12.",
            "Los primeros 12 que doy en mi carrera como docente, además.",
            "¡SÍ!",
            "VAMOS, NUNCA MÁS VUELVO A LA UTU.",
            "Con un 8 estaba feliz, pero un 12…",
            "Ya está, ¿Podemos irnos de acá? ",
            "Ya tenemos todo aprobado, quedarnos es innecesario.",
            "Síp síp, nos vamos.",
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
            "It’s my dislike to communicate you that you…",
            " all aproved with 12!",
            "The first 12 I give in my career, too.",
            " YEAH!",
            "LET’S GO! I’M NOT COMING BACK TO THE UTU ANYMORE!",
            "With an 8 I was happy, but a 12…",
            "It’s done, can we leave? ",
            "We have passed every class, it’s unnecesary to stay.",
            "Yup, yup, we’re leaving.",
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
