using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tibia_Utilities.CustomControls;
using Tibia_Utilities.Lib;

namespace Tibia_Utilities.Core
{
  public class ObjectPool<T> where T : class, new()
  {
    private readonly Stack<T> _pool;
    private readonly int _capacity;
    private TUPanel cachePanel = new();

    private int AddCant = 0;

    public ObjectPool(int initialCapacity)
    {
      _capacity = initialCapacity;
      _pool = new Stack<T>(initialCapacity);
      PreLoadCache();
    }

    public ObjectPool<T> InitializePool()
    {
      for (int i = 0; i < _capacity; i++)
      {
        _pool.Push(new T());
      }
      return this;
    }

    private void PreLoadCache()
    {
      List<T> list = new();

      //_pool = new Stack<T>(initialCapacity);
      for (int i = 0; i < _capacity; i++)
      {
        T t = new T();
        list.Add(t);
      }

      cachePanel.Controls.AddRange(list.OfType<Control>().ToArray());

      ToString().ConsoleWL();
    }

    //TODO: Simplificar Clase, AltGet, convertirlo a Get, y aplicar cambios a return
    public T AltGet<T>() where T : Control, new()
    {
      if (cachePanel.Controls.Count == 0)
      {
        AddCant++;
        Console.WriteLine($"Control(#{AddCant}) {typeof(T).Name} creado");
        return new T();
      }

      var obj = (T)cachePanel.Controls[0];
      cachePanel.Controls.Remove(obj);
      return obj;
    }

    public void AltReturn<T>(List<T> objs) where T : Control
    {
      cachePanel.Controls.AddRange(objs.ToArray());
#if FAST_DEBUG || DEBUG
      $"{objs.Count} objetos devueltos al pool de {typeof(T).Name}".ConsoleWL();
      ToString().ConsoleWL();
#endif

    }

    public async Task<T> Get()
    {
      return await Task.Run(() => _pool.Count > 0 ? _pool.Pop() : new T());
    }

    public async Task Return(T obj)
    {
      await Task.Run(() => _pool.Push(obj));
    }

    public Array PoolToArray() => _pool.ToArray();

    /// <summary>
    /// Calcula el tamaño(MB) estimado de los objetos en el pool.
    /// </summary>
    public double GetMemoryUsageMB()
    {
      //if (_pool.Count == 0)
      if (cachePanel.Controls.Count == 0)
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

      // Calculamos el peso total de los objetos en el pool
      //long totalSizeBytes = objectSize * _pool.Count;
      long totalSizeBytes = objectSize * cachePanel.Controls.Count;

      // Convertimos y retornamos el valor en MB (1 MB = 1,048,576 bytes)
      return totalSizeBytes / 1048576;
    }

    public override string ToString()
    {
      return $"╔═══{typeof(T).Name} Pool════\n" +
             $"╠═Total Objects: {cachePanel.Controls.Count}\n" +
             $"╠═Init Capacity: {_capacity}\n" +
             $"╠═Estimated Memory Usage: {GetMemoryUsageMB():F2} MB\n" +
             $"╚════════════════════════════\n";
    }
  }
}
