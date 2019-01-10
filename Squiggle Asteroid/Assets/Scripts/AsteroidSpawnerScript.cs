using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawnerScript : MonoBehaviour
{
    public GameObject Asteroid;
    float posX;
    Vector2 spawnPlace;
    public float inComingSpawn = 2f;
    float nextSpawn = 0.0f;
    
    
        // Choose a random position between the set quantities and spawn a prefab over time.
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + inComingSpawn;
            posX = Random.Range(-5.4f, 5.4f);
            spawnPlace = new Vector2(posX, transform.position.y);
            Instantiate(Asteroid, spawnPlace, Quaternion.identity);
        }
    }
}
