using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootStrap : MonoBehaviour
{
    [SerializeField] private Bullet BulletPref;
    [SerializeField] private PlayerShooter playerShooter;
    //private BulletPool _bulletPool;
    private IPool<Bullet> _bulletPool;

    private void Start()
    {
       
        //_bulletPool = new(BulletPref);
        _bulletPool=new Pool<Bullet>();
        playerShooter.Construct(_bulletPool);
    }
}
