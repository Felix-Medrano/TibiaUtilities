﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FloatingStickyNotes.Core
{
  public static class Win32
  {
    public const int HT_CAPTION = 0x2;
    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int WM_SETREDRAW = 0x000B;

    /// <summary>
    /// Muestra la ventana indicada
    /// </summary>
    /// <param name="hWnd">Window Handle</param>
    /// <param name="fUnknow"><see langword="true"/></param>
    [DllImport("user32.dll")]
    public static extern void SwitchToThisWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    [DllImport("user32.dll")]
    public static extern bool SetForegroundWindow(IntPtr hWnd);

    public static void SuspendDrawing(Control parent)
    {
      SendMessage(parent.Handle, WM_SETREDRAW, false, 1);
    }

    public static void ResumeDrawing(Control parent)
    {
      SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
      parent.Refresh();
    }
  }
}
