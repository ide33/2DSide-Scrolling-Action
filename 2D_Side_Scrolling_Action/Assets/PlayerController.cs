using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private float xSpeed;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        MoveUpdate ();
    }
    private void MoveUpdate()
    {
        if(Input.GetKey (KeyCode.RightArrow))
        {
            xSpeed = 6.0f;
        }
        else if(Input.GetKey (KeyCode.LeftArrow))
        {
           xSpeed = -6.0f;
        }
        else
        {
            xSpeed = 0.0f;
        }
    }
    private void FixedUpdate()
    {
        Vector2 velocity = rigidbody.velocity;
        velocity.x = xSpeed;
        rigidbody.velocity = velocity;
    }

}