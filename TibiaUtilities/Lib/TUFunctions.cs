using System;
using System.Drawing;
using System.Windows.Forms;

using TibiaUtilities.CustomControls;

using static System.Windows.Forms.Control;

namespace TibiaUtilities.Lib
{
  public class TUFunctions
  {
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
  }
}
