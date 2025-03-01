namespace Tibia_Utilities.CustomControls.Houses
{
  partial class HouseDataView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HouseDataView));
      this.viewPort = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.shopImg = new System.Windows.Forms.PictureBox();
      this.coinImg = new System.Windows.Forms.PictureBox();
      this.lblDesc = new System.Windows.Forms.Label();
      this.lblStatus = new System.Windows.Forms.Label();
      this.lblCantRent = new System.Windows.Forms.Label();
      this.lblRent = new System.Windows.Forms.Label();
      this.lblCantBeds = new System.Windows.Forms.Label();
      this.lblBeds = new System.Windows.Forms.Label();
      this.lblSqm = new System.Windows.Forms.Label();
      this.lblSize = new System.Windows.Forms.Label();
      this.topPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblName = new System.Windows.Forms.Label();
      this.viewPort.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.shopImg)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.coinImg)).BeginInit();
      this.topPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // viewPort
      // 
      this.viewPort.BackColor = System.Drawing.Color.Transparent;
      this.viewPort.Controls.Add(this.shopImg);
      this.viewPort.Controls.Add(this.coinImg);
      this.viewPort.Controls.Add(this.lblDesc);
      this.viewPort.Controls.Add(this.lblStatus);
      this.viewPort.Controls.Add(this.lblCantRent);
      this.viewPort.Controls.Add(this.lblRent);
      this.viewPort.Controls.Add(this.lblCantBeds);
      this.viewPort.Controls.Add(this.lblBeds);
      this.viewPort.Controls.Add(this.lblSqm);
      this.viewPort.Controls.Add(this.lblSize);
      this.viewPort.Controls.Add(this.topPanel);
      this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPort.Location = new System.Drawing.Point(3, 3);
      this.viewPort.Margin = new System.Windows.Forms.Padding(0);
      this.viewPort.Name = "viewPort";
      this.viewPort.OriginalImage = ((System.Drawing.Image)(resources.GetObject("viewPort.OriginalImage")));
      this.viewPort.Size = new System.Drawing.Size(437, 69);
      this.viewPort.TabIndex = 0;
      // 
      // shopImg
      // 
      this.shopImg.BackColor = System.Drawing.Color.Transparent;
      this.shopImg.Image = global::Tibia_Utilities.Properties.Resources.HouseShopIcon;
      this.shopImg.Location = new System.Drawing.Point(417, 25);
      this.shopImg.Name = "shopImg";
      this.shopImg.Size = new System.Drawing.Size(12, 13);
      this.shopImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.shopImg.TabIndex = 10;
      this.shopImg.TabStop = false;
      // 
      // coinImg
      // 
      this.coinImg.BackColor = System.Drawing.Color.Transparent;
      this.coinImg.Image = global::Tibia_Utilities.Properties.Resources.singleGP;
      this.coinImg.Location = new System.Drawing.Point(352, 25);
      this.coinImg.Name = "coinImg";
      this.coinImg.Size = new System.Drawing.Size(12, 12);
      this.coinImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.coinImg.TabIndex = 9;
      this.coinImg.TabStop = false;
      // 
      // lblDesc
      // 
      this.lblDesc.AutoSize = true;
      this.lblDesc.Location = new System.Drawing.Point(66, 47);
      this.lblDesc.Name = "lblDesc";
      this.lblDesc.Size = new System.Drawing.Size(97, 13);
      this.lblDesc.TabIndex = 8;
      this.lblDesc.Text = "Dummy text for info";
      // 
      // lblStatus
      // 
      this.lblStatus.AutoSize = true;
      this.lblStatus.Location = new System.Drawing.Point(8, 47);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(40, 13);
      this.lblStatus.TabIndex = 7;
      this.lblStatus.Text = "Status:";
      // 
      // lblCantRent
      // 
      this.lblCantRent.AutoSize = true;
      this.lblCantRent.Location = new System.Drawing.Point(307, 24);
      this.lblCantRent.Name = "lblCantRent";
      this.lblCantRent.Size = new System.Drawing.Size(34, 13);
      this.lblCantRent.TabIndex = 6;
      this.lblCantRent.Text = "999 k";
      // 
      // lblRent
      // 
      this.lblRent.AutoSize = true;
      this.lblRent.Location = new System.Drawing.Point(258, 24);
      this.lblRent.Name = "lblRent";
      this.lblRent.Size = new System.Drawing.Size(33, 13);
      this.lblRent.TabIndex = 5;
      this.lblRent.Text = "Rent:";
      // 
      // lblCantBeds
      // 
      this.lblCantBeds.AutoSize = true;
      this.lblCantBeds.Location = new System.Drawing.Point(204, 24);
      this.lblCantBeds.Name = "lblCantBeds";
      this.lblCantBeds.Size = new System.Drawing.Size(19, 13);
      this.lblCantBeds.TabIndex = 4;
      this.lblCantBeds.Text = "99";
      // 
      // lblBeds
      // 
      this.lblBeds.AutoSize = true;
      this.lblBeds.Location = new System.Drawing.Point(137, 24);
      this.lblBeds.Name = "lblBeds";
      this.lblBeds.Size = new System.Drawing.Size(57, 13);
      this.lblBeds.TabIndex = 3;
      this.lblBeds.Text = "Max Beds:";
      // 
      // lblSqm
      // 
      this.lblSqm.AutoSize = true;
      this.lblSqm.Location = new System.Drawing.Point(66, 24);
      this.lblSqm.Name = "lblSqm";
      this.lblSqm.Size = new System.Drawing.Size(47, 13);
      this.lblSqm.TabIndex = 2;
      this.lblSqm.Text = "999 sqm";
      // 
      // lblSize
      // 
      this.lblSize.AutoSize = true;
      this.lblSize.Location = new System.Drawing.Point(8, 24);
      this.lblSize.Name = "lblSize";
      this.lblSize.Size = new System.Drawing.Size(30, 13);
      this.lblSize.TabIndex = 1;
      this.lblSize.Text = "Size:";
      // 
      // topPanel
      // 
      this.topPanel.Controls.Add(this.lblName);
      this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.topPanel.EdgeHeight = 5;
      this.topPanel.EdgeWidth = 5;
      this.topPanel.Location = new System.Drawing.Point(0, 0);
      this.topPanel.Name = "topPanel";
      this.topPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.TopBarS;
      this.topPanel.Size = new System.Drawing.Size(437, 20);
      this.topPanel.TabIndex = 0;
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.BackColor = System.Drawing.Color.Transparent;
      this.lblName.Location = new System.Drawing.Point(181, 2);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(69, 13);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "House Name";
      this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // HouseDataView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Transparent;
      this.Controls.Add(this.viewPort);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "HouseDataView";
      this.Padding = new System.Windows.Forms.Padding(3);
      this.Size = new System.Drawing.Size(443, 75);
      this.viewPort.ResumeLayout(false);
      this.viewPort.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.shopImg)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.coinImg)).EndInit();
      this.topPanel.ResumeLayout(false);
      this.topPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private TUSlicePanel viewPort;
    private TUSlicePanel topPanel;
    private System.Windows.Forms.Label lblSqm;
    private System.Windows.Forms.Label lblSize;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblCantBeds;
    private System.Windows.Forms.Label lblBeds;
    private System.Windows.Forms.Label lblDesc;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Label lblCantRent;
    private System.Windows.Forms.Label lblRent;
    private System.Windows.Forms.PictureBox coinImg;
    private System.Windows.Forms.PictureBox shopImg;
  }
}
