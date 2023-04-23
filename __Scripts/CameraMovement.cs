using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(3,0,0);
    }

    void Update()
    {
        
    }
	
}
