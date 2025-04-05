using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.Core;
using Tibia_Utilities.Lib;
using Tibia_Utilities.Models.HotCuisine;

namespace Tibia_Utilities.CustomControls.HotCuisine.PopUp
{
  public enum PopupState
  {
    Ingredient = 0,
    Effect
  }

  public partial class RecipePopup : UserControl
  {
    private ObjectPool<IngredientPopupRow> _ingredientRowPool;
    private PopupState _popupState = PopupState.Ingredient;

    private List<IngredientModel> _recipe;
    private Label lblEffect;

    public RecipePopup()
    {
      DoubleBuffered = true;
      InitializeComponent();

      _ingredientRowPool = new ObjectPool<IngredientPopupRow>(10);

      lblEffect = new Label()
      {
        AutoSize = true,
        MaximumSize = new Size(400, 0),
        Dock = DockStyle.Fill
      };

      viewPort.Controls.Add(lblEffect);

      lblEffect.Font =
      lblCant.Font =
      lblImg.Font =
      lblName.Font = Helper.safeFont8;

      lblEffect.ForeColor =
      lblCant.ForeColor =
      lblImg.ForeColor =
      lblName.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);

      DisposeData();
    }

    private void SetPopupData()
    {
      rowsPanel.SuspendLayout();

      switch (_popupState)
      {
        case PopupState.Ingredient:
          Size = new Size(230, 30);
          tableTopPanel.Visible =
          rowsPanel.Visible = true;
          foreach (var ingredient in _recipe)
          {
            var row = _ingredientRowPool.AltGet<IngredientPopupRow>();
            row.SetIngredient(ingredient);
            rowsPanel.Controls.Add(row);
          }
          break;
        case PopupState.Effect:
          lblEffect.Visible = true;
          Size = lblEffect.Size;
          break;
        default:
          break;
      }
      rowsPanel.PerformLayout();
      rowsPanel.ResumeLayout();
    }

    public void SetRecipeData(List<IngredientModel> recipe)
    {
      _recipe = recipe;
      _popupState = PopupState.Ingredient;
      SetPopupData();
    }

    public void SetEffectData(string effect)
    {
      lblEffect.Text = effect;
      _popupState = PopupState.Effect;
      SetPopupData();
    }

    public void DisposeData()
    {
      List<IngredientPopupRow> rows = new();
      int index = 0;
      while (index < rowsPanel.Controls.Count)
      {
        var row = (IngredientPopupRow)rowsPanel.Controls[index];
        row.DisposeImage();
        rows.Add(row);
        index++;
      }
      _ingredientRowPool.AltReturn(rows);
      rowsPanel.Controls.Clear();
      Height = 30;
      rowsPanel.Height = 0;

      lblEffect.Visible =
      rowsPanel.Visible =
      tableTopPanel.Visible = false;
    }
  }
}
