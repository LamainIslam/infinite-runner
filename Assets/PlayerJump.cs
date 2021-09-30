using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody rb;
    public float jumpBy;
    public bool isGrounded = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded) 
        {
            rb.AddForce(0, jumpBy*Time.deltaTime, 0);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision) //looks for collisions
    {
        if (collision.gameObject.tag == "Ground")//player can't jump in midair
        {
            isGrounded = true;
        }
    }
}
