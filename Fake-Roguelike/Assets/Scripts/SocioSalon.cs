using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;
using UnityEngine.SceneManagement;

public class SocioSalon : MonoBehaviour
{
    public void Start()
    {
        int l = PlayerPrefs.GetInt("Lang");

        string[] names =
        {
            "Sheina",
            "Sheina",
            "Luciel",
            "Brun",
            "Sheina",
            "EO",
            "Masinha",
            "Brun",
            "Brun",
            "Sheina",
            "Sheina",
            "Sheina",
            "Brun",
            "Masinha",
            "Luciel",
            "EO",
            "Sheina",
            "Sheina",
            "Luciel",
            "Luciel",
            "Brun",
            "Masinha",
            "Luciel",
            "Sheina",
            "Brun",
            "EO"
            };


        if (l == 1)
        {
            string[] sentences =
                {
                "¡CHICOS!",
                "Los noto desacatados.",
                "Profe, no hay tiempo.",
                "Necesitamos salvar tu materia.",
                "¡Ah! ¿Trajeron el escrito domiciliario que mandé la semana pasada?",
                "(¿Qué escrito?)",
                "(¿Había un escrito?)",
                "(Tengo una idea…)",
                "¡Obvio! Acá está.",
                "¡Excelente! Pero no sé si me va a dar el tiempo para corregirlo.",
                "Y tengo que cerrar los promedios mañana.",
                "¿Están seguros de que entendieron los temas?",
                "Sí.",
                "Obvio.",
                "Por supuesto.",
                "Seguro.",
                "Está bien, les creo.",
                "¡Pasan con 12! ¡Felicitaciones!",
                "(¿Fue así de fácil?)",
                "(Brun, ¿qué le diste a la profe?)",
                "(Un boleto de hace tres semanas.)",
                "JAJAJAJAJAJAJAJA.",
                "LOL.",
                "¿De qué se ríen?",
                "Nada, profe, un chiste interno.",
                "Em, sí, eso."
                };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 15);
        }


        if (l == 0)
        {
            string[] sentences =
            {
                //TRADUCIR ESTO A INGLÉS
                "¡CHICOS!",
                "Los noto desacatados.",
                "Profe, no hay tiempo.",
                "Necesitamos salvar tu materia.",
                "¡Ah! ¿Trajeron el escrito domiciliario que mandé la semana pasada?",
                "(¿Qué escrito?)",
                "(¿Había un escrito?)",
                "(Tengo una idea…)",
                "¡Obvio! Acá está.",
                "¡Excelente! Pero no sé si me va a dar el tiempo para corregirlo.",
                "Y tengo que cerrar los promedios mañana.",
                "¿Están seguros de que entendieron los temas?",
                "Sí.",
                "Obvio.",
                "Por supuesto.",
                "Seguro.",
                "Está bien, les creo.",
                "¡Pasan con 12! ¡Felicitaciones!",
                "(¿Fue así de fácil?)",
                "(Brun, ¿qué le diste a la profe?)",
                "(Un boleto de hace tres semanas.)",
                "JAJAJAJAJAJAJAJA.",
                "LOL.",
                "¿De qué se ríen?",
                "Nada, profe, un chiste interno.",
                "Em, sí, eso."
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 15);
        }
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 15 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("LevelSelector2");
    }
}
