using System;
using System.Drawing;
using System.Windows.Forms;

using TibiaUtilities.CustomControls;

using static System.Windows.Forms.Control;

namespace TibiaUtilities.Lib
{
  public class TUFunctions
  {
    public enum SliceType
    {
      None,
      NineSlice,
      ThreeSliceVertical,
      ThreeSliceHorizontal
    }

    public Rectangle[] CalculateSlices(Image backgroundImage, SliceType sliceType, int cornerWidth, int cornerHeight)
    {
      if (backgroundImage == null) return null;

      int width = backgroundImage.Width;
      int height = backgroundImage.Height;
      int centerWidth = width - 2 * cornerWidth;
      int centerHeight = height - 2 * cornerHeight;

      Rectangle[] slices;

      switch (sliceType)
      {
        case SliceType.None:
          slices = new Rectangle[1];
          slices[0] = new Rectangle(0, 0, width, height);
          break;

        case SliceType.NineSlice:
          slices = new Rectangle[9];
          // Top-left, Top-center, Top-right
          slices[0] = new Rectangle(0, 0, cornerWidth, cornerHeight);
          slices[1] = new Rectangle(cornerWidth, 0, centerWidth, cornerHeight);
          slices[2] = new Rectangle(width - cornerWidth, 0, cornerWidth, cornerHeight);
          // Middle-left, Middle-center, Middle-right
          slices[3] = new Rectangle(0, cornerHeight, cornerWidth, centerHeight);
          slices[4] = new Rectangle(cornerWidth, cornerHeight, centerWidth, centerHeight);
          slices[5] = new Rectangle(width - cornerWidth, cornerHeight, cornerWidth, centerHeight);
          // Bottom-left, Bottom-center, Bottom-right
          slices[6] = new Rectangle(0, height - cornerHeight, cornerWidth, cornerHeight);
          slices[7] = new Rectangle(cornerWidth, height - cornerHeight, centerWidth, cornerHeight);
          slices[8] = new Rectangle(width - cornerWidth, height - cornerHeight, cornerWidth, cornerHeight);
          break;

        case SliceType.ThreeSliceVertical:
          slices = new Rectangle[3];
          // Top, Middle, Bottom
          slices[0] = new Rectangle(0, 0, width, cornerHeight);
          slices[1] = new Rectangle(0, cornerHeight, width, centerHeight);
          slices[2] = new Rectangle(0, height - cornerHeight, width, cornerHeight);
          break;

        case SliceType.ThreeSliceHorizontal:
          slices = new Rectangle[3];
          // Left, Center, Right
          slices[0] = new Rectangle(0, 0, cornerWidth, height);
          slices[1] = new Rectangle(cornerWidth, 0, centerWidth, height);
          slices[2] = new Rectangle(width - cornerWidth, 0, cornerWidth, height);
          break;

        default:
          throw new ArgumentException("Invalid slice type");
      }

      return slices;
    }

    public void DrawRepeatedSlice(Graphics g, Image image, Rectangle sourceRect, int x, int y, int width, int height)
    {
      for (int i = 0; i < width; i += sourceRect.Width)
      {
        for (int j = 0; j < height; j += sourceRect.Height)
        {
          int drawWidth = Math.Min(sourceRect.Width, width - i);
          int drawHeight = Math.Min(sourceRect.Height, height - j);

          g.DrawImage(image,
              new Rectangle(x + i, y + j, drawWidth, drawHeight),
              new Rectangle(sourceRect.X, sourceRect.Y, drawWidth, drawHeight),
              GraphicsUnit.Pixel);
        }
      }
    }


    public void AlignButtons(ControlCollection controls)
    {
      var nextLoc = 1;
      foreach (Control control in controls)
      {
        if (control is TUMainButton tuBtn)
        {
          tuBtn.Left = nextLoc;
          nextLoc += tuBtn.Width + 1;
        }
      }
    }

    /// <summary>
    /// Convierte el valor Hexadecimal a ARG
    /// </summary>
    /// <param name="hex">Color en Valor Hexadecimal</param>
    /// <returns>Color en valor RGB</returns>
    public Color FromHexColor(string hex)
    {
      // Eliminar el símbolo '#' si está presente
      hex = hex.Replace("#", "");

      // Convertir el hex a un número entero
      int argb = Convert.ToInt32(hex, 16);

      // Extraer los componentes de color
      int r = (argb >> 16) & 0xFF;
      int g = (argb >> 8) & 0xFF;
      int b = argb & 0xFF;

      // Retornar el color
      return Color.FromArgb(r, g, b);
    }

    /// <summary>
    /// Le da el formato de tibia a las cantidades
    /// </summary>
    /// <param name="amount">Cantidad a aplicar formato</param>
    /// <returns></returns>
    public string FormatTibiaMoney(long amount)
    {
      if (amount >= 1_000_000) // Si es 1kk o más
      {
        return (amount / 1_000_000).ToString() + "kk";
      }
      else if (amount >= 1_000) // Si es 1k o más
      {
        return (amount / 1_000).ToString() + "k";
      }
      else
      {
        return amount.ToString(); // Para cantidades menores a 1000
      }
    }
  }
}
