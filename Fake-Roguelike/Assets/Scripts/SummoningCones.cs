using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummoningCones : MonoBehaviour
{

    public float SummonTime = 2;
    private float SummonTimeInitial;
    public GameObject objeto;
    


    // Start is called before the first frame update
    void Start()
    {
        SummonTimeInitial = SummonTime;
        SummonTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Time.time;

        if (x > SummonTime)
        {
            float random = Random.Range(0,3);
            if((int)random==0)random=-1.1f;
            if ((int)random == 1) random = 0f;
            if ((int)random == 2) random = 1.1f;
            SummonTime = SummonTime + SummonTimeInitial;
            Instantiate(objeto, new Vector2((int)random, 5f), transform.rotation);

        }
    }

    

}
