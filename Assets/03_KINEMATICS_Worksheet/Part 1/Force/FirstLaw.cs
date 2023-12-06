using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLaw : MonoBehaviour
{
    public Vector3 force;
    Rigidbody rb;

    void Start()
    {
        // your code here;
        // Gets the rigibody component from the ball1 gameObject
        rb = GetComponent<Rigidbody>();
        
        // your code here;
        // is pushed by forcemode.impulse by the force
        rb.AddForce(force, ForceMode.Impulse);
     }

    //Updates ball1's position constantly
    void FixedUpdate()
    {
        Debug.Log(transform.position);
    }
}

