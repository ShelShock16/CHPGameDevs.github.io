using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;
using UnityEngine.SceneManagement;

public class ArteSalon : MonoBehaviour
{

    public GameObject ufo1;
    public GameObject ufo2;
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
                "Hi?",
                "…",
                "HI?!",
                "I can’t hear you, It’s full of flying hamsters!",
                "Are we still gonna act like this is normal?",
                "There 's no time for questioning, we have to approve every subject.",
                "What?!"
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
            Destroy(ufo1);
            Destroy(ufo2);
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
                "(¿Alguien sabe de qué está hablando?)",
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
                "Now I can hear you, what did you want to tell me?",
                "How can we approve your subject?",
                "You’ve already approved! You’ve brought the best drawing of the class!",
                "What drawings?",
                "Those characters!",
                "The guy with the white shirt, and the other with the yellow hat…",
                "And the one with the guitar…",
                "Oh! And the one with curly hair!",
                "(Did anybody know what he is talking about?)",
                "(no, but he want to approve us, just say yes)",
                "Oh! Yeah! That! Did you like it?",
                "Of course!",
                "Excelent! Thank you.",
                "Oh...",
                "We’re late for Narrative class.",
                "The teacher told me he was waiting for you on the 3rd floor.",
                "Take the stairs to the right, good luck!"
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
