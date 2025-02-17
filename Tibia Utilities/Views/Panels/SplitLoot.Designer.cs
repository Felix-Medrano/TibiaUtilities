namespace Tibia_Utilities.Views.Panels
{
  partial class SplitLoot
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
      this.rightPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.leftPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.topPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.tuSlicePanel1 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblSplitLoot = new System.Windows.Forms.Label();
      this.viewPanel.SuspendLayout();
      this.topPanel.SuspendLayout();
      this.tuSlicePanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // viewPanel
      // 
      this.viewPanel.Controls.Add(this.rightPanel);
      this.viewPanel.Controls.Add(this.leftPanel);
      this.viewPanel.Controls.Add(this.topPanel);
      this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPanel.Location = new System.Drawing.Point(0, 0);
      this.viewPanel.Name = "viewPanel";
      this.viewPanel.Size = new System.Drawing.Size(764, 475);
      this.viewPanel.TabIndex = 0;
      // 
      // rightPanel
      // 
      this.rightPanel.EdgeHeight = 5;
      this.rightPanel.EdgeWidth = 5;
      this.rightPanel.Location = new System.Drawing.Point(292, 66);
      this.rightPanel.Name = "rightPanel";
      this.rightPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.rightPanel.Size = new System.Drawing.Size(472, 409);
      this.rightPanel.TabIndex = 2;
      // 
      // leftPanel
      // 
      this.leftPanel.EdgeHeight = 5;
      this.leftPanel.EdgeWidth = 5;
      this.leftPanel.Location = new System.Drawing.Point(0, 66);
      this.leftPanel.Name = "leftPanel";
      this.leftPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.leftPanel.Size = new System.Drawing.Size(286, 409);
      this.leftPanel.TabIndex = 1;
      // 
      // topPanel
      // 
      this.topPanel.Controls.Add(this.tuSlicePanel1);
      this.topPanel.EdgeHeight = 5;
      this.topPanel.EdgeWidth = 5;
      this.topPanel.Location = new System.Drawing.Point(0, 0);
      this.topPanel.Name = "topPanel";
      this.topPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.topPanel.Size = new System.Drawing.Size(764, 60);
      this.topPanel.TabIndex = 0;
      // 
      // tuSlicePanel1
      // 
      this.tuSlicePanel1.Controls.Add(this.lblSplitLoot);
      this.tuSlicePanel1.EdgeHeight = 2;
      this.tuSlicePanel1.EdgeWidth = 2;
      this.tuSlicePanel1.Location = new System.Drawing.Point(150, 21);
      this.tuSlicePanel1.Name = "tuSlicePanel1";
      this.tuSlicePanel1.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.tuSlicePanel1.Size = new System.Drawing.Size(88, 22);
      this.tuSlicePanel1.TabIndex = 0;
      // 
      // lblSplitLoot
      // 
      this.lblSplitLoot.AutoSize = true;
      this.lblSplitLoot.BackColor = System.Drawing.Color.Transparent;
      this.lblSplitLoot.Location = new System.Drawing.Point(17, 4);
      this.lblSplitLoot.Name = "lblSplitLoot";
      this.lblSplitLoot.Size = new System.Drawing.Size(51, 13);
      this.lblSplitLoot.TabIndex = 0;
      this.lblSplitLoot.Text = "Split Loot";
      // 
      // SplitLoot
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(764, 475);
      this.Controls.Add(this.viewPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "SplitLoot";
      this.Text = "Form";
      this.viewPanel.ResumeLayout(false);
      this.topPanel.ResumeLayout(false);
      this.tuSlicePanel1.ResumeLayout(false);
      this.tuSlicePanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControls.TUPanel viewPanel;
    private CustomControls.TUSlicePanel topPanel;
    private CustomControls.TUSlicePanel leftPanel;
    private CustomControls.TUSlicePanel rightPanel;
    private CustomControls.TUSlicePanel tuSlicePanel1;
    private System.Windows.Forms.Label lblSplitLoot;
  }
}