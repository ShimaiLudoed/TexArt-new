using System;

public interface IPoolable
{
  event Action<IPoolable> OnBulletDisable;
}