using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tibia_Utilities.Core
{
  public class ObjectPool<T> where T : class, new()
  {
    private readonly Stack<T> _pool;

    public ObjectPool(int initialCapacity)
    {
      _pool = new Stack<T>(initialCapacity);
      InitializePool(initialCapacity);
    }

    private async void InitializePool(int initialCapacity)
    {
      await Task.Run(() =>
      {
        for (int i = 0; i < initialCapacity; i++)
        {
          _pool.Push(new T());
        }
      });
    }

    public async Task<T> Get()
    {
      return await Task.Run(() => _pool.Count > 0 ? _pool.Pop() : new T());
    }

    public async Task Return(T obj)
    {
      await Task.Run(() => _pool.Push(obj));
    }
  }
}
