using System.Windows.Forms;

using Tibia_Utilities.CustomControls;
using Tibia_Utilities.Interfaces.Panels;

namespace Tibia_Utilities.Views.Panels
{
  public partial class Equipment : Form, IViewPanel
  {

    public Equipment()
    {
      InitializeComponent();
    }

    public void SetViewPanel(TUPanel panel)
    {
      panel.Controls.Clear();
      panel.Controls.Add(viewPanel);
    }
  }
}
