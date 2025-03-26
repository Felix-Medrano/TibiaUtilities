using System.Windows.Forms;

namespace Tibia_Utilities.CustomControls
{
  public class TULabel : Label
  {
    public TibiaComboBox TibiaComboBox { get; set; }

    public TULabel()
    {
      DoubleBuffered = true;
    }
  }
}
