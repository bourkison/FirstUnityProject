using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleComponent : MonoBehaviour
{
    public Rigidbody ball_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        ball_Rigidbody.AddForce(-transform.forward * 1000f);   
    }
}
