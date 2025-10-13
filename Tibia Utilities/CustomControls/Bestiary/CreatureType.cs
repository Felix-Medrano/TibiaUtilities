using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.Lib;

namespace Tibia_Utilities.CustomControls.Bestiary
{
  public partial class CreatureType : UserControl
  {
    public CreatureType()
    {
      DoubleBuffered = true;
      SetStyle(ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.UserPaint, true);
      InitializeComponent();
    }

    public void SetTitle(string title)
    {
      lblType.Text = title;
      lblType.Font = Helper.safeFont8;
      lblType.ForeColor = Helper.HexToColor(TUStrings.Colors.TITLE_TEXT_COLOR);
      lblType.CenterControlToParent();
    }

    public void SetImage(Image image)
    {
      typeBtn.Icon = image;
    }
  }
}
