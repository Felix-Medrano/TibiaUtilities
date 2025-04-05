using System.Collections.Generic;
using System.Drawing;

namespace Tibia_Utilities.Models.HotCuisine
{
  public class RecipeModel
  {
    public string Name { get; set; }
    public Image? Icon { get; set; }
    public string Effect { get; set; }
    public List<IngredientModel> Ingredients { get; set; }
  }
}
