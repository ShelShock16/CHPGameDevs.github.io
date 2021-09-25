using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Dialogue;

public class NextLevel : MonoBehaviour
{
    public bool talked = false;
    public int numScene;
    public GameObject Player;
    public Transform transform;
    public float time = 0;

    void Update()
    {
        if (talked && !DialogueTrigger.dialogueActive)
        {
            time += Time.deltaTime;
            transform.Translate(0, 0.025f, 0);
            if (time > 1)
            {
                SceneManager.LoadScene(numScene);
                PlayerPrefs.SetInt("LockedLvl2", 0);
            }
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
            "El ejército de perros y hamsters?",
            "Qué?",
            "Digo… Sí, eso.",
            "Ah, sí, si no me equivoco tienen algo que ver con el examen de matemática.",
            "Hace unas horas entraron los de 3BA al salón de eventos, y salieron esos bichos.",
            "Supongo que muy bien no les fue.",
            "…",
            "Cómo llegaste acá en primer lugar?",
            "Ni siquiera les enseñaron a volar?",
            "SE PUEDE VOLAR?",
            "Entonces para qué necesito un ómnibus? O un auto?",
            "Para evitar a los hámsters voladores, obviamente.",
            "…",
            "Deberían entrar a la UTU, van a llegar tarde.",
            "Y si nos enseñas a volar antes?"
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
