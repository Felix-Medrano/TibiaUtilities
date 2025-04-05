using System.Windows.Forms;

namespace Tibia_Utilities.CustomControls
{
  internal class TUFlowLayoutPanel : FlowLayoutPanel
  {
    public TUFlowLayoutPanel()
    {
      // Habilitar el doble búfer
      SetStyle(
          ControlStyles.DoubleBuffer |
          ControlStyles.UserPaint |
          ControlStyles.AllPaintingInWmPaint,
          true);

      // Reducir el parpadeo adicional
      UpdateStyles();
    }
  }
}
