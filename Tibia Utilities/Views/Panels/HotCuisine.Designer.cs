namespace Tibia_Utilities.Views.Panels
{
  partial class HotCuisine
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.viewPanel = new Tibia_Utilities.CustomControls.TUPanel();
      this.mainViewPort = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.IngredientsPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.ingredientsViewPort = new Tibia_Utilities.CustomControls.TUPanel();
      this.rightScrollBar = new Tibia_Utilities.CustomControls.TibiaVScrollBar();
      this.ingredientsC = new Tibia_Utilities.CustomControls.TUPanel();
      this.ingredientsContainer = new Tibia_Utilities.CustomControls.TUFlowLayoutPanel();
      this.ingredientsTopPanel = new Tibia_Utilities.CustomControls.TUPanel();
      this.tuSlicePanel5 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblIngredientOk = new System.Windows.Forms.Label();
      this.tuSlicePanel3 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblIngredientCant = new System.Windows.Forms.Label();
      this.tuSlicePanel4 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.tuSlicePanel1 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblIngredientName = new System.Windows.Forms.Label();
      this.tuSlicePanel2 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblIngredientImg = new System.Windows.Forms.Label();
      this.recipesPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.recipesContainer = new Tibia_Utilities.CustomControls.TUFlowLayoutPanel();
      this.allRecipesPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.clearBtn = new Tibia_Utilities.CustomControls.TUSliceButton();
      this.removeAllBtn = new Tibia_Utilities.CustomControls.TUSliceButton();
      this.allRecipesViewPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblAllRecipes = new Tibia_Utilities.CustomControls.TULabel();
      this.addAllBtn = new Tibia_Utilities.CustomControls.TUSliceButton();
      this.recipePopup1 = new Tibia_Utilities.CustomControls.HotCuisine.PopUp.RecipePopup();
      this.viewPanel.SuspendLayout();
      this.mainViewPort.SuspendLayout();
      this.IngredientsPanel.SuspendLayout();
      this.ingredientsViewPort.SuspendLayout();
      this.ingredientsC.SuspendLayout();
      this.ingredientsTopPanel.SuspendLayout();
      this.tuSlicePanel5.SuspendLayout();
      this.tuSlicePanel3.SuspendLayout();
      this.tuSlicePanel1.SuspendLayout();
      this.tuSlicePanel2.SuspendLayout();
      this.recipesPanel.SuspendLayout();
      this.allRecipesPanel.SuspendLayout();
      this.allRecipesViewPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // viewPanel
      // 
      this.viewPanel.Controls.Add(this.mainViewPort);
      this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPanel.Location = new System.Drawing.Point(0, 0);
      this.viewPanel.Name = "viewPanel";
      this.viewPanel.Size = new System.Drawing.Size(764, 475);
      this.viewPanel.TabIndex = 0;
      // 
      // mainViewPort
      // 
      this.mainViewPort.Controls.Add(this.IngredientsPanel);
      this.mainViewPort.Controls.Add(this.recipesPanel);
      this.mainViewPort.Controls.Add(this.recipePopup1);
      this.mainViewPort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainViewPort.Location = new System.Drawing.Point(0, 0);
      this.mainViewPort.Name = "mainViewPort";
      this.mainViewPort.OriginalImage = global::Tibia_Utilities.Properties.Resources.TextureBackground;
      this.mainViewPort.Size = new System.Drawing.Size(764, 475);
      this.mainViewPort.TabIndex = 0;
      // 
      // IngredientsPanel
      // 
      this.IngredientsPanel.Controls.Add(this.ingredientsViewPort);
      this.IngredientsPanel.Controls.Add(this.ingredientsTopPanel);
      this.IngredientsPanel.Location = new System.Drawing.Point(399, 0);
      this.IngredientsPanel.Name = "IngredientsPanel";
      this.IngredientsPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.FramedBackground;
      this.IngredientsPanel.Padding = new System.Windows.Forms.Padding(5, 4, 4, 4);
      this.IngredientsPanel.Size = new System.Drawing.Size(365, 475);
      this.IngredientsPanel.TabIndex = 1;
      // 
      // ingredientsViewPort
      // 
      this.ingredientsViewPort.BackColor = System.Drawing.Color.Transparent;
      this.ingredientsViewPort.Controls.Add(this.rightScrollBar);
      this.ingredientsViewPort.Controls.Add(this.ingredientsC);
      this.ingredientsViewPort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ingredientsViewPort.Location = new System.Drawing.Point(5, 24);
      this.ingredientsViewPort.Name = "ingredientsViewPort";
      this.ingredientsViewPort.Size = new System.Drawing.Size(356, 447);
      this.ingredientsViewPort.TabIndex = 2;
      // 
      // rightScrollBar
      // 
      this.rightScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
      this.rightScrollBar.Location = new System.Drawing.Point(340, 0);
      this.rightScrollBar.Name = "rightScrollBar";
      this.rightScrollBar.Size = new System.Drawing.Size(16, 447);
      this.rightScrollBar.Step = 10;
      this.rightScrollBar.TabIndex = 2;
      this.rightScrollBar.ViewContainer = this.ingredientsC;
      this.rightScrollBar.ViewPort = this.ingredientsViewPort;
      // 
      // ingredientsC
      // 
      this.ingredientsC.AutoSize = true;
      this.ingredientsC.Controls.Add(this.ingredientsContainer);
      this.ingredientsC.Location = new System.Drawing.Point(0, 0);
      this.ingredientsC.Name = "ingredientsC";
      this.ingredientsC.Size = new System.Drawing.Size(340, 0);
      this.ingredientsC.TabIndex = 1;
      // 
      // ingredientsContainer
      // 
      this.ingredientsContainer.AutoSize = true;
      this.ingredientsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ingredientsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.ingredientsContainer.Location = new System.Drawing.Point(0, 0);
      this.ingredientsContainer.Name = "ingredientsContainer";
      this.ingredientsContainer.Size = new System.Drawing.Size(340, 0);
      this.ingredientsContainer.TabIndex = 0;
      this.ingredientsContainer.WrapContents = false;
      // 
      // ingredientsTopPanel
      // 
      this.ingredientsTopPanel.BackColor = System.Drawing.Color.Transparent;
      this.ingredientsTopPanel.Controls.Add(this.tuSlicePanel5);
      this.ingredientsTopPanel.Controls.Add(this.tuSlicePanel3);
      this.ingredientsTopPanel.Controls.Add(this.tuSlicePanel4);
      this.ingredientsTopPanel.Controls.Add(this.tuSlicePanel1);
      this.ingredientsTopPanel.Controls.Add(this.tuSlicePanel2);
      this.ingredientsTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.ingredientsTopPanel.Location = new System.Drawing.Point(5, 4);
      this.ingredientsTopPanel.Name = "ingredientsTopPanel";
      this.ingredientsTopPanel.Size = new System.Drawing.Size(356, 20);
      this.ingredientsTopPanel.TabIndex = 3;
      // 
      // tuSlicePanel5
      // 
      this.tuSlicePanel5.Controls.Add(this.lblIngredientOk);
      this.tuSlicePanel5.Dock = System.Windows.Forms.DockStyle.Left;
      this.tuSlicePanel5.Location = new System.Drawing.Point(308, 0);
      this.tuSlicePanel5.Margin = new System.Windows.Forms.Padding(0);
      this.tuSlicePanel5.Name = "tuSlicePanel5";
      this.tuSlicePanel5.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.tuSlicePanel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
      this.tuSlicePanel5.Size = new System.Drawing.Size(32, 20);
      this.tuSlicePanel5.TabIndex = 14;
      // 
      // lblIngredientOk
      // 
      this.lblIngredientOk.BackColor = System.Drawing.Color.Transparent;
      this.lblIngredientOk.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblIngredientOk.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblIngredientOk.Location = new System.Drawing.Point(0, 0);
      this.lblIngredientOk.Margin = new System.Windows.Forms.Padding(0);
      this.lblIngredientOk.Name = "lblIngredientOk";
      this.lblIngredientOk.Size = new System.Drawing.Size(32, 18);
      this.lblIngredientOk.TabIndex = 0;
      this.lblIngredientOk.Text = "Ok";
      this.lblIngredientOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tuSlicePanel3
      // 
      this.tuSlicePanel3.Controls.Add(this.lblIngredientCant);
      this.tuSlicePanel3.Dock = System.Windows.Forms.DockStyle.Left;
      this.tuSlicePanel3.Location = new System.Drawing.Point(225, 0);
      this.tuSlicePanel3.Margin = new System.Windows.Forms.Padding(0);
      this.tuSlicePanel3.Name = "tuSlicePanel3";
      this.tuSlicePanel3.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.tuSlicePanel3.Size = new System.Drawing.Size(83, 20);
      this.tuSlicePanel3.TabIndex = 13;
      // 
      // lblIngredientCant
      // 
      this.lblIngredientCant.BackColor = System.Drawing.Color.Transparent;
      this.lblIngredientCant.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblIngredientCant.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblIngredientCant.Location = new System.Drawing.Point(0, 0);
      this.lblIngredientCant.Margin = new System.Windows.Forms.Padding(0);
      this.lblIngredientCant.Name = "lblIngredientCant";
      this.lblIngredientCant.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
      this.lblIngredientCant.Size = new System.Drawing.Size(83, 20);
      this.lblIngredientCant.TabIndex = 0;
      this.lblIngredientCant.Text = "Cant";
      this.lblIngredientCant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tuSlicePanel4
      // 
      this.tuSlicePanel4.Dock = System.Windows.Forms.DockStyle.Right;
      this.tuSlicePanel4.Location = new System.Drawing.Point(340, 0);
      this.tuSlicePanel4.Margin = new System.Windows.Forms.Padding(0);
      this.tuSlicePanel4.Name = "tuSlicePanel4";
      this.tuSlicePanel4.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.tuSlicePanel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
      this.tuSlicePanel4.Size = new System.Drawing.Size(16, 20);
      this.tuSlicePanel4.TabIndex = 12;
      // 
      // tuSlicePanel1
      // 
      this.tuSlicePanel1.BackColor = System.Drawing.Color.Transparent;
      this.tuSlicePanel1.Controls.Add(this.lblIngredientName);
      this.tuSlicePanel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.tuSlicePanel1.Location = new System.Drawing.Point(45, 0);
      this.tuSlicePanel1.Margin = new System.Windows.Forms.Padding(0);
      this.tuSlicePanel1.Name = "tuSlicePanel1";
      this.tuSlicePanel1.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.tuSlicePanel1.Size = new System.Drawing.Size(180, 20);
      this.tuSlicePanel1.TabIndex = 9;
      // 
      // lblIngredientName
      // 
      this.lblIngredientName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblIngredientName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblIngredientName.Location = new System.Drawing.Point(0, 0);
      this.lblIngredientName.Margin = new System.Windows.Forms.Padding(0);
      this.lblIngredientName.Name = "lblIngredientName";
      this.lblIngredientName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
      this.lblIngredientName.Size = new System.Drawing.Size(180, 20);
      this.lblIngredientName.TabIndex = 0;
      this.lblIngredientName.Text = "Ingredient";
      this.lblIngredientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tuSlicePanel2
      // 
      this.tuSlicePanel2.Controls.Add(this.lblIngredientImg);
      this.tuSlicePanel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.tuSlicePanel2.Location = new System.Drawing.Point(0, 0);
      this.tuSlicePanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tuSlicePanel2.Name = "tuSlicePanel2";
      this.tuSlicePanel2.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.tuSlicePanel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
      this.tuSlicePanel2.Size = new System.Drawing.Size(45, 20);
      this.tuSlicePanel2.TabIndex = 8;
      // 
      // lblIngredientImg
      // 
      this.lblIngredientImg.BackColor = System.Drawing.Color.Transparent;
      this.lblIngredientImg.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblIngredientImg.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblIngredientImg.Location = new System.Drawing.Point(0, 0);
      this.lblIngredientImg.Margin = new System.Windows.Forms.Padding(0);
      this.lblIngredientImg.Name = "lblIngredientImg";
      this.lblIngredientImg.Size = new System.Drawing.Size(45, 18);
      this.lblIngredientImg.TabIndex = 0;
      this.lblIngredientImg.Text = "Img";
      this.lblIngredientImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // recipesPanel
      // 
      this.recipesPanel.Controls.Add(this.recipesContainer);
      this.recipesPanel.Controls.Add(this.allRecipesPanel);
      this.recipesPanel.Location = new System.Drawing.Point(0, 0);
      this.recipesPanel.Name = "recipesPanel";
      this.recipesPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.TextureBackground;
      this.recipesPanel.Size = new System.Drawing.Size(365, 475);
      this.recipesPanel.TabIndex = 0;
      // 
      // recipesContainer
      // 
      this.recipesContainer.BackColor = System.Drawing.Color.Transparent;
      this.recipesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.recipesContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.recipesContainer.Location = new System.Drawing.Point(0, 0);
      this.recipesContainer.Name = "recipesContainer";
      this.recipesContainer.Size = new System.Drawing.Size(365, 450);
      this.recipesContainer.TabIndex = 15;
      // 
      // allRecipesPanel
      // 
      this.allRecipesPanel.Controls.Add(this.clearBtn);
      this.allRecipesPanel.Controls.Add(this.removeAllBtn);
      this.allRecipesPanel.Controls.Add(this.allRecipesViewPanel);
      this.allRecipesPanel.Controls.Add(this.addAllBtn);
      this.allRecipesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.allRecipesPanel.Location = new System.Drawing.Point(0, 450);
      this.allRecipesPanel.Name = "allRecipesPanel";
      this.allRecipesPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.TextureBackground;
      this.allRecipesPanel.Size = new System.Drawing.Size(365, 25);
      this.allRecipesPanel.TabIndex = 14;
      // 
      // clearBtn
      // 
      this.clearBtn.Dock = System.Windows.Forms.DockStyle.Left;
      this.clearBtn.Icon = null;
      this.clearBtn.Location = new System.Drawing.Point(301, 0);
      this.clearBtn.Margin = new System.Windows.Forms.Padding(0);
      this.clearBtn.Name = "clearBtn";
      this.clearBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.clearBtn.PressedImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.clearBtn.Size = new System.Drawing.Size(32, 25);
      this.clearBtn.TabIndex = 8;
      this.clearBtn.Text = "Clear";
      this.clearBtn.UnpressedImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.clearBtn.UseVisualStyleBackColor = true;
      this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
      // 
      // removeAllBtn
      // 
      this.removeAllBtn.Dock = System.Windows.Forms.DockStyle.Left;
      this.removeAllBtn.Icon = null;
      this.removeAllBtn.Location = new System.Drawing.Point(269, 0);
      this.removeAllBtn.Margin = new System.Windows.Forms.Padding(0);
      this.removeAllBtn.Name = "removeAllBtn";
      this.removeAllBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.removeAllBtn.PressedImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.removeAllBtn.Size = new System.Drawing.Size(32, 25);
      this.removeAllBtn.TabIndex = 7;
      this.removeAllBtn.Text = "- 1";
      this.removeAllBtn.UnpressedImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.removeAllBtn.UseVisualStyleBackColor = true;
      this.removeAllBtn.Click += new System.EventHandler(this.removeAllBtn_Click);
      // 
      // allRecipesViewPanel
      // 
      this.allRecipesViewPanel.Controls.Add(this.lblAllRecipes);
      this.allRecipesViewPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.allRecipesViewPanel.Location = new System.Drawing.Point(0, 0);
      this.allRecipesViewPanel.Margin = new System.Windows.Forms.Padding(0);
      this.allRecipesViewPanel.Name = "allRecipesViewPanel";
      this.allRecipesViewPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.allRecipesViewPanel.Size = new System.Drawing.Size(269, 25);
      this.allRecipesViewPanel.TabIndex = 6;
      // 
      // lblAllRecipes
      // 
      this.lblAllRecipes.BackColor = System.Drawing.Color.Transparent;
      this.lblAllRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblAllRecipes.Location = new System.Drawing.Point(0, 0);
      this.lblAllRecipes.Name = "lblAllRecipes";
      this.lblAllRecipes.Size = new System.Drawing.Size(269, 25);
      this.lblAllRecipes.TabIndex = 0;
      this.lblAllRecipes.Text = "All Recipes";
      this.lblAllRecipes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblAllRecipes.TibiaComboBox = null;
      // 
      // addAllBtn
      // 
      this.addAllBtn.Dock = System.Windows.Forms.DockStyle.Right;
      this.addAllBtn.Icon = null;
      this.addAllBtn.Location = new System.Drawing.Point(333, 0);
      this.addAllBtn.Margin = new System.Windows.Forms.Padding(0);
      this.addAllBtn.Name = "addAllBtn";
      this.addAllBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.addAllBtn.PressedImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.addAllBtn.Size = new System.Drawing.Size(32, 25);
      this.addAllBtn.TabIndex = 5;
      this.addAllBtn.Text = "+ 1";
      this.addAllBtn.UnpressedImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.addAllBtn.UseVisualStyleBackColor = true;
      this.addAllBtn.Click += new System.EventHandler(this.addAllBtn_Click);
      // 
      // recipePopup1
      // 
      this.recipePopup1.AutoSize = true;
      this.recipePopup1.Location = new System.Drawing.Point(368, 9);
      this.recipePopup1.Margin = new System.Windows.Forms.Padding(0);
      this.recipePopup1.Name = "recipePopup1";
      this.recipePopup1.Size = new System.Drawing.Size(230, 30);
      this.recipePopup1.TabIndex = 15;
      this.recipePopup1.Visible = false;
      // 
      // HotCuisine
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(764, 475);
      this.Controls.Add(this.viewPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "HotCuisine";
      this.Text = "Form";
      this.viewPanel.ResumeLayout(false);
      this.mainViewPort.ResumeLayout(false);
      this.mainViewPort.PerformLayout();
      this.IngredientsPanel.ResumeLayout(false);
      this.ingredientsViewPort.ResumeLayout(false);
      this.ingredientsViewPort.PerformLayout();
      this.ingredientsC.ResumeLayout(false);
      this.ingredientsC.PerformLayout();
      this.ingredientsTopPanel.ResumeLayout(false);
      this.tuSlicePanel5.ResumeLayout(false);
      this.tuSlicePanel3.ResumeLayout(false);
      this.tuSlicePanel1.ResumeLayout(false);
      this.tuSlicePanel2.ResumeLayout(false);
      this.recipesPanel.ResumeLayout(false);
      this.allRecipesPanel.ResumeLayout(false);
      this.allRecipesViewPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControls.TUPanel viewPanel;
    private CustomControls.TUSlicePanel mainViewPort;
    private CustomControls.TUSlicePanel recipesPanel;
    private CustomControls.TUSlicePanel IngredientsPanel;
    private CustomControls.TUSlicePanel allRecipesPanel;
    private CustomControls.HotCuisine.PopUp.RecipePopup recipePopup1;
    private CustomControls.TUPanel ingredientsViewPort;
    private CustomControls.TUPanel ingredientsTopPanel;
    private CustomControls.TUSlicePanel tuSlicePanel2;
    private CustomControls.TUSlicePanel tuSlicePanel1;
    private System.Windows.Forms.Label lblIngredientName;
    private System.Windows.Forms.Label lblIngredientImg;
    private CustomControls.TUPanel ingredientsC;
    private CustomControls.TibiaVScrollBar rightScrollBar;
    private CustomControls.TUSlicePanel allRecipesViewPanel;
    private CustomControls.TULabel lblAllRecipes;
    private CustomControls.TUSliceButton addAllBtn;
    private CustomControls.TUFlowLayoutPanel recipesContainer;
    private CustomControls.TUFlowLayoutPanel ingredientsContainer;
    private CustomControls.TUSliceButton clearBtn;
    private CustomControls.TUSliceButton removeAllBtn;
    private CustomControls.TUSlicePanel tuSlicePanel3;
    private System.Windows.Forms.Label lblIngredientCant;
    private CustomControls.TUSlicePanel tuSlicePanel4;
    private CustomControls.TUSlicePanel tuSlicePanel5;
    private System.Windows.Forms.Label lblIngredientOk;
  }
}