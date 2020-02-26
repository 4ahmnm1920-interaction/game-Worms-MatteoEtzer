using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupscript : MonoBehaviour
{
    public WormsController worm;
    public float speed;
    void OnCollisionEnter(Collision collision)
    {
        //Kollisionsabfrage
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("PICKUP");
            //Referenz aus anderem Skript
            worm = collision.gameObject.GetComponent<WormsController>();
            worm.ammospeed = speed;
            worm.rb.useGravity = false;
            //Selbstzerstörung des Objekts
            Destroy(this.gameObject);
        }
    }
}
