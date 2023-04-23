using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class IncorrectNote : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            GameFlow.health -= 10;
            Debug.Log(GameFlow.health);
            Destroy(gameObject);
        }

    }
}
