using System;
using System.Runtime.InteropServices;

namespace Tibia_Utilities.Lib
{
  public static class Win32
  {
    // Constantes para los mensajes de Windows
    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;

    // Importar funciones de User32.dll
    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

  }
}
