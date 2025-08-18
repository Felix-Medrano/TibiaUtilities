namespace Tibia_Utilities.CustomControls.Equipment
{
  partial class EquipmentItem
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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.tuSlicePanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // tuSlicePanel1
      // 
      this.tuSlicePanel1.Controls.Add(this.pictureBox1);
      this.tuSlicePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tuSlicePanel1.Location = new System.Drawing.Point(0, 0);
      this.tuSlicePanel1.Margin = new System.Windows.Forms.Padding(0);
      this.tuSlicePanel1.Name = "tuSlicePanel1";
      this.tuSlicePanel1.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.tuSlicePanel1.Padding = new System.Windows.Forms.Padding(5);
      this.tuSlicePanel1.Size = new System.Drawing.Size(150, 150);
      this.tuSlicePanel1.TabIndex = 0;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Location = new System.Drawing.Point(5, 5);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(140, 140);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // EquipmentItem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tuSlicePanel1);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "EquipmentItem";
      this.tuSlicePanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private TUSlicePanel tuSlicePanel1;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}
