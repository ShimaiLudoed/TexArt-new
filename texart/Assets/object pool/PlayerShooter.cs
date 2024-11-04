using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    public IPool<Bullet> _bullka;
    private IPool<Bullet> _bulletPool
    {
        get => _bullka;
        set { _bullka = value; Debug.Log(_bullka+ "убъёт? не должно" ); }
    }

    private void Start()
    {
        Debug.Log(_bulletPool != null ? "Bullet pool initialized" : "Bullet pool is null");
        
    }

    public void Shoot()
    {
        if(_bulletPool.TryGetFromPool(out Bullet bullet))
        {
            bullet.transform.position=firePoint.position;
        }
        Debug.Log("пиу");
    }

    public void Construct(IPool<Bullet> bulletPool)
    {
        _bulletPool = bulletPool;
        Debug.Log("Bullet pool assigned: " + _bulletPool);
    }
}
