using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPool<T>
{
    int Count { get; }
    void InitPool(T prefab);
    bool TryGetFromPool(out T bullet);
    void ReturnToPool(T bullet);
}

public interface IPoolable { }

public class Pool<T> : IPool<T> where T : IPoolable
{
    public int Count => throw new System.NotImplementedException();

    public void InitPool(T prefab)
    {
        throw new System.NotImplementedException();
    }

    public void ReturnToPool(T bullet)
    {
        throw new System.NotImplementedException();
    }

    public bool TryGetFromPool(out T bullet)
    {
        throw new System.NotImplementedException();
    }
}