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
            var healthComponent = GetComponent<Collider>().GetComponent<PlayerHealth>();
            if (healthComponent != null)
            {
                healthComponent.TakeDamage(10);
            }

            //GameFlow.health -= 10;
            //Debug.Log(GameFlow.health);
            Destroy(gameObject);
        }

    }
}
