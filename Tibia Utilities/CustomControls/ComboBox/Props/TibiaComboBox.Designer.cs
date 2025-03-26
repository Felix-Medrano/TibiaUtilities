namespace Tibia_Utilities.CustomControls
{
  partial class TibiaComboBox
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
      this.worldBtn = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblWorld = new System.Windows.Forms.Label();
      this.dropBtn = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblDrop = new System.Windows.Forms.Label();
      this.worldBtn.SuspendLayout();
      this.dropBtn.SuspendLayout();
      this.SuspendLayout();
      // 
      // worldBtn
      // 
      this.worldBtn.Controls.Add(this.lblWorld);
      this.worldBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.worldBtn.Location = new System.Drawing.Point(0, 0);
      this.worldBtn.Name = "worldBtn";
      this.worldBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.worldBtn.Size = new System.Drawing.Size(187, 23);
      this.worldBtn.TabIndex = 1;
      // 
      // lblWorld
      // 
      this.lblWorld.AutoSize = true;
      this.lblWorld.Location = new System.Drawing.Point(62, 10);
      this.lblWorld.Name = "lblWorld";
      this.lblWorld.Size = new System.Drawing.Size(65, 13);
      this.lblWorld.TabIndex = 0;
      this.lblWorld.Text = "Placeholder";
      // 
      // dropBtn
      // 
      this.dropBtn.Controls.Add(this.lblDrop);
      this.dropBtn.Dock = System.Windows.Forms.DockStyle.Right;
      this.dropBtn.EdgeHeight = 3;
      this.dropBtn.EdgeWidth = 3;
      this.dropBtn.Location = new System.Drawing.Point(187, 0);
      this.dropBtn.Name = "dropBtn";
      this.dropBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.dropBtn.Size = new System.Drawing.Size(23, 23);
      this.dropBtn.TabIndex = 0;
      // 
      // lblDrop
      // 
      this.lblDrop.AutoSize = true;
      this.lblDrop.Location = new System.Drawing.Point(4, 6);
      this.lblDrop.Name = "lblDrop";
      this.lblDrop.Size = new System.Drawing.Size(16, 13);
      this.lblDrop.TabIndex = 0;
      this.lblDrop.Text = "▼";
      // 
      // TibiaComboBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.worldBtn);
      this.Controls.Add(this.dropBtn);
      this.Name = "TibiaComboBox";
      this.Size = new System.Drawing.Size(210, 23);
      this.worldBtn.ResumeLayout(false);
      this.worldBtn.PerformLayout();
      this.dropBtn.ResumeLayout(false);
      this.dropBtn.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private TUSlicePanel dropBtn;
    private TUSlicePanel worldBtn;
    private System.Windows.Forms.Label lblWorld;
    private System.Windows.Forms.Label lblDrop;
  }
}
