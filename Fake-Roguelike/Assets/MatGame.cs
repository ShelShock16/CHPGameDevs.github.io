using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatGame : MonoBehaviour
{
    public int battleTime = 0;
    public float time = 0;
    public GameObject redSmallVertical, redBigVertical, redSmallHorizontal, redBigHorizontal, redSingle;
    public AudioSource alert;
    void Start()
    {
        //ESTO ES UN DEBUG
        PlayerPrefs.SetFloat("MatSpeed", 0.6f);
        PlayerPrefs.SetInt("Progress", 24);
        
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("Progress") == 24 || PlayerPrefs.GetInt("Progress") == 25) StageOne();
        if (PlayerPrefs.GetInt("Progress") == 26) StageTwo();
    }


    void StageOne()
    {
        if (battleTime == 0)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "StageOne"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "StageOne"
            };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 25);
                battleTime++;
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR ESTO A INGLÉS
                "StageOne"
            };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 25);
                battleTime++;
            }
        }

        //STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 

        if (battleTime >= 1) time += Time.deltaTime;
        if (time > 2 && battleTime == 1) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, 0.39f, 0), gameObject.transform.rotation); battleTime++; alert.Play();}
        if (time > 2.5 && battleTime == 2) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, 0.26f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 3 && battleTime == 3) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, 0.13f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 3.5 && battleTime == 4) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, 0.00f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 4 && battleTime == 5) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.13f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 4.5 && battleTime == 6) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.26f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 5 && battleTime == 7) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.39f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 5.5 && battleTime == 8) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.52f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 6 && battleTime == 9) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.65f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 6.5 && battleTime == 10) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.78f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 7.5 && battleTime == 11) { Instantiate(redBigHorizontal, new Vector3(-1.2f, -0.52f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 8 && battleTime == 12) { Instantiate(redBigHorizontal, new Vector3(-1.2f, -0.13f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 8.5 && battleTime == 13) { Instantiate(redBigHorizontal, new Vector3(-1.2f, 0.26f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 12 && battleTime == 14)
        {
            Instantiate(redSmallVertical, new Vector3(-1.2f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-1.2f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-1.2f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.72f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.72f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.72f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.24f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.24f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.24f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.24f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.24f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.24f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.72f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.72f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.72f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.96f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.96f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.48f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.48f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.48f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.48f, 0.13f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.96f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.96f, 0.13f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }
        if (time > 15 && battleTime == 15)
        {
            Instantiate(redBigHorizontal, new Vector3(-1.2f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redBigHorizontal, new Vector3(-1.2f, -0.52f, 0), gameObject.transform.rotation);
            battleTime++;
            alert.Play();
        }

        if (time > 15.5 && battleTime == 16) { Instantiate(redBigHorizontal, new Vector3(-1.2f, 0f, 0), gameObject.transform.rotation); battleTime++; alert.Play();}

        if (time > 17 && battleTime == 17) PlayerPrefs.SetInt("Progress", 26);
    }

    void StageTwo()
    {
        int l = PlayerPrefs.GetInt("Lang");

        string[] names =
        {
            "StageTwo"
        };


        if (l == 1)
        {
            string[] sentences =
            {
                "StageTwo"
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 27);
        }


        if (l == 0)
        {
            string[] sentences =
            {
                //TRADUCIR ESTO A INGLÉS
                "StageTwo"
            };

            Dialogue.names = names;
            Dialogue.sentences = sentences;
            DialogueTrigger.dialogueActive = true;
            PlayerPrefs.SetInt("Progress", 27);
        }

        //STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 

    }
}
