using System.Drawing;

using Tibia_Utilities.Interfaces.Panels;

namespace Tibia_Utilities.Models
{
  public class PanelDataModel
  {
    public string ButtonText { get; set; }
    public Image ButtonImage { get; set; }
    public IViewPanel Panel { get; set; }
  }
}
