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
            PlayerScore.instance.AddScore();

            //var scoreComponent = GetComponent<Collider>().GetComponent<PlayerScore>();
            //if (scoreComponent != null)
            //{
            //    scoreComponent.AddScore(10);
            //}

            //GameFlow.score += 10;
            //Debug.Log(GameFlow.score);
            Destroy(gameObject);
        }

    }
}
