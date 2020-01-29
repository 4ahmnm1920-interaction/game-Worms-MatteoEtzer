using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsController : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpHeight;
    public float movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
    }
}
