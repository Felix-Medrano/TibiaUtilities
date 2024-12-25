using System.Collections.Generic;
using System.Drawing;

namespace TibiaUtilities.Core
{
  public class ImageCache
  {
    private Dictionary<string, Image> cache;

    public ImageCache()
    {
      cache = new Dictionary<string, Image>();
    }

    public void AddImageToCache(string key, Image image)
    {
      if (cache.ContainsKey(key))
      {
        cache[key].Dispose();
        cache[key] = image;
      }
      else
      {
        cache.Add(key, image);
      }
    }

    public Image GetImageFromCache(string key)
    {
      if (cache.ContainsKey(key))
      {
        return cache[key];
      }
      return null;
    }

    public void RemoveImageFromCache(string key)
    {
      if (cache.ContainsKey(key))
      {
        cache[key].Dispose();
        cache.Remove(key);
      }
    }

    public void ClearCache()
    {
      foreach (var image in cache.Values)
      {
        image.Dispose();
      }
      cache.Clear();
    }

    public string GenerateKey(string prefix, int width, int height)
    {
      return $"{prefix}{width}x{height}";
    }
  }
}
