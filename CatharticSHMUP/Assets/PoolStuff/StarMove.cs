using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMove : MonoBehaviour
{
    public static float spawnSpeed = 2f;
    public Rigidbody2D rb;
    public int hp;
    private static int killCount;
    EnemyHp enemyHp;
    
    private void Update()
    {
        if (killCount > 10)
        {
            spawnSpeed += 2;
        }
    }

    private void Start()
    {
        enemyHp = GetComponent<EnemyHp>();
        enemyHp.OnEnemyKilled += EnemyHp_OnEnemyKilled;
        rb = GetComponent<Rigidbody2D>();
    }

    private void EnemyHp_OnEnemyKilled(object sender, System.EventArgs e)
    {
        killCount++;
        if (killCount > 10)
        {
            killCount = 0;
            spawnSpeed++;
            Debug.Log(spawnSpeed);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.down * spawnSpeed;
    }
}
