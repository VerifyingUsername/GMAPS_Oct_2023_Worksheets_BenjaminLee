using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLaw : MonoBehaviour
{
    public Vector3 force;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();// your code here;
        rb.AddForce(force, ForceMode.Impulse);// your code here;
     }

    void FixedUpdate()
    {
        Debug.Log(transform.position);
    }
}

