using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAirship : MonoBehaviour
{
    public Transform airShipTf;

    // Update is called once per frame
    void Update()
    {
        transform.position = airShipTf.position + new Vector3(0f, 0.8f, -4f);    
    }
}
