using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BootStrap : MonoBehaviour
{
    [SerializeField] private Bullet bulletPref;
    [SerializeField] private PlayerShooter playerShooter;
    private IPool<Bullet> _bulletPool;
    private const int _startPool = 10;

    private void Awake()
    {
        _bulletPool=new Pool<Bullet>(_startPool, bulletPref);
        if (playerShooter != null && _bulletPool != null)
        {
            playerShooter.Construct(_bulletPool);
        }
        else
        {
            Debug.LogError("PlayerShooter or BulletPool is not assigned in Bootka");
        }
        playerShooter.Shoot();
    }
}
