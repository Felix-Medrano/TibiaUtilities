namespace Tibia_Utilities.CustomControls.SplitLoot
{
  partial class PlayerTransfer
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerTransfer));
      this.viewPort = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblPayer = new System.Windows.Forms.Label();
      this.imgCoin = new System.Windows.Forms.PictureBox();
      this.lblAmount = new System.Windows.Forms.Label();
      this.lblReceiver = new System.Windows.Forms.Label();
      this.topPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.copyBtn = new Tibia_Utilities.CustomControls.TUCtrlButton();
      this.viewPort.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.imgCoin)).BeginInit();
      this.SuspendLayout();
      // 
      // viewPort
      // 
      this.viewPort.Controls.Add(this.lblPayer);
      this.viewPort.Controls.Add(this.imgCoin);
      this.viewPort.Controls.Add(this.lblAmount);
      this.viewPort.Controls.Add(this.lblReceiver);
      this.viewPort.Controls.Add(this.topPanel);
      this.viewPort.Controls.Add(this.copyBtn);
      this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPort.Location = new System.Drawing.Point(0, 0);
      this.viewPort.Name = "viewPort";
      this.viewPort.OriginalImage = ((System.Drawing.Image)(resources.GetObject("viewPort.OriginalImage")));
      this.viewPort.Size = new System.Drawing.Size(446, 70);
      this.viewPort.TabIndex = 0;
      // 
      // lblPayer
      // 
      this.lblPayer.AutoSize = true;
      this.lblPayer.Location = new System.Drawing.Point(10, 36);
      this.lblPayer.Name = "lblPayer";
      this.lblPayer.Size = new System.Drawing.Size(35, 13);
      this.lblPayer.TabIndex = 1;
      this.lblPayer.Text = "label1";
      // 
      // imgCoin
      // 
      this.imgCoin.Image = global::Tibia_Utilities.Properties.Resources.GoldCoin;
      this.imgCoin.InitialImage = global::Tibia_Utilities.Properties.Resources.GoldCoin;
      this.imgCoin.Location = new System.Drawing.Point(85, 26);
      this.imgCoin.Name = "imgCoin";
      this.imgCoin.Size = new System.Drawing.Size(32, 32);
      this.imgCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.imgCoin.TabIndex = 2;
      this.imgCoin.TabStop = false;
      // 
      // lblAmount
      // 
      this.lblAmount.AutoSize = true;
      this.lblAmount.Location = new System.Drawing.Point(148, 36);
      this.lblAmount.Name = "lblAmount";
      this.lblAmount.Size = new System.Drawing.Size(35, 13);
      this.lblAmount.TabIndex = 3;
      this.lblAmount.Text = "label1";
      // 
      // lblReceiver
      // 
      this.lblReceiver.AutoSize = true;
      this.lblReceiver.Location = new System.Drawing.Point(294, 36);
      this.lblReceiver.Name = "lblReceiver";
      this.lblReceiver.Size = new System.Drawing.Size(35, 13);
      this.lblReceiver.TabIndex = 4;
      this.lblReceiver.Text = "label1";
      // 
      // topPanel
      // 
      this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.topPanel.EdgeHeight = 5;
      this.topPanel.EdgeWidth = 5;
      this.topPanel.Location = new System.Drawing.Point(0, 0);
      this.topPanel.Name = "topPanel";
      this.topPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.TopBarS;
      this.topPanel.Size = new System.Drawing.Size(446, 20);
      this.topPanel.TabIndex = 0;
      // 
      // copyBtn
      // 
      this.copyBtn.BackColor = System.Drawing.Color.Transparent;
      this.copyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.copyBtn.FlatAppearance.BorderSize = 0;
      this.copyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.copyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.copyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.copyBtn.Image = global::Tibia_Utilities.Properties.Resources.Copy;
      this.copyBtn.Location = new System.Drawing.Point(357, 26);
      this.copyBtn.Name = "copyBtn";
      this.copyBtn.Size = new System.Drawing.Size(32, 32);
      this.copyBtn.TabIndex = 5;
      this.copyBtn.UseVisualStyleBackColor = false;
      // 
      // PlayerTransfer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.viewPort);
      this.Name = "PlayerTransfer";
      this.Size = new System.Drawing.Size(446, 70);
      this.viewPort.ResumeLayout(false);
      this.viewPort.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.imgCoin)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private TUSlicePanel viewPort;
    private TUSlicePanel topPanel;
    private System.Windows.Forms.Label lblPayer;
    private System.Windows.Forms.PictureBox imgCoin;
    private System.Windows.Forms.Label lblAmount;
    private System.Windows.Forms.Label lblReceiver;
    private TUCtrlButton copyBtn;
  }
}
