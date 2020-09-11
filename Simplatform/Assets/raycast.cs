using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class raycast : MonoBehaviour
{
    bool can_jump = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Ray r = new Ray(transform.position, Vector3.down);

        Debug.DrawLine(r.origin, r.origin + (Vector3.down * 3));

        RaycastHit hit;

        if(Physics.Raycast(r, out hit, 3))
        {
            if(hit.transform != null)
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
    }
}
