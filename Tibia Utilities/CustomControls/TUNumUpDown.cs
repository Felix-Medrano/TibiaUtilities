using System.ComponentModel;
using System.Windows.Forms;

using Tibia_Utilities.Lib;

using static Tibia_Utilities.CustomControls.TUTextBox;

namespace Tibia_Utilities.CustomControls
{
  public partial class TUNumUpDown : UserControl
  {
    private bool _allowNegative = false;

    private int _maximum = 100;
    private int _minimum = 0;
    private int _value = 0;

    // Propiedad TextAlign
    [Browsable(true)]
    [Category("Appearance")]
    [Description("La alineación del texto.")]
    public HorizontalAlignment TextAlign
    {
      get => num.TextAlign;
      set => num.TextAlign = value;
    }

    // Propiedad Maximum
    [Browsable(true)]
    [Category("Appearance")]
    [Description("Valor maximo aceptado.")]
    public int Maximum
    {
      get => _maximum;
      set
      {
        _maximum = value;
        if (_value > value)
          Value = _maximum;
      }
    }

    // Propiedad Minimum
    [Browsable(true)]
    [Category("Appearance")]
    [Description("Valor minimo aceptado.")]
    public int Minimum
    {
      get => _minimum;

      set
      {
        if (value < 0 && !_allowNegative)
          _minimum = 0;
        else
          _minimum = value;

        if (_value < _minimum)
          Value = _minimum;
      }
    }


    // Propiedad Value
    [Browsable(true)]
    [Category("Appearance")]
    [Description("Valor actual.")]
    public int Value
    {
      get => _value;
      set
      {
        if (value > _maximum)
          _value = _maximum;
        else if (value < _minimum)
          _value = _minimum;
        else
          _value = value;

        num.Text = _value.ToString();
      }
    }

    // Propiedad AllowNegative
    [Browsable(true)]
    [Category("Appearance")]
    [Description("Permitir valores negativos.")]
    public bool AllowNegative
    {
      get => _allowNegative;
      set
      {
        _allowNegative = value;
        if (!value && _minimum < 0)
        {
          Minimum = 0;
          if (_value < 0)
            Value = 0;
        }
      }
    }

    //Propiedad TextBoxType
    [Browsable(true)]
    [Category("Appearance")]
    [Description("Tipo de TextBox.")]
    public TextBoxType Type
    {
      get => num.Type;
      set
      {
        num.Type = value;
      }
    }

    public TUNumUpDown()
    {
      InitializeComponent();

      num.Text = "0";

    }

    private void num_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Enter)
      {
        if (int.TryParse(num.Text, out int result))
        {
          Value = result;
        }
        else
        {
          num.Text = _value.ToString();
          "Solo numeros".Mbox();
        }
      }
      else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
      {
        e.Handled = true;
      }
    }

    private void UpBtn_Click(object sender, System.EventArgs e)
    {
      Value++;
    }

    private void DownBtn_Click(object sender, System.EventArgs e)
    {
      Value--;
    }
  }
}
