using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player") && (Input.GetKey("s") | Input.GetKey("down"))) //In other words, if player is crouched and touches powerup it is destroyed
        {
            var healthComponent = GetComponent<Collider>().GetComponent<PlayerHealth>();
            if (healthComponent != null)
            {
                healthComponent.AddHealth(10);
            }

            //GameFlow.health += 10;
            //Debug.Log(GameFlow.health);
            Destroy(gameObject);
        }

    }
	
}
