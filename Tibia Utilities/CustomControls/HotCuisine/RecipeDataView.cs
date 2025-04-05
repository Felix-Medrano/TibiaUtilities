using System;
using System.ComponentModel;
using System.Windows.Forms;

using Tibia_Utilities.Core.HotCuisine;
using Tibia_Utilities.Lib;
using Tibia_Utilities.Models.HotCuisine;

namespace Tibia_Utilities.CustomControls.HotCuisine
{
  public partial class RecipeDataView : UserControl
  {
    public event EventHandler AddClick;
    public event EventHandler RemoveClick;
    public event EventHandler<PictureBox> recipeInfoMouseEnter;
    public event EventHandler<PictureBox> recipeInfoMouseLeave;
    public event EventHandler<PictureBox> recipeEffectMouseEnter;
    public event EventHandler<PictureBox> recipeEffectMouseLeave;

    private HotCuisineManager _manager = new();
    private RecipeModel _recipe;

    private int cant = 0;

    private string _recipeName;

    [Browsable(true)]
    [TypeConverter(typeof(RecipeTypeConverter))]
    public string RecipeName
    {
      get => _recipeName;
      set
      {
        _recipeName = value;
        var recipe = _manager.Recipes[_recipeName];
        SetRecipeInfo(recipe);
        Invalidate();
      }
    }

    public RecipeDataView()
    {
      DoubleBuffered = true;
      InitializeComponent();

      recipeImg.MouseEnter += (sender, e) => RecipeInfo_MouseEnter(sender, recipeImg);
      recipeImg.MouseLeave += (sender, e) => RecipeInfo_MouseLeave(sender, recipeImg);
      recipeEffect.MouseEnter += (sender, e) => RecipeEffect_MouseEnter(sender, recipeEffect);
      recipeEffect.MouseLeave += (sender, e) => RecipeEffect_MouseLeave(sender, recipeEffect);
    }

    private void SetRecipeInfo(RecipeModel recipe)
    {
      lblName.Text = recipe.Name;
      recipeImg.Image = recipe.Icon;

      lblName.Font =
      lblCant.Font =
      addBtn.Font =
      removeBtn.Font = Helper.safeFont9;

      lblName.ForeColor =
      addBtn.ForeColor =
      removeBtn.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);

      lblCant.ForeColor = Helper.HexToColor(TUStrings.Colors.EARTHBORN_BUGLE);
    }

    public void SetRecipe(RecipeModel recipe)
    {
      _recipe = recipe;
      SetRecipeInfo(recipe);
    }

    public RecipeModel GetRecipe()
    {
      return _recipe;
    }

    private void addBtn_Click(object sender, EventArgs e)
    {
      AddClick?.Invoke(this, e);
      cant++;
      lblCant.Text = cant.ToString();
    }

    private void removeBtn_Click(object sender, EventArgs e)
    {
      RemoveClick?.Invoke(this, e);
      cant--;
      if (cant < 0) cant = 0;
      lblCant.Text = cant.ToString();
    }

    private void RecipeInfo_MouseEnter(object sender, PictureBox img)
    {
      recipeInfoMouseEnter?.Invoke(this, img);
    }

    private void RecipeInfo_MouseLeave(object sender, PictureBox img)
    {
      recipeInfoMouseLeave?.Invoke(this, img);
    }

    private void RecipeEffect_MouseEnter(object sender, PictureBox img)
    {
      recipeEffectMouseEnter?.Invoke(this, img);
    }

    private void RecipeEffect_MouseLeave(object sender, PictureBox img)
    {
      recipeEffectMouseLeave?.Invoke(this, img);
    }

    public void SetRecipeCount(int count)
    {
      cant = count;
      lblCant.Text = cant.ToString();
    }
  }
}
