using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.Lib;
using Tibia_Utilities.Models.HotCuisine;

namespace Tibia_Utilities.CustomControls.HotCuisine
{
  public partial class MainIngredientRow : UserControl
  {
    private IngredientModel _ingredient;
    private int currentIngredientCant = 0;

    public MainIngredientRow()
    {
      DoubleBuffered = true;
      InitializeComponent();

      lblName.ForeColor =
      lblCant.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);

      lblName.Font =
      lblCant.Font = Helper.safeFont9;

      pbIcon.LoadCompleted += recipeImage_LoadCompleted;
    }

    private void ShowData()
    {
      lblName.Text = _ingredient.Name;
      lblCant.Text = currentIngredientCant.ToString();
      pbIcon.LoadAsync(_ingredient.Image);
    }

    private void recipeImage_LoadCompleted(object sender, AsyncCompletedEventArgs e)
    {
      var img = (PictureBox)sender;

      if (e.Error != null || e.Cancelled)
      {
        img.Visible = false;
        return;
      }

      pbIcon.Visible = true;
    }

    public void SetData(IngredientModel ingredient)
    {
      Name = ingredient.Name;
      _ingredient = ingredient;
      currentIngredientCant = ingredient.Cant;
      pbIcon.Visible = false;
      ShowData();
    }

    public void SetCant(int cant)
    {
      lblCant.Text = $"{cant}";
    }

    public void RemoveCant(int cant)
    {
      currentIngredientCant -= cant;
      if (currentIngredientCant < 0) currentIngredientCant = 0;
      lblCant.Text = currentIngredientCant.ToString();
    }

    public void DisposeRow()
    {
      _ingredient = null;
      currentIngredientCant = 0;
      lblName.Text = string.Empty;
      lblCant.Text = string.Empty;
      pbIcon.Image = null;
      pbIcon.Visible = false;
      ResetCbIngredient();
    }

    public IngredientModel GetIngredient()
    {
      return _ingredient;
    }

    public void ResetCbIngredient()
    {
      cbIngredientOk.Checked = false;
      cbIngredientOk_CheckedChanged(cbIngredientOk, null);
    }

    private void cbIngredientOk_CheckedChanged(object sender, System.EventArgs e)
    {
      CheckBox check = sender as CheckBox;
      if (check.Checked)
      {
        lblCant.Font =
        lblName.Font = Helper.safeFont9Strike;

        lblCant.ForeColor =
        lblName.ForeColor = Color.Black;
      }
      else
      {
        lblCant.Font =
        lblName.Font = Helper.safeFont9;

        lblName.ForeColor =
        lblCant.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);
      }
    }
  }
}
