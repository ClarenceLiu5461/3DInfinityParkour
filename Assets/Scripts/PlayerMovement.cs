using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed;
    public float SidewaysSpeed;

    //We marked this as "Fixed"Update because we are using it to mess with physics
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, Speed * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysSpeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
