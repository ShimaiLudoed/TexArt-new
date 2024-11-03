using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool 
{
    private readonly Queue<Bullet> _pool = new();
    private const int _startPoolSlize = 10;

    public BulletPool(Bullet bulletPref)
    {
        InitPool(bulletPref);
    }
    public bool TryGetFromPool(out Bullet bullet)
    {
        return _pool.TryDequeue(out bullet);
    }
    public void ReturnToPool(Bullet bullet)
    {
        _pool.Enqueue(bullet);
    }

    private void InitPool(Bullet bulletPref)
    {
        for(int i=0; i < _startPoolSlize; i++)
        {
            Bullet bulletInit = MonoBehaviour.Instantiate(bulletPref);
            bulletInit.onBulletDisable += ReturnToPool;
            ReturnToPool(bulletInit);
        }
    }
}
