using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summoning : MonoBehaviour
{
    // Start is called before the first frame update

    public float SummonTime=2;
    public float SummonTimeInitial;
    public GameObject objeto;
    public float r1 = -8;
    public float r2 = 8;
    void Start()
    {
        SummonTimeInitial = SummonTime;
        SummonTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        float x = Time.time;

        if (x > SummonTime )
        {
            float random = Random.Range(r1,r2);
            SummonTime = SummonTime + SummonTimeInitial;
            Instantiate(objeto, new Vector2(random, 4.2f), transform.rotation);

        }
        
    }


   
}
