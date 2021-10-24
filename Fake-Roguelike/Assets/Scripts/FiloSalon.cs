using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;
using UnityEngine.SceneManagement;

public class FiloSalon : MonoBehaviour
{
    public void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("Progress"));
        //A PENAS ENTRAS SE LEE ESTO
        if (PlayerPrefs.GetInt("Progress") == 2)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Ticholo",
            "Luciel",
            "Ticholo",
            "EO",
            "EO",
            "Brun",
            "Ticholo",
            "Ticholo",
            "Ticholo",
            "Masinha",
            "Brun",
            "EO",
            "Luciel",
            "Luciel",
            "Ticholo",
            "Ticholo",
            "Brun",
            "Brun",
            "EO"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "Buenas noches.",
                "Profe, llegamos solo un minuto tarde.",
                "�Un minuto? �Llegaron 8 meses tarde!",
                "Ah.",
                "S�, eso.",
                "Viar nos dijo que nos pondr�as una prueba, como un examen para aprobar.",
                "Te�ricamente pueden aprobar, pero �Creen saber lo necesario para hacerlo?",
                "No van a hacer un escrito sin haber estudiado antes.",
                "�Estudiaron?",
                "(No.)",
                "(Nada.)",
                "(Cero.)",
                "T�cnicamente no, pero �Qu� es estudiar? Ayer vimos un v�deo de filosof�a.",
                "�Eso cuenta?",
                "No voy a permitir que hagan un escrito as�.",
                "Es una falta de respeto a su docente.",
                "Honestamente no s� qu� esper�bamos de todas formas.",
                "�Probamos con la siguiente materia?",
                "La re baja, pero s�."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 3);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR TODO ESTO A INGL�S
                "Buenas noches.",
                "Profe, llegamos solo un minuto tarde.",
                "�Un minuto? �Llegaron 8 meses tarde!",
                "Ah.",
                "S�, eso.",
                "Viar nos dijo que nos pondr�as una prueba, como un examen para aprobar.",
                "Te�ricamente pueden aprobar, pero �Creen saber lo necesario para hacerlo?",
                "No van a hacer un escrito sin haber estudiado antes.",
                "�Estudiaron?",
                "(No.)",
                "(Nada.)",
                "(Cero.)",
                "T�cnicamente no, pero �Qu� es estudiar? Ayer vimos un v�deo de filosof�a.",
                "�Eso cuenta?",
                "No voy a permitir que hagan un escrito as�.",
                "Es una falta de respeto a su docente.",
                "Honestamente no s� qu� esper�bamos de todas formas.",
                "�Probamos con la siguiente materia?",
                "La re baja, pero s�."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 3);
            }
        }

        //DESPU�S DEL VAC�O SE VE ESTO

        if (PlayerPrefs.GetInt("Progress") == 4)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Ticholo",
            "Masinha",
            "Masinha",
            "Ticholo",
            "Ticholo",
            "EO",
            "Ticholo",
            "Ticholo",
            "Ticholo",
            "Ticholo",
            "Brun",
            "Ticholo"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "�Qu� hacen ac� de vuelta? �No les dije que no pod�an dar la prueba?",
                "PROFE, EL MUNDO AFUERA NO EXISTE.",
                "CREO QUE ES EL FIN DEL MUNDO.",
                "Supongo que se sienten as�, despu�s de la conversaci�n de hace unos minutos.",
                "Pero perder una materia no es el fin del mundo.",
                "Literalmente no hay nada fuera de este sal�n.",
                "�Sienten que esta materia es tan importante?",
                "Supongo que est�n usando una buena met�fora.",
                "Pero aprobar mi examen va a ser dif�cil.",
                "�Quieren intentarlo de todas formas?",
                "S�.",
                "En ese caso, les deseo suerte."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 5);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR ESTO A INLG�S
                "�Qu� hacen ac� de vuelta? �No les dije que no pod�an dar la prueba?",
                "PROFE, EL MUNDO AFUERA NO EXISTE.",
                "CREO QUE ES EL FIN DEL MUNDO.",
                "Supongo que se sienten as�, despu�s de la conversaci�n de hace unos minutos.",
                "Pero perder una materia no es el fin del mundo.",
                "Literalmente no hay nada fuera de este sal�n.",
                "�Sienten que esta materia es tan importante?",
                "Supongo que est�n usando una buena met�fora.",
                "Pero aprobar mi examen va a ser dif�cil.",
                "�Quieren intentarlo de todas formas?",
                "S�.",
                "En ese caso, les deseo suerte."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 5);
            }
        }

        //DESPU�S DEL JUEGO SE VE ESTO

        if (PlayerPrefs.GetInt("Progress") == 6)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Brun",
            "EO",
            "EO",
            "Masinha",
            "Luciel",
            "Ticholo",
            "Luciel",
            "Luciel",
            "Luciel",
            "Luciel",
            "EO",
            "Ticholo",
            "Luciel",
            "Ticholo",
            "Ticholo",
            "Masinha",
            "Brun",
            "EO",
            "Ticholo",
            "Ticholo",
            "Luciel",
            "Masinha"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "Fua.",
                "Creo que aprobamos exclusivamente por ver ese video.",
                "Aunque no recordaba que el mito de la caverna fuera tan�",
                "�Simple?",
                "Creo que hay algo raro ac�.",
                "�Raro? �C�mo?",
                "Como si la realidad fuera una serie de objetivos lineales.",
                "Todo es demasiado conveniente.",
                "Como estos asientos, �No hab�a como treinta personas en el grupo?",
                "Parece que la realidad se amoldara a nuestra conveniencia.",
                "Como un videju�",
                "�No est�n llegando tarde a la pr�xima materia?",
                "Es verdad, seguro todo son ideas m�as.",
                "No, de hecho, el mundo es un videojuego dise�ado por ustedes mismos.",
                "En un plano superior, mucho m�s complejo que el nuestro.",
                "JAJAJAJAJAJA",
                "xd",
                "Profe, �qu� fumaste?",
                "�",
                "En fin, suerte con su pr�xima materia.",
                "�Gracias! Creo que en serio podemos aprobar todo.",
                "Seh, vamos."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR ESTO A INLG�S
                "Fua.",
                "Creo que aprobamos exclusivamente por ver ese video.",
                "Aunque no recordaba que el mito de la caverna fuera tan�",
                "�Simple?",
                "Creo que hay algo raro ac�.",
                "�Raro? �C�mo?",
                "Como si la realidad fuera una serie de objetivos lineales.",
                "Todo es demasiado conveniente.",
                "Como estos asientos, �No hab�a como treinta personas en el grupo?",
                "Parece que la realidad se amoldara a nuestra conveniencia.",
                "Como un videju�",
                "�No est�n llegando tarde a la pr�xima materia?",
                "Es verdad, seguro todo son ideas m�as.",
                "No, de hecho, el mundo es un videojuego dise�ado por ustedes mismos.",
                "En un plano superior, mucho m�s complejo que el nuestro.",
                "JAJAJAJAJAJA",
                "xd",
                "Profe, �qu� fumaste?",
                "�",
                "En fin, suerte con su pr�xima materia.",
                "�Gracias! Creo que en serio podemos aprobar todo.",
                "Seh, vamos."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
            }
        }
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 3 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("VacioFilo");
        if (PlayerPrefs.GetInt("Progress") == 5 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("IcyTower");
        if (PlayerPrefs.GetInt("Progress") == 6 && DialogueTrigger.dialogueActive == false)
        {
            PlayerPrefs.SetInt("Progress", 7);
            SceneManager.LoadScene("LevelSelector");
        }
    }
}
