using System.Drawing;

using TibiaUtilities.Lib;

namespace TibiaUtilities.Classes
{
  public class CacheImageGenerator
  {
    private TUFunctions.SliceType sliceType;
    private Rectangle[] slices;

    public CacheImageGenerator() { }

    public void GenerateCacheImage(
      string prefix, Image backgroundImage,
      int cornerWidth, int cornerHeight,
      int width, int height,
      TUFunctions.SliceType sliceType)
    {
      string key = TUHelper.ImageCache.GenerateKey(prefix, width, height);

      if (TUHelper.ImageCache.GetImageFromCache(key) != null) return;

      Bitmap cachedImage = new Bitmap(width, height);
      slices = TUHelper.TUFunctions.CalculateSlices(backgroundImage, sliceType, cornerWidth, cornerHeight);

      using (Graphics g = Graphics.FromImage(cachedImage))
      {
        switch (sliceType)
        {
          case TUFunctions.SliceType.None:
            g.DrawImage(backgroundImage, new Rectangle(0, 0, width, height));
            break;

          case TUFunctions.SliceType.NineSlice:
            // Esquinas inferiores (7 y 9)
            g.DrawImage(backgroundImage, new Rectangle(0, height - cornerHeight, cornerWidth, cornerHeight), slices[6], GraphicsUnit.Pixel);
            g.DrawImage(backgroundImage, new Rectangle(width - cornerWidth, height - cornerHeight, cornerWidth, cornerHeight), slices[8], GraphicsUnit.Pixel);

            // Borde inferior (8)
            TUHelper.TUFunctions.DrawRepeatedSlice(g, backgroundImage, slices[7], cornerWidth, height - cornerHeight, width - 2 * cornerWidth, cornerHeight);

            // Bordes laterales (4 y 6)
            TUHelper.TUFunctions.DrawRepeatedSlice(g, backgroundImage, slices[3], 0, cornerHeight, cornerWidth, height - 2 * cornerHeight);
            TUHelper.TUFunctions.DrawRepeatedSlice(g, backgroundImage, slices[5], width - cornerWidth, cornerHeight, cornerWidth, height - 2 * cornerHeight);

            // Centro (5)
            TUHelper.TUFunctions.DrawRepeatedSlice(g, backgroundImage, slices[4], cornerWidth, cornerHeight, width - 2 * cornerWidth, height - 2 * cornerHeight);

            // Esquinas superiores (1 y 3)
            g.DrawImage(backgroundImage, new Rectangle(0, 0, cornerWidth, cornerHeight), slices[0], GraphicsUnit.Pixel);
            g.DrawImage(backgroundImage, new Rectangle(width - cornerWidth, 0, cornerWidth, cornerHeight), slices[2], GraphicsUnit.Pixel);

            // Borde superior (2)
            TUHelper.TUFunctions.DrawRepeatedSlice(g, backgroundImage, slices[1], cornerWidth, 0, width - 2 * cornerWidth, cornerHeight);
            break;

          case TUFunctions.SliceType.ThreeSliceVertical:
            // Top
            TUHelper.TUFunctions.DrawRepeatedSlice(g, backgroundImage, slices[0], 0, 0, width, cornerHeight);
            // Middle
            TUHelper.TUFunctions.DrawRepeatedSlice(g, backgroundImage, slices[1], 0, cornerHeight, width, height - 2 * cornerHeight);
            // Bottom
            TUHelper.TUFunctions.DrawRepeatedSlice(g, backgroundImage, slices[2], 0, height - cornerHeight, width, cornerHeight);
            break;

          case TUFunctions.SliceType.ThreeSliceHorizontal:
            // Left
            TUHelper.TUFunctions.DrawRepeatedSlice(g, backgroundImage, slices[0], 0, 0, cornerWidth, height);
            // Center
            TUHelper.TUFunctions.DrawRepeatedSlice(g, backgroundImage, slices[1], cornerWidth, 0, width - 2 * cornerWidth, height);
            // Right
            TUHelper.TUFunctions.DrawRepeatedSlice(g, backgroundImage, slices[2], width - cornerWidth, 0, cornerWidth, height);
            break;
        }
      }

      TUHelper.ImageCache.AddImageToCache(key, cachedImage);
    }
  }
}
