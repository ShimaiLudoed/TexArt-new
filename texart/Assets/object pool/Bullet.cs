using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IPoolable
{
    [SerializeField] private float speed;
    [SerializeField] private float lifeTime;
    private float _curTime;
    public event Action<IPoolable> OnBulletDisable;

    private void Start()
    {
        _curTime = lifeTime;
    }

    private void Update()
    {
        transform.position = Vector3.forward * (speed * Time.deltaTime);
        
        if (_curTime <= 0)
        {
            Disable();
        }
        else
        {
            _curTime -= Time.deltaTime;
        }
    }
    private  void Disable()
    {
        OnBulletDisable?.Invoke(this);
    }
}
