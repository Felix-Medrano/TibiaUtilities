using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TibiaUtilities.Lib
{
  public static class TUMethodExtensions
  {
    //DO_NOTHING
  }

  public static class StringBuilderExtensions
  {
    public static StringBuilder AppendLineWithColor(this StringBuilder sb, string text, Color color)
    {
      sb.AppendLine($"<color={ColorTranslator.ToHtml(color)}>{text}</color>");
      return sb;
    }

    public static StringBuilder AppendWithColor(this StringBuilder sb, string text, Color color)
    {
      sb.Append($"<color={ColorTranslator.ToHtml(color)}>{text}</color>");
      return sb;
    }
  }

  public static class RichTextBoxExtensions
  {
    public static void AppendText(this RichTextBox box, string text, Color color)
    {
      box.SelectionStart = box.TextLength;
      box.SelectionLength = 0;
      box.SelectionColor = color;
      box.AppendText(text);
      box.SelectionColor = box.ForeColor;
    }
  }
}
