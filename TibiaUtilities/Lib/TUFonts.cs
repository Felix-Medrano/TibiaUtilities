using System.Drawing;

namespace TibiaUtilities.Lib
{
  public class TUFonts
  {
    public Font TextFont { get; internal set; }
    public Color TextColor { get; internal set; }

    public static TUFonts Description = new TUFonts()
    {
      TextFont = new Font("Constantia", 10, FontStyle.Bold),
      TextColor = TUColors.SILVER
    };

    public static TUFonts Title = new TUFonts()
    {
      TextFont = new Font("Constantia", 10, FontStyle.Bold),
      TextColor = TUColors.TV_GRAY
    };

    public static TUFonts Selected = new TUFonts()
    {
      TextFont = new Font("Constantia", 10, FontStyle.Bold),
      TextColor = TUColors.WHITE_SIGNS
    };
  }
}
