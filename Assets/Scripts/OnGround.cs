using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGround : MonoBehaviour
{
    private Rigidbody rb;
    private bool isOnGround = false;
    public bool IsOnGround { get => isOnGround; }

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            isOnGround = true;

            // Stop rotating
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            isOnGround = false;

            // Stop rotating
            rb.constraints = RigidbodyConstraints.None;
        }
    }
}
