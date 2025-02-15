using System;
using System.Drawing;

namespace Tibia_Utilities.Lib
{
  public static class ImageSlicer
  {
    public static (Image left, Image center, Image right) SliceImage(Image originalImage, int edgeWidth)
    {
      if (originalImage == null)
        throw new ArgumentNullException(nameof(originalImage), "La imagen no puede ser nula.");

      int width = originalImage.Width;
      int height = originalImage.Height;

      // Validar que el ancho de las orillas sea menor que la mitad del ancho total
      if (edgeWidth * 2 >= width)
        throw new ArgumentException("El ancho de las orillas es demasiado grande para la imagen.");

      // Crear rectángulos para cada parte
      Rectangle leftRect = new Rectangle(0, 0, edgeWidth, height);
      Rectangle centerRect = new Rectangle(edgeWidth, 0, width - (edgeWidth * 2), height);
      Rectangle rightRect = new Rectangle(width - edgeWidth, 0, edgeWidth, height);

      // Extraer las partes usando Bitmap
      using (Bitmap originalBitmap = new Bitmap(originalImage))
      {
        Bitmap leftSlice = originalBitmap.Clone(leftRect, originalBitmap.PixelFormat);
        Bitmap centerSlice = originalBitmap.Clone(centerRect, originalBitmap.PixelFormat);
        Bitmap rightSlice = originalBitmap.Clone(rightRect, originalBitmap.PixelFormat);

        return (leftSlice, centerSlice, rightSlice);
      }
    }
  }
}
