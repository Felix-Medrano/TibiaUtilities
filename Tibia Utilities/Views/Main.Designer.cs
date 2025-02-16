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
      this.mainTopControlPanel = new Tibia_Utilities.CustomControls.TUTopControlBar();
      this.mainTitle = new System.Windows.Forms.Label();
      this.minimizeButton = new Tibia_Utilities.CustomControls.TUCtrlButton();
      this.closeButton = new Tibia_Utilities.CustomControls.TUCtrlButton();
      this.tuSlicePanel1 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.mainTopControlPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // mainTopControlPanel
      // 
      this.mainTopControlPanel.Controls.Add(this.mainTitle);
      this.mainTopControlPanel.Controls.Add(this.minimizeButton);
      this.mainTopControlPanel.Controls.Add(this.closeButton);
      this.mainTopControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.mainTopControlPanel.EdgeWidth = 50;
      this.mainTopControlPanel.Location = new System.Drawing.Point(0, 0);
      this.mainTopControlPanel.Name = "mainTopControlPanel";
      this.mainTopControlPanel.OriginalImage = ((System.Drawing.Image)(resources.GetObject("mainTopControlPanel.OriginalImage")));
      this.mainTopControlPanel.Size = new System.Drawing.Size(800, 20);
      this.mainTopControlPanel.TabIndex = 0;
      // 
      // mainTitle
      // 
      this.mainTitle.AutoSize = true;
      this.mainTitle.BackColor = System.Drawing.Color.Transparent;
      this.mainTitle.Location = new System.Drawing.Point(327, 2);
      this.mainTitle.Margin = new System.Windows.Forms.Padding(0);
      this.mainTitle.Name = "mainTitle";
      this.mainTitle.Size = new System.Drawing.Size(66, 13);
      this.mainTitle.TabIndex = 3;
      this.mainTitle.Text = "Tibia Utilities";
      this.mainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // minimizeButton
      // 
      this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
      this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.minimizeButton.FlatAppearance.BorderSize = 0;
      this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.minimizeButton.ForeColor = System.Drawing.Color.Transparent;
      this.minimizeButton.Image = global::Tibia_Utilities.Properties.Resources.MinimizeBtn;
      this.minimizeButton.Location = new System.Drawing.Point(765, 3);
      this.minimizeButton.Margin = new System.Windows.Forms.Padding(0);
      this.minimizeButton.Name = "minimizeButton";
      this.minimizeButton.Size = new System.Drawing.Size(15, 15);
      this.minimizeButton.TabIndex = 2;
      this.minimizeButton.UseVisualStyleBackColor = false;
      // 
      // closeButton
      // 
      this.closeButton.BackColor = System.Drawing.Color.Transparent;
      this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.closeButton.FlatAppearance.BorderSize = 0;
      this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.closeButton.ForeColor = System.Drawing.Color.Transparent;
      this.closeButton.Image = global::Tibia_Utilities.Properties.Resources.CloseBtn;
      this.closeButton.Location = new System.Drawing.Point(780, 3);
      this.closeButton.Margin = new System.Windows.Forms.Padding(0);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(15, 15);
      this.closeButton.TabIndex = 1;
      this.closeButton.UseVisualStyleBackColor = false;
      // 
      // tuSlicePanel1
      // 
      this.tuSlicePanel1.EdgeHeight = 0;
      this.tuSlicePanel1.EdgeWidth = 0;
      this.tuSlicePanel1.Location = new System.Drawing.Point(19, 34);
      this.tuSlicePanel1.Name = "tuSlicePanel1";
      this.tuSlicePanel1.OriginalImage = global::Tibia_Utilities.Properties.Resources.MainButtonPanel;
      this.tuSlicePanel1.Size = new System.Drawing.Size(761, 41);
      this.tuSlicePanel1.TabIndex = 1;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::Tibia_Utilities.Properties.Resources.Background;
      this.ClientSize = new System.Drawing.Size(800, 615);
      this.Controls.Add(this.tuSlicePanel1);
      this.Controls.Add(this.mainTopControlPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximumSize = new System.Drawing.Size(800, 615);
      this.MinimumSize = new System.Drawing.Size(800, 615);
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Tibia Utilities";
      this.mainTopControlPanel.ResumeLayout(false);
      this.mainTopControlPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControls.TUTopControlBar mainTopControlPanel;
    private CustomControls.TUCtrlButton closeButton;
    private CustomControls.TUCtrlButton minimizeButton;
    private System.Windows.Forms.Label mainTitle;
    private CustomControls.TUSlicePanel tuSlicePanel1;
  }
}

