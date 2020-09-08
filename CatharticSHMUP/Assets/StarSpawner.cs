using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public UnityEngine.GameObject starPrefab;
    public Transform starSpawner;

    public float spawnTimer;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer < 5f)
        {
            Instantiate(starPrefab, starSpawner.transform.position, starSpawner.transform.rotation);
        }
        spawnTimer = Random.Range(1, 1000);

    }
}
