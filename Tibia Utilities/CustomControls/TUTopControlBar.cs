using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.Lib;
using Tibia_Utilities.Properties;

namespace Tibia_Utilities.CustomControls
{
  public class TUTopControlBar : Panel
  {
    private Image _originalImage;
    private int _edgeWidth;
    private Image _leftSlice;
    private Image _centerSlice;
    private Image _rightSlice;

    // Propiedad para la imagen original
    [Browsable(true)]
    [Category("Appearance")]
    [Description("La imagen original que se dividirá en tres partes.")]
    public Image OriginalImage
    {
      get => _originalImage;
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof(value), "La imagen no puede ser nula.");

        _originalImage = value;

        SliceAndRedraw(); // Volver a dividir la imagen y redibujar
      }
    }

    // Propiedad para el ancho de las orillas
    [Browsable(true)]
    [Category("Appearance")]
    [Description("El ancho de las orillas izquierda y derecha.")]
    [DefaultValue(20)]
    public int EdgeWidth
    {
      get => _edgeWidth;
      set
      {
        if (value <= 0 || (_originalImage != null && value * 2 >= _originalImage.Width))
          throw new ArgumentException("El ancho de las orillas es inválido.");

        _edgeWidth = value;
        SliceAndRedraw(); // Volver a dividir la imagen y redibujar
      }
    }

    // Constructor
    public TUTopControlBar()
    {
      DoubleBuffered = true; // Doble búfer para evitar el parpadeo
      ResizeRedraw = true; // Redibujar automáticamente al cambiar el tamaño

      // Valor predeterminado para EdgeWidth
      _edgeWidth = 50;
      OriginalImage = Resources.TopBar; // Imagen predeterminada
      Height = _originalImage.Height; // Establecer la altura inicial
    }

    // Método privado para dividir la imagen y redibujar
    private void SliceAndRedraw()
    {
      if (_originalImage == null || _edgeWidth <= 0)
        return;

      // Dividir la imagen usando la función SliceImage
      (_leftSlice, _centerSlice, _rightSlice) = Helper.SliceImage(_originalImage, _edgeWidth);

      // Forzar un redibujado del control
      Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {

      base.OnPaint(e);

      if (_leftSlice == null || _centerSlice == null || _rightSlice == null)
        return;

      Graphics g = e.Graphics;
      int width = ClientSize.Width;
      int height = ClientSize.Height;

      // Dibujar la parte izquierda
      g.DrawImage(_leftSlice, new Rectangle(0, 0, _leftSlice.Width, height));

      // Dibujar la parte central (repetida horizontalmente)
      int centerStartX = _leftSlice.Width;
      int centerWidth = width - (_leftSlice.Width + _rightSlice.Width);
      if (centerWidth > 0)
      {
        int centerX = centerStartX;
        while (centerX < width - _rightSlice.Width)
        {
          g.DrawImage(_centerSlice, new Rectangle(centerX, 0, _centerSlice.Width, height));
          centerX += _centerSlice.Width; // Mover a la siguiente posición
        }
      }

      // Dibujar la parte derecha
      int rightStartX = width - _rightSlice.Width;
      g.DrawImage(_rightSlice, new Rectangle(rightStartX, 0, _rightSlice.Width, height));
    }

    // Liberar recursos
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        _leftSlice?.Dispose();
        _centerSlice?.Dispose();
        _rightSlice?.Dispose();
      }
      base.Dispose(disposing);
    }
  }
}
