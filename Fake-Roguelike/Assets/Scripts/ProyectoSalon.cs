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
        }
    }



    //UPDATE

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 22 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("Race2DGame");
        if (PlayerPrefs.GetInt("Progress") == 23 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("LevelSelector3");
    }
}
