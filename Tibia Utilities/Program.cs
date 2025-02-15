using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tibia_Utilities
{
  internal static class Program
  {

    [DllImport("user32.dll")]
    private static extern bool SetProcessDPIAware();

    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {
      if (Environment.OSVersion.Version.Major >= 6)
      {
        SetProcessDPIAware(); // Habilitar soporte para alta resolución
      }

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Main());
    }
  }
}
