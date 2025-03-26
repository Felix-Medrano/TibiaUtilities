using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tibia_Utilities.Lib
{
  public static class ExtendedMethods
  {
    /// <summary>
    /// Centra un control dentro de su contenedor padre.
    /// </summary>
    /// <param name="control">El control que se desea centrar.</param>
    public static void CenterControlToParent(this Control control, ContentAlignment alignment = ContentAlignment.MiddleCenter)
    {
      if (control.Parent == null)
        return;

      Padding parentPadding = control.Parent.Padding;

      int x = (control.Parent.ClientSize.Width - control.Width) / 2;
      int y = (control.Parent.ClientSize.Height - control.Height) / 2;

      switch (alignment)
      {
        case ContentAlignment.TopLeft:
          x = parentPadding.Left;
          y = parentPadding.Top;
          break;
        case ContentAlignment.TopCenter:
          x = (control.Parent.ClientSize.Width - control.Width) / 2;
          y = parentPadding.Top;
          break;
        case ContentAlignment.TopRight:
          x = control.Parent.ClientSize.Width - control.Width - parentPadding.Right;
          y = parentPadding.Top;
          break;
        case ContentAlignment.MiddleLeft:
          x = parentPadding.Left;
          y = (control.Parent.ClientSize.Height - control.Height) / 2;
          break;
        case ContentAlignment.MiddleCenter:
          // Ya está calculado por defecto
          break;
        case ContentAlignment.MiddleRight:
          x = control.Parent.ClientSize.Width - control.Width - parentPadding.Right;
          y = (control.Parent.ClientSize.Height - control.Height) / 2;
          break;
        case ContentAlignment.BottomLeft:
          x = parentPadding.Left;
          y = control.Parent.ClientSize.Height - control.Height - parentPadding.Bottom;
          break;
        case ContentAlignment.BottomCenter:
          x = (control.Parent.ClientSize.Width - control.Width) / 2;
          y = control.Parent.ClientSize.Height - control.Height - parentPadding.Bottom;
          break;
        case ContentAlignment.BottomRight:
          x = control.Parent.ClientSize.Width - control.Width - parentPadding.Right;
          y = control.Parent.ClientSize.Height - control.Height - parentPadding.Bottom;
          break;
      }

      // Asegurar que las coordenadas respeten los márgenes internos
      x = Math.Max(x, parentPadding.Left);
      y = Math.Max(y, parentPadding.Top);

      control.Location = new Point(x, y);
    }

    public static void ConsoleWL<T>(this T txt)
    {
      Console.WriteLine(txt);
    }

    public static void Mbox<T>(this T txt)
    {
      MessageBox.Show(txt.ToString());
    }

    /// <summary>
    /// Genera una representación en cadena de un objeto, incluyendo sus propiedades y valores.
    /// </summary>
    /// <typeparam name="T">El tipo del objeto.</typeparam>
    /// <param name="obj">El objeto a representar.</param>
    /// <param name="deep">El nivel de profundidad actual.</param>
    /// <param name="maxDeep">El nivel máximo de profundidad permitido.</param>
    /// <returns>Una cadena que representa el objeto y sus propiedades.</returns>
    public static string DeepInfoToString<T>(this T obj, int deep = 0, int maxDeep = 3) where T : class
    {
      if (obj == null || deep > maxDeep) return "No Data";

      var indent = new string(' ', deep * 2);
      var type = obj.GetType();
      var properties = type.GetProperties();
      var result = $"{indent}{type.Name}:\n";

      foreach (var property in properties)
      {
        object value;
        if (property.GetIndexParameters().Length == 0)
        {
          value = property.GetValue(obj);
        }
        else
        {
          value = "Indexed property cannot be displayed";
        }

        if (value != null && !property.PropertyType.IsPrimitive && property.PropertyType != typeof(string))
        {
          result += value.DeepInfoToString(deep + 1, maxDeep);
        }
        else
        {
          result += $"{indent} -{property.Name}: {value}\n";
        }
      }

      return result;
    }

    /// <summary>
    /// Realiza una copia profunda de un objeto de tipo <see cref="Models.Houses.Houses"/>.
    /// </summary>
    /// <param name="original">El objeto original a copiar.</param>
    /// <returns>Una copia profunda del objeto original.</returns>
    public static Models.Houses.Houses DeepCopy(this Models.Houses.Houses original)
    {
      return new Models.Houses.Houses
      {
        house_list = original.house_list?.Select(h => new Models.Houses.HousesList
        {
          house_id = h.house_id,
          name = h.name,
          rent = h.rent,
          size = h.size,
          auction = h.auction,
          auctioned = h.auctioned,
          rented = h.rented
        }).ToList(),
        guildhall_list = original.guildhall_list?.Select(g => new Models.Houses.GuildhallList
        {
          house_id = g.house_id,
          name = g.name,
          rent = g.rent,
          size = g.size,
          auction = g.auction,
          auctioned = g.auctioned,
          rented = g.rented
        }).ToList(),
        town = original.town,
        world = original.world
      };
    }
  }
}
