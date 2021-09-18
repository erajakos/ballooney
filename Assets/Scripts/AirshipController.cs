using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirshipController : MonoBehaviour
{
    public ParticleSystem burner;
    public PropellerMovement leftPropelMovement;
    public PropellerMovement rightPropelMovement;
    private OnGround onGround;
    private Rigidbody rb;
    private float burnSpeed = 800f;
    private float forwardMovementSpeed = 40f;
    private float propelMovementMagnifier = 200f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        onGround = GetComponent<OnGround>();
    }

    private void Update()
    {
        if (!onGround.IsOnGround)
        {
            rb.AddForce(Vector3.forward * forwardMovementSpeed * Time.deltaTime, ForceMode.Force);
        }
    }

    public void Burn()
    {
        if (!burner.isPlaying)
        {
            burner.Play();

        }
        rb.AddForce(Vector3.up * burnSpeed * Time.deltaTime, ForceMode.Force);
        if (transform.position.y > 400f)
        {
            rb.AddForce(Vector3.down * burnSpeed * Time.deltaTime, ForceMode.Force);
        }
    }

    public void StopBurn()
    {
        if (burner.isPlaying)
        {
            burner.Stop();
        }
    }

    public void RotateLeftPropel()
    {
        leftPropelMovement.moreSpeedRequested = true;
        if (!onGround.IsOnGround)
        {
            rb.AddForce(Vector3.right * leftPropelMovement.Speed * propelMovementMagnifier * Time.deltaTime, ForceMode.Force);
        }
    }

    public void RotateRightPropel()
    {
        rightPropelMovement.moreSpeedRequested = true;
        if (!onGround.IsOnGround)
        {
            rb.AddForce(Vector3.left * rightPropelMovement.Speed * propelMovementMagnifier * Time.deltaTime, ForceMode.Force);
        }
    }
}
