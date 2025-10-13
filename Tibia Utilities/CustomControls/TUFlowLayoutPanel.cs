using System.Windows.Forms;

namespace Tibia_Utilities.CustomControls
{
  internal class TUFlowLayoutPanel : FlowLayoutPanel
  {
    public TUFlowLayoutPanel()
    {
      DoubleBuffered = true;
      SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

      //// Habilitar el doble búfer
      //SetStyle(
      //    ControlStyles.DoubleBuffer |
      //    ControlStyles.UserPaint |
      //    ControlStyles.AllPaintingInWmPaint,
      //    true);

      // Reducir el parpadeo adicional
      UpdateStyles();
    }
  }
}
