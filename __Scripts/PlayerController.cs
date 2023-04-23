using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private string laneChange = "n";
    private string midJump = "n";

    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(3, 0, 0);
    }

    void Update()
    {
        if ((Input.GetKey("a")) && (transform.position.z < 1.9) && (midJump == "n")) //| (Input.GetKey("left")) // && (laneChange == "n")
        {
            GetComponent<Rigidbody>().velocity = new Vector3(3, 0, 1);
            //laneChange = "y";
            StartCoroutine(stopLaneChange());
        }

        if ((Input.GetKey("d")) && (transform.position.z > .9) && (midJump == "n")) //| (Input.GetKey("right")) // && (laneChange == "n")
        {
            GetComponent<Rigidbody>().velocity = new Vector3(3, 0, -1);
            //laneChange = "y";
            StartCoroutine(stopLaneChange());
        }

        //Jump
        if ((Input.GetKey("space")) && (midJump == "n")) //&& (laneChange == "n")) //(Input.GetKey("w") | | Input.GetKey("up"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(3, 1, 0);
            midJump = "y";
            StartCoroutine(stopJump());
        }

        //Might be able to remove since similar thing in health powerup script
        //Crouch (The Action that Allows PowerUps to be Collected) 
        if (Input.GetKey("s") | Input.GetKey("down"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(3, 0, 0);
            //Debug.Log("Crouch");
        }
    }

    IEnumerator stopJump()
    {
        yield return new WaitForSeconds(0.75f);
        GetComponent<Rigidbody>().velocity = new Vector3(3, -1, 0);
        yield return new WaitForSeconds(0.75f);
        GetComponent<Rigidbody>().velocity = new Vector3(3, 0, 0);
        midJump = "n";
    }

    IEnumerator stopLaneChange()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody>().velocity = new Vector3(3, 0, 0);
        //Debug.Log(GetComponent<Transform>().position); //was used to test out if the transform posiiton matches what i wanted it to be
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            //Debug.Log("Damage"); //Used for Testing
        }

        if(other.tag == "CorrectNote")
        {
            //Debug.Log("Correct"); //Used for testing
        }

        if(other.tag == "PowerUp")
        {
            //Debug.Log("Health"); //Used for testing
        }
    }

}
