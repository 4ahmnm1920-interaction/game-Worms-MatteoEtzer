﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsController : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpHeight;
    public float movement;
    public float laser;
    public float ammospeed;
    public Rigidbody projectile;
    public Transform Spawnpoint;
    void Start()
    {
        
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
           Vector3 force = new Vector3(0, jumpHeight, 0);
           rb.AddForce(force, ForceMode.Impulse);
           Debug.Log("Die Leertaste wurde gedrückt");
       }
       if (Input.GetKey(KeyCode.D))
       {
           Vector3 move = new Vector3(movement, 0, 0);
           rb.AddForce(move, ForceMode.Force);
           Debug.Log("D wurde gedrückt");
       }
       if (Input.GetKey(KeyCode.A))
       {
           Vector3 move = new Vector3(movement * (-1), 0, 0);
           rb.AddForce(move, ForceMode.Force);
           Debug.Log("A wurde gedrückt");
       }
       if (Input.GetButtonDown("Fire1"))
        {
            for (int i = 0; i < 5; i++)
            {
            Rigidbody clone;
            clone = Instantiate(projectile, Spawnpoint.position, transform.rotation);
            Vector3 pSpeed = new Vector3(ammospeed, 0, 0);
            
            clone.AddForce(pSpeed);
            }
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            for (int i = 0; i < 50; i++)
            {
            Rigidbody clone;
            rb.mass = 1;
            clone = Instantiate(projectile, Spawnpoint.position, transform.rotation);
            Vector3 pSpeed = new Vector3(laser, 0, 0);
            
            clone.AddForce(pSpeed);
            }
        }
    }
}
