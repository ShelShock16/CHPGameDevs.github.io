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
            "Masinha",
            "EO",
            "Masinha",
            "Luciel",
            "Luciel",
            "Brun",
            "EO",
            "Brun",
            "Brun",
            "Masinha",
            "EO",
            "Brun",
            "Brun",
            "Viar",
            "EO",
            "Viar",
            "Masinha",
            "Luciel",
            "Viar",
            "Luciel",
            "Masinha",
            "EO",
            "Brun",
            "Viar",
            "Brun",
            "Luciel",
            "EO",
            "Viar",
            "Viar",
            "Masinha",
            "EO",
            "Brun",
            "Viar",
            "Luciel",
            "Viar",
            "Viar",
            "Viar",
            "Viar",
            "Brun",
            "Brun",
            "Viar",
            "Viar",
            "Chofer",
            "Chofer",
            "Chofer",
            "Chofer",
            "Chofer",
            "Chofer"
            };


        if (l == 1)
        {
            string[] sentences =
            {
                "…y entonces choqué al del auto gris, porque el hijo de p-",
                "¿Seguimos hablando del examen de manejo? ",
                "…sí",
                "EN FIN",
                "La cosa es que si te armas Liandry con Garen, podés—",
                "¿Hicieron los deberes de matemática?",
                "¿Había deberes?",
                "Sí, era algo de Pitágoras. Aunque no entiendo la parte que dice Roger Navidad.",
                "Creo que es un teorema pero no lo encuentro en internet.",
                "Creo que Roger era el profe de geometría del año pasado.",
                "Sí.",
                "…",
                "Bueno, no había deberes.",
                "Hola chicos.",
                "¡Oh! Hola profe.",
                "¿Cómo van con el proyecto?",
                "Vamos re bien.... ¿no?",
                "¡Si! Ya terminamos la planilla de tareas, y estamos empezando a diseñar la interfaz.",
                "La entrega es mañana.",
                "...",
                "...",
                "...",
                "...",
                "¿Nos vemos el año que viene entonces?",
                "NO.",
                "Solo tenemos que estudiar 9 meses de UTU en un día.",
                "Se puede.",
                "...",
                "¿Qué saben hacer?",
                "Con SPACE paso al siguiente diálogo.",
                "Sí, con SPACE.",
                "Justo iba a decir eso.",
                "¿Nada más?",
                "...",
                "Bueno, empezamos con lo básico.",
                "Te moves con W,A,S,D y atacas con las flechas",
                "No puedo creer que no les enseñaron esto.",
                "¿Qué les enseñaron en programación?",
                "Ah! Nos sacamos un 12 en eso.",
                "Hicimos un Powerpoint sobre PacMan :v",
                "...",
                "Bueno, creo que eso es todo lo que necesitan por ahora.",
                "AAAHHHHHH",
                "...",
                "Perdón, tremendo susto.",
                "Creo que el motor explotó.",
                "Todos abajo, el próximo ómnibus pasa en 10 minutos.",
                "Creo.",
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
                "…so I crashed with the grey car, ‘cause the motherf…",
                "Are we still talking about the driving exam?",
                "…yeah",
                "ANYWAY",
                "The thing is that if you buy Liandry with Garen, you are able to—",
                "Did anyone do the math homework?",
                "Did the teacher leave homework?",
                "Yup, it was something about Pythagoras. But I don’t understand the part that says Roger Navidad.",
                "I think there is a theorem but I can’t find it on the web.",
                "Roger was last year’s geometry teacher, I believe.",
                "Yes",
                "...",
                "Okay, there was no homework.",
                "Hi guys.",
                "¡Oh! Hi professor.",
                "How is the project going?",
                "We’re doing pretty good.... right?",
                "Absolutely! We’ve completed the task sheet, and we’re designing the interface.",
                "The presentation deadline is tomorrow.",
                "...",
                "...",
                "...",
                "...",
                "Am I seeing y’all next year?",
                "NO.",
                "We only have to study nine months in a day",
                "It 's possible.",
                "...",
                "What do you know to do?",
                "With SPACE I advance to the next dialog.",
                "Yup, with SPACE.",
                "I was about to say that.",
                "Only that?",
                "...",
                "Okay, let’s start with the basics.",
                "You move with W, A, S, D and attack with the arrows",
                "I can’t believe they didn’t teach you this.",
                "What did you learn in programming class?",
                "Ah! We got a 12 on that!",
                "We did a PowerPoint about PacMan :v",
                "...",
                "Okay, I think that’s all you need to know for now.",
                "AAAHHHHHH",
                "...",
                "Sorry, I panicked. ",
                "I think the engine exploded.",
                "Everyone get off the bus, the next bus comes in 10 minutes.",
                "I believe.",
                };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 35);
        }
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 35 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("ViarWink");
    }
}
