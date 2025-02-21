using System.Collections.Generic;

namespace Tibia_Utilities.Core
{
  public class ObjectPool<T> where T : class, new()
  {
    private readonly Stack<T> _pool;

    public ObjectPool(int initialCapacity)
    {
      _pool = new Stack<T>(initialCapacity);
    }

    public T Get()
    {
      return _pool.Count > 0 ? _pool.Pop() : new T();
    }

    public void Return(T obj)
    {
      _pool.Push(obj);
    }
  }
}
