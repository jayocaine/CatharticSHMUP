using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public static CircleSpawner instance;
    public UnityEngine.GameObject circlePrefab;
    public Transform circleSpawner;
    public float spawnSpeed = 1;

    public float spawnTimer;
    public ObjectPool enemyPool;

    private int spawnIncrement = 20;
    private int spawnTimer2 = 2;

    private float timer;

 

   

    private void Awake()
    {
        instance = this;
        spawnTimer = Random.Range(1, 100);       
    }
    void Update()
    {
        timer += Time.deltaTime;
        if(spawnIncrement < timer && spawnTimer2 != 20)
        {
            spawnTimer2++;
            timer = 0;
        }

        if (spawnTimer < spawnTimer2)
        {
            
            enemyPool.SpawnObject(circleSpawner.transform.position, circleSpawner.transform.rotation);
            //enemyHp.HpReset();
        }
        spawnTimer = Random.Range(1, 1000);       
    }
}
