using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour, IPoolable
{
    [SerializeField] private Transform firePoint;
    private IPool<Bullet> _bulletPool;

    public void Shoot()
    {
        if(_bulletPool.TryGetFromPool(out Bullet bullet))
        {
            bullet.transform.position=firePoint.position;
        }
    }

    public void Construct(IPool<Bullet> bulletPool)
    {
        _bulletPool = bulletPool;
    }
}
