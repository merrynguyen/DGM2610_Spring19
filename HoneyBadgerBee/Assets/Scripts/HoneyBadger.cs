using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyBadger : MonoBehaviour
{



    
    private Boolean IsDead;
    public float upForce = 300;
    public Rigidbody rgbd;
 
    public Vector3 Movement;
    public int speed =10
        ;
    
        void Start ()
        {
            rgbd= GetComponent<Rigidbody>();
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                rgbd.velocity = Vector2.zero;
                rgbd.AddForce(new Vector2(100, upForce));
               
            }

            if (Input.GetKey(KeyCode.A))
            {
                Movement = rgbd.velocity;
                Movement.x = Input.GetAxis("Horizontal") * speed;
                rgbd.velocity = Movement;
            }

            if (Input.GetKey(KeyCode.D))
            {
                Movement = rgbd.velocity;
                Movement.x = Input.GetAxis("Horizontal") * speed;
                rgbd.velocity = Movement;
            }

            if (Input.GetKeyUp(KeyCode.A))
            {
                Movement = rgbd.velocity;
                Movement.x = 0;
                rgbd.velocity = Movement;
            }
            
            if (Input.GetKeyUp(KeyCode.D))
            {
                Movement = rgbd.velocity;
                Movement.x = 0;
                rgbd.velocity = Movement;
            }
        }
    


}

