using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class GameFlow : MonoBehaviour
{
    //Creates the Tile1 Object & Adds Vector3 to Allow for Spawning Next Tile
    public Transform Tile1;
    private Vector3 nextTileSpawn;

    //Creates the WrongRock Object & Adds Vector3 to Allow for Spawning Next Tile
    public Transform WrongRock;
    private Vector3 nextWrongRockSpawn;

    private int randomZ;

    //Creates the RightRock Object & Adds Vector3 to Allow for Spawning Next Tile
    public Transform RightRock;
    private Vector3 nextRightRockSpawn;

    //Creates the HealthPowerUps Object & Adds Vector3 to Allow for Spawning Next Tile
    public Transform HealthPowerUp;
    private Vector3 nextHealthPowerUpSpawn;


    void Start()
    {
        //Controls Where the Next Tile Will Spawn
        nextTileSpawn.x = 40;
        StartCoroutine(SpawnTile());
    }

    void Update()
    {
        
    }

    //Creates an IEnumerator that Allows for Spawning of Tiles & Items
    IEnumerator SpawnTile()
    {
        yield return new WaitForSeconds(1);
        randomZ = Random.Range(0, 3); //Need to Always Bump Up Right End by One so its Included
        nextWrongRockSpawn = nextTileSpawn;
        //nextWrongRockSpawn.y = .02f;
        nextWrongRockSpawn.z = randomZ;

        Instantiate(Tile1, nextTileSpawn, Tile1.rotation);
        Instantiate(WrongRock, nextWrongRockSpawn, WrongRock.rotation);

        nextTileSpawn.x += 5;
        randomZ = Random.Range(0, 3); //Need to Always Bump Up Right End by One so its Included
        nextRightRockSpawn = nextTileSpawn;
        //nextRightRockSpawn.y = .02f;
        nextRightRockSpawn.z = randomZ;

        Instantiate(Tile1, nextTileSpawn, Tile1.rotation);
        Instantiate(RightRock, nextRightRockSpawn, RightRock.rotation);

        //If randomZ = 0 then change it to 1
        if(randomZ==0)
        {
            randomZ = 1;
        }

        //If randomZ = 1 then change it to 2
        else if (randomZ==1)
        {
            randomZ = 2;
        }

        //If randomZ = 2 then change it to 0
        else
        {
            randomZ = 0;
        }

        nextHealthPowerUpSpawn = nextTileSpawn;
        //nextHealthPowerUpSpawn.y = .02f;
        nextHealthPowerUpSpawn.z = randomZ;
        Instantiate(HealthPowerUp, nextHealthPowerUpSpawn, HealthPowerUp.rotation);
        
        nextTileSpawn.x += 5;
        StartCoroutine(SpawnTile());
        
    }
}
