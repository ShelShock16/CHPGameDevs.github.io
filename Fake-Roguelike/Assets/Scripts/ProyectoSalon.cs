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
                "Bienvenidos…",
                "¿Viar? ¿Qué haces acá de vuelta?",
                "¿Se olvidaron de la materia más importante…? ",
                "Les dejé pasar ADA así nomás, pero no van a aprobar esta clase sin el proyecto perfecto.",
                "Así que vamos a ver, ¿qué hicieron?",
                "Bueno… Escribimos una historia que se puede recorrer mediante minijuegos basados en la UTU.",
                "Todo está hecho con Unity y documentado en este PDF.",
                "¿Puedo verlo?",
                "Obvio.",
                "Esto sería un…",
                "7. ¡Nos vemos el año que viene entonces!",
                "¿QUÉ?",
                "¿No hicimos todo?",
                "Fua, creo que falta Negocios Digitales.",
                "No, Negocios Digitales abandonó el curso un día después que ustedes, en marzo.",
                "Pero no tienen el Ciclo de Vida del proyecto.",
                "No puedo aprobarlos así.",
                "¡Ah! ¡Eso lo hicimos la primera clase!",
                "¡Estoy seguro de que tengo el documento en mi casa!",
                "¿A cuánto queda tu casa?",
                "40 minutos…",
                "¿Vamos a perder el año por una tarea que olvidamos traer?",
                "Ok, tengo una idea.",
                "Pero es bastante ilegal.",
                "Sigo sin tener la licencia de conducir, pero mi auto está estacionado en frente.",
                "¿Eso no es extremadamente conveniente?",
                "Bueno… Supongo...",
                "Como decía, podemos ir y volver a tiempo si nos apuramos.",
                "Messirve.",
                "Ah, otra cosa, creo que no tengo gasolina.",
                "No te preocupes, intuyo que va a haber un montón de gasolina perfectamente posicionada en el camino a mi casa.",
                "...",
                "Más te vale.",
                "Los espero acá entonces."
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
                //TRADUCIR ESTO A INGLÉS
                "Bienvenidos…",
                "¿Viar? ¿Qué haces acá de vuelta?",
                "¿Se olvidaron de la materia más importante…? ",
                "Les dejé pasar ADA así nomás, pero no van a aprobar esta clase sin el proyecto perfecto.",
                "Así que vamos a ver, ¿qué hicieron?",
                "Bueno… Escribimos una historia que se puede recorrer mediante minijuegos basados en la UTU.",
                "Todo está hecho con Unity y documentado en este PDF.",
                "¿Puedo verlo?",
                "Obvio.",
                "Esto sería un…",
                "7. ¡Nos vemos el año que viene entonces!",
                "¿QUÉ?",
                "¿No hicimos todo?",
                "Fua, creo que falta Negocios Digitales.",
                "No, Negocios Digitales abandonó el curso un día después que ustedes, en marzo.",
                "Pero no tienen el Ciclo de Vida del proyecto.",
                "No puedo aprobarlos así.",
                "¡Ah! ¡Eso lo hicimos la primera clase!",
                "¡Estoy seguro de que tengo el documento en mi casa!",
                "¿A cuánto queda tu casa?",
                "40 minutos…",
                "¿Vamos a perder el año por una tarea que olvidamos traer?",
                "Ok, tengo una idea.",
                "Pero es bastante ilegal.",
                "Sigo sin tener la licencia de conducir, pero mi auto está estacionado en frente.",
                "¿Eso no es extremadamente conveniente?",
                "Bueno… Supongo...",
                "Como decía, podemos ir y volver a tiempo si nos apuramos.",
                "Messirve.",
                "Ah, otra cosa, creo que no tengo gasolina.",
                "No te preocupes, intuyo que va a haber un montón de gasolina perfectamente posicionada en el camino a mi casa.",
                "...",
                "Más te vale.",
                "Los espero acá entonces."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 22);
            }
        }

        //DESPUÉS DEL JUEGO

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
                "Pero acá está, el Ciclo de Vida del proyecto.",
                "A ver…",
                "No voy a mentir, está casi todo mal, pero lo voy a tomar como entregado.",
                "Pasan con 8.",
                "YAY.",
                "Ya está, nunca más estudio informática, voy a hacer bellas artes.",
                "¿Bellas artes? Yo voy a vender hamburguesas o algo por un año y después veo.",
                "¿No se están olvidando de algo…?",
                "Queda un salón más, pero dudo que sea muy difícil.",
                "¿No es el de Negocios Digitales? Creo que no debería haber nadie en ese salón.",
                "Vayan a ver entonces, mi parte ya está lista.",
                "Ah y… Tomen esto, les va a servir.",
                "Lapicera",
                "¿Un montón de lapiceras bic? ¿Para qué vamos a usar esto?",
                "Seguro solo está jodiendo, vamos."
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
                //TRADUCIR A INGLÉS
                "FUA.",
                "Casi chocamos como cinco veces.",
                "Pero acá está, el Ciclo de Vida del proyecto.",
                "A ver…",
                "No voy a mentir, está casi todo mal, pero lo voy a tomar como entregado.",
                "Pasan con 8.",
                "YAY.",
                "Ya está, nunca más estudio informática, voy a hacer bellas artes.",
                "¿Bellas artes? Yo voy a vender hamburguesas o algo por un año y después veo.",
                "¿No se están olvidando de algo…?",
                "Queda un salón más, pero dudo que sea muy difícil.",
                "¿No es el de Negocios Digitales? Creo que no debería haber nadie en ese salón.",
                "Vayan a ver entonces, mi parte ya está lista.",
                "Ah y… Tomen esto, les va a servir.",
                "Lapicera",
                "¿Un montón de lapiceras bic? ¿Para qué vamos a usar esto?",
                "Seguro solo está jodiendo, vamos."
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
