using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlemovement : MonoBehaviour
{

    //public new Rigidbody2D rigidbody { get; private set; }

    //public Vector2 direction { get; private set; }

    public float speed = 30f;

    float movementHorizontal;


    // Update is called once per frame
    void Update()
    {
        
        /*
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.direction = Vector2.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.direction = Vector2.right;
        }
        else
        {
            this.direction = Vector2.zero;
        }
        */

        movementHorizontal = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * movementHorizontal * speed * Time.deltaTime;
        

    }
}