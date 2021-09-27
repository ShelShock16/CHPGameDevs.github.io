using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Dialogue;

public class ViarLvl1 : MonoBehaviour
{
    public bool talked = false;
    public int numScene;
    public GameObject Player;
    public Transform transform;
    public float time = 0;
    public string LockedLvl = "LockedLvl";
    public int LckLvlStatus = 0;
    

    void Update()
    {
        if (talked && !DialogueTrigger.dialogueActive)
        {
            time += Time.deltaTime;
            transform.Translate(0, 0.025f, 0);
        }
        if (time > 2)
        {
            PlayerPrefs.SetInt(LockedLvl, LckLvlStatus);
            SceneManager.LoadScene(numScene);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int l = PlayerPrefs.GetInt("Lang");

        string[] names =
        {
            "Viar",
            "Luciel",
            "Luciel",
            "Viar",
            "Luciel",
            "Luciel",
            "Viar",
            "Viar",
            "Viar",
            "Luciel",
            "EO",
            "Viar",
            "Masinha",
            "Masinha",
            "Viar",
            "Masinha",
            "Viar",
            "Luciel"
        };


        if (l == 1)
        {
            string[] sentences =
        {
            "¡Hola!",
            "Profe.",
            "No vas creer lo que acabamos de ver.",
            "¿El ejército de perros y hamsters?",
            "¿Qué?",
            "Digo… Sí, eso.",
            "Ah, sí, si no me equivoco tienen algo que ver con el examen de matemática.",
            "Hace unas horas entraron los de 3BA al salón de eventos, y salieron esos bichos.",
            "Supongo que muy bien no les fue.",
            "…",
            "Cómo llegaste acá en primer lugar?",
            "Ni siquiera les enseñaron a volar?",
            "¿SE PUEDE VOLAR?",
            "Entonces ¿Para qué necesito un ómnibus?¿O un auto?",
            "Para evitar a los hámsters voladores, obviamente.",
            "…",
            "Deberían entrar a la UTU, van a llegar tarde.",
            "¿Y si nos enseñas a volar antes?"
        };
            if (collision.gameObject.tag == "Player")
            {
                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                //FindObjectOfType<Dialogue>().SetDialogue(names, sentences);
                //FindObjectOfType<DialogueTrigger>().dialogueActive = !FindObjectOfType<DialogueTrigger>().dialogueActive;
                talked = true;
            }
        }


        if (l == 0)
        {
            string[] sentences =
        {
            "Hello!",
            "Prof.",
            "You won't believe what we just saw.",
            "The army of dogs and hamsters?",
            "What?",
            "I mean… Yes, that.",
            "Oh yeah, if I'm not mistaken they have something to do with the math test.",
            "A few hours ago, those from 3BA entered the events room, and those bugs came out.",
            "I guess they didn't do very well.",
            "…",
            "How did you get here in the first place?",
            "Didn't they even teach you how to fly?",
            "IT'S POSSIBLE TO FLY?",
            "So why do I need a bus? Or a car?",
            "To avoid flying hamsters, obviously.",
            "…",
            "You should enter the UTU, you are going to be late.",
            "And if you teach us to fly before ? "
        };
            if (collision.gameObject.tag == "Player")
            {
                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                //FindObjectOfType<Dialogue>().SetDialogue(names, sentences);
                //FindObjectOfType<DialogueTrigger>().dialogueActive = !FindObjectOfType<DialogueTrigger>().dialogueActive;
                talked = true;
            }
        }


    }
}
