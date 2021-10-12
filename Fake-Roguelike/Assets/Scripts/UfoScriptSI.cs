using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoScriptSI : MonoBehaviour
{
    public float time=3f;
    private float initialTime;
    public GameObject  bullet;
    public Transform shootingPoint;
    public int rd;
    // Start is called before the first frame update
    void Start()
    {
        initialTime = time;
    }

    // Update is called once per frame
    void Update()
    {
        time =time - Time.deltaTime;
         rd = Random.Range(0, 200);
        if (time <= 0 && rd == 3)
        {
            Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
            time = initialTime;
        }
    }
}
