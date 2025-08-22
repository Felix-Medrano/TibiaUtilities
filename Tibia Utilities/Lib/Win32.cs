using System;
using System.Runtime.InteropServices;

namespace Tibia_Utilities.Lib
{
  public static class Win32
  {
    // Constantes para los mensajes de Windows
    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;
    public const int WM_MOUSEACTIVATE = 0x0021;
    public const int WM_NCHITTEST = 0x0084;

    // Constantes para WM_MOUSEACTIVATE
    public const int MA_ACTIVATE = 1;
    public const int MA_ACTIVATEANDEAT = 2;
    public const int MA_NOACTIVATE = 3;
    public const int MA_NOACTIVATEANDEAT = 4;

    // Constantes para WM_NCHITTEST
    public const int HTCLIENT = 1; // El clic ocurrió en el área cliente de la ventana
    public const int HTCAPTION = 2; // El clic ocurrió en la barra de título de la ventana
    public const int HTTRANSPARENT = -1; // El clic ocurrió en un control transparente

    //(m.Msg == 0x201 || m.Msg == 0x204 || m.Msg == 0x205)
    public const int N_LBUTTONDOWN = 0X201; //Btn Izquierdo presionado
    public const int N_RBUTTONDOWN = 0X204; //Btn Derecho presionado
    public const int N_RBUTTONUP = 0X205; //Btn Derecho liberado

    // Constantes para ShowWindow
    public const int SW_RESTORE = 9;

    // Importar funciones de User32.dll
    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    [DllImport("user32.dll")]
    public static extern IntPtr SetCapture(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern bool GetCursorPos(out Point lpPoint);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    // Estructura para almacenar coordenadas del cursor
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
      public int X;
      public int Y;
    }
  }
}
