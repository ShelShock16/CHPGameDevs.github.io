using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public SpriteRenderer characterPortrait;
    public Sprite lucielPortrait, eoPortrait, masiPortrait, brunPortrait, viarPortrait;
    public Text nameText, dialogueText;
    public bool end = false;
    private static Queue<string> sentences;
    private static Queue<string> names;

    void Start()
    {
        sentences = new Queue<string>();
        names = new Queue<string>();
    }

    public void StartDialogue ()
    {
        end = false;
        Debug.Log("Starting conversation.");
        //nameText.text = dialogue.name;

        sentences.Clear();
        names.Clear();

        foreach (string sentence in Dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        foreach (string name in Dialogue.names)
        {
            names.Enqueue(name);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string name = names.Dequeue();
        string sentence = sentences.Dequeue();
        if (name == "Luciel")
        {
            characterPortrait.sprite = lucielPortrait;
        } else if (name == "EO")
        {
            characterPortrait.sprite = eoPortrait;
        } else if (name == "Masinha")
        {
            characterPortrait.sprite = masiPortrait;
        } else if (name == "Brun")
        {
            characterPortrait.sprite = brunPortrait;
        } else if (name == "Viar")
        {
            characterPortrait.sprite = viarPortrait;
        }
        Debug.Log(name);
        Debug.Log(sentence);
        nameText.text = name;
        dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence, name));
    }

   IEnumerator TypeSentence(string sentence, string name)
    {
        nameText.text = "";
        dialogueText.text = "";
        foreach (char letter in name.ToCharArray())
        {
            nameText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }

    }

    void EndDialogue()
    {
        Debug.Log("End of conversation.");
        end = true;
    }

}
