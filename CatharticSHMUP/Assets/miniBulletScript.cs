using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniBulletScript : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 direction;
    float x;
    float y;
    EnemyHp enemyHP;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        x = Random.Range(-1f, 1f);
        y = Random.Range(-1f, 1f);
        
        direction = new Vector2(x, y);
    }

   

    // Update is called once per frame
    void Update()
    {
        rb.velocity = direction * 8;
    }
}
