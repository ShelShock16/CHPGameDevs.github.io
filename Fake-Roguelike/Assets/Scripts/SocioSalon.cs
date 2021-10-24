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
                "�CHICOS!",
                "Los noto desacatados.",
                "Profe, no hay tiempo.",
                "Necesitamos salvar tu materia.",
                "�Ah! �Trajeron el escrito domiciliario que mand� la semana pasada?",
                "(�Qu� escrito?)",
                "(�Hab�a un escrito?)",
                "(Tengo una idea�)",
                "�Obvio! Ac� est�.",
                "�Excelente! Pero no s� si me va a dar el tiempo para corregirlo.",
                "Y tengo que cerrar los promedios ma�ana.",
                "�Est�n seguros de que entendieron los temas?",
                "S�.",
                "Obvio.",
                "Por supuesto.",
                "Seguro.",
                "Est� bien, les creo.",
                "�Pasan con 12! �Felicitaciones!",
                "(�Fue as� de f�cil?)",
                "(Brun, �qu� le diste a la profe?)",
                "(Un boleto de hace tres semanas.)",
                "JAJAJAJAJAJAJAJA.",
                "LOL.",
                "�De qu� se r�en?",
                "Nada, profe, un chiste interno.",
                "Em, s�, eso."
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
                //TRADUCIR ESTO A INGL�S
                "�CHICOS!",
                "Los noto desacatados.",
                "Profe, no hay tiempo.",
                "Necesitamos salvar tu materia.",
                "�Ah! �Trajeron el escrito domiciliario que mand� la semana pasada?",
                "(�Qu� escrito?)",
                "(�Hab�a un escrito?)",
                "(Tengo una idea�)",
                "�Obvio! Ac� est�.",
                "�Excelente! Pero no s� si me va a dar el tiempo para corregirlo.",
                "Y tengo que cerrar los promedios ma�ana.",
                "�Est�n seguros de que entendieron los temas?",
                "S�.",
                "Obvio.",
                "Por supuesto.",
                "Seguro.",
                "Est� bien, les creo.",
                "�Pasan con 12! �Felicitaciones!",
                "(�Fue as� de f�cil?)",
                "(Brun, �qu� le diste a la profe?)",
                "(Un boleto de hace tres semanas.)",
                "JAJAJAJAJAJAJAJA.",
                "LOL.",
                "�De qu� se r�en?",
                "Nada, profe, un chiste interno.",
                "Em, s�, eso."
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
