using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhosts : MonoBehaviour
{


    public GameObject obstacle;
public float maxX;
public float minX;
public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;
    public GameObject OverShield;

    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        if(Random.Range(0, 10) == 0)
        {
            Instantiate(OverShield, transform.position + new Vector3(randomX, randomY, 0), transform.rotation); // Spawned OverShield
        }
        else
        {
            Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        }


    }
}
