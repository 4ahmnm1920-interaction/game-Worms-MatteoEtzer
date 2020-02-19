using System.Collections;
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
    
    
    public KeyCode ShootKey;
    public KeyCode LeftKey;
    public KeyCode RightKey;
    public KeyCode JumpKey;
    public KeyCode SpecialityKey;
    void Start()
    {
        
    }

    void Update()
    {
       if (Input.GetKeyDown(JumpKey))
       {
           Vector3 force = new Vector3(0, jumpHeight, 0);
           rb.AddForce(force, ForceMode.Impulse);
           Debug.Log("Die Leertaste wurde gedrückt");
       }
       if (Input.GetKeyDown(RightKey))
       {
           Vector3 move = new Vector3(movement, 0, 0);
           rb.AddForce(move, ForceMode.Force);
           Debug.Log("D wurde gedrückt");
           transform.eulerAngles = new Vector3(0, 180 ,0);
           ammospeed = -ammospeed;
       }
       if (Input.GetKeyDown(LeftKey))
       {
           Vector3 move = new Vector3(movement * (-1), 0, 0);
           rb.AddForce(move, ForceMode.Force);
           Debug.Log("A wurde gedrückt");
           transform.eulerAngles = new Vector3(0, 0 ,0);

       }
       if (Input.GetKeyDown(ShootKey))
        {
            for (int i = 0; i < 1; i++)
            {
            Rigidbody clone;
            clone = Instantiate(projectile, Spawnpoint.position, transform.rotation);
            Vector3 pSpeed = new Vector3(ammospeed, 0, 0);
            
            clone.AddForce(pSpeed);
            Destroy(clone.gameObject, 1.5f);
            }
        }
        if (Input.GetKeyDown(SpecialityKey))
        {
            for (int i = 0; i < 50; i++)
            {
            Rigidbody clone;
            rb.mass = 1;
            clone = Instantiate(projectile, Spawnpoint.position, transform.rotation);
            Vector3 pSpeed = new Vector3(laser, 0, 0);
            
            clone.AddForce(pSpeed);
            Destroy(clone.gameObject, 3.0f);
            }
        }
        
    }
}
