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
      this.mainButtonPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.mainTopControlPanel = new Tibia_Utilities.CustomControls.TUTopControlBar();
      this.mainTitle = new System.Windows.Forms.Label();
      this.minimizeButton = new Tibia_Utilities.CustomControls.TUCtrlButton();
      this.closeButton = new Tibia_Utilities.CustomControls.TUCtrlButton();
      this.mainPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.mainView = new Tibia_Utilities.CustomControls.TUPanel();
      this.mainTopControlPanel.SuspendLayout();
      this.mainPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // mainButtonPanel
      // 
      this.mainButtonPanel.EdgeHeight = 0;
      this.mainButtonPanel.EdgeWidth = 0;
      this.mainButtonPanel.Location = new System.Drawing.Point(19, 34);
      this.mainButtonPanel.Margin = new System.Windows.Forms.Padding(0);
      this.mainButtonPanel.Name = "mainButtonPanel";
      this.mainButtonPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.MainButtonPanel;
      this.mainButtonPanel.Size = new System.Drawing.Size(764, 41);
      this.mainButtonPanel.TabIndex = 1;
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
      // mainPanel
      // 
      this.mainPanel.Controls.Add(this.mainView);
      this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainPanel.EdgeHeight = 5;
      this.mainPanel.EdgeWidth = 5;
      this.mainPanel.Location = new System.Drawing.Point(0, 0);
      this.mainPanel.Name = "mainPanel";
      this.mainPanel.OriginalImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.OriginalImage")));
      this.mainPanel.Size = new System.Drawing.Size(800, 615);
      this.mainPanel.TabIndex = 3;
      // 
      // mainView
      // 
      this.mainView.BackColor = System.Drawing.Color.Transparent;
      this.mainView.Location = new System.Drawing.Point(19, 81);
      this.mainView.Margin = new System.Windows.Forms.Padding(0);
      this.mainView.Name = "mainView";
      this.mainView.Size = new System.Drawing.Size(764, 475);
      this.mainView.TabIndex = 0;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 615);
      this.Controls.Add(this.mainButtonPanel);
      this.Controls.Add(this.mainTopControlPanel);
      this.Controls.Add(this.mainPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximumSize = new System.Drawing.Size(800, 615);
      this.MinimumSize = new System.Drawing.Size(800, 615);
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Tibia Utilities";
      this.mainTopControlPanel.ResumeLayout(false);
      this.mainTopControlPanel.PerformLayout();
      this.mainPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControls.TUTopControlBar mainTopControlPanel;
    private CustomControls.TUCtrlButton closeButton;
    private CustomControls.TUCtrlButton minimizeButton;
    private System.Windows.Forms.Label mainTitle;
    private CustomControls.TUSlicePanel mainButtonPanel;
    private CustomControls.TUSlicePanel mainPanel;
    private CustomControls.TUPanel mainView;
  }
}

