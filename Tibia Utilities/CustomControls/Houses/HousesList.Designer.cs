﻿namespace Tibia_Utilities.CustomControls.Houses
{
  partial class HousesList
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HousesList));
      this.viewPort = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.container = new Tibia_Utilities.CustomControls.TUPanel();
      this.topPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblName = new System.Windows.Forms.Label();
      this.viewPort.SuspendLayout();
      this.topPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // viewPort
      // 
      this.viewPort.BackColor = System.Drawing.Color.Transparent;
      this.viewPort.Controls.Add(this.container);
      this.viewPort.Controls.Add(this.topPanel);
      this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPort.Location = new System.Drawing.Point(0, 0);
      this.viewPort.Name = "viewPort";
      this.viewPort.OriginalImage = ((System.Drawing.Image)(resources.GetObject("viewPort.OriginalImage")));
      this.viewPort.Size = new System.Drawing.Size(452, 250);
      this.viewPort.TabIndex = 1;
      // 
      // container
      // 
      this.container.BackColor = System.Drawing.Color.Transparent;
      this.container.Dock = System.Windows.Forms.DockStyle.Fill;
      this.container.Location = new System.Drawing.Point(0, 20);
      this.container.Margin = new System.Windows.Forms.Padding(0);
      this.container.Name = "container";
      this.container.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
      this.container.Size = new System.Drawing.Size(452, 230);
      this.container.TabIndex = 1;
      // 
      // topPanel
      // 
      this.topPanel.Controls.Add(this.lblName);
      this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.topPanel.EdgeHeight = 5;
      this.topPanel.EdgeWidth = 5;
      this.topPanel.Location = new System.Drawing.Point(0, 0);
      this.topPanel.Margin = new System.Windows.Forms.Padding(0);
      this.topPanel.Name = "topPanel";
      this.topPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.TopBarS;
      this.topPanel.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
      this.topPanel.Size = new System.Drawing.Size(452, 20);
      this.topPanel.TabIndex = 0;
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(212, 5);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(65, 13);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "Town Name";
      // 
      // HousesList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.viewPort);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "HousesList";
      this.Size = new System.Drawing.Size(452, 250);
      this.viewPort.ResumeLayout(false);
      this.topPanel.ResumeLayout(false);
      this.topPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private TUSlicePanel topPanel;
    private System.Windows.Forms.Label lblName;
    private TUSlicePanel viewPort;
    private TUPanel container;
  }
}
