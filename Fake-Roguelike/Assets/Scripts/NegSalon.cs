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
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 24 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("LevelSelector3");
    }
}
