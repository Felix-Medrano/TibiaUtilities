using TibiaUtilities.Core;

namespace TibiaUtilities.Lib
{
  public static class TUHelper
  {
    private static TUData _tuData;
    private static TUFunctions _tuFunctions;
    private static ImageCache _imageCache;

    public static TUData TUData
    {
      get
      {
        if (_tuData == null)
        {
          _tuData = new TUData();
        }
        return _tuData;
      }
    }

    public static TUFunctions TUFunctions
    {
      get
      {
        if (_tuFunctions == null)
        {
          _tuFunctions = new TUFunctions();
        }
        return _tuFunctions;
      }
    }

    public static ImageCache ImageCache
    {
      get
      {
        if (_imageCache == null)
        {
          _imageCache = new ImageCache();
        }
        return _imageCache;
      }
    }

    public static void Initialize()
    {
      // La inicialización ahora es perezosa, no necesitamos hacer nada aquí
    }
  }
}
