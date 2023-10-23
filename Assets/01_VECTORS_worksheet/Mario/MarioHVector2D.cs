using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioHVector2D : MonoBehaviour
{
    public Transform planet;
    public float force = 5f;
    public float gravityStrength = 5f;

    private HVector2D gravityDir, gravityNorm;
    private HVector2D moveDir;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        gravityDir = new HVector2D(planet.position - transform.position);
        moveDir = new HVector2D(gravityDir.y, -gravityDir.x);

        moveDir.Normalize();

        moveDir = moveDir * -1f;

        rb.AddForce(moveDir.ToUnityVector2() * force);

        gravityNorm = gravityDir * 1;
        gravityNorm.Normalize();
        rb.AddForce(gravityNorm.ToUnityVector2() * gravityStrength);

        float angle = Vector3.SignedAngle(Vector3.down, gravityDir.ToUnityVector3(), Vector3.forward);

        rb.MoveRotation(Quaternion.Euler(0, 0, angle));

        DebugExtension.DebugArrow(transform.position, planet.position, Color.red);
        DebugExtension.DebugArrow(transform.position, moveDir.ToUnityVector3(), Color.blue);

        //gravityDir = planet.position - transform.position;
        //moveDir = new Vector3(gravityDir.y, -gravityDir.x, 0f);
        //moveDir = moveDir.normalized * -1f;

        //rb.AddForce(moveDir * force);

        //gravityNorm = gravityDir.normalized;
        //rb.AddForce(gravityNorm * gravityStrength);

        //float angle = Vector3.SignedAngle(Vector3.down, gravityDir, Vector3.forward);


        //rb.MoveRotation(Quaternion.Euler(0, 0, angle));

        //DebugExtension.DebugArrow(transform.position, planet.position, Color.red);   //Gravity acts on the player object, The planet's position


        //DebugExtension.DebugArrow(transform.position, moveDir, Color.blue);
    }
}
