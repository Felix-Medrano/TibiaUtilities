using System;
using System.Threading;
using System.Windows.Forms;

using Tibia_Utilities.Lib;

namespace Tibia_Utilities
{
  internal static class Program
  {
    private static Mutex mutex = null;

    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {
      const string appName = "TibiaUtilitiesApp";
      bool createdNew;

      var a = Application.ProductName;
      mutex = new Mutex(true, appName, out createdNew);

      if (!createdNew)
      {
        // Buscar la ventana de la instancia existente
        IntPtr hWnd = Win32.FindWindow(null, Application.ProductName);

        if (hWnd != IntPtr.Zero)
        {
          // Restaurar y activar la ventana de la instancia existente
          Win32.ShowWindow(hWnd, Win32.SW_RESTORE);
          Win32.SetForegroundWindow(hWnd);
        }
        return;
      }

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Main());
    }
  }
}
