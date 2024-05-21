using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
        void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKey (KeyCode.RightArrow))
        {
            Vector2 pos = transform.position;
            pos.x += 0.03f;
            transform.position = pos;
        }
        else if(Input.GetKey (KeyCode.LeftArrow))
        {
            Vector2 pos = transform.position;
            pos.x -= 0.03f;
            transform.position = pos;
        }
    }
}
