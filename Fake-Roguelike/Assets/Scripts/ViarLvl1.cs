using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Dialogue;

public class ViarLvl1 : MonoBehaviour
{
    public bool talked = false;
    public GameObject Player;
    public Transform transform;
    public float time = 0;
    public string LockedLvl = "LockedLvl";
    public int LckLvlStatus = 0;
    public GameObject Pl;
    public GameObject PlIMG;
    public Collider2D col;

    void Update()
    {
        if (talked && !DialogueTrigger.dialogueActive)
        {
            time += Time.deltaTime;
            transform.Translate(0, 0.025f, 0);
        }
        if (time > 2)
        {
            PlayerPrefs.SetInt("Progress", 1);
            SceneManager.LoadScene("To-LevelSelector");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
        PlIMG.SetActive(true);
        PlIMG.transform.transform.position=Pl.transform.position;
        Pl.SetActive(false);
        col.isTrigger=true;
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
            "�Hola!",
            "Profe.",
            "No vas creer lo que acabamos de ver.",
            "�El ej�rcito de perros y hamsters?",
            "�Qu�?",
            "Digo� S�, eso.",
            "Ah, s�, si no me equivoco tienen algo que ver con el examen de matem�tica.",
            "Hace unas horas entraron los de 3BA al sal�n de eventos, y salieron esos bichos.",
            "Supongo que muy bien no les fue.",
            "�",
            "�C�mo llegaste ac� en primer lugar?",
            "�Ni siquiera les ense�aron a volar?",
            "�SE PUEDE VOLAR?",
            "Entonces �Para qu� necesito un �mnibus?�O un auto?",
            "Para evitar a los h�msters voladores, obviamente.",
            "�",
            "Deber�an entrar a la UTU, van a llegar tarde.",
            "�Y si nos ense�as a volar antes?"
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
            "I mean� Yes, that.",
            "Oh yeah, if I'm not mistaken they have something to do with the math test.",
            "A few hours ago, those from 3BA entered the events room, and those creatures came out.",
            "I guess they didn't do very well.",
            "�",
            "First of all, how did you get here ?",
            "Didn't they even teach you how to fly?",
            "IS IT POSSIBLE TO FLY?",
            "So why do I need a bus? Or a car?",
            "To avoid flying hamsters, obviously.",
            "�",
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
}
