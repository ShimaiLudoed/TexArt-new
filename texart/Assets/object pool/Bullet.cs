using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IPoolable
{
    [SerializeField] private float speed;
    [SerializeField] private float lifeTime;
    public event Action<Bullet> onBulletDisable;

    private void Update()
    {
        
    }
    //TODO Bullet movement
    //TODO Bullet LifeTime
    private void OnDisable()
    {
        onBulletDisable?.Invoke(this);
    }
}
