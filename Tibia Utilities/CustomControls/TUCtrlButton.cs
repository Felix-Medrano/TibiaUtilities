using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tibia_Utilities.CustomControls
{
  public class TUCtrlButton : Button
  {
    private Image _image;
    private bool _isPressed = false;
    private int offset = 1;

    // Propiedad para la imagen
    public new Image Image
    {
      get => _image;
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof(value), "La imagen no puede ser nula.");

        _image = value;

        // Ajustar el tamaño del botón al tamaño de la imagen
        Size = _image.Size;
      }
    }

    // Constructor
    public TUCtrlButton()
    {
      DoubleBuffered = true; // Doble búfer para evitar el parpadeo

      FlatStyle = FlatStyle.Flat; // Estilo plano
      FlatAppearance.BorderSize = 0; // Sin borde
      Cursor = Cursors.Hand; // Cambiar el cursor al pasar sobre el botón

      // Suscribir eventos de mouse
      MouseDown += CtrlButton_MouseDown;
      MouseUp += CtrlButton_MouseUp;
      MouseLeave += CtrlButton_MouseLeave;
    }

    // Evento MouseDown: Simular el efecto de presionar
    private void CtrlButton_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        _isPressed = true;
        Size = new Size(Size.Width - offset, Size.Height - offset); // Reducir tamaño
        Location = new Point(Location.X + offset, Location.Y + offset); // Desplazar offsetpx hacia abajo-derecha
      }
    }

    // Evento MouseUp: Restaurar la posición original
    private void CtrlButton_MouseUp(object sender, MouseEventArgs e)
    {
      if (_isPressed)
      {
        _isPressed = false;
        Size = new Size(Size.Width + offset, Size.Height + offset); // Restaurar tamaño
        Location = new Point(Location.X - offset, Location.Y - offset); // Restaurar posición original

        // Verificar si el cursor sigue dentro del botón antes de activar el evento Click
        if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
        {
          OnClick(EventArgs.Empty); // Activar el evento Click
        }
      }
    }

    // Evento MouseLeave: Restaurar la posición si el cursor sale del botón
    private void CtrlButton_MouseLeave(object sender, EventArgs e)
    {
      if (_isPressed)
      {
        _isPressed = false;
        Location = new Point(Location.X - offset, Location.Y - offset); // Restaurar posición original
      }
    }

    // Sobrescribir OnPaint para dibujar la imagen
    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);

      if (_image != null)
      {
        e.Graphics.DrawImage(_image, new Rectangle(0, 0, Width, Height));
      }

      // Dibujar líneas negras solo si el botón está presionado
      if (_isPressed)
      {
        using (Pen blackPen = new Pen(Color.Black, 1))
        {
          // Línea en el lado izquierdo
          e.Graphics.DrawLine(blackPen, 0, 0, 0, Height);

          // Línea en la parte superior
          e.Graphics.DrawLine(blackPen, 0, 0, Width, 0);
        }
      }
    }
  }
}
