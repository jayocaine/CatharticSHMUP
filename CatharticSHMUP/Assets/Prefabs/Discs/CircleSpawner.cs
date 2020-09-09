using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public static CircleSpawner instance;
    public UnityEngine.GameObject circlePrefab;
    public Transform circleSpawner;
    public float spawnSpeed = 5f;

    public float spawnTimer;
    public ObjectPool enemyPool;

    private void Awake()
    {
        instance = this;
        spawnTimer = Random.Range(1, 1000);
    }
    void Update()
    {
        if (spawnTimer < 5f)
        {
            enemyPool.SpawnObject(circleSpawner.transform.position, circleSpawner.transform.rotation);          
        }
        spawnTimer = Random.Range(1, 1000);
       
    }
}
