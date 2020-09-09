using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMove : MonoBehaviour
{
    public static float spawnSpeed = 2f;
    public Rigidbody2D rb;
    public SquareSpawner sqspwn;
    EnemyHp enemyHp;
    private static int killCount;
    public GameObject square;

    

    private void Start()
    {
        enemyHp = GetComponent<EnemyHp>();
        enemyHp.OnEnemyKilled += EnemyHp_OnEnemyKilled;
        rb = GetComponent<Rigidbody2D>();
        sqspwn = GetComponent<SquareSpawner>();
    }

    private void EnemyHp_OnEnemyKilled(object sender, System.EventArgs e)
    {
        killCount++;
        if (killCount > 10)
        {
            killCount = 0;
            spawnSpeed ++;
            Debug.Log(spawnSpeed);
        }
    }
    private void Update()
    {
      
    }
    private void FixedUpdate()
    {
        rb.velocity = Vector2.down * spawnSpeed;
        //Debug.Log(sqspwn.randomSpeed);
    }
}
