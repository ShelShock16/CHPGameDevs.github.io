using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    
        public GameObject arrow;
        public float launchForce;
        public Transform shotPoint;
        public float nextAttackTime;
        public float attackRate=1.3f;
        Vector2 direction;
        
        private void Start()
        {

        }

        void Update()
        {
            Vector2 cannonPosition = transform.position;
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = mousePosition - cannonPosition;
            transform.right = direction;
      
        if (Time.time > nextAttackTime) { 
            if (Input.GetMouseButtonDown(0))
            {

                Shoot();
                nextAttackTime = Time.time+1f/attackRate;
            }
        }

        }

        void Shoot()
        {
            GameObject newBall = Instantiate(arrow, shotPoint.position, shotPoint.rotation);
            newBall.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
            

        }

    }


