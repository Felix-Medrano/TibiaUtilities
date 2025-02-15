using System.Windows.Forms;

namespace Tibia_Utilities
{
  public partial class Main : Form
  {
    public Main()
    {
      DoubleBuffered = true;
      InitializeComponent();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
      base.OnPaint(e);
    }
  }
}
