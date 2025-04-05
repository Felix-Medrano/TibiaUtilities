namespace Tibia_Utilities.CustomControls.HotCuisine.PopUp
{
  partial class RecipePopup
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipePopup));
      this.viewPort = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.tableTopPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.namePanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblName = new System.Windows.Forms.Label();
      this.cantPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblCant = new System.Windows.Forms.Label();
      this.imgPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblImg = new System.Windows.Forms.Label();
      this.rowsPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.viewPort.SuspendLayout();
      this.tableTopPanel.SuspendLayout();
      this.namePanel.SuspendLayout();
      this.cantPanel.SuspendLayout();
      this.imgPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // viewPort
      // 
      this.viewPort.AutoSize = true;
      this.viewPort.Controls.Add(this.rowsPanel);
      this.viewPort.Controls.Add(this.tableTopPanel);
      this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPort.Location = new System.Drawing.Point(0, 0);
      this.viewPort.Margin = new System.Windows.Forms.Padding(0);
      this.viewPort.Name = "viewPort";
      this.viewPort.OriginalImage = ((System.Drawing.Image)(resources.GetObject("viewPort.OriginalImage")));
      this.viewPort.Padding = new System.Windows.Forms.Padding(5);
      this.viewPort.Size = new System.Drawing.Size(230, 30);
      this.viewPort.TabIndex = 0;
      // 
      // tableTopPanel
      // 
      this.tableTopPanel.Controls.Add(this.namePanel);
      this.tableTopPanel.Controls.Add(this.cantPanel);
      this.tableTopPanel.Controls.Add(this.imgPanel);
      this.tableTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.tableTopPanel.Location = new System.Drawing.Point(5, 5);
      this.tableTopPanel.Margin = new System.Windows.Forms.Padding(0);
      this.tableTopPanel.Name = "tableTopPanel";
      this.tableTopPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.TextureBackground;
      this.tableTopPanel.Size = new System.Drawing.Size(220, 20);
      this.tableTopPanel.TabIndex = 0;
      // 
      // namePanel
      // 
      this.namePanel.Controls.Add(this.lblName);
      this.namePanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.namePanel.Location = new System.Drawing.Point(45, 0);
      this.namePanel.Name = "namePanel";
      this.namePanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.namePanel.Size = new System.Drawing.Size(130, 20);
      this.namePanel.TabIndex = 2;
      // 
      // lblName
      // 
      this.lblName.BackColor = System.Drawing.Color.Transparent;
      this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblName.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold);
      this.lblName.Location = new System.Drawing.Point(0, 0);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(130, 20);
      this.lblName.TabIndex = 2;
      this.lblName.Text = "Ingredient";
      this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cantPanel
      // 
      this.cantPanel.Controls.Add(this.lblCant);
      this.cantPanel.Dock = System.Windows.Forms.DockStyle.Right;
      this.cantPanel.Location = new System.Drawing.Point(175, 0);
      this.cantPanel.Name = "cantPanel";
      this.cantPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.cantPanel.Size = new System.Drawing.Size(45, 20);
      this.cantPanel.TabIndex = 1;
      // 
      // lblCant
      // 
      this.lblCant.BackColor = System.Drawing.Color.Transparent;
      this.lblCant.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblCant.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold);
      this.lblCant.Location = new System.Drawing.Point(0, 0);
      this.lblCant.Name = "lblCant";
      this.lblCant.Size = new System.Drawing.Size(45, 20);
      this.lblCant.TabIndex = 1;
      this.lblCant.Text = "Qty";
      this.lblCant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // imgPanel
      // 
      this.imgPanel.Controls.Add(this.lblImg);
      this.imgPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.imgPanel.Location = new System.Drawing.Point(0, 0);
      this.imgPanel.Name = "imgPanel";
      this.imgPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.imgPanel.Size = new System.Drawing.Size(45, 20);
      this.imgPanel.TabIndex = 0;
      // 
      // lblImg
      // 
      this.lblImg.BackColor = System.Drawing.Color.Transparent;
      this.lblImg.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblImg.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold);
      this.lblImg.Location = new System.Drawing.Point(0, 0);
      this.lblImg.Name = "lblImg";
      this.lblImg.Size = new System.Drawing.Size(45, 20);
      this.lblImg.TabIndex = 0;
      this.lblImg.Text = "Img";
      this.lblImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // rowsPanel
      // 
      this.rowsPanel.AutoSize = true;
      this.rowsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rowsPanel.Location = new System.Drawing.Point(5, 25);
      this.rowsPanel.Name = "rowsPanel";
      this.rowsPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.TextureBackground;
      this.rowsPanel.Size = new System.Drawing.Size(220, 0);
      this.rowsPanel.TabIndex = 1;
      // 
      // RecipePopup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.Controls.Add(this.viewPort);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "RecipePopup";
      this.Size = new System.Drawing.Size(230, 30);
      this.viewPort.ResumeLayout(false);
      this.viewPort.PerformLayout();
      this.tableTopPanel.ResumeLayout(false);
      this.namePanel.ResumeLayout(false);
      this.cantPanel.ResumeLayout(false);
      this.imgPanel.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TUSlicePanel viewPort;
    private TUSlicePanel tableTopPanel;
    private TUSlicePanel namePanel;
    private TUSlicePanel cantPanel;
    private TUSlicePanel imgPanel;
    private System.Windows.Forms.Label lblCant;
    private System.Windows.Forms.Label lblImg;
    private System.Windows.Forms.Label lblName;
    private TUSlicePanel rowsPanel;
  }
}
