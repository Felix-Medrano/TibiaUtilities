using System;
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

    private int scrollAccelerationFactor = 10; // Factor de aceleración para el desplazamiento
    private int minStep = 5; // Mínimo desplazamiento permitido
    private int maxStep = 50; // Máximo desplazamiento permitido

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

    public TUPanel viewPort { get; set; }
    public TUPanel viewContainer { get; set; }

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
      base.OnMouseWheel(e);

      MoveThumbByWheel(e.Delta);
    }

    public void MoveThumbByWheel(int delta)
    {
      // Verificar si el thumb ya ocupa todo el espacio disponible en el track
      if (thumb.Height >= Height - (up.Height + down.Height))
      {
        // No permitir movimiento si el thumb ocupa todo el track
        return;
      }

      scrollAccelerationFactor = (int)viewPort.Height / 10;
      // Calcular el desplazamiento basado en la velocidad de la rueda del ratón (e.Delta)
      int scrollAmount = delta / 120; // Dividir por 120 para normalizar el valor (típico incremento de la rueda)
      int step = Math.Min(maxStep, Math.Max(minStep, Math.Abs(scrollAmount) * scrollAccelerationFactor));

      // Determinar la nueva posición del thumb
      int newY;
      if (delta > 0)
      {
        newY = Math.Max(up.Height, thumb.Top - step); // Mover hacia arriba
      }
      else
      {
        newY = Math.Min(Height - thumb.Height - down.Height, thumb.Top + step); // Mover hacia abajo
      }

      // Actualizar la posición del thumb
      thumb.Top = newY;

      // Actualizar el ViewPort
      Update();
      Invalidate(thumb.Bounds);
      UpdateViewPort();
    }

    private void UpButton_MouseDown(object sender, MouseEventArgs e)
    {
      StartScroll((int)ScrollDirection.Up); // Mover hacia arriba
      Helper.Sounds.PlayPressButtonSound();
    }

    private void DownButton_MouseDown(object sender, MouseEventArgs e)
    {
      StartScroll((int)ScrollDirection.Down); // Mover hacia abajo
      Helper.Sounds.PlayPressButtonSound();
    }

    private void Button_MouseUp(object sender, MouseEventArgs e)
    {
      StopScroll((int)ScrollDirection.Stop); // Detener el desplazamiento
      Helper.Sounds.PlayReleaseButtonSound();
    }

    private void Thumb_MouseDown(object sender, MouseEventArgs e)
    {
      if (thumb.Height >= Height - (up.Height + down.Height)) return;
      if (e.Button == MouseButtons.Left)
      {
        isDragging = true;
        mouseOffsetY = e.Y;
      }
    }

    private void Thumb_MouseMove(object sender, MouseEventArgs e)
    {
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
      if (viewPort == null || viewContainer == null) return;

      double percent = (double)(thumb.Top - up.Height) / (Height - thumb.Height - up.Height - down.Height);
      int maxScroll = viewContainer.Height - viewPort.Height;
      viewPort.Top = (int)(percent * maxScroll);

      viewPort.Update();
    }

    public void UpdateThumbHeight()
    {
      if (viewPort == null || viewContainer == null)
        return;

      int availableHeight = Height - (up.Height + down.Height);

      if (viewContainer.Height >= viewPort.Height)
      {
        thumb.Height = availableHeight;
        thumb.Top = 16;
      }
      else
      {
        double percentVisible = (double)viewPort.Height / viewContainer.Height;
        thumb.Height = (int)Math.Max(availableHeight / percentVisible, 47);
      }

      UpdateThumbPosition();
    }

    private void UpdateThumbPosition()
    {
      if (viewPort == null || viewContainer == null) return;

      double percent = (double)viewPort.Top / (viewContainer.Height - viewPort.Height);
      thumb.Top = up.Height + (int)(percent * (track.Height - thumb.Height - up.Height - down.Height));

      thumb.Top = Math.Max(up.Height, Math.Min(track.Height - thumb.Height - down.Height, thumb.Top));
    }
  }
}
