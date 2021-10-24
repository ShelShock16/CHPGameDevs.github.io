using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharImg : MonoBehaviour
{
    public GameObject charImg, player;

    void Update()
    {
        if (!DialogueTrigger.dialogueActive)
        {
            charImg.active = false;
            player.active = true;
        }
    }
}
