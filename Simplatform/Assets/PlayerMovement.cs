using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    bool can_jump = false;

    [SerializeField]
    float moveSpeed = 1;

    [SerializeField]
    float jumpSpeed = 1;

    Rigidbody rb;
     //Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

     //Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(h,
                                  rb.velocity.y,
                                  v);
        Ray r = new Ray(transform.position, Vector3.down);

        Debug.DrawLine(r.origin, r.origin + (Vector3.down * 10));

        RaycastHit hit;
        
        if (Physics.Raycast(r, out hit, 10))
        {
            if (hit.transform != null)
            {
                Debug.Log(hit.transform.name);
                {
                    if (hit.transform.name == "ground")
                    { can_jump = true; }
                    else;
                    { can_jump = false; }
                }
            }
        }


        if (Input.GetButtonDown("Jump") && can_jump == true)
        {
            jump();
        }
        

        void jump()
        {
            rb.velocity = new Vector3(rb.velocity.x,
                                      jumpSpeed,
                                      rb.velocity.z);
        }
    }
}
