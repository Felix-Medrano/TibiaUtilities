using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tibia_Utilities.Lib
{
  public class NaturalOrderComparer : IComparer<string>
  {
    public int Compare(string x, string y)
    {
      if (x == y) return 0;
      if (x == null) return -1;
      if (y == null) return 1;

      var regex = new Regex(@"(\d+|\D+)");
      var xParts = regex.Matches(x);
      var yParts = regex.Matches(y);

      for (int i = 0; i < Math.Min(xParts.Count, yParts.Count); i++)
      {
        var xPart = xParts[i].Value;
        var yPart = yParts[i].Value;

        int result;
        if (int.TryParse(xPart, out int xNum) && int.TryParse(yPart, out int yNum))
        {
          result = xNum.CompareTo(yNum);
        }
        else
        {
          result = string.Compare(xPart, yPart, StringComparison.Ordinal);
        }

        if (result != 0)
        {
          return result;
        }
      }

      return xParts.Count.CompareTo(yParts.Count);
    }
  }
}
