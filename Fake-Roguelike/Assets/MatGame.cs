using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatGame : MonoBehaviour
{
    public int battleTime = 0;
    public float time = 0;
    public GameObject redSmallVertical, redBigVertical, redSmallHorizontal, redBigHorizontal, redSingle, redMarker, purpleBigVertical, purpleBigHorizontal;
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
        if (PlayerPrefs.GetInt("Progress") == 26 || PlayerPrefs.GetInt("Progress") == 27) StageTwo();
        if (PlayerPrefs.GetInt("Progress") == 28 || PlayerPrefs.GetInt("Progress") == 29 || PlayerPrefs.GetInt("Progress") == 30) StageThree();
        if (battleTime >= 1) time += Time.deltaTime;
    }


    void StageOne()
    {
        if (PlayerPrefs.GetInt("Progress") == 24)
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
            }
        }

        if (PlayerPrefs.GetInt("Progress") == 25 && !DialogueTrigger.dialogueActive && battleTime == 0) { battleTime = 1; time = 0; }

        //STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 STAGE 1 

        if (time > 1 && battleTime == 1) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, 0.39f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 1.2 && battleTime == 2) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, 0.26f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 1.4 && battleTime == 3) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, 0.13f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 1.6 && battleTime == 4) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, 0.00f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 1.8 && battleTime == 5) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.13f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 2 && battleTime == 6) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.26f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 2.2 && battleTime == 7) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.39f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 2.4 && battleTime == 8) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.52f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 2.6 && battleTime == 9) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.65f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 2.8 && battleTime == 10) { Instantiate(redSmallHorizontal, new Vector3(-0.24f, -0.78f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 4 && battleTime == 11) { Instantiate(redBigHorizontal, new Vector3(-1.2f, -0.52f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 5.5 && battleTime == 12) { Instantiate(redBigHorizontal, new Vector3(-1.2f, -0.13f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }
        if (time > 6.5 && battleTime == 13) { Instantiate(redBigHorizontal, new Vector3(-1.2f, 0.26f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }

        if (time > 8 && battleTime == 14)
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
        if (time > 10 && battleTime == 15)
        {
            Instantiate(redBigHorizontal, new Vector3(-1.2f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redBigHorizontal, new Vector3(-1.2f, -0.52f, 0), gameObject.transform.rotation);
            battleTime++;
            alert.Play();
        }

        if (time > 11 && battleTime == 16) { Instantiate(redBigHorizontal, new Vector3(-1.2f, 0f, 0), gameObject.transform.rotation); battleTime++; alert.Play(); }

        if (time > 13.6 && battleTime == 17)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            battleTime++;
            alert.Play();
            PlayerPrefs.SetInt("Progress", 26);
        }
    }

    void StageTwo()
    {
        if (PlayerPrefs.GetInt("Progress") == 26)
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
        }

        if ((PlayerPrefs.GetInt("Progress") == 27 && !DialogueTrigger.dialogueActive) && battleTime == 18 || battleTime == 0) { battleTime = 1; time = 0; }

        //STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 STAGE 2 

        if (time > 2 && battleTime == 1)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            alert.Play();
            battleTime++;
        }

        if (time > 3 && battleTime == 2)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            alert.Play();
            battleTime++;
        }

        if (time > 4 && battleTime == 3)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(0.48f, 0.39f, 0), gameObject.transform.rotation);

            alert.Play();
            battleTime++;
        }

        if (time > 5 && battleTime == 4)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(-0.24f, 0.39f, 0), gameObject.transform.rotation);

            alert.Play();
            battleTime++;
        }

        if (time > 6 && battleTime == 5)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(-0.48f, 0.39f, 0), gameObject.transform.rotation);

            alert.Play();
            battleTime++;
        }

        if (time > 7 && battleTime == 6)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(-1.2f, 0.39f, 0), gameObject.transform.rotation);

            alert.Play();
            battleTime++;
        }

        if (time > 8 && battleTime == 7)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(-0.48f, 0.39f, 0), gameObject.transform.rotation);

            alert.Play();
            battleTime++;
        }

        if (time > 10 && battleTime == 8)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);

            alert.Play();
            battleTime++;
        }

        if (time > 12 && battleTime == 9)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            alert.Play();
            battleTime++;
        }

        if (time > 13 && battleTime == 10)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);
            alert.Play();
            battleTime++;
        }

        if (time > 15 && battleTime == 11)
        {
            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(-1.2f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(0.48f, 0.39f, 0), gameObject.transform.rotation);
            alert.Play();
            battleTime++;
        }

        if (time > 18 && battleTime == 12)
        {
            battleTime++;
            PlayerPrefs.SetInt("Progress", 28);
            battleTime = 0;
        }

    }

    void StageThree()
    {
        if (PlayerPrefs.GetInt("Progress") == 28)
        {
            int l = PlayerPrefs.GetInt("Lang");

            string[] names =
            {
            "StageThree"
            };


            if (l == 1)
            {
                string[] sentences =
                {
                "StageThree"
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 29);
            }


            if (l == 0)
            {
                string[] sentences =
                {
                //TRADUCIR ESTO A INGLÉS
                "StageThree"
                };

                Dialogue.names = names;
                Dialogue.sentences = sentences;
                DialogueTrigger.dialogueActive = true;
                PlayerPrefs.SetInt("Progress", 29);
            }
        }

        if ((PlayerPrefs.GetInt("Progress") == 29 && !DialogueTrigger.dialogueActive)) { battleTime = 1; time = 0; PlayerPrefs.SetInt("Progress", 30); }

        //STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 STAGE 3 

        if (time > 2 && battleTime == 1)
        {
            Instantiate(redBigVertical, new Vector3(-0.72f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redBigVertical, new Vector3(0.00f, 0.39f, 0), gameObject.transform.rotation);

            alert.Play();
            battleTime++;
        }

        if (time > 3 && battleTime == 2)
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


            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 4 && battleTime == 3)
        {
            Instantiate(redSmallVertical, new Vector3(-1.2f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-1.2f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.72f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.72f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.24f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.24f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.24f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.24f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.72f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.72f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.96f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.96f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.96f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.48f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.48f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.48f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.48f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.48f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.48f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.96f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.96f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.96f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);


            battleTime++;

            alert.Play();

        }

        if (time > 5 && battleTime == 4)
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

            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 6 && battleTime == 5)
        {
            Instantiate(redSmallVertical, new Vector3(-1.2f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-1.2f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.72f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.72f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.24f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.24f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.24f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.24f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.72f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.72f, -0.39f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.96f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.96f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.96f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(-0.48f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.48f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(-0.48f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.48f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.48f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.48f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redSmallVertical, new Vector3(0.96f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.96f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallVertical, new Vector3(0.96f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();

        }

        if (time > 8 && battleTime == 6)
        {
            Instantiate(purpleBigVertical, new Vector3(-1.2f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(purpleBigVertical, new Vector3(0.48f, 0.39f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 10 && battleTime == 7)
        {
            Instantiate(redSmallHorizontal, new Vector3(-0.48f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(0.00f, 0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(0.00f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(-0.24f, 0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(-0.48f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(0.00f, -0.13f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(0.00f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(-0.24f, -0.39f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(-0.48f, -0.65f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(0.00f, -0.65f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 11 && battleTime == 8)
        {
            Instantiate(redSmallHorizontal, new Vector3(-0.48f, 0.26f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(0.00f, 0.26f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(0.00f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(-0.24f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(-0.48f, -0.26f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(0.00f, -0.26f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(0.00f, -0.52f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(-0.24f, -0.52f, 0), gameObject.transform.rotation);
            Instantiate(redSmallHorizontal, new Vector3(-0.48f, -0.78f, 0), gameObject.transform.rotation);
            Instantiate(redSingle, new Vector3(0.00f, -0.78f, 0), gameObject.transform.rotation);

            Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 13 && battleTime == 9)
        {
            Instantiate(purpleBigHorizontal, new Vector3(-1.2f, -0.52f, 0), gameObject.transform.rotation);
            Instantiate(purpleBigHorizontal, new Vector3(-1.2f, -0.13f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 15 && battleTime == 10)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 16 && battleTime == 11)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 17 && battleTime == 12)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 18 && battleTime == 13)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 19 && battleTime == 14)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 20 && battleTime == 15)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 20 && battleTime == 16)
        {
            Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
            Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

        if (time > 22 && battleTime == 17)
        {
            Instantiate(purpleBigHorizontal, new Vector3(-1.2f, 0.26f, 0), gameObject.transform.rotation);

            battleTime++;

            alert.Play();
        }

    }

    public void MarcadoresEnOrden()
    {
        Instantiate(redMarker, new Vector3(-1.9f, -0.79f, 0), gameObject.transform.rotation);
        Instantiate(redMarker, new Vector3(-1.9f, -0.66f, 0), gameObject.transform.rotation);
        Instantiate(redMarker, new Vector3(-1.9f, -0.53f, 0), gameObject.transform.rotation);
        Instantiate(redMarker, new Vector3(-1.9f, -0.40f, 0), gameObject.transform.rotation);
        Instantiate(redMarker, new Vector3(-1.9f, -0.27f, 0), gameObject.transform.rotation);
        Instantiate(redMarker, new Vector3(-1.9f, -0.14f, 0), gameObject.transform.rotation);
        Instantiate(redMarker, new Vector3(-1.9f, 0.00f, 0), gameObject.transform.rotation);
        Instantiate(redMarker, new Vector3(-1.9f, 0.12f, 0), gameObject.transform.rotation);
        Instantiate(redMarker, new Vector3(-1.9f, 0.25f, 0), gameObject.transform.rotation);
        Instantiate(redMarker, new Vector3(-1.9f, 0.38f, 0), gameObject.transform.rotation);
    }

}
