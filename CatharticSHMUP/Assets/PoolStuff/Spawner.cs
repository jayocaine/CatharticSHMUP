using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    ObjectPooler objectPooler;
    public float spawnTimer = Random.Range(1, 1000);
    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }
    private void FixedUpdate()
    {        
        if(spawnTimer < 5)
        {
            ObjectPooler.Instance.SpawnFromPool("Enemy4", transform.position, Quaternion.identity);
        }
        spawnTimer = Random.Range(1, 1000);
    }
}
