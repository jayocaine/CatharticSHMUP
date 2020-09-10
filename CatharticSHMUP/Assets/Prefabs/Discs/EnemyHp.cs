using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public static EnemyHp instance;

    public event EventHandler OnEnemyKilled;   
    public UnityEngine.GameObject bullet;
    public int hp = 3;
    ObjectPool enemyPool;
    public ObjectPool miniBulletPool;
        

    private void Awake()
    {      
        instance = this;
        
    }
    private void Update()
    {
        if (hp == 0)
        {
            
            miniBulletPool.SpawnObject(transform.position, transform.rotation);
            miniBulletPool.SpawnObject(transform.position, transform.rotation);
            miniBulletPool.SpawnObject(transform.position, transform.rotation);
            miniBulletPool.SpawnObject(transform.position, transform.rotation);

            HpReset();           
            //spawn minibullets
            
            //trigger event
            OnEnemyKilled?.Invoke(this, EventArgs.Empty);

        }
    } 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            hp -= 1;
        }
        if (collision.gameObject.tag == "MiniBullet")
        {
            CircleSpawner.instance.enemyPool.ReturnObject(gameObject);
            miniBulletPool.ReturnObject(collision.gameObject);
            hp = 3;
        }
        if (collision.gameObject.tag == "Boarder")
        {
            CircleSpawner.instance.enemyPool.ReturnObject(gameObject);
            hp = 3;
        }
    }
    public void HpReset()
    {
        hp = 3;
        CircleSpawner.instance.enemyPool.ReturnObject(gameObject);
    }
}
