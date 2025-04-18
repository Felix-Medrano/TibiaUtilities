﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

using Tibia_Utilities.Lib;

namespace Tibia_Utilities.CustomControls
{
  public enum ScrollDirection
  {
    Up = -1,
    Stop = 0,
    Down = 1
  }

  public partial class TibiaVScrollBar : UserControl
  {
    private bool isDragging = false;
    private int mouseOffsetY;

    private int _step = 10;

    // Timer para el "keep pressed"
    private Timer scrollTimer = new Timer();
    private int currentScrollDirection = 0; // 1 para abajo, -1 para arriba, 0 para detenido

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new int Width
    {
      get => 16;
      set { /* Ignorar cambios */ }
    }

    [Browsable(true)]
    public int Step
    {
      get => _step;
      set => _step = value;
    }

    public TUPanel ViewContainer { get; set; }
    public TUPanel ViewPort { get; set; }

    public TibiaVScrollBar()
    {
      InitializeComponent();
      DoubleBuffered = true;

      scrollTimer.Interval = 100;
      scrollTimer.Tick += ScrollTimer_Tick;

      up.MouseDown += UpButton_MouseDown;
      up.MouseUp += Button_MouseUp;
      down.MouseDown += DownButton_MouseDown;
      down.MouseUp += Button_MouseUp;

      thumb.MouseDown += Thumb_MouseDown;
      thumb.MouseMove += Thumb_MouseMove;
      thumb.MouseUp += Thumb_MouseUp;
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);
      if (base.Width != 16) base.Width = 16;

      up.Top = 0;
      track.Height = Height;
      down.Top = Height - down.Height;
      UpdateThumbHeight();
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
      if (ViewContainer.Height <= ViewPort.Height) return;

      base.OnMouseWheel(e);

      MoveThumbByWheel(e.Delta);
    }

    public void MoveThumbByWheel(int delta)
    {
      switch (delta)
      {
        case > 0:
          MoveThumbByClick(-_step);
          break;
        case < 0:
          MoveThumbByClick(_step);
          break;
        case 0:
          break;
      }
    }

    private void UpButton_MouseDown(object sender, MouseEventArgs e)
    {
      if (ViewContainer.Height <= ViewPort.Height) return;

      StartScroll((int)ScrollDirection.Up); // Mover hacia arriba
      Helper.Sounds.PlayPressButtonSound();
    }

    private void DownButton_MouseDown(object sender, MouseEventArgs e)
    {
      if (ViewContainer.Height <= ViewPort.Height) return;

      StartScroll((int)ScrollDirection.Down); // Mover hacia abajo
      Helper.Sounds.PlayPressButtonSound();
    }

    private void Button_MouseUp(object sender, MouseEventArgs e)
    {

      if (ViewContainer.Height <= ViewPort.Height) return;
      StopScroll((int)ScrollDirection.Stop); // Detener el desplazamiento
      Helper.Sounds.PlayReleaseButtonSound();
    }

    private void Thumb_MouseDown(object sender, MouseEventArgs e)
    {
      if ((thumb.Height >= Height - (up.Height + down.Height)) ||
          (ViewContainer.Height <= ViewPort.Height))
        return;

      if (e.Button == MouseButtons.Left)
      {
        isDragging = true;
        mouseOffsetY = e.Y;
      }
    }

    private void Thumb_MouseMove(object sender, MouseEventArgs e)
    {
      if (ViewContainer.Height <= ViewPort.Height) return;

      if (isDragging)
      {
        int newY = Math.Max(16, Math.Min(Height - thumb.Height - 16, thumb.Top + e.Y - mouseOffsetY));
        thumb.Top = newY;

        Update();
        Invalidate(thumb.Bounds);

        UpdateViewPort();
      }
    }

    private void Thumb_MouseUp(object sender, MouseEventArgs e)
    {
      isDragging = false;
    }

    private void ScrollTimer_Tick(object sender, EventArgs e)
    {
      if (currentScrollDirection != 0)
      {
        MoveThumbByClick(currentScrollDirection * _step);
      }
    }

    private void StartScroll(int direction)
    {
      currentScrollDirection = direction;

      // Aplicar el primer paso inmediatamente
      MoveThumbByClick(currentScrollDirection * _step);

      // Iniciar el Timer después de un retraso inicial
      scrollTimer.Stop(); // Asegurarse de que el Timer esté detenido
      scrollTimer.Start();
    }

    private void StopScroll(int direction)
    {
      currentScrollDirection = direction; // Detener el desplazamiento
      scrollTimer.Stop(); // Detener el Timer
    }

    private void MoveThumbByClick(int step)
    {
      // Calcular la nueva posición del thumb
      int newY = Math.Max(up.Height, Math.Min(Height - thumb.Height - down.Height, thumb.Top + step));

      // Si no hay cambio en la posición, salir
      if (newY == thumb.Top) return;

      // Actualizar la posición del thumb
      thumb.Top = newY;

      Update();
      Invalidate(thumb.Bounds);
      UpdateViewPort();
    }

    private void UpdateViewPort()
    {
      if (ViewContainer == null || ViewPort == null) return;

      double percent = (double)(thumb.Top - up.Height) / (Height - thumb.Height - up.Height - down.Height);
      int maxScroll = ViewPort.Height - ViewContainer.Height;
      ViewContainer.Top = (int)(percent * maxScroll);

      // Asegurarse de que el contenedor no se desplace más allá del límite superior
      if (ViewContainer.Top > 0)
      {
        ViewContainer.Top = 0;
      }

      // Asegurarse de que el contenedor no se desplace más allá del límite inferior
      if (thumb.Top + thumb.Height >= track.Height - down.Height)
      {
        ViewContainer.Top = Math.Min(0, ViewPort.Height - ViewContainer.Height);
      }

      ViewContainer.Update();
    }

    public void UpdateThumbHeight()
    {
      if (ViewContainer == null || ViewPort == null)
        return;

      Visible = ViewContainer.Height > ViewPort.Height;

      if (!Visible)
      {
        ViewContainer.Top = 0;
      }

      int availableHeight = Height - (up.Height + down.Height);

      if (ViewPort.Height >= ViewContainer.Height)
      {
        thumb.Height = availableHeight;
        thumb.Top = 16;
      }
      else
      {
        double percentVisible = (double)ViewPort.Height / ViewContainer.Height;
        thumb.Height = (int)Math.Max(availableHeight * percentVisible, 47);
      }

      UpdateThumbPosition();

      // Ajustar la posición del contenedor si el thumb está al final del track
      if (thumb.Top + thumb.Height >= track.Height - down.Height)
      {
        ViewContainer.Top = Math.Min(0, ViewPort.Height - ViewContainer.Height);
      }
    }

    private void UpdateThumbPosition()
    {
      if (ViewContainer == null || ViewPort == null) return;


      double percent = (double)ViewContainer.Top / (ViewPort.Height - ViewContainer.Height);
      thumb.Top = up.Height + (int)(percent * (track.Height - thumb.Height - up.Height - down.Height));

      thumb.Top = Math.Max(up.Height, Math.Min(track.Height - thumb.Height - down.Height, thumb.Top));
    }
  }
}
