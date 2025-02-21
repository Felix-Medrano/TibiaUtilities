using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Tibia_Utilities.Lib
{
  public static class ExtendedMethods
  {
    /// <summary>
    /// Centra un control dentro de su contenedor padre.
    /// </summary>
    /// <param name="control">El control que se desea centrar.</param>
    public static void CenterControlToParent(this Control control)
    {
      if (control.Parent == null)
        return;

      // Calcular las coordenadas para centrar el control
      int x = (control.Parent.ClientSize.Width - control.Width) / 2;
      int y = (control.Parent.ClientSize.Height - control.Height) / 2;

      // Asegurarse de que las coordenadas no sean negativas
      x = Math.Max(x, 0);
      y = Math.Max(y, 0);

      // Establecer la nueva ubicación del control
      control.Location = new Point(x, y);
    }

    public static void UnsubscribeAllEvents(this object obj)
    {
      if (obj == null) throw new ArgumentNullException(nameof(obj));

      // Obtener todos los eventos del tipo del objeto
      var events = obj.GetType().GetEvents(BindingFlags.Instance | BindingFlags.Public);

      foreach (var eventInfo in events)
      {
        // Obtener el campo subyacente del evento (el campo de delegado)
        var field = obj.GetType().GetField(eventInfo.Name, BindingFlags.Instance | BindingFlags.NonPublic);

        if (field != null)
        {
          // Limpiar el campo de delegado asignándole null
          field.SetValue(obj, null);
        }
      }
    }
  }
}
