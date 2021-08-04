using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    public float spawnRate = 1.0f;
    public float spawnDelay = 1.0f;
    [SerializeField] float rangX1;
    [SerializeField] float rangX2;
    float randomX;
    Vector3 whereToSpawn;

    // Update is called once per frame
    void Update()
    {
        spawnRate -= Time.deltaTime;
        if (spawnRate <= 0)
        {
            spawnRate = spawnDelay;
            randomX = Random.Range(rangX1, rangX2);
            whereToSpawn = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(ball, whereToSpawn, Quaternion.identity);
        }
    }
}
