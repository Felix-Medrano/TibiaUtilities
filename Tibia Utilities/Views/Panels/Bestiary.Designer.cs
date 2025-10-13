namespace Tibia_Utilities.Views.Panels
{
  partial class Bestiary
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
      this.viewPanel = new Tibia_Utilities.CustomControls.TUPanel();
      this.tuSlicePanel1 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.CreatureTypePanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.viewPort = new Tibia_Utilities.CustomControls.TUPanel();
      this.container = new Tibia_Utilities.CustomControls.TUPanel();
      this.CreatureTypeLayOut = new Tibia_Utilities.CustomControls.TUFlowLayoutPanel();
      this.VScrollBar = new Tibia_Utilities.CustomControls.TibiaVScrollBar();
      this.viewPanel.SuspendLayout();
      this.tuSlicePanel1.SuspendLayout();
      this.CreatureTypePanel.SuspendLayout();
      this.viewPort.SuspendLayout();
      this.container.SuspendLayout();
      this.SuspendLayout();
      // 
      // viewPanel
      // 
      this.viewPanel.Controls.Add(this.tuSlicePanel1);
      this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPanel.Location = new System.Drawing.Point(0, 0);
      this.viewPanel.Name = "viewPanel";
      this.viewPanel.Size = new System.Drawing.Size(764, 475);
      this.viewPanel.TabIndex = 0;
      // 
      // tuSlicePanel1
      // 
      this.tuSlicePanel1.Controls.Add(this.CreatureTypePanel);
      this.tuSlicePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tuSlicePanel1.Location = new System.Drawing.Point(0, 0);
      this.tuSlicePanel1.Name = "tuSlicePanel1";
      this.tuSlicePanel1.OriginalImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.tuSlicePanel1.Size = new System.Drawing.Size(764, 475);
      this.tuSlicePanel1.TabIndex = 0;
      // 
      // CreatureTypePanel
      // 
      this.CreatureTypePanel.BackColor = System.Drawing.Color.Transparent;
      this.CreatureTypePanel.Controls.Add(this.viewPort);
      this.CreatureTypePanel.Controls.Add(this.VScrollBar);
      this.CreatureTypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CreatureTypePanel.Location = new System.Drawing.Point(0, 0);
      this.CreatureTypePanel.Name = "CreatureTypePanel";
      this.CreatureTypePanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.CreatureTypePanel.Size = new System.Drawing.Size(764, 475);
      this.CreatureTypePanel.TabIndex = 0;
      // 
      // viewPort
      // 
      this.viewPort.Controls.Add(this.container);
      this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPort.Location = new System.Drawing.Point(0, 0);
      this.viewPort.Name = "viewPort";
      this.viewPort.Size = new System.Drawing.Size(748, 475);
      this.viewPort.TabIndex = 1;
      // 
      // container
      // 
      this.container.BackColor = System.Drawing.Color.Transparent;
      this.container.Controls.Add(this.CreatureTypeLayOut);
      this.container.Location = new System.Drawing.Point(0, 0);
      this.container.Name = "container";
      this.container.Size = new System.Drawing.Size(748, 0);
      this.container.TabIndex = 0;
      // 
      // CreatureTypeLayOut
      // 
      this.CreatureTypeLayOut.BackColor = System.Drawing.Color.Transparent;
      this.CreatureTypeLayOut.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CreatureTypeLayOut.Location = new System.Drawing.Point(0, 0);
      this.CreatureTypeLayOut.Margin = new System.Windows.Forms.Padding(0);
      this.CreatureTypeLayOut.Name = "CreatureTypeLayOut";
      this.CreatureTypeLayOut.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
      this.CreatureTypeLayOut.Size = new System.Drawing.Size(748, 0);
      this.CreatureTypeLayOut.TabIndex = 0;
      // 
      // VScrollBar
      // 
      this.VScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
      this.VScrollBar.Location = new System.Drawing.Point(748, 0);
      this.VScrollBar.Name = "VScrollBar";
      this.VScrollBar.Size = new System.Drawing.Size(16, 475);
      this.VScrollBar.Step = 10;
      this.VScrollBar.TabIndex = 2;
      this.VScrollBar.ViewContainer = this.container;
      this.VScrollBar.ViewPort = this.viewPort;
      // 
      // Bestiary
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(764, 475);
      this.Controls.Add(this.viewPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Bestiary";
      this.Text = "Form";
      this.viewPanel.ResumeLayout(false);
      this.tuSlicePanel1.ResumeLayout(false);
      this.CreatureTypePanel.ResumeLayout(false);
      this.viewPort.ResumeLayout(false);
      this.container.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControls.TUPanel viewPanel;
    private CustomControls.TUSlicePanel tuSlicePanel1;
    private CustomControls.TUSlicePanel CreatureTypePanel;
    private CustomControls.TUPanel viewPort;
    private CustomControls.TUPanel container;
    private CustomControls.TibiaVScrollBar VScrollBar;
    private CustomControls.TUFlowLayoutPanel CreatureTypeLayOut;
  }
}