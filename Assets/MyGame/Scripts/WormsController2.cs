using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsController2 : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpHeight;
    public float movement;
    public Vector3 ammospeed;
    public Rigidbody projectile;
    public GameObject positionObject;
    void Start()
    {
        
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.UpArrow))
       {
           Vector3 force = new Vector3(0, jumpHeight, 0);
           rb.AddForce(force, ForceMode.Impulse);
           Debug.Log("Die Leertaste wurde gedrückt");
       }
       if (Input.GetKey(KeyCode.RightArrow))
       {
           Vector3 move = new Vector3(movement, 0, 0);
           rb.AddForce(move, ForceMode.Force);
           Debug.Log("D wurde gedrückt");
       }
       if (Input.GetKey(KeyCode.LeftArrow))
       {
           Vector3 move = new Vector3(movement * (-1), 0, 0);
           rb.AddForce(move, ForceMode.Force);
           Debug.Log("A wurde gedrückt");
       }
       if (Input.GetKeyDown(KeyCode.RightShift))
        {
            for (int i = 0; i < 3; i++)
            {
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.forward * 25);
            }
        }
        if (Input.GetKeyDown(KeyCode.Asterisk))
        {
            for (int i = 0; i < 1000; i++)
            {
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.forward * 25);
            }
        }
    }
}
