using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float bulletForce = 5f;
    Vector2 dir;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dir = Vector2.up;
    }
    private void Update()
    {
        
        rb.AddForce(dir * bulletForce, ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ShootingScript.instance.bulletPool.ReturnObject(gameObject);
    }

}
