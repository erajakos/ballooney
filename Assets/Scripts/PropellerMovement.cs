using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerMovement : MonoBehaviour
{
    public Transform rotationPivot;
    private float magnifier = 3.5f;
    private float speed = 0f;
    private float maxSpeed = 10f;
    public bool moreSpeedRequested = false;

    public float Speed { get => speed; }

    // Update is called once per frame
    void Update()
    {
        if (moreSpeedRequested && speed < maxSpeed)
        {
            speed += Time.deltaTime * magnifier;
            moreSpeedRequested = false;
        } else
        {
            speed -= Time.deltaTime * magnifier;
            if (speed < 0f)
            {
                speed = 0f;
            }
        }
        transform.RotateAround(rotationPivot.position, Vector3.right, speed);
    }

}
