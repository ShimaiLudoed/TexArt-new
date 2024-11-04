using System.Collections;

public interface IPool<T>
{
    int Count { get; }
    void InitPool(T prefab);
    bool TryGetFromPool(out T bullet);
    void ReturnToPool(T bullet);

    void Update();
}