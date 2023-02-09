using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speedRight;
    //public float speedForward;
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.right * speedRight;
        //GetComponent<Rigidbody>().velocity = transform.forward * speedForward;

    }

    
}
