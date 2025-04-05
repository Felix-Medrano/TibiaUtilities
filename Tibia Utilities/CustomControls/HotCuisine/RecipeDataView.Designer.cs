namespace Tibia_Utilities.CustomControls.HotCuisine
{
  partial class RecipeDataView
  {
    /// <summary> 
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de componentes

    /// <summary> 
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.tuSlicePanel1 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.recipeEffect = new System.Windows.Forms.PictureBox();
      this.lblName = new Tibia_Utilities.CustomControls.TULabel();
      this.recipeImg = new System.Windows.Forms.PictureBox();
      this.removeBtn = new Tibia_Utilities.CustomControls.TUSliceButton();
      this.addBtn = new Tibia_Utilities.CustomControls.TUSliceButton();
      this.tuSlicePanel2 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblCant = new Tibia_Utilities.CustomControls.TULabel();
      this.tuSlicePanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.recipeEffect)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.recipeImg)).BeginInit();
      this.tuSlicePanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tuSlicePanel1
      // 
      this.tuSlicePanel1.Controls.Add(this.recipeEffect);
      this.tuSlicePanel1.Controls.Add(this.lblName);
      this.tuSlicePanel1.Controls.Add(this.recipeImg);
      this.tuSlicePanel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.tuSlicePanel1.Location = new System.Drawing.Point(0, 0);
      this.tuSlicePanel1.Margin = new System.Windows.Forms.Padding(0);
      this.tuSlicePanel1.Name = "tuSlicePanel1";
      this.tuSlicePanel1.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.tuSlicePanel1.Padding = new System.Windows.Forms.Padding(2);
      this.tuSlicePanel1.Size = new System.Drawing.Size(269, 32);
      this.tuSlicePanel1.TabIndex = 8;
      // 
      // recipeEffect
      // 
      this.recipeEffect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.recipeEffect.Image = global::Tibia_Utilities.Properties.Resources.informacion;
      this.recipeEffect.Location = new System.Drawing.Point(245, 8);
      this.recipeEffect.Name = "recipeEffect";
      this.recipeEffect.Size = new System.Drawing.Size(15, 15);
      this.recipeEffect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.recipeEffect.TabIndex = 4;
      this.recipeEffect.TabStop = false;
      // 
      // lblName
      // 
      this.lblName.BackColor = System.Drawing.Color.Transparent;
      this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblName.Location = new System.Drawing.Point(34, 2);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(233, 28);
      this.lblName.TabIndex = 3;
      this.lblName.Text = "Blessed Wooden Stake";
      this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblName.TibiaComboBox = null;
      // 
      // recipeImg
      // 
      this.recipeImg.BackColor = System.Drawing.Color.Transparent;
      this.recipeImg.Dock = System.Windows.Forms.DockStyle.Left;
      this.recipeImg.Image = global::Tibia_Utilities.Properties.Resources.Rotworm_Stew;
      this.recipeImg.Location = new System.Drawing.Point(2, 2);
      this.recipeImg.Margin = new System.Windows.Forms.Padding(0);
      this.recipeImg.Name = "recipeImg";
      this.recipeImg.Size = new System.Drawing.Size(32, 28);
      this.recipeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.recipeImg.TabIndex = 2;
      this.recipeImg.TabStop = false;
      // 
      // removeBtn
      // 
      this.removeBtn.Dock = System.Windows.Forms.DockStyle.Left;
      this.removeBtn.Location = new System.Drawing.Point(269, 0);
      this.removeBtn.Margin = new System.Windows.Forms.Padding(0);
      this.removeBtn.Name = "removeBtn";
      this.removeBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.removeBtn.PressedImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.removeBtn.Size = new System.Drawing.Size(32, 32);
      this.removeBtn.TabIndex = 9;
      this.removeBtn.Text = "- 1";
      this.removeBtn.UnpressedImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.removeBtn.UseVisualStyleBackColor = true;
      this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
      // 
      // addBtn
      // 
      this.addBtn.Dock = System.Windows.Forms.DockStyle.Right;
      this.addBtn.Location = new System.Drawing.Point(333, 0);
      this.addBtn.Margin = new System.Windows.Forms.Padding(0);
      this.addBtn.Name = "addBtn";
      this.addBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.addBtn.PressedImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.addBtn.Size = new System.Drawing.Size(32, 32);
      this.addBtn.TabIndex = 10;
      this.addBtn.Text = "+ 1";
      this.addBtn.UnpressedImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.addBtn.UseVisualStyleBackColor = true;
      this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
      // 
      // tuSlicePanel2
      // 
      this.tuSlicePanel2.Controls.Add(this.lblCant);
      this.tuSlicePanel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.tuSlicePanel2.Location = new System.Drawing.Point(301, 0);
      this.tuSlicePanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tuSlicePanel2.Name = "tuSlicePanel2";
      this.tuSlicePanel2.OriginalImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.tuSlicePanel2.Size = new System.Drawing.Size(32, 32);
      this.tuSlicePanel2.TabIndex = 11;
      // 
      // lblCant
      // 
      this.lblCant.BackColor = System.Drawing.Color.Transparent;
      this.lblCant.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblCant.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCant.Location = new System.Drawing.Point(0, 0);
      this.lblCant.Name = "lblCant";
      this.lblCant.Size = new System.Drawing.Size(32, 32);
      this.lblCant.TabIndex = 4;
      this.lblCant.Text = "0";
      this.lblCant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblCant.TibiaComboBox = null;
      // 
      // RecipeDataView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Transparent;
      this.Controls.Add(this.tuSlicePanel2);
      this.Controls.Add(this.addBtn);
      this.Controls.Add(this.removeBtn);
      this.Controls.Add(this.tuSlicePanel1);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "RecipeDataView";
      this.Size = new System.Drawing.Size(365, 32);
      this.tuSlicePanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.recipeEffect)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.recipeImg)).EndInit();
      this.tuSlicePanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private TUSlicePanel tuSlicePanel1;
    private System.Windows.Forms.PictureBox recipeEffect;
    private TULabel lblName;
    private System.Windows.Forms.PictureBox recipeImg;
    private TUSliceButton removeBtn;
    private TUSliceButton addBtn;
    private TUSlicePanel tuSlicePanel2;
    private TULabel lblCant;
  }
}
