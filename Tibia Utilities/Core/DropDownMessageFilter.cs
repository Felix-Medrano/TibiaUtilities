using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.CustomControls;
using Tibia_Utilities.Lib;

public class DropDownMessageFilter : IMessageFilter
{
  private readonly TibiaComboBox _comboBox;

  public DropDownMessageFilter(TibiaComboBox comboBox)
  {
    _comboBox = comboBox;
  }

  public bool PreFilterMessage(ref Message m)
  {
    if (m.Msg == Win32.N_LBUTTONDOWN || m.Msg == Win32.N_RBUTTONDOWN || m.Msg == Win32.N_RBUTTONUP)
    {
      Point clickPosition = Control.MousePosition;
      if (!_comboBox.Bounds.Contains(_comboBox.Parent.PointToClient(clickPosition)) &&
          !_comboBox.DropDownPanel.Bounds.Contains(_comboBox.Parent.PointToClient(clickPosition)))
      {
        _comboBox.HideDropDown();
        return true;
      }
    }
    return false;
  }
}