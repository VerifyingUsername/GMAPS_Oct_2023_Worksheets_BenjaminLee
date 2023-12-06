using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    public Vector3 Velocity;

    void FixedUpdate()
    {
        float dt = Time.deltaTime;

        // Calculates position based on the time and velocity
        float dx = Velocity.x * dt;
        float dy = Velocity.y * dt;
        float dz = Velocity.z * dt;

        // Moves the object 
        transform.Translate(new Vector3(dx, dy, dz));
    }
}
