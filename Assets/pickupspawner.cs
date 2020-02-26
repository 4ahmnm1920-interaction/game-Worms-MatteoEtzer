using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupspawner : MonoBehaviour
{
    public int count_of_pickups;
    public float floatxmin;
    public float floatxmax;
    public float floatymin;
    public float floatymax;
    public GameObject PickUp;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < count_of_pickups; i++)
        {
            float x = Random.Range(floatxmin, floatxmax);
            float y = Random.Range(floatymin, floatymax);
            float z = 1;
            Vector3 position = new Vector3(x,y,z);
            GameObject clone;
            clone = Instantiate(PickUp, position, Quaternion.identity);
        }
    }
}
