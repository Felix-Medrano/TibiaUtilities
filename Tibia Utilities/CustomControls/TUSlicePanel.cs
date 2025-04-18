﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Tibia_Utilities.CustomControls
{
  [Serializable]
  public class TUSlicePanel : Panel
  {
    private Image _originalImage;
    private int _edgeWidth; // Ancho de las orillas (izquierda y derecha)
    private int _edgeHeight; // Alto de las orillas (superior e inferior)

    private Image _topLeftCorner, _topRightCorner, _bottomLeftCorner, _bottomRightCorner; // Esquinas fijas
    private Image _topCenter, _bottomCenter; // Centros horizontales
    private Image _leftCenter, _rightCenter; // Centros verticales
    private Image _center; // Centro expansible

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
        SliceAndRedraw(); // Dividir la imagen y redibujar
      }
    }

    // Propiedad para el ancho de las orillas
    [Browsable(true)]
    [Category("Appearance")]
    [Description("El ancho de las orillas.")]
    [DefaultValue(20)]
    public int EdgeWidth
    {
      get => _edgeWidth;
      set
      {
        if (value < 0)
          throw new ArgumentException("El ancho de las orillas no puede ser negativo.");
        _edgeWidth = value;
        SliceAndRedraw();
      }
    }

    // Propiedad para el alto de las orillas
    [Browsable(true)]
    [Category("Appearance")]
    [Description("El alto de las orillas.")]
    [DefaultValue(20)]
    public int EdgeHeight
    {
      get => _edgeHeight;
      set
      {
        if (value < 0)
          throw new ArgumentException("El alto de las orillas no puede ser negativo.");
        _edgeHeight = value;
        SliceAndRedraw();
      }
    }

    // Constructor
    public TUSlicePanel()
    {
      DoubleBuffered = true; // Doble búfer para evitar el parpadeo

      SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
      SetStyle(ControlStyles.AllPaintingInWmPaint, true);
      SetStyle(ControlStyles.UserPaint, true);
      SetStyle(ControlStyles.ResizeRedraw, true);

      UpdateStyles();

      ResizeRedraw = true; // Redibujar automáticamente al cambiar el tamaño
                           // Valores predeterminados
      EdgeHeight = 20;
      EdgeWidth = 20;
      OriginalImage = Properties.Resources.FramedBackground; // Imagen predeterminada
    }

    // Método privado para dividir la imagen y redibujar
    private void SliceAndRedraw()
    {
      if (_originalImage == null || _edgeWidth < 0 || _edgeHeight < 0)
        return;

      // Si EdgeWidth o EdgeHeight es 0, no realizar el slice
      if (_edgeWidth == 0 || _edgeHeight == 0)
      {
        _topLeftCorner = _topCenter = _topRightCorner =
        _leftCenter = _center = _rightCenter =
        _bottomLeftCorner = _bottomCenter = _bottomRightCorner = null;

        Invalidate();
        return;
      }

      int width = _originalImage.Width;
      int height = _originalImage.Height;

      // Crear rectángulos para cada parte de la matriz 3x3
      Rectangle topLeftRect = new Rectangle(0, 0, _edgeWidth, _edgeHeight); // Esquina superior izquierda
      Rectangle topCenterRect = new Rectangle(_edgeWidth, 0, width - (_edgeWidth * 2), _edgeHeight); // Borde superior central
      Rectangle topRightRect = new Rectangle(width - _edgeWidth, 0, _edgeWidth, _edgeHeight); // Esquina superior derecha

      Rectangle leftCenterRect = new Rectangle(0, _edgeHeight, _edgeWidth, height - (_edgeHeight * 2)); // Borde izquierdo central
      Rectangle centerRect = new Rectangle(_edgeWidth, _edgeHeight, width - (_edgeWidth * 2), height - (_edgeHeight * 2)); // Centro
      Rectangle rightCenterRect = new Rectangle(width - _edgeWidth, _edgeHeight, _edgeWidth, height - (_edgeHeight * 2)); // Borde derecho central

      Rectangle bottomLeftRect = new Rectangle(0, height - _edgeHeight, _edgeWidth, _edgeHeight); // Esquina inferior izquierda
      Rectangle bottomCenterRect = new Rectangle(_edgeWidth, height - _edgeHeight, width - (_edgeWidth * 2), _edgeHeight); // Borde inferior central
      Rectangle bottomRightRect = new Rectangle(width - _edgeWidth, height - _edgeHeight, _edgeWidth, _edgeHeight); // Esquina inferior derecha

      // Extraer las partes usando Bitmap
      using (Bitmap originalBitmap = new Bitmap(_originalImage))
      {
        _topLeftCorner = originalBitmap.Clone(topLeftRect, originalBitmap.PixelFormat);
        _topCenter = originalBitmap.Clone(topCenterRect, originalBitmap.PixelFormat);
        _topRightCorner = originalBitmap.Clone(topRightRect, originalBitmap.PixelFormat);

        _leftCenter = originalBitmap.Clone(leftCenterRect, originalBitmap.PixelFormat);
        _center = originalBitmap.Clone(centerRect, originalBitmap.PixelFormat);
        _rightCenter = originalBitmap.Clone(rightCenterRect, originalBitmap.PixelFormat);

        _bottomLeftCorner = originalBitmap.Clone(bottomLeftRect, originalBitmap.PixelFormat);
        _bottomCenter = originalBitmap.Clone(bottomCenterRect, originalBitmap.PixelFormat);
        _bottomRightCorner = originalBitmap.Clone(bottomRightRect, originalBitmap.PixelFormat);
      }

      // Forzar un redibujado del control
      Invalidate();
    }

    // Sobrescribir OnPaint para dibujar las partes
    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);

      if (_originalImage == null)
        return;

      Graphics g = e.Graphics;
      int width = ClientSize.Width;
      int height = ClientSize.Height;

      // Si EdgeWidth o EdgeHeight es 0, dibujar la imagen completa
      if (_edgeWidth == 0 || _edgeHeight == 0)
      {
        g.DrawImage(_originalImage, new Rectangle(0, 0, width, height));
        Height = _originalImage.Height;
        Width = _originalImage.Width;
        return;
      }

      // Dibujar las esquinas fijas
      g.DrawImage(_topLeftCorner, new Rectangle(0, 0, _edgeWidth, _edgeHeight)); // Esquina superior izquierda
      g.DrawImage(_topRightCorner, new Rectangle(width - _edgeWidth, 0, _edgeWidth, _edgeHeight)); // Esquina superior derecha
      g.DrawImage(_bottomLeftCorner, new Rectangle(0, height - _edgeHeight, _edgeWidth, _edgeHeight)); // Esquina inferior izquierda
      g.DrawImage(_bottomRightCorner, new Rectangle(width - _edgeWidth, height - _edgeHeight, _edgeWidth, _edgeHeight)); // Esquina inferior derecha

      // Dibujar los bordes centrales (repetidos)
      DrawRepeatedImage(g, _topCenter, _edgeWidth, 0, width - (_edgeWidth * 2), _edgeHeight); // Borde superior central
      DrawRepeatedImage(g, _bottomCenter, _edgeWidth, height - _edgeHeight, width - (_edgeWidth * 2), _edgeHeight); // Borde inferior central
      DrawRepeatedImage(g, _leftCenter, 0, _edgeHeight, _edgeWidth, height - (_edgeHeight * 2)); // Borde izquierdo central
      DrawRepeatedImage(g, _rightCenter, width - _edgeWidth, _edgeHeight, _edgeWidth, height - (_edgeHeight * 2)); // Borde derecho central

      // Dibujar el centro expansible (repetido)
      DrawRepeatedImage(g, _center, _edgeWidth, _edgeHeight, width - (_edgeWidth * 2), height - (_edgeHeight * 2));
    }

    // Método auxiliar para dibujar una imagen repetida
    private void DrawRepeatedImage(Graphics g, Image image, int x, int y, int areaWidth, int areaHeight)
    {
      if (image == null) return;

      int imgWidth = image.Width;
      int imgHeight = image.Height;

      for (int posX = x; posX < x + areaWidth; posX += imgWidth)
      {
        for (int posY = y; posY < y + areaHeight; posY += imgHeight)
        {
          int drawWidth = Math.Min(imgWidth, x + areaWidth - posX);
          int drawHeight = Math.Min(imgHeight, y + areaHeight - posY);
          g.DrawImage(image, new Rectangle(posX, posY, drawWidth, drawHeight),
                      new Rectangle(0, 0, drawWidth, drawHeight), GraphicsUnit.Pixel);
        }
      }
    }

    // Liberar recursos
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        _topLeftCorner?.Dispose();
        _topCenter?.Dispose();
        _topRightCorner?.Dispose();
        _leftCenter?.Dispose();
        _center?.Dispose();
        _rightCenter?.Dispose();
        _bottomLeftCorner?.Dispose();
        _bottomCenter?.Dispose();
        _bottomRightCorner?.Dispose();
      }
      base.Dispose(disposing);
    }
  }
}
