using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picterroation : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            transform.Rotate(0, 0, 0.2f);
            //transform.Rotate(Vector3.left * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.B))
        {
            transform.Rotate(0, 0, -0.2f);
            // transform.Rotate(Vector3.right * Time.deltaTime, Space.World);
        }
    }
}
