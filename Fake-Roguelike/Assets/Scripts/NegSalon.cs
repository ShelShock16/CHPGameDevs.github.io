using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;
using UnityEngine.SceneManagement;

public class NegSalon : MonoBehaviour
{
    public void Start()
    {
        int l = PlayerPrefs.GetInt("Lang");

        string[] names =
        {
            "EO",
            "Brun",
            "EO",
            "Brun",
            "Masinha",
            "Brun",
            "Masinha",
            "Masinha",
            "Brun",
            "Perro",
            "Luciel",
            "Perro",
            "Masinha",
            "Masinha",
            "Brun"
            };


        if (l == 1)
        {
            string[] sentences =
            {
                "¿Ven? No hay nada, solo un perro en patineta por algún motivo.",
                "¿Se juegan un Counter hoy de tarde?",
                "Dale, a las 12 ya estoy pronto.",
                "Pero llego como a las 2 a casa.",
                "lol, imaginate vivir en Sauce.",
                "Imaginate perder el examen de conducir cinco veces.",
                "…",
                "¿Counter a las 2 entonces?",
                "Se.",
                "m… mat…",
                "¿El perro acaba de hablar? ¿O estoy escuchando cualquier cosa?",
                "matem…",
                "AH.",
                "¿Escucharon eso? Creo que hay algo afuera.",
                "Vamos a ver."
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 24);
        }


        if (l == 0)
        {
            string[] sentences =
            {
                //TRADUCIR A INGLÉS
                "Do you see? There’s nothing in here, only a dog on a skateboard for some reason.",
                "Do you want to play Counter today’s evening?",
                "Of course, I’ll be ready at 12.",
                "But I arrive home at 2pm.",
                "lol, imagine living in Sauce.",
                "Imagine failing the driving exam five times.",
                "…",
                "Counter at 2pm then?",
                "Yeah.",
                "m… mat…",
                "Did the dog just talked? Or am I listening to random things?",
                "math…",
                "AH.",
                "Did you listen to that? I think there’s something outside.",
                "Let’s see."
                
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 24);
        }
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 24 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("LevelSelector3");
    }
}
