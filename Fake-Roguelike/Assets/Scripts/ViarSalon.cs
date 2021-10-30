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
                "¡Hola!",
                "Viar! Justo te estábamos buscando.",
                "¿Cómo llegaste acá?",
                "Por la ventana, obviamente.",
                "...",
                "Bueno, ¿Qué hacemos ahora?",
                "El primer paso a la hora de enfrentar un proyecto es la planeación.",
                "Deben analizar la situación en la que se encuentran.",
                "Y buscar una solución óptima.",
                "En su caso, deben aprobar diez materias en un día, ¿Cómo planean hacer eso?",
                "No tenemos ni idea.",
                "Bueno, pueden empezar por visitar el salón a la derecha del mío.",
                "Creo que ahí está la profesora de filosofía.",
                "Ella les va a plantear una prueba, como un examen.",
                "¿Así de fácil? ¿Si la pasamos aprobamos?",
                "No lo llamaría fácil.",
                "Pero eso es cosa de ustedes.",
                "Una vez aprueben eso, pasen al siguiente salón.",
                "Hay tres salones por piso, y tres pisos en la escuela.",
                "¡Excelente!",
                "Ese es nuestro plan, entonces.",
                "¿Qué debemos hacer para ADA?",
                "Ah, no se preocupen.",
                "Tienen un plan para trabajar, ese es el propósito de mi materia.",
                "Enfoquense en las demás.",
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
                "Hi!",
                "Viar! We were waiting for you,",
                "How did you enter the room?",
                "Through the window, obviously.",
                "...",
                "Well, what do we do now?",
                "The first step when facing a project is planning.",
                "You must analyze the situation you are in.",
                "And look for an optimal solution.",
                "In your case, you have to pass ten subjects in one day, how do you plan to do that?",
                "We dunno.",
                "Okay, you can start going to the classroom on the right.",
                "I think the philosophy teacher is there.",
                "She will give you an exam.",
                "That easy? If we pass we approve?",
                "I wouldn’t call it easy.",
                "But that’s your problem.",
                "Once you approve, you can go to the next classroom.",
                "There are three classrooms on each floor, and three floors in total.",
                "Excelent!",
                "That 's our plan then.",
                "What should we do for ADA?",
                "Oh, don’t worry.",
                "You have a plan to follow, that’s the purpose of my subject.",
                "Try to focus on the other subjects.",
                "Good luck, you will need it."
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
