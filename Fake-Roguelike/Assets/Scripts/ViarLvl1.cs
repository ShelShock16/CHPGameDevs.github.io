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

        string[] sentences =
        {
            "Hola!",
            "Profe.",
            "No vas creer lo que acabamos de ver.",
            "El ej�rcito de perros y hamsters?",
            "Qu�?",
            "Digo� S�, eso.",
            "Ah, s�, si no me equivoco tienen algo que ver con el examen de matem�tica.",
            "Hace unas horas entraron los de 3BA al sal�n de eventos, y salieron esos bichos.",
            "Supongo que muy bien no les fue.",
            "�",
            "C�mo llegaste ac� en primer lugar?",
            "Ni siquiera les ense�aron a volar?",
            "SE PUEDE VOLAR?",
            "Entonces para qu� necesito un �mnibus? O un auto?",
            "Para evitar a los h�msters voladores, obviamente.",
            "�",
            "Deber�an entrar a la UTU, van a llegar tarde.",
            "Y si nos ense�as a volar antes?"
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