using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[SerializedField]
    //float moveSpeed = 1;

    [SerializedField]
    float jumpSpeed = 1;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(h,
                                  rb.velocity.y,
                                  v);

       // if (input.GetButtonDown("jump"));
       // {
            //jump();
       // }
        

        //void jump()
        {
            //rb.velocity = new Vector3(rb.velocity.x,
                                     // jumpSpeed,
                                      //rb.velocity.z);
        }
    }
}
