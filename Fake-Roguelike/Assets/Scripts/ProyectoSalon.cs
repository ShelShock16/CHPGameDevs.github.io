using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;
using UnityEngine.SceneManagement;

public class ProyectoSalon : MonoBehaviour
{
    public void Start()
    {
        //PRIMERA VEZ QUE ENTRAS

        if (PlayerPrefs.GetInt("Progress") == 21)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Viar",
            "Brun",
            "Viar",
            "Viar",
            "Viar",
            "Brun",
            "Brun",
            "Viar",
            "EO",
            "Viar",
            "Viar",
            "Masinha",
            "Masinha",
            "EO",
            "Viar",
            "Viar",
            "Viar",
            "Luciel",
            "Luciel",
            "Brun",
            "Luciel",
            "EO",
            "Masinha",
            "Masinha",
            "Masinha",
            "EO",
            "Masinha",
            "Masinha",
            "EO",
            "Masinha",
            "Luciel",
            "EO",
            "Brun",
            "Viar"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "Bienvenidos�",
                "�Viar? �Qu� haces ac� de vuelta?",
                "�Se olvidaron de la materia m�s importante�? ",
                "Les dej� pasar ADA as� nom�s, pero no van a aprobar esta clase sin el proyecto perfecto.",
                "As� que vamos a ver, �qu� hicieron?",
                "Bueno� Escribimos una historia que se puede recorrer mediante minijuegos basados en la UTU.",
                "Todo est� hecho con Unity y documentado en este PDF.",
                "�Puedo verlo?",
                "Obvio.",
                "Esto ser�a un�",
                "7. �Nos vemos el a�o que viene entonces!",
                "�QU�?",
                "�No hicimos todo?",
                "Fua, creo que falta Negocios Digitales.",
                "No, Negocios Digitales abandon� el curso un d�a despu�s que ustedes, en marzo.",
                "Pero no tienen el Ciclo de Vida del proyecto.",
                "No puedo aprobarlos as�.",
                "�Ah! �Eso lo hicimos la primera clase!",
                "�Estoy seguro de que tengo el documento en mi casa!",
                "�A cu�nto queda tu casa?",
                "40 minutos�",
                "�Vamos a perder el a�o por una tarea que olvidamos traer?",
                "Ok, tengo una idea.",
                "Pero es bastante ilegal.",
                "Sigo sin tener la licencia de conducir, pero mi auto est� estacionado en frente.",
                "�Eso no es extremadamente conveniente?",
                "Bueno� Supongo...",
                "Como dec�a, podemos ir y volver a tiempo si nos apuramos.",
                "Messirve.",
                "Ah, otra cosa, creo que no tengo gasolina.",
                "No te preocupes, intuyo que va a haber un mont�n de gasolina perfectamente posicionada en el camino a mi casa.",
                "...",
                "M�s te vale.",
                "Los espero ac� entonces."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 22);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR ESTO A INGL�S
                "Welcome�",
                "Viar? What are you doing here again?",
                "Did you forget about the most important subject�?  ",
                "I let you pass ADA easily, but you won�t pass this class without the perfect project.",
                "So, let�s see,  what did you do?",
                "Well� We wrote a story in which you could advance by playing videogames based on the UTU..",
                "Everything is made in Unity and documented in this PDF.",
                "Can I see it?",
                "Of course.",
                "This would be a�",
                "7. See you next year!",
                "WHAT?",
                "Didn�t we do everything?",
                "Oh� I think we are missing Digital Business.",
                "No, Digital Business teacher abandoned the course one day after y�all, in march.",
                "But you don�t have the �Project Life Cycle�.",
                " I can�t approve you like that.",
                "Oh! We did that the first class!",
                "I�m pretty sure I have the document at home!",
                "How far is your home?",
                "40 minutes�",
                "Are we gonna lose the year for a homework that we forgot to bring with us?",
                "Ok, I have an idea.",
                "But it�s quite illegal.",
                " I don�t have my driving license yet, but my car is parked in the opposite street.",
                "Isn�t that extremely convenient?",
                "Well� I suppose...",
                "As I was saying, we can go and come back in time if we hurry up.",
                "Noice.",
                "Oh, another thing, I think I don�t have gasoline.",
                "Don�t worry, I intuit there will be a lot of gasoline gallons perfectly located on the way home.",
                "...",
                "You better.",
                "I�ll wait for you here then."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 22);
            }
        }

        //DESPU�S DEL JUEGO

        if (PlayerPrefs.GetInt("Progress") == 23)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Masinha",
            "Masinha",
            "Masinha",
            "Viar",
            "Viar",
            "Viar",
            "Luciel",
            "Brun",
            "EO",
            "Viar",
            "Luciel",
            "Luciel",
            "Viar",
            "Viar",
            "Lapicera",
            "Luciel",
            "EO"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "FUA.",
                "Casi chocamos como cinco veces.",
                "Pero ac� est�, el Ciclo de Vida del proyecto.",
                "A ver�",
                "No voy a mentir, est� casi todo mal, pero lo voy a tomar como entregado.",
                "Pasan con 8.",
                "YAY.",
                "Ya est�, nunca m�s estudio inform�tica, voy a hacer bellas artes.",
                "�Bellas artes? Yo voy a vender hamburguesas o algo por un a�o y despu�s veo.",
                "�No se est�n olvidando de algo�?",
                "Queda un sal�n m�s, pero dudo que sea muy dif�cil.",
                "�No es el de Negocios Digitales? Creo que no deber�a haber nadie en ese sal�n.",
                "Vayan a ver entonces, mi parte ya est� lista.",
                "Ah y� Tomen esto, les va a servir.",
                "Lapicera",
                "�Un mont�n de lapiceras bic? �Para qu� vamos a usar esto?",
                "Seguro solo est� jodiendo, vamos."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 23);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR A INGL�S
                "Holy s...",
                "We almost crashed like five times.",
                "But here it is, the �Project Life Cycle�.",
                "Let me see�",
                "I won�t lie, this is almost everything wrong, but I will count it as delivered.",
                "You approve with 8.",
                "YAY.",
                "That�s it, I won�t study ICT anymore, I'm going to dedicate myself to the fine arts .",
                "Fine arts? I�ll sell hamburguers or something for a year and then I�ll see what I do with my life.",
                "Aren�t you forgetting something�?",
                "There�s one room left, but I doubt it will be hard.",
                "Isn�t it Digital Business? I think there will be no one in there.",
                "You should go and check then, my part is already done..",
                "Oh and� take this, you�ll need it.",
                "Pen",
                "A lot of bic pens? What do we need this for?",
                "I�m pretty sure he�s just kidding, let�s go."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 23);
            }
        }
    }



    //UPDATE

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 22 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("Race2DGame");
        if (PlayerPrefs.GetInt("Progress") == 23 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("LevelSelector3");
    }
}
