using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLIDED WITH SOMTHING");

        Debug.Log(collision.gameObject.name);
    }

    private void OnCollisionEnter(Collider other)
    {
        Debug.Log("Hit trigger");

        Debug.Log(other.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Out of trigger");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Staying in Trigger");
    }
}
