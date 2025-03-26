using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tibia_Utilities.Core
{
  public class ObjectPool<T> where T : class, new()
  {
    private readonly Stack<T> _pool;
    private readonly int _capacity;

    public ObjectPool(int initialCapacity)
    {
      _capacity = initialCapacity;
      _pool = new Stack<T>(initialCapacity);
    }

    public ObjectPool<T> InitializePool()
    {
      for (int i = 0; i < _capacity; i++)
      {
        _pool.Push(new T());
      }
      return this;
    }

    public async Task<T> Get()
    {
      return await Task.Run(() => _pool.Count > 0 ? _pool.Pop() : new T());
    }

    public async Task Return(T obj)
    {
      await Task.Run(() => _pool.Push(obj));
    }

    /// <summary>
    /// Calcula el tamaño(MB) estimado de los objetos en el pool.
    /// </summary>
    public double GetMemoryUsageMB()
    {
      if (_pool.Count == 0)
        return 0;

      // Medimos la memoria inicial
      long memoryBefore = GC.GetTotalMemory(true);

      // Creamos un obj temporal
      T tempObject = new T();

      // Forzamos al recolector a calcular la memoria con el nuevo obj
      long memoryAfter = GC.GetTotalMemory(true);

      // Calculamos la diferencia
      long objectSize = memoryAfter - memoryBefore;

      // Si la diferencia es 0, evitamos cálculos incorrectos
      if (objectSize <= 0)
        return 0;

      // Calculamso el peso total de los objetos en el pool
      long totalSizeBytes = objectSize * _pool.Count;

      // Convertimos y retornams el valor en MB (1 MB = 1,048,576 bytes)
      return totalSizeBytes / 1048576;
    }

    public override string ToString()
    {
      return $"===={typeof(T).Name} Pool====\n" +
             $"Total Objects: {_pool.Count}\n" +
             $"Init Capacity: {_capacity}\n" +
             $"Estimated Memory Usage: {GetMemoryUsageMB():F2} MB";
    }
  }
}
