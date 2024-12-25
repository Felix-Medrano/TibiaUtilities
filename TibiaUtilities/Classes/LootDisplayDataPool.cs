using System.Collections.Generic;

using TibiaUtilities.CustomControls;

namespace TibiaUtilities.Classes
{
  public class LootDisplayDataPool
  {
    private readonly List<LootDisplayData> pool;
    private readonly int maxPoolSize;

    public LootDisplayDataPool(int size)
    {
      maxPoolSize = size;
      pool = new List<LootDisplayData>(size);
    }

    public LootDisplayData Get()
    {
      if (pool.Count > 0)
      {
        LootDisplayData item = pool[pool.Count - 1];
        pool.RemoveAt(pool.Count - 1);
        return item;
      }
      return new LootDisplayData();
    }

    public void Return(LootDisplayData item)
    {
      if (pool.Count < maxPoolSize)
      {
        item.Reset();
        pool.Add(item);
      }
    }
  }
}
