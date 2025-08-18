using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.Lib;

namespace Tibia_Utilities.CustomControls
{
  public partial class TUTextBox : UserControl
  {
    public enum TextBoxType
    {
      Normal,
      Password,
      Numeric
    }

    private Color _textColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);
    private Color _placeholderColor = Helper.HexToColor(TUStrings.Colors.GRAY_SHADOW);
    private string _placeholderText = "Type here...";
    private Font _textFont = Helper.safeFont10;
    private TextBoxType _type = TextBoxType.Normal;

    // Propiedad Text
    [Browsable(true)]
    [Category("Appearance")]
    [Description("El texto del control.")]
    public override string Text
    {
      get => text.Text == _placeholderText ? string.Empty : text.Text;
      set
      {
        if (string.IsNullOrEmpty(value))
        {
          ShowPlaceholder();
        }
        else
        {
          text.Text = value;
          text.ForeColor = _textColor;
        }
      }
    }

    // Propiedad Font
    [Browsable(true)]
    [Category("Appearance")]
    [Description("La fuente del texto.")]
    public override Font Font
    {
      get => text.Font;
      set
      {
        //text.Font = value;
        text.Font = _textFont;
        Height = text.Height + 5;
      }
    }

    // Propiedad ForeColor
    [Browsable(true)]
    [Category("Appearance")]
    [Description("El color del texto.")]
    public override Color ForeColor
    {
      get => text.ForeColor;
      set => text.ForeColor = value;
    }

    // Propiedad TextAlign
    [Browsable(true)]
    [Category("Appearance")]
    [Description("La alineación del texto.")]
    public HorizontalAlignment TextAlign
    {
      get => text.TextAlign;
      set => text.TextAlign = value;
    }

    // Propiedad TextBoxType
    [Browsable(true)]
    [Category("Appearance")]
    [Description("El tipo de TextBox.")]
    public TextBoxType Type
    {
      get => _type;
      set
      {
        _type = value;
        switch (value)
        {
          case TextBoxType.Password:
            text.UseSystemPasswordChar = true;
            break;
          case TextBoxType.Numeric:
            text.KeyPress += text_KeyPress;
            break;
          default:
            text.UseSystemPasswordChar = false;
            text.KeyPress -= text_KeyPress;
            break;
        }
      }
    }

    public TUTextBox()
    {
      InitializeComponent();

      text.GotFocus += RemovePlaceholder;
      text.LostFocus += ShowPlaceholder;

      Height = text.Height + 5;

      ShowPlaceholder();
    }

    private void text_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Enter)
      {
        if (_type == TextBoxType.Numeric && !int.TryParse(text.Text, out _))
        {
          text.Text = string.Empty;
          text.ForeColor = _placeholderColor;
        }
      }
    }

    private void RemovePlaceholder(object sender, EventArgs e)
    {
      if (text.Text == _placeholderText)
      {
        text.Text = string.Empty;
        text.ForeColor = _textColor;
      }
    }

    private void ShowPlaceholder(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(text.Text))
      {
        text.Text = _placeholderText;
        text.ForeColor = _placeholderColor;
      }
    }

    private void ShowPlaceholder()
    {
      if (string.IsNullOrEmpty(text.Text))
      {
        text.Text = _placeholderText;
        text.ForeColor = _placeholderColor;
      }
    }
  }
}
