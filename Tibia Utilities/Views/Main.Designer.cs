namespace Tibia_Utilities
{
  partial class Main
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

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.tuTopControlBar1 = new Tibia_Utilities.CustomControls.TUTopControlBar();
      this.SuspendLayout();
      // 
      // tuTopControlBar1
      // 
      this.tuTopControlBar1.EdgeWidth = 50;
      this.tuTopControlBar1.Location = new System.Drawing.Point(126, 103);
      this.tuTopControlBar1.Name = "tuTopControlBar1";
      this.tuTopControlBar1.OriginalImage = ((System.Drawing.Image)(resources.GetObject("tuTopControlBar1.OriginalImage")));
      this.tuTopControlBar1.Size = new System.Drawing.Size(443, 20);
      this.tuTopControlBar1.TabIndex = 0;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::Tibia_Utilities.Properties.Resources.Background;
      this.ClientSize = new System.Drawing.Size(800, 615);
      this.Controls.Add(this.tuTopControlBar1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximumSize = new System.Drawing.Size(800, 615);
      this.MinimumSize = new System.Drawing.Size(800, 615);
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Tibia Utilities";
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControls.TUTopControlBar tuTopControlBar1;
  }
}

