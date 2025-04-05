namespace Tibia_Utilities.CustomControls.HotCuisine.PopUp
{
  partial class IngredientPopupRow
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
      this.lblCant = new System.Windows.Forms.Label();
      this.tuSlicePanel2 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.img = new System.Windows.Forms.PictureBox();
      this.tuSlicePanel3 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblName = new System.Windows.Forms.Label();
      this.tuSlicePanel1.SuspendLayout();
      this.tuSlicePanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
      this.tuSlicePanel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // tuSlicePanel1
      // 
      this.tuSlicePanel1.Controls.Add(this.lblCant);
      this.tuSlicePanel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.tuSlicePanel1.Location = new System.Drawing.Point(175, 0);
      this.tuSlicePanel1.Name = "tuSlicePanel1";
      this.tuSlicePanel1.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.tuSlicePanel1.Size = new System.Drawing.Size(45, 32);
      this.tuSlicePanel1.TabIndex = 6;
      // 
      // lblCant
      // 
      this.lblCant.BackColor = System.Drawing.Color.Transparent;
      this.lblCant.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblCant.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCant.Location = new System.Drawing.Point(0, 0);
      this.lblCant.Name = "lblCant";
      this.lblCant.Size = new System.Drawing.Size(45, 32);
      this.lblCant.TabIndex = 1;
      this.lblCant.Text = "99";
      this.lblCant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tuSlicePanel2
      // 
      this.tuSlicePanel2.Controls.Add(this.img);
      this.tuSlicePanel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.tuSlicePanel2.Location = new System.Drawing.Point(0, 0);
      this.tuSlicePanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tuSlicePanel2.Name = "tuSlicePanel2";
      this.tuSlicePanel2.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.tuSlicePanel2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.tuSlicePanel2.Size = new System.Drawing.Size(45, 32);
      this.tuSlicePanel2.TabIndex = 7;
      // 
      // img
      // 
      this.img.BackColor = System.Drawing.Color.Transparent;
      this.img.Dock = System.Windows.Forms.DockStyle.Fill;
      this.img.Image = global::Tibia_Utilities.Properties.Resources.Blessed_Steak;
      this.img.Location = new System.Drawing.Point(5, 3);
      this.img.Margin = new System.Windows.Forms.Padding(0);
      this.img.Name = "img";
      this.img.Size = new System.Drawing.Size(35, 26);
      this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.img.TabIndex = 0;
      this.img.TabStop = false;
      this.img.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.RecipeImage_LoadCompleted);
      // 
      // tuSlicePanel3
      // 
      this.tuSlicePanel3.Controls.Add(this.lblName);
      this.tuSlicePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tuSlicePanel3.Location = new System.Drawing.Point(45, 0);
      this.tuSlicePanel3.Name = "tuSlicePanel3";
      this.tuSlicePanel3.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.tuSlicePanel3.Size = new System.Drawing.Size(130, 32);
      this.tuSlicePanel3.TabIndex = 8;
      // 
      // lblName
      // 
      this.lblName.BackColor = System.Drawing.Color.Transparent;
      this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblName.Location = new System.Drawing.Point(0, 0);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(130, 32);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "Jalapeño Pepper";
      this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // IngredientPopupRow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tuSlicePanel3);
      this.Controls.Add(this.tuSlicePanel2);
      this.Controls.Add(this.tuSlicePanel1);
      this.Name = "IngredientPopupRow";
      this.Size = new System.Drawing.Size(220, 32);
      this.tuSlicePanel1.ResumeLayout(false);
      this.tuSlicePanel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
      this.tuSlicePanel3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private TUSlicePanel tuSlicePanel1;
    private System.Windows.Forms.Label lblCant;
    private TUSlicePanel tuSlicePanel2;
    private System.Windows.Forms.PictureBox img;
    private TUSlicePanel tuSlicePanel3;
    private System.Windows.Forms.Label lblName;
  }
}
