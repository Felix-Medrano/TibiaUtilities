using System.Collections.Generic;

namespace Tibia_Utilities.Core
{
  public class ObjectPool<T> where T : class, new()
  {
    private readonly Dictionary<int, T> _pool = new ();

    private int index = 0;
    private int currentOutIndex = 0;

    public ObjectPool(int initialCapacity)
    {

      for (index = 0; index < initialCapacity; index++)
      {
        var obj = new T();
        _pool.Add(index, obj);
      }
    }

    public T Get()
    {
      if (_pool.Count == 0)
      {
        var obj = new T();
        _pool.Add(currentOutIndex, obj);
      }

      var objToGet = _pool[currentOutIndex];
      _pool.Remove(currentOutIndex);
      currentOutIndex++;
      return objToGet;
    }

    public void Return(T obj)
    {
      currentOutIndex--;
      _pool.Add(currentOutIndex, obj);
    }
  }
}
