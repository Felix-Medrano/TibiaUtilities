namespace Tibia_Utilities.CustomControls.ComboBox.Props
{
  partial class TCBDropDown
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
      this.backgroundPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.viewPort = new Tibia_Utilities.CustomControls.TUPanel();
      this.container = new Tibia_Utilities.CustomControls.TUPanel();
      this.scrollBar = new Tibia_Utilities.CustomControls.TibiaVScrollBar();
      this.backgroundPanel.SuspendLayout();
      this.container.SuspendLayout();
      this.SuspendLayout();
      // 
      // backgroundPanel
      // 
      this.backgroundPanel.Controls.Add(this.viewPort);
      this.backgroundPanel.Controls.Add(this.container);
      this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
      this.backgroundPanel.Name = "backgroundPanel";
      this.backgroundPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.backgroundPanel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 3);
      this.backgroundPanel.Size = new System.Drawing.Size(156, 155);
      this.backgroundPanel.TabIndex = 0;
      // 
      // viewPort
      // 
      this.viewPort.BackColor = System.Drawing.Color.Transparent;
      this.viewPort.Location = new System.Drawing.Point(0, 0);
      this.viewPort.Name = "viewPort";
      this.viewPort.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.viewPort.Size = new System.Drawing.Size(128, 145);
      this.viewPort.TabIndex = 1;
      // 
      // container
      // 
      this.container.BackColor = System.Drawing.Color.Transparent;
      this.container.Controls.Add(this.scrollBar);
      this.container.Dock = System.Windows.Forms.DockStyle.Fill;
      this.container.Location = new System.Drawing.Point(3, 2);
      this.container.Name = "container";
      this.container.Size = new System.Drawing.Size(150, 150);
      this.container.TabIndex = 0;
      // 
      // scrollBar
      // 
      this.scrollBar.Dock = System.Windows.Forms.DockStyle.Right;
      this.scrollBar.Location = new System.Drawing.Point(134, 0);
      this.scrollBar.Name = "scrollBar";
      this.scrollBar.Size = new System.Drawing.Size(16, 150);
      this.scrollBar.Step = 10;
      this.scrollBar.TabIndex = 0;
      this.scrollBar.viewContainer = this.container;
      this.scrollBar.viewPort = this.viewPort;
      // 
      // TCBDropDown
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.backgroundPanel);
      this.Name = "TCBDropDown";
      this.Size = new System.Drawing.Size(156, 155);
      this.Resize += new System.EventHandler(this.TCBDropDown_Resize);
      this.backgroundPanel.ResumeLayout(false);
      this.container.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private TUSlicePanel backgroundPanel;
    private TUPanel container;
    private TibiaVScrollBar scrollBar;
    private TUPanel viewPort;
  }
}
