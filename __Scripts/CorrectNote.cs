using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CorrectNote : MonoBehaviour
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
            GameFlow.score += 10;
            Debug.Log(GameFlow.score);
            Destroy(gameObject);
        }

    }
}
