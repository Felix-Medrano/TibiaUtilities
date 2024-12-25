using System.Windows.Forms;

namespace TibiaUtilities.CustomControls
{
  public class TUPanel : Panel
  {
    public TUPanel()
    {
      this.DoubleBuffered = true;
      this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
      this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
      this.SetStyle(ControlStyles.UserPaint, true);
    }
  }
}
