using System;
using System.Drawing;
using System.Drawing.Text;

namespace Tibia_Utilities.Lib
{
  public static class Helper
  {
    public static Font safeFont8 = FontHelper.GetSafeFont(
                preferredFontName: TUStrings.Fonts.PREFERRED_FONT, // Fuente preferida
                fallbackFontName: TUStrings.Fonts.FLLBACK_FONT,    // Fuente alternativa
                size: 8,
                style: FontStyle.Bold
            );

    public static Font safeFont10 = FontHelper.GetSafeFont(
                preferredFontName: TUStrings.Fonts.PREFERRED_FONT, // Fuente preferida
                fallbackFontName: TUStrings.Fonts.FLLBACK_FONT,    // Fuente alternativa
                size: 10,
                style: FontStyle.Bold
            );

    public static Font safeFont12 = FontHelper.GetSafeFont(
                preferredFontName: TUStrings.Fonts.PREFERRED_FONT, // Fuente preferida
                fallbackFontName: TUStrings.Fonts.FLLBACK_FONT,    // Fuente alternativa
                size: 12,
                style: FontStyle.Bold
            );

    /// <summary>
    /// Divide una imagen en tres partes: izquierda, centro y derecha, basándose en un ancho especificado para las orillas.
    /// </summary>
    /// <param name="originalImage">La imagen original que se dividirá. No puede ser nula.</param>
    /// <param name="edgeWidth">El ancho de las orillas izquierda y derecha. Debe ser menor que la mitad del ancho total de la imagen.</param>
    /// <returns>
    /// Una tupla que contiene tres imágenes:
    /// - left: La parte izquierda de la imagen (fija).
    /// - center: La parte central de la imagen (se puede estirar o repetir).
    /// - right: La parte derecha de la imagen (fija).
    /// </returns>
    /// <exception cref="ArgumentNullException">Se lanza si <paramref name="originalImage"/> es nulo.</exception>
    /// <exception cref="ArgumentException">Se lanza si <paramref name="edgeWidth"/> es demasiado grande para la imagen.</exception>
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

    /// <summary>
    /// Convierte un color en formato hexadecimal a un objeto Color.
    /// </summary>
    /// <param name="hex">El color en formato hexadecimal (#RRGGBB o #AARRGGBB).</param>
    /// <returns>Un objeto Color con el valor ARGB correspondiente.</returns>
    public static Color HexToColor(string hex)
    {
      if (string.IsNullOrEmpty(hex))
        throw new ArgumentNullException(nameof(hex), "El valor hexadecimal no puede ser nulo o vacío.");

      // Eliminar el carácter '#' si está presente
      hex = hex.TrimStart('#');

      // Validar la longitud del valor hexadecimal
      if (hex.Length != 6 && hex.Length != 8)
        throw new ArgumentException("El valor hexadecimal debe tener 6 caracteres (#RRGGBB) o 8 caracteres (#AARRGGBB).", nameof(hex));

      // Convertir el valor hexadecimal a números enteros
      int alpha = 255; // Valor predeterminado para la opacidad (FF)
      int red, green, blue;

      if (hex.Length == 8)
      {
        // Formato #AARRGGBB
        alpha = Convert.ToInt32(hex.Substring(0, 2), 16);
        red = Convert.ToInt32(hex.Substring(2, 2), 16);
        green = Convert.ToInt32(hex.Substring(4, 2), 16);
        blue = Convert.ToInt32(hex.Substring(6, 2), 16);
      }
      else
      {
        // Formato #RRGGBB
        red = Convert.ToInt32(hex.Substring(0, 2), 16);
        green = Convert.ToInt32(hex.Substring(2, 2), 16);
        blue = Convert.ToInt32(hex.Substring(4, 2), 16);
      }

      // Crear y devolver el objeto Color
      return Color.FromArgb(alpha, red, green, blue);
    }

    public static class FontHelper
    {
      /// <summary>
      /// Verifica si una fuente específica está instalada en el sistema.
      /// </summary>
      /// <param name="fontName">El nombre de la fuente a verificar.</param>
      /// <returns>True si la fuente está instalada; False en caso contrario.</returns>
      public static bool IsFontInstalled(string fontName)
      {
        using (InstalledFontCollection fonts = new InstalledFontCollection())
        {
          foreach (FontFamily fontFamily in fonts.Families)
          {
            if (fontFamily.Name.Equals(fontName, StringComparison.OrdinalIgnoreCase))
              return true;
          }
        }
        return false;
      }

      /// <summary>
      /// Obtiene una fuente segura basada en la disponibilidad de la fuente deseada.
      /// </summary>
      /// <param name="preferredFontName">El nombre de la fuente preferida.</param>
      /// <param name="fallbackFontName">El nombre de la fuente alternativa.</param>
      /// <param name="size">El tamaño de la fuente.</param>
      /// <param name="style">El estilo de la fuente.</param>
      /// <returns>Una instancia de Font con la fuente preferida o la alternativa.</returns>
      public static Font GetSafeFont(string preferredFontName, string fallbackFontName, float size, FontStyle style = FontStyle.Regular)
      {
        string fontName = IsFontInstalled(preferredFontName) ? preferredFontName : fallbackFontName;
        return new Font(fontName, size, style);
      }
    }
  }
}
