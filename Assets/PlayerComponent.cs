using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComponent : MonoBehaviour
{
    public Rigidbody my_RigidBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("left") || Input.GetKey("right") || Input.GetKey("space"))
        {
            Vector3 input = new Vector3();
            if (Input.GetKey("left") || Input.GetKey("right"))
            {
                input += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            }

            if (Input.GetKey("space"))
            {
                input += new Vector3(0, 1, 0);
            }

            my_RigidBody.MovePosition(transform.position + input * Time.deltaTime * 5f);
        }
    }
}
