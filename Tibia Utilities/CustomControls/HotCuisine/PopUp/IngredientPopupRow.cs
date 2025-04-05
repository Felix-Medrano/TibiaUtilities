using System.ComponentModel;
using System.Windows.Forms;

using Tibia_Utilities.Lib;
using Tibia_Utilities.Models.HotCuisine;

namespace Tibia_Utilities.CustomControls.HotCuisine.PopUp
{
  public partial class IngredientPopupRow : UserControl
  {
    private string _ingredientName;

    public IngredientPopupRow()
    {
      DoubleBuffered = true;
      InitializeComponent();

      Dock = DockStyle.Bottom;

      lblName.Font =
      lblCant.Font = Helper.safeFont8;

      lblName.ForeColor =
      lblCant.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);
    }

    public void SetIngredient(IngredientModel ingredient)
    {
      img.Visible = true;
      img.LoadAsync(ingredient.Image);

      _ingredientName =
      lblName.Text = ingredient.Name;

      lblCant.Text = ingredient.Cant.ToString();
    }

    private void RecipeImage_LoadCompleted(object sender, AsyncCompletedEventArgs e)
    {
      var img = (PictureBox)sender;

      if (e.Error != null)
      {
        $"Error loading image [{_ingredientName}]".ConsoleWL();
        img.Visible = false;
        return;
      }

      if (e.Cancelled)
      {
        $"Image loading cancelled[{_ingredientName}]".ConsoleWL();
        return;
      }
    }

    public void DisposeImage()
    {
      //img.Image = null;
      img.Visible = false;
      lblName.Text =
      lblCant.Text = string.Empty;

    }
  }
}
