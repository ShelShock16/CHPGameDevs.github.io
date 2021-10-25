using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Dialogue : MonoBehaviour
{
    public int a = PlayerPrefs.GetInt("Progress");
    public static string[] names;

    [TextArea(3, 10)]//3 renglones 10 de ancho

    public static string[] sentences;//array de texto

    public void SetDialogue(string[] inNames, string[] inSentences)
    {
        names = inNames;
        sentences = inSentences;
    }


}