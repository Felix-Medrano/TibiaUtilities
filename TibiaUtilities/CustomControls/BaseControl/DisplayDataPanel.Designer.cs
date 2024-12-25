using TibiaUtilities.Properties;

namespace TibiaUtilities.CustomControls.BaseControl
{
  partial class DisplayDataPanel
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
      this.topPanel = new TibiaUtilities.CustomControls.TUPanel();
      this.title = new System.Windows.Forms.Label();
      this.topPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // topPanel
      // 
      this.topPanel.BackColor = System.Drawing.Color.Transparent;
      this.topPanel.Controls.Add(this.title);
      this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.topPanel.Location = new System.Drawing.Point(0, 0);
      this.topPanel.Name = "topPanel";
      this.topPanel.Size = new System.Drawing.Size(387, 19);
      this.topPanel.TabIndex = 0;
      // 
      // title
      // 
      this.title.AutoSize = true;
      this.title.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
      this.title.Location = new System.Drawing.Point(118, 2);
      this.title.Name = "title";
      this.title.Size = new System.Drawing.Size(120, 17);
      this.title.TabIndex = 1;
      this.title.Text = "Lord\'Paulistinha";
      // 
      // DisplayDataPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.BackgroundImage = global::TibiaUtilities.Properties.Resources.Background;
      this.Controls.Add(this.topPanel);
      this.Name = "DisplayDataPanel";
      this.Size = new System.Drawing.Size(387, 242);
      this.Resize += new System.EventHandler(this.DisplayDataPanel_Resize);
      this.topPanel.ResumeLayout(false);
      this.topPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private TUPanel topPanel;
    private System.Windows.Forms.Label title;
  }
}
