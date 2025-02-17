using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.Interfaces.Panels;
using Tibia_Utilities.Lib;

using static Tibia_Utilities.Lib.Helper;

namespace Tibia_Utilities.CustomControls
{
  public class TUMainPanelButton : Button
  {
    public enum ButtonState { Unpressed, Pressed, Selected }

    private ButtonState _currentState = ButtonState.Unpressed;
    private Image _unpressedImage;
    private Image _pressedImage;
    private Image _selectedImage;
    private Image _icon;

    [Browsable(true)]
    [Category("Appearance")]
    [Description("Imagen para el estado Unpressed.")]
    public Image UnpressedImage
    {
      get => _unpressedImage;
      set
      {
        _unpressedImage = value ?? throw new ArgumentNullException(nameof(value), "La imagen no puede ser nula.");
        UpdateButtonSizeAndState();
      }
    }

    [Browsable(true)]
    [Category("Appearance")]
    [Description("Imagen para el estado Pressed.")]
    public Image PressedImage
    {
      get => _pressedImage;
      set
      {
        _pressedImage = value ?? throw new ArgumentNullException(nameof(value), "La imagen no puede ser nula.");
        UpdateButtonSizeAndState();
      }
    }

    [Browsable(true)]
    [Category("Appearance")]
    [Description("Imagen para el estado Selected.")]
    public Image SelectedImage
    {
      get => _selectedImage;
      set
      {
        _selectedImage = value ?? throw new ArgumentNullException(nameof(value), "La imagen no puede ser nula.");
        UpdateButtonSizeAndState();
      }
    }

    [Browsable(true)]
    [Category("Appearance")]
    [Description("Ícono que se dibuja en el centro del botón.")]
    public Image Icon
    {
      get => _icon;
      set
      {
        _icon = value;
        Invalidate();
      }
    }

    [Browsable(true)]
    [Category("Appearance")]
    [Description("Texto que se mostrará cuando el botón esté seleccionado.")]
    public string SelectedText { get; set; } = "Seleccionado";

    public ButtonState CurrentState
    {
      get => _currentState;
    }

    public IViewPanel Panel { get; set; }

    public TUMainPanelButton()
    {
      DoubleBuffered = true;
      FlatStyle = FlatStyle.Flat;
      FlatAppearance.BorderSize = 0;
      Text = string.Empty;

      UnpressedImage = Properties.Resources.MainButtonUnpressed;
      PressedImage = Properties.Resources.MainButtonPressed;
      SelectedImage = Properties.Resources.MainButtonSelected;

      Size = UnpressedImage.Size;

      MouseDown += Button_MouseDown;
      MouseUp += Button_MouseUp;
      MouseLeave += Button_MouseLeave;
    }

    private void UpdateButtonSizeAndState()
    {
      if (_unpressedImage != null)
      {
        _currentState = ButtonState.Unpressed;
        Invalidate();
      }
    }

    private void Button_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left && _currentState != ButtonState.Selected)
      {
        _currentState = ButtonState.Pressed;
        Invalidate();
      }
    }

    private void Button_MouseUp(object sender, MouseEventArgs e)
    {
      if (_currentState == ButtonState.Pressed)
      {
        if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
        {
          _currentState = _currentState == ButtonState.Selected ? ButtonState.Unpressed : ButtonState.Selected;
          if (_currentState == ButtonState.Selected)
            OnClick(EventArgs.Empty);
        }
        else
        {
          _currentState = ButtonState.Unpressed;
        }

        Invalidate();
      }
    }

    private void Button_MouseLeave(object sender, EventArgs e)
    {
      if (_currentState == ButtonState.Pressed)
      {
        _currentState = ButtonState.Unpressed;
        Invalidate();
      }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);

      Image backgroundImage = null;

      switch (_currentState)
      {
        case ButtonState.Unpressed:
          backgroundImage = _unpressedImage;
          Size = _unpressedImage.Size;
          break;
        case ButtonState.Pressed:
          backgroundImage = _pressedImage;
          Size = _pressedImage.Size;
          break;
        case ButtonState.Selected:
          backgroundImage = _selectedImage;
          Size = _selectedImage.Size;
          break;
      }

      if (backgroundImage != null)
      {
        e.Graphics.DrawImage(backgroundImage, new Rectangle(0, 0, Width, Height));
      }

      if (_icon != null && _icon.Width > 0 && _icon.Height > 0)
      {
        int offsetX = _currentState == ButtonState.Pressed || _currentState == ButtonState.Selected ? 1 : 0;
        int offsetY = offsetX;

        int centerX = (_unpressedImage.Width - _icon.Width) / 2 + offsetX;
        int centerY = (Height - _icon.Height) / 2 + offsetY;

        e.Graphics.DrawImage(_icon, new Rectangle(centerX, centerY, _icon.Width, _icon.Height));
      }

      if (_currentState == ButtonState.Selected && !string.IsNullOrEmpty(SelectedText))
      {
        // Configurar la fuente
        Font safeFont = FontHelper.GetSafeFont(
                preferredFontName: TUStrings.Fonts.PREFERRED_FONT, // Fuente preferida
                fallbackFontName: TUStrings.Fonts.FLLBACK_FONT,    // Fuente alternativa
                size: 10,
                style: FontStyle.Bold
            );

        SizeF textSize = e.Graphics.MeasureString(SelectedText, safeFont);
        Color textColor = HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);
        int textX = (_icon != null) ? _icon.Width + ((_selectedImage.Width - _icon.Width - (int)textSize.Width) / 2) : (Width - (int)textSize.Width) / 2;
        int textY = (Height - (int)textSize.Height) / 2;

        using (Brush textBrush = new SolidBrush(textColor))
        {
          e.Graphics.DrawString(SelectedText, safeFont, textBrush, textX, textY);
        }
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        _unpressedImage?.Dispose();
        _pressedImage?.Dispose();
        _selectedImage?.Dispose();
        _icon?.Dispose();
      }
      base.Dispose(disposing);
    }

    /// <summary>
    /// Establece si el botón está seleccionado o no.
    /// </summary>
    /// <param name="selected"></param>
    public void SetSelected(bool selected)
    {
      _currentState = selected ? ButtonState.Selected : ButtonState.Unpressed;
      Size = _currentState == ButtonState.Selected ? _selectedImage.Size : _unpressedImage.Size;
      Invalidate();
    }
  }
}
