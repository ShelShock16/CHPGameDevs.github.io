using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BusEndScript : MonoBehaviour
{
    public void Start()
    {
        int l = PlayerPrefs.GetInt("Lang");

        string[] names =
        {
            "Luciel",
            "Luciel",
            "Brun",
            "EO",
            "Masinha",
            "Luciel",
            "Luciel",
            "Luciel",
            "Viar",
            "Luciel",
            "Viar",
            "Brun",
            "Viar",
            "Viar",
            "Masinha",
            "Viar",
            "Brun",
            "Viar",
            "Viar",
            "Viar",
           
            };


        if (l == 1)
        {
            string[] sentences =
            {
            " Ah�",
            "Se siente bien poder descansar un poco�",
            "S�, supongo que llevamos muchas horas intentando aprobar materias.",
            "�Pueden dejar de hablar de la UTU? ",
            "S�, la re aburren, ya pasamos, podemos hablar de cualquier otra cosa.",
            "Perd�n�",
            "Solo siento que algo no cuadra.",
            "Como si no fuera la primera vez que hacemos esto.",
            "�Hola! �Chicos!",
            "�Profe? �Qu� hac�s ac�?",
            "Escuch� que estaban hablando de c�mo pasaron el a�o� �Felicitaciones!",
            "�Gracias! Habr�a sido imposible sin tu ayuda.",
            "No se preocupen, es mi trabajo de todas formas.",
            "Pero creo que podr�an haber trabajado un poco mejor�",
            "�Qu� importa? Aprobamos, no queremos m�s.",
            "Supongo que les fue mejor que la vez anterior�",
            "�La qu�?",
            "Lo van a entender m�s tarde.",
            "Suerte, y m�s les vale pasar con 12.",
            "A menos que quieran vivir este d�a por la eternidad, claro.",
                };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 35);
        }


        if (l == 0)
        {
            string[] sentences =
             {
                "Oh�",
            " It feels good to rest a bit�",
            "Yes, I suppose we spent so many hours trying to approve subjects.",
            "Can you stop talking about the UTU? ",
            "Yup, you�re being really boring, we�ve just passed, we can talk about anything we want.",
            "Sorry�",
            "It�s just that I feel that something is not ok.",
            " Like if it wasn�t the first time we do this.",
            "Hi guys!",
            "Prof? What are you doing here?",
            "I�ve heard that you�re talking about how you passed the year� Congrats!",
            "Thank you! It would�ve been impossible without your help.",
            "Don�t worry, It�s my job anyways.",
            "But I think you could�ve done better�",
            "What 's the odds? We approved, we don�t want more.",
            "I suppose you did better than last time�",
            "What?",
            "You�re going to understand it later.",
            "Good luck, and you better pass with 12.",
            "Unless you want to live this day for eternity.",
                };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 35);
        }
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 35 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("Credits");
    }
}
