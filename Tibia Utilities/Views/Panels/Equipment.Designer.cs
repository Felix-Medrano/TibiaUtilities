namespace Tibia_Utilities.Views.Panels
{
  partial class Equipment
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
      this.viewPanel = new Tibia_Utilities.CustomControls.TUPanel();
      this.mainViewPort = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.tuMainPanelButton1 = new Tibia_Utilities.CustomControls.TUMainPanelButton();
      this.viewPanel.SuspendLayout();
      this.mainViewPort.SuspendLayout();
      this.SuspendLayout();
      // 
      // viewPanel
      // 
      this.viewPanel.Controls.Add(this.mainViewPort);
      this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPanel.Location = new System.Drawing.Point(0, 0);
      this.viewPanel.Name = "viewPanel";
      this.viewPanel.Size = new System.Drawing.Size(764, 475);
      this.viewPanel.TabIndex = 0;
      // 
      // mainViewPort
      // 
      this.mainViewPort.Controls.Add(this.tuMainPanelButton1);
      this.mainViewPort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainViewPort.Location = new System.Drawing.Point(0, 0);
      this.mainViewPort.Margin = new System.Windows.Forms.Padding(0);
      this.mainViewPort.Name = "mainViewPort";
      this.mainViewPort.OriginalImage = global::Tibia_Utilities.Properties.Resources.TextureBackground;
      this.mainViewPort.Size = new System.Drawing.Size(764, 475);
      this.mainViewPort.TabIndex = 0;
      // 
      // tuMainPanelButton1
      // 
      this.tuMainPanelButton1.FlatAppearance.BorderSize = 0;
      this.tuMainPanelButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.tuMainPanelButton1.Icon = null;
      this.tuMainPanelButton1.Location = new System.Drawing.Point(43, 101);
      this.tuMainPanelButton1.Name = "tuMainPanelButton1";
      this.tuMainPanelButton1.Panel = null;
      this.tuMainPanelButton1.PressedImage = ((System.Drawing.Image)(resources.GetObject("tuMainPanelButton1.PressedImage")));
      this.tuMainPanelButton1.SelectedImage = ((System.Drawing.Image)(resources.GetObject("tuMainPanelButton1.SelectedImage")));
      this.tuMainPanelButton1.SelectedText = "Seleccionado";
      this.tuMainPanelButton1.Size = new System.Drawing.Size(39, 39);
      this.tuMainPanelButton1.TabIndex = 1;
      this.tuMainPanelButton1.Text = "tuMainPanelButton1";
      this.tuMainPanelButton1.UnpressedImage = ((System.Drawing.Image)(resources.GetObject("tuMainPanelButton1.UnpressedImage")));
      this.tuMainPanelButton1.UseVisualStyleBackColor = true;
      // 
      // Equipment
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(764, 475);
      this.Controls.Add(this.viewPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Equipment";
      this.Text = "Form";
      this.viewPanel.ResumeLayout(false);
      this.mainViewPort.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControls.TUPanel viewPanel;
    private CustomControls.TUSlicePanel mainViewPort;
    private CustomControls.TUMainPanelButton tuMainPanelButton1;
  }
}