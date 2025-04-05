using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Tibia_Utilities.Core;
using Tibia_Utilities.Core.HotCuisine;
using Tibia_Utilities.CustomControls;
using Tibia_Utilities.CustomControls.HotCuisine;
using Tibia_Utilities.Interfaces.Panels;
using Tibia_Utilities.Lib;
using Tibia_Utilities.Models.HotCuisine;

namespace Tibia_Utilities.Views.Panels
{
  public partial class HotCuisine : Form, IViewPanel
  {
    private HotCuisineManager _manager = new();

    private ObjectPool<RecipeDataView> _recipeDataViewPool;
    private ObjectPool<MainIngredientRow> _ingredientRowPool;
    private TUPanel cachePanel = new();

    private Dictionary<RecipeModel, int> dicRecipes = new();
    private Dictionary<string, (IngredientModel data, int cant)> dicIngredients = new();

    /// <summary>
    /// Constructor for the HotCuisine class.
    /// </summary>
    public HotCuisine()
    {
      DoubleBuffered = true;

      InitializeComponent();


      //TODO: Aplicar nuevo sistema de cache al resto de paneles

      _recipeDataViewPool = new ObjectPool<RecipeDataView>(14);
      _ingredientRowPool = new ObjectPool<MainIngredientRow>(58);

      addAllBtn.Font =
      removeAllBtn.Font =
      lblAllRecipes.Font =
      lblIngredientOk.Font =
      lblIngredientImg.Font =
      lblIngredientName.Font =
      lblIngredientCant.Font = Helper.safeFont9;

      addAllBtn.ForeColor =
      removeAllBtn.ForeColor =
      lblAllRecipes.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);

      lblIngredientOk.ForeColor =
      lblIngredientImg.ForeColor =
      lblIngredientName.ForeColor =
      lblIngredientCant.ForeColor = Helper.HexToColor(TUStrings.Colors.TITLE_TEXT_COLOR);

      SetDataViews();

      recipePopup1.BringToFront();

      rightScrollBar.UpdateThumbHeight();

      ingredientsContainer.MouseWheel += MouseWheelEvent;
    }

    #region Private Events
    /// <summary>
    /// Handles the mouse wheel event for scrolling the ingredients container.
    /// </summary>
    protected override void OnMouseWheel(MouseEventArgs e)
    {
      base.OnMouseWheel(e);

      rightScrollBar.MoveThumbByWheel(e.Delta);
    }

    /// <summary>
    /// Handles the click event for the add button in the recipe data view.
    /// </summary>
    private void AddBtn_Click(object sender, System.EventArgs e)
    {
      var data = (RecipeDataView)sender;
      var recipe = data.GetRecipe();

      if (dicRecipes.ContainsKey(recipe))
        dicRecipes[recipe]++;
      else
        dicRecipes[recipe] = 1;

      foreach (var ingredient in recipe.Ingredients)
      {
        //int totalCant = ingredient.Cant * dicRecipes[recipe];

        if (dicIngredients.ContainsKey(ingredient.Name))
        {
          var ingredientExist = dicIngredients[ingredient.Name];
          dicIngredients[ingredient.Name] = (ingredientExist.data, ingredientExist.cant + ingredient.Cant);
        }
        else
        {
          dicIngredients.Add(ingredient.Name, (ingredient, ingredient.Cant));
        }
      }

      var sortIngredients = dicIngredients.OrderBy(k => k.Key);

      AddNewIngredientRow(sortIngredients);

      rightScrollBar.UpdateThumbHeight();
    }

    /// <summary>
    /// Handles the click event for the remove button in the recipe data view.
    /// </summary>
    private void RemoveBtn_Click(object sender, System.EventArgs e)
    {
      var data = (RecipeDataView)sender;
      var recipe = data.GetRecipe();

      if (dicRecipes.ContainsKey(recipe))
      {
        dicRecipes[recipe]--;
        if (dicRecipes[recipe] <= 0)
        {
          dicRecipes.Remove(recipe);
        }

        foreach (var ingredient in recipe.Ingredients)
        {
          if (dicIngredients.ContainsKey(ingredient.Name))
          {
            var ingredientExist = dicIngredients[ingredient.Name];
            dicIngredients[ingredient.Name] = (ingredientExist.data, ingredientExist.cant - ingredient.Cant);
            if (dicIngredients[ingredient.Name].cant <= 0)
            {
              dicIngredients.Remove(ingredient.Name);
              List<MainIngredientRow> rowsToRemove = new();
              // Limpiar la fila correspondiente
              foreach (MainIngredientRow row in ingredientsContainer.Controls)
              {
                if (row.GetIngredient().Name == ingredient.Name)
                {
                  rowsToRemove.Add(row);
                  break;
                }
                _ingredientRowPool.AltReturn(rowsToRemove);
              }
            }
          }
        }
      }


      var sortIngredients = dicIngredients.OrderBy(k => k.Key);

      AddNewIngredientRow(sortIngredients);

      if (ingredientsContainer.Controls.Count > 0)
      {
        ingredientsC.Height =
        ingredientsContainer.Height = ingredientsContainer.Controls[ingredientsContainer.Controls.Count - 1].Bottom;
      }
      else if (ingredientsContainer.Controls.Count == 0)
      {
        ingredientsC.Height =
        ingredientsContainer.Height = 0;
      }

      rightScrollBar.UpdateThumbHeight();
    }

    /// <summary>
    /// Handles the mouse enter event for the recipe info.
    /// </summary>
    private void RecipeInfo_MouseEnter(object sender, PictureBox img)
    {
      var data = (RecipeDataView)sender;
      var recipe = data.GetRecipe();
      recipePopup1.SetRecipeData(recipe.Ingredients);

      Point pictureBoxLocation = img.PointToScreen(Point.Empty);
      Point relativeToPanel = recipesPanel.PointToClient(pictureBoxLocation);

      int popupX = relativeToPanel.X + img.Width + 5;
      int popupY = relativeToPanel.Y - recipePopup1.Height;

      popupY = popupY < 0 ? 0 : popupY;

      recipePopup1.Location = new Point(popupX, popupY);
      recipePopup1.Visible = true;
    }

    /// <summary>
    /// Handles the mouse leave event for the recipe info.
    /// </summary>
    private void RecipeInfo_MouseLeave(object sender, PictureBox img)
    {
      recipePopup1.DisposeData();
      recipePopup1.Visible = false;
    }

    /// <summary>
    /// Maneja el evento de entrada del ratón sobre la información de la receta.
    /// </summary>
    private void RecipeEffect_MouseEnter(object sender, PictureBox img)
    {
      var data = (RecipeDataView)sender;
      var recipe = data.GetRecipe();
      recipePopup1.SetEffectData(recipe.Effect);

      Point pictureBoxLocation = img.PointToScreen(Point.Empty);
      Point relativeToPanel = recipesPanel.PointToClient(pictureBoxLocation);

      int popupX = relativeToPanel.X + img.Width + 9;
      int popupY = relativeToPanel.Y - recipePopup1.Height;

      popupY = popupY < 0 ? 0 : popupY;

      recipePopup1.Location = new Point(popupX, popupY);

      recipePopup1.Visible = true;
    }

    /// <summary>
    /// Maneja el evento de salida del ratón sobre la información de la receta.
    /// </summary>
    private void RecipeEffect_MouseLeave(object sender, PictureBox img)
    {
      recipePopup1.DisposeData();
      recipePopup1.Visible = false;
    }

    /// <summary>
    /// Handles the click event for the add all button.
    /// </summary>
    private void addAllBtn_Click(object sender, EventArgs e)
    {
      ingredientsContainer.SuspendLayout();

      foreach (var recipeView in recipesContainer.Controls.OfType<RecipeDataView>())
      {
        var recipe = recipeView.GetRecipe();

        if (dicRecipes.ContainsKey(recipe))
          dicRecipes[recipe]++;
        else
          dicRecipes[recipe] = 1;

        recipeView.SetRecipeCount(dicRecipes[recipe]);

        foreach (var ingredient in recipe.Ingredients)
        {
          if (dicIngredients.ContainsKey(ingredient.Name))
          {
            var ingredientExist = dicIngredients[ingredient.Name];
            dicIngredients[ingredient.Name] = (ingredientExist.data, ingredientExist.cant + ingredient.Cant);
          }
          else
          {
            dicIngredients.Add(ingredient.Name, (ingredient, ingredient.Cant));
          }
        }
      }

      var sortIngredients = dicIngredients.OrderBy(k => k.Key);

      AddNewIngredientRow(sortIngredients);

      ingredientsContainer.ResumeLayout();

      rightScrollBar.UpdateThumbHeight();
    }

    /// <summary>
    /// Handles the mouse wheel event for scrolling the ingredients container.
    /// </summary>
    private void MouseWheelEvent(object sender, MouseEventArgs e)
    {
      OnMouseWheel(e);
    }

    /// <summary>
    /// Handles the click event for the remove all button.
    /// </summary>
    private void removeAllBtn_Click(object sender, EventArgs e)
    {
      ingredientsContainer.SuspendLayout();

      List<MainIngredientRow> rowsToRemove = new();
      foreach (var recipeView in recipesContainer.Controls.OfType<RecipeDataView>())
      {
        var recipe = recipeView.GetRecipe();

        if (dicRecipes.ContainsKey(recipe))
        {
          dicRecipes[recipe]--;
          if (dicRecipes[recipe] <= 0)
          {
            dicRecipes.Remove(recipe);
          }

          recipeView.SetRecipeCount(dicRecipes.ContainsKey(recipe) ? dicRecipes[recipe] : 0);

          foreach (var ingredient in recipe.Ingredients)
          {
            if (dicIngredients.ContainsKey(ingredient.Name))
            {
              var ingredientExist = dicIngredients[ingredient.Name];
              dicIngredients[ingredient.Name] = (ingredientExist.data, ingredientExist.cant - ingredient.Cant);
              if (dicIngredients[ingredient.Name].cant <= 0)
              {
                dicIngredients.Remove(ingredient.Name);
                foreach (MainIngredientRow row in ingredientsContainer.Controls)
                {
                  if (row.GetIngredient().Name == ingredient.Name)
                  {
                    rowsToRemove.Add(row);
                    break;
                  }
                }
              }
            }
          }
        }
      }
      _ingredientRowPool.AltReturn(rowsToRemove);

      var sortIngredients = dicIngredients.OrderBy(k => k.Key);

      AddNewIngredientRow(sortIngredients);

      if (ingredientsContainer.Controls.Count > 0)
      {
        ingredientsC.Height =
        ingredientsContainer.Height = ingredientsContainer.Controls[ingredientsContainer.Controls.Count - 1].Bottom;
      }
      else if (ingredientsContainer.Controls.Count == 0)
      {
        ingredientsC.Height =
        ingredientsContainer.Height = 0;
      }

      ingredientsContainer.ResumeLayout();

      rightScrollBar.UpdateThumbHeight();
    }

    /// <summary>
    /// Handles the click event for the clear button.
    /// </summary>
    private void clearBtn_Click(object sender, EventArgs e)
    {
      ingredientsContainer.SuspendLayout();

      dicRecipes.Clear();
      dicIngredients.Clear();

      List<MainIngredientRow> rowsToRemove = new();
      foreach (MainIngredientRow row in ingredientsContainer.Controls)
      {
        row.DisposeRow();
        rowsToRemove.Add(row);
      }
      _ingredientRowPool.AltReturn(rowsToRemove);
      foreach (var recipeView in recipesContainer.Controls.OfType<RecipeDataView>())
      {
        recipeView.SetRecipeCount(0);
      }

      ingredientsContainer.Controls.Clear();

      ingredientsC.Height =
      ingredientsContainer.Height = 0;

      ingredientsContainer.ResumeLayout();

      rightScrollBar.UpdateThumbHeight();
    }
    #endregion

    #region private methods
    /// <summary>
    /// Adds a new ingredient row to the ingredients container.
    /// </summary>
    private void AddNewIngredientRow(IOrderedEnumerable<KeyValuePair<string, (IngredientModel, int)>> ingredients)
    {
      int index = 0;
      MainIngredientRow row;

      ingredientsContainer.SuspendLayout();

      foreach (var ingredient in ingredients)
      {
        if (index < ingredientsContainer.Controls.Count)
        {
          row = (MainIngredientRow)ingredientsContainer.Controls[index];
        }
        else
        {
          row = _ingredientRowPool.AltGet<MainIngredientRow>();
          ingredientsContainer.Controls.Add(row);
        }

        row.DisposeRow();
        row.SetData(ingredient.Value.Item1);
        row.SetCant(ingredient.Value.Item2);
        //row.ResetCbIngredient();
        index++;
      }

      ingredientsContainer.ResumeLayout();
    }

    /// <summary>
    /// Sets the view panel for the HotCuisine.
    /// </summary>
    /// <param name="panel"> The panel to set.</param>
    public void SetViewPanel(TUPanel panel)
    {
      panel.Controls.Clear();
      panel.Controls.Add(viewPanel);
    }

    /// <summary>
    /// Sets the data views for the recipes.
    /// </summary>
    private void SetDataViews()
    {
      List<RecipeDataView> recipeViews = new();
      foreach (var recipe in _manager.Recipes)
      {
        //var recipeView = (RecipeDataView)cachePanel.Controls[0];
        var recipeView = _recipeDataViewPool.AltGet<RecipeDataView>();
        cachePanel.Controls.Remove(recipeView);
        recipeView.Name = recipe.Key;
        recipeView.SetRecipe(recipe.Value);
        recipeView.AddClick += AddBtn_Click;
        recipeView.RemoveClick += RemoveBtn_Click;
        recipeView.recipeInfoMouseEnter += RecipeInfo_MouseEnter;
        recipeView.recipeInfoMouseLeave += RecipeInfo_MouseLeave;
        recipeView.recipeEffectMouseEnter += RecipeEffect_MouseEnter;
        recipeView.recipeEffectMouseLeave += RecipeEffect_MouseLeave;
        recipeViews.Add(recipeView);
      }

      recipesContainer.Controls.AddRange(recipeViews.ToArray());
    }
    #endregion

    #region public methods
    /// <summary>
    /// Disposes the data in the ingredients container.
    /// </summary>
    public async void DisposeData()
    {
      foreach (Control control in ingredientsContainer.Controls)
      {
        if (control is MainIngredientRow data)
        {
          await _ingredientRowPool.Return(data);
        }
      }

      ingredientsContainer.Controls.Clear();
    }
    #endregion
  }
}
