using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public UnityEngine.GameObject circlePrefab;
    public Transform circleSpawner;
    public float spawnSpeed = 5f;

    public float spawnTimer;
    
    void Update()
    {
        if (spawnTimer < 5f)
        {
            Instantiate(circlePrefab, circleSpawner.transform.position, circleSpawner.transform.rotation);          
        }
        spawnTimer = Random.Range(1, 1000);
       
    }
}
