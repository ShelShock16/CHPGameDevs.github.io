using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Dialogue;
using UnityEngine.SceneManagement;

public class NarrativaSalon : MonoBehaviour
{
    public SpriteRenderer black;
    public Sprite es, en;
    public float time = 0;
    public void Start()
    {
        black.color = new Color(255, 255, 255, 0);

        int l = PlayerPrefs.GetInt("Lang");

        string[] names =
        {
            "Mari�o",
            "Luciel",
            "Mari�o",
            "Luciel",
            "Luciel",
            "Mari�o",
            "Mari�o",
            "Brun",
            "Mari�o"
        };


        if (l == 1)
        {
            black.sprite = es;

            string[] sentences =
            {
                "�Hola chicos! �Llegan 32 semanas tarde!",
                "�Perd�n! �Est�bamos tir�ndole l�pices a hamsters voladores!",
                "Entendible, despertarse a esta hora deber�a ser un pecado de todas formas.",
                "Y� �Qu� te parece la idea hasta ahora?",
                "�Te gust� la parte de filosof�a? Creo que el detalle existencial aporta un mont�n.",
                "S�, es brillante.",
                "�Quiz� podr�an profundizar en eso m�s tarde? El comentario meta aporta un mont�n a la comedia.",
                "De hecho pens�bamos hacer justo eso.",
                "Ya vieron c�mo van a hacer el�-"
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 19);
        }


        if (l == 0)
        {
            black.sprite = en;

            string[] sentences =
            {
                //TRADUCIR ESTO A INGL�S
                "�Hola chicos! �Llegan 32 semanas tarde!",
                "�Perd�n! �Est�bamos tir�ndole l�pices a hamsters voladores!",
                "Entendible, despertarse a esta hora deber�a ser un pecado de todas formas.",
                "Y� �Qu� te parece la idea hasta ahora?",
                "�Te gust� la parte de filosof�a? Creo que el detalle existencial aporta un mont�n.",
                "S�, es brillante.",
                "�Quiz� podr�an profundizar en eso m�s tarde? El comentario meta aporta un mont�n a la comedia.",
                "De hecho pens�bamos hacer justo eso.",
                "Ya vieron c�mo van a hacer el�-"
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 19);
        }
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 19 && DialogueTrigger.dialogueActive == false)
        {
            time += Time.deltaTime;
            black.color = new Color(255,255,255,255);
            if (time > 3)
            {
                black.color = new Color(255, 255, 255, 0);
                PlayerPrefs.SetInt("Progress", 20);
            }
        }

        if (PlayerPrefs.GetInt("Progress") == 20 && DialogueTrigger.dialogueActive == false)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "Masinha",
            "Masinha",
            "Mari�o",
            "Mari�o",
            "Mari�o",
            "Mari�o",
            "Luciel",
            "Luciel",
            "EO",
            "Mari�o",
            "Mari�o"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "lol",
                "No es mala, despu�s agregamos eso.",
                "Bueno, se est� haciendo tarde�",
                "Pero no se estresen, tienen el a�o aprobado pr�cticamente, van bien.",
                "Ah, una cosa m�s.",
                "Creo que un Shapeshifter aportar�a un mont�n a la historia, para evitar que se sienta muy predecible todo.",
                "�Seguro? Siento que ser�a demasiado complicado.",
                "Pero s�, podemos intentar implementar algo as�.",
                "�Nos falta algo m�s?",
                "No, nada m�s.",
                "Ahora si me lo permiten voy a tomar una muy necesaria powernap antes de tener al pr�ximo grupo."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 21);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR A INGL�S
                "lol",
                "No es mala, despu�s agregamos eso.",
                "Bueno, se est� haciendo tarde�",
                "Pero no se estresen, tienen el a�o aprobado pr�cticamente, van bien.",
                "Ah, una cosa m�s.",
                "Creo que un Shapeshifter aportar�a un mont�n a la historia, para evitar que se sienta muy predecible todo.",
                "�Seguro? Siento que ser�a demasiado complicado.",
                "Pero s�, podemos intentar implementar algo as�.",
                "�Nos falta algo m�s?",
                "No, nada m�s.",
                "Ahora si me lo permiten voy a tomar una muy necesaria powernap antes de tener al pr�ximo grupo."
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 21);
            }
        }

        if (PlayerPrefs.GetInt("Progress") == 21 && DialogueTrigger.dialogueActive == false) SceneManager.LoadScene("LevelSelector3");
    }
}
