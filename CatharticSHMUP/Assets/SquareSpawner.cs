using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    public UnityEngine.GameObject squacrePrefab;
    public Transform squareSpawner;

    public float spawnTimer;
    public float randomSpeed;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer < 5f)
        {
            Instantiate(squacrePrefab, squareSpawner.transform.position, squareSpawner.transform.rotation);
        }
        spawnTimer = Random.Range(1, 1000);

    }
}
