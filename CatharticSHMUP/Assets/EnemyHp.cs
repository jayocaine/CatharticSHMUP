using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public  event EventHandler OnEnemyKilled;   
    public UnityEngine.GameObject bullet;
    public int hp = 3;

    private void Awake()
    {
        hp = 3;
    }
    private void Update()
    {
        if (hp == 0)
        {
            Destroy(gameObject);
            OnEnemyKilled?.Invoke(this, EventArgs.Empty);
        }
    } 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            hp -= 1;
            //Debug.Log(hp);
        }
    }
}
