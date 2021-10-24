using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;
using UnityEngine.SceneManagement;

public class ViarSalon : MonoBehaviour
{
    public void Start()
    {
        int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Viar",
            "Luciel",
            "Luciel",
            "Viar",
            "Luciel",
            "Brun",
            "Viar",
            "Viar",
            "Viar",
            "Viar",
            "Masinha",
            "Viar",
            "Viar",
            "Viar",
            "Brun",
            "Viar",
            "Viar",
            "Viar",
            "Viar",
            "Luciel",
            "Luciel",
            "Luciel",
            "Viar",
            "Viar",
            "Viar",
            "Viar"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "�Hola!",
                "Viar! Justo te est�bamos buscando.",
                "�C�mo llegaste ac�?",
                "Por la ventana, obviamente.",
                "...",
                "Bueno, �Qu� hacemos ahora?",
                "El primer paso a la hora de enfrentar un proyecto es la planeaci�n.",
                "Deben analizar la situaci�n en la que se encuentran.",
                "Y buscar una soluci�n �ptima.",
                "En su caso, deben aprobar diez materias en un d�a, �C�mo planean hacer eso?",
                "No tenemos ni idea.",
                "Bueno, pueden empezar por visitar el sal�n a la derecha del m�o.",
                "Creo que ah� est� la profesora de filosof�a.",
                "Ella les va a plantear una prueba, como un examen.",
                "�As� de f�cil? �Si la pasamos aprobamos?",
                "No lo llamar�a f�cil.",
                "Pero eso es cosa de ustedes.",
                "Una vez aprueben eso, pasen al siguiente sal�n.",
                "Hay tres salones por piso, y tres pisos en la escuela.",
                "�Excelente!",
                "Ese es nuestro plan, entonces.",
                "�Qu� debemos hacer para ADA?",
                "Ah, no se preocupen.",
                "Tienen un plan para trabajar, ese es el prop�sito de mi materia.",
                "Enfoquense en las dem�s.",
                "Suerte, la van a necesitar."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 2);
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
                "I mean� Yes, that.",
                "Oh yeah, if I'm not mistaken they have something to do with the math test.",
                "A few hours ago, those from 3BA entered the events room, and those creatures came out.",
                "I guess they didn't do very well.",
                "�",
                "First of all, how did you get here ?",
                "Didn't they even teach you how to fly?",
                "IS IT POSSIBLE TO FLY?",
                "So why do I need a bus? Or a car?",
                "To avoid flying hamsters, obviously.",
                "�",
                "You should enter the UTU, you are going to be late.",
                "And if you teach us to fly before?"
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 2);
            }
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 2 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene(4);
    }
}
