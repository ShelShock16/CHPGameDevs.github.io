using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;
using UnityEngine.SceneManagement;

public class NarrativaSalon : MonoBehaviour
{
    public SpriteRenderer black;
    public Sprite es, en;
    public float time = 0;
    public void Start()
    {
        black.color = new Color(255, 255, 255, 0);

        int l = PlayerPrefs.GetInt("Lang");

        string[] names =
        {
            "Mariño",
            "Luciel",
            "Mariño",
            "Luciel",
            "Luciel",
            "Mariño",
            "Mariño",
            "Brun",
            "Mariño"
        };


        if (l == 1)
        {
            black.sprite = es;

            string[] sentences =
            {
                "¡Hola chicos! ¡Llegan 32 semanas tarde!",
                "¡Perdón! ¡Estábamos tirándole lápices a hamsters voladores!",
                "Entendible, despertarse a esta hora debería ser un pecado de todas formas.",
                "Y… ¿Qué te parece la idea hasta ahora?",
                "¿Te gustó la parte de filosofía? Creo que el detalle existencial aporta un montón.",
                "Sí, es brillante.",
                "¿Quizá podrían profundizar en eso más tarde? El comentario meta aporta un montón a la comedia.",
                "De hecho pensábamos hacer justo eso.",
                "Ya vieron cómo van a hacer el…-"
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 19);
        }


        if (l == 0)
        {
            black.sprite = en;

            string[] sentences =
            {
                //TRADUCIR ESTO A INGLÉS
                "¡Hi guys! Y’all came 32 weeks late!",
                "Sorry! We were throwing pencils to flying hamsters!",
                "Understandable, waking up at this hour should be a sin anyways.",
                "And… What are your thoughts on the idea so far?",
                "Did you like the Philosophy part? I believe the existential detail contributes a lot.",
                "Yes, It’s brilliant.",
                "Maybe could you deepen on that later? The meta comentary contributes a lot to the comedy.",
                "In fact, we were thinking about that.",
                "Have you seen how you will do…-"
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 19);
        }
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 19 && DialogueTrigger.dialogueActive == false)
        {
            time += Time.deltaTime;
            black.color = new Color(255,255,255,255);
            if (time > 3)
            {
                black.color = new Color(255, 255, 255, 0);
                PlayerPrefs.SetInt("Progress", 20);
            }
        }

        if (PlayerPrefs.GetInt("Progress") == 20 && DialogueTrigger.dialogueActive == false)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Masinha",
            "Masinha",
            "Mariño",
            "Mariño",
            "Mariño",
            "Mariño",
            "Luciel",
            "Luciel",
            "EO",
            "Mariño",
            "Mariño"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "lol",
                "No es mala, después agregamos eso.",
                "Bueno, se está haciendo tarde…",
                "Pero no se estresen, tienen el año aprobado prácticamente, van bien.",
                "Ah, una cosa más.",
                "Creo que un Shapeshifter aportaría un montón a la historia, para evitar que se sienta muy predecible todo.",
                "¿Seguro? Siento que sería demasiado complicado.",
                "Pero sí, podemos intentar implementar algo así.",
                "¿Nos falta algo más?",
                "No, nada más.",
                "Ahora si me lo permiten voy a tomar una muy necesaria powernap antes de tener al próximo grupo."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 21);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR A INGLÉS
                "lol",
                "That’s not a bad idea, later we will add it.",
                "Well, it’s getting late…",
                "But don’t worry, you have the year practically approved, you’re doing great.",
                "Oh, one more thing.",
                "I think a shapeshifter would contribute a lot to the story, to avoid everything to be so predictable",
                "Sure? I feel it would be too complicated.",
                "But yeah, we could try to implement it. ",
                "Are we missing anything?",
                "No, nothing more.",
                "Now, with your permission, I will take a recharging powernap before the other group’s class."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 21);
            }
        }

        if (PlayerPrefs.GetInt("Progress") == 21 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("LevelSelector3");
    }
}
