namespace Tibia_Utilities.CustomControls.Bestiary
{
  partial class CreatureType
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatureType));
      this.tuSlicePanel1 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.typeBtn = new Tibia_Utilities.CustomControls.TUSliceButton();
      this.topPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblType = new System.Windows.Forms.Label();
      this.tuSlicePanel1.SuspendLayout();
      this.topPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // tuSlicePanel1
      // 
      this.tuSlicePanel1.Controls.Add(this.typeBtn);
      this.tuSlicePanel1.Controls.Add(this.topPanel);
      this.tuSlicePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tuSlicePanel1.Location = new System.Drawing.Point(5, 5);
      this.tuSlicePanel1.Name = "tuSlicePanel1";
      this.tuSlicePanel1.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.tuSlicePanel1.Size = new System.Drawing.Size(139, 129);
      this.tuSlicePanel1.TabIndex = 0;
      // 
      // typeBtn
      // 
      this.typeBtn.Icon = global::Tibia_Utilities.Properties.Resources.BookC;
      this.typeBtn.Location = new System.Drawing.Point(34, 24);
      this.typeBtn.Name = "typeBtn";
      this.typeBtn.OriginalImage = ((System.Drawing.Image)(resources.GetObject("typeBtn.OriginalImage")));
      this.typeBtn.PressedImage = ((System.Drawing.Image)(resources.GetObject("typeBtn.PressedImage")));
      this.typeBtn.Size = new System.Drawing.Size(71, 71);
      this.typeBtn.TabIndex = 2;
      this.typeBtn.UnpressedImage = ((System.Drawing.Image)(resources.GetObject("typeBtn.UnpressedImage")));
      this.typeBtn.UseVisualStyleBackColor = true;
      // 
      // topPanel
      // 
      this.topPanel.Controls.Add(this.lblType);
      this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.topPanel.EdgeHeight = 5;
      this.topPanel.EdgeWidth = 5;
      this.topPanel.Location = new System.Drawing.Point(0, 0);
      this.topPanel.Name = "topPanel";
      this.topPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.TopBarS;
      this.topPanel.Size = new System.Drawing.Size(139, 20);
      this.topPanel.TabIndex = 1;
      // 
      // lblType
      // 
      this.lblType.AutoSize = true;
      this.lblType.BackColor = System.Drawing.Color.Transparent;
      this.lblType.Location = new System.Drawing.Point(53, 0);
      this.lblType.Name = "lblType";
      this.lblType.Size = new System.Drawing.Size(31, 13);
      this.lblType.TabIndex = 0;
      this.lblType.Text = "Type";
      this.lblType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // CreatureType
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Transparent;
      this.Controls.Add(this.tuSlicePanel1);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "CreatureType";
      this.Padding = new System.Windows.Forms.Padding(5);
      this.Size = new System.Drawing.Size(149, 139);
      this.tuSlicePanel1.ResumeLayout(false);
      this.topPanel.ResumeLayout(false);
      this.topPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private TUSlicePanel tuSlicePanel1;
    private TUSliceButton typeBtn;
    private TUSlicePanel topPanel;
    private System.Windows.Forms.Label lblType;
  }
}
