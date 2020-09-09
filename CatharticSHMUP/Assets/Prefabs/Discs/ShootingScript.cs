using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public static ShootingScript instance;
    
    public Transform firePoint;
    public UnityEngine.GameObject bulletPrefab;
    public float bulletForce = 20f;
    public ObjectPool bulletPool;
    // Update is called once per frame

    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        bulletPool.SpawnObject(firePoint.position, firePoint.rotation);       
    }
}

