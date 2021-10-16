using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcyTowerKiller : MonoBehaviour
{
    private Vector3 startPos;
    public Transform target;
    public float speed;
    private bool moveUp;
    public float startTime = 5f;


    void Start()
    {
        startPos = transform.position;
        moveUp = true;
    }
    void Update()
    {
        if (startTime <= 0)
        {
            float step = speed * Time.deltaTime;
            if (transform.position == target.position)
            {
                moveUp = false;
            }
            else if (transform.position == startPos)
            {
                moveUp = true;
            }
            if (moveUp == false)
            {
                transform.position = Vector3.MoveTowards(transform.position, startPos, step);
            }
            else if (moveUp)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
        }
        else
        {
            startTime -= Time.deltaTime;
        }
    }

}

/*
 *   private Vector3 startPos;
    public Transform target;
    public float speed;
    private bool moveUp;
    public float startTime=5f;
    void Start()
    {
        startPos = transform.position;
        moveUp = true;
    }
    void Update()
    {
        if (startTime <= 0) { 
        float step = speed * Time.deltaTime;
        if (transform.position == target.position)
        {
            moveUp = false;
        }
        else if (transform.position == startPos)
        {
            moveUp = true;
        }
        if (moveUp == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos, step);
        }
        else if (moveUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        }
        else
        {
            startTime -= Time.deltaTime;
        }
    }
 */