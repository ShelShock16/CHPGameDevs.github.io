using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;
using UnityEngine.SceneManagement;

public class ArteSalon : MonoBehaviour
{
    public void Start()
    {
        //PRIMERA VEZ QUE ENTRAS

        if (PlayerPrefs.GetInt("Progress") == 15)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Luciel",
            "Claudio",
            "Luciel",
            "Claudio",
            "EO",
            "Brun",
            "Claudio"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "¿Hola?",
                "…",
                "¡¿Hola?!",
                "No los escucho, ¡Está lleno de hamsters voladores!",
                "¿Vamos a seguir actuando como si esto tuviera sentido?",
                "No hay tiempo para cuestionar, tenemos que salvar el año",
                "¡¿Qué?!"
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 16);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR ESTO A INGLÉS
                "¿Hola?",
                "…",
                "¡¿Hola?!",
                "No los escucho, ¡Está lleno de hamsters voladores!",
                "¿Vamos a seguir actuando como si esto tuviera sentido?",
                "No hay tiempo para cuestionar, tenemos que salvar el año",
                "¡¿Qué?!"
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 16);
            }
        }

        //DESPUÉS DEL JUEGO

        if (PlayerPrefs.GetInt("Progress") == 17)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Claudio",
            "Luciel",
            "Claudio",
            "Luciel",
            "Claudio",
            "Claudio",
            "Claudio",
            "Claudio",
            "Brun",
            "EO",
            "Luciel",
            "Claudio",
            "Luciel",
            "Masinha",
            "Masinha",
            "Claudio",
            "Claudio"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "Ahora sí, qué me querían decir?",
                "¿Cómo pasamos tu materia?",
                "¡Ya pasaron! ¡Trajeron los mejores dibujos de la clase!",
                "¿Qué dibujos?",
                "¡Esos personajes!",
                "El de la camisa blanca, y el del gorro amarillo…",
                "Y el de la guitarra…",
                "¡Ah! ¡Y el de los rulos!",
                " (¿Alguien sabe de qué está hablando?)",
                "(No, pero nos quiere pasar de año, solo digan que sí)",
                "¡Ah! ¡Sí! ¡Eso! ¿Te gustaron?",
                "¡Por supuesto!",
                "¡Excelente! Muchas gracias.",
                "Fua.",
                "Vamos a llegar tarde a Narrativa.",
                "El profe me dijo que los estaba esperando en el tercer piso.",
                "Tomen las escaleras a la derecha, suerte con las demás materias!"
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 17);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                "Hello!",
                "Prof.",
                "You won't believe what we just saw.",
                "The army of dogs and hamsters?",
                "What?",
                "I mean… Yes, that.",
                "Oh yeah, if I'm not mistaken they have something to do with the math test.",
                "A few hours ago, those from 3BA entered the events room, and those creatures came out.",
                "I guess they didn't do very well.",
                "…",
                "First of all, how did you get here ?",
                "Didn't they even teach you how to fly?",
                "IS IT POSSIBLE TO FLY?",
                "So why do I need a bus? Or a car?",
                "To avoid flying hamsters, obviously.",
                "…",
                "You should enter the UTU, you are going to be late.",
                "And if you teach us to fly before ? "
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 17);
            }
        }
    }



    //UPDATE

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 16 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("SpaceInvaders3");
        if (PlayerPrefs.GetInt("Progress") == 17 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("LevelSelector2");
    }
}
