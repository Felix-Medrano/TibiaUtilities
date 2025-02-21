using System;
using System.Windows.Forms;

namespace Tibia_Utilities.CustomControls
{
  [Serializable]
  public class TUPanel : Panel
  {
    public TUPanel()
    {
      DoubleBuffered = true;
      SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
      SetStyle(ControlStyles.AllPaintingInWmPaint, true);
      SetStyle(ControlStyles.UserPaint, true);
      SetStyle(ControlStyles.ResizeRedraw, true);
    }
  }
}
