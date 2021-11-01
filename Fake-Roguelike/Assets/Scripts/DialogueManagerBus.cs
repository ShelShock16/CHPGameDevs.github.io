using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManagerBus : MonoBehaviour
{
    public SpriteRenderer characterPortrait;
    public string profe;
    public Sprite lucielPortrait, eoPortrait, masiPortrait, brunPortrait, profePortrait,choferPortrait;
    public Text nameText, dialogueText;
    public bool end = false;
    private static Queue<string> sentences;
    private static Queue<string> names;
    public AudioSource voice;
    void Start()
    {
        sentences = new Queue<string>();
        names = new Queue<string>();
    }

    public void StartDialogue()
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
        }
        else if (name == "EO")
        {
            characterPortrait.sprite = eoPortrait;
        }
        else if (name == "Masinha")
        {
            characterPortrait.sprite = masiPortrait;
        }
        else if (name == "Brun")
        {
            characterPortrait.sprite = brunPortrait;
        }
        else if (name == profe)
        {
            characterPortrait.sprite = profePortrait;
        }
        else if (name == "Chofer")
        {
            characterPortrait.sprite = choferPortrait;
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
        voice.Play();
        foreach (char letter in name.ToCharArray())
        {
            nameText.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.03f);
        }
        voice.Stop();
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation.");
        voice.Stop();
        end = true;
    }

}
