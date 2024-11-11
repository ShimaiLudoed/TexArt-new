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
        set { _bullka = value; }
    }

    private void Start()
    {
        Debug.Log(_bulletPool != null );
        
    }

    public void Shoot()
    {
        if(_bulletPool.TryGetFromPool(out Bullet bullet))
        {
            bullet.transform.position=firePoint.position;
            bullet.gameObject.SetActive(true);
        }
        Debug.Log("пиу");
    }

    public void Construct(IPool<Bullet> bulletPool)
    {
        _bulletPool = bulletPool;
    }
}
