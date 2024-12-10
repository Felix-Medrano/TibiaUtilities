using System.Drawing;
using System.Windows.Forms;

namespace TibiaUtilities.Interfaces
{
  public interface IPanelView
  {
    Panel GetPanel();
    Image ButtonImage { get; }
  }
}
