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
      this.label1 = new System.Windows.Forms.Label();
      this.worldBtn = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.dropBtn = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Location = new System.Drawing.Point(3, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(16, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "▼";
      // 
      // worldBtn
      // 
      this.worldBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.worldBtn.Location = new System.Drawing.Point(0, 0);
      this.worldBtn.Name = "worldBtn";
      this.worldBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.worldBtn.Size = new System.Drawing.Size(188, 23);
      this.worldBtn.TabIndex = 1;
      // 
      // dropBtn
      // 
      this.dropBtn.Dock = System.Windows.Forms.DockStyle.Right;
      this.dropBtn.EdgeHeight = 3;
      this.dropBtn.EdgeWidth = 3;
      this.dropBtn.Location = new System.Drawing.Point(188, 0);
      this.dropBtn.Name = "dropBtn";
      this.dropBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.dropBtn.Size = new System.Drawing.Size(23, 23);
      this.dropBtn.TabIndex = 0;
      // 
      // TibiaComboBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.worldBtn);
      this.Controls.Add(this.dropBtn);
      this.Name = "TibiaComboBox";
      this.Size = new System.Drawing.Size(210, 23);
      this.ResumeLayout(false);

    }

    #endregion

    private TUSlicePanel dropBtn;
    private TUSlicePanel worldBtn;
    private System.Windows.Forms.Label label1;
  }
}
