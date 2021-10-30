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
                "¿Un minuto? ¡Llegaron 8 meses tarde!",
                "Ah.",
                "Sí, eso.",
                "Viar nos dijo que nos pondrías una prueba, como un examen para aprobar.",
                "Teóricamente pueden aprobar, pero ¿Creen saber lo necesario para hacerlo?",
                "No van a hacer un escrito sin haber estudiado antes.",
                "¿Estudiaron?",
                "(No.)",
                "(Nada.)",
                "(Cero.)",
                "Técnicamente no, pero ¿Qué es estudiar? Ayer vimos un vídeo de filosofía.",
                "¿Eso cuenta?",
                "No voy a permitir que hagan un escrito así.",
                "Es una falta de respeto a su docente.",
                "Honestamente no sé qué esperábamos de todas formas.",
                "¿Probamos con la siguiente materia?",
                "La re baja, pero sí."
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
                //TRADUCIR TODO ESTO A INGLÉS
                "Good night.",
                "Prof, we arrived just one minute late.",
                "One minute? You arrived eight months late!",
                "Oh.",
                "Yeah, that.",
                "Viar told us you would give us an exam, like an exam to approve.",
                "Theoretically you can approve, but, do you consider you have what it takes to do it?",
                "There’s no way you can take the exam without studying .",
                "Did you study?",
                "(No.)",
                "(Nothing.)",
                "(Zero.)",
                "Technically no, but, what is studying? Yesterday we saw a Philosophy video.",
                "Does it count?",
                "I won’t allow you to take the exam like this.",
                "That’s a lack of respect for your teacher.",
                "Honestly, I don’t know what we were expecting.",
                "Should we try the next subject?",
                "It’s a shame but yes."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 3);
            }
        }

        //DESPUÉS DEL VACÍO SE VE ESTO

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
                "¿Qué hacen acá de vuelta? ¿No les dije que no podían dar la prueba?",
                "PROFE, EL MUNDO AFUERA NO EXISTE.",
                "CREO QUE ES EL FIN DEL MUNDO.",
                "Supongo que se sienten así, después de la conversación de hace unos minutos.",
                "Pero perder una materia no es el fin del mundo.",
                "Literalmente no hay nada fuera de este salón.",
                "¿Sienten que esta materia es tan importante?",
                "Supongo que están usando una buena metáfora.",
                "Pero aprobar mi examen va a ser difícil.",
                "¿Quieren intentarlo de todas formas?",
                "Sí.",
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
                //TRADUCIR ESTO A INLGÉS
                "What are you doing here again? Didn’t I tell you that you weren’t allowed to take the exam?",
                "PROF, THE WORLD OUTSIDE DOESN’T EXIST.",
                "I THINK IT’S THE END OF THE WORLD.",
                "I suppose you feel like it, after the conversation we had a few minutes ago.",
                "But disapproving a subject is not the end of the world.",
                "Literally, there’s nothing outside this room.",
                "Do you feel like this subject is that important?",
                "I suppose you are using a great metaphor.",
                "But approving my exam won’t be that easy.",
                "Would you want to do the exam anyways?",
                "Yup.",
                "In that case, I wish you the best of lucks."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 5);
            }
        }

        //DESPUÉS DEL JUEGO SE VE ESTO

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
                "Aunque no recordaba que el mito de la caverna fuera tan…",
                "¿Simple?",
                "Creo que hay algo raro acá.",
                "¿Raro? ¿Cómo?",
                "Como si la realidad fuera una serie de objetivos lineales.",
                "Todo es demasiado conveniente.",
                "Como estos asientos, ¿No había como treinta personas en el grupo?",
                "Parece que la realidad se amoldara a nuestra conveniencia.",
                "Como un videju–",
                "¿No están llegando tarde a la próxima materia?",
                "Es verdad, seguro todo son ideas mías.",
                "No, de hecho, el mundo es un videojuego diseñado por ustedes mismos.",
                "En un plano superior, mucho más complejo que el nuestro.",
                "JAJAJAJAJAJA",
                "xd",
                "Profe, ¿qué fumaste?",
                "…",
                "En fin, suerte con su próxima materia.",
                "¡Gracias! Creo que en serio podemos aprobar todo.",
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
                //TRADUCIR ESTO A INLGÉS
                "Holy….",
                "I think we only approved because of that video we saw.",
                "But I don’t remember the myth of the cave being so…",
                "Simple?",
                "I believe there’s something strange here.",
                "Strange? How?",
                "Like if the reality was a chain of linear events.",
                "Everything is too convenient.",
                "Like these seats, there weren’t like thirty people in this group?",
                "It feels like reality shapes itself to our convenience.",
                "Like a videog-",
                "Aren’t you late for your next subject?",
                "You’re right, I’m sure that’s only my thoughts.",
                "No, in fact, the world is a videogame designed by yourselves.",
                "In a superior level, much more complicated than ours.",
                "HAHAHAHAHA",
                "xd",
                "Prof, what did you smoke?",
                "…",
                "Anyways, good luck on your next subject.",
                "Thanks! I think we really can approve everything.",
                "Yeah, let’s go."
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
