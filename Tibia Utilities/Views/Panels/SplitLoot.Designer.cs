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
      this.tuSlicePanel3 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.tuSlicePanel2 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.tuSlicePanel1 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.viewPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // viewPanel
      // 
      this.viewPanel.Controls.Add(this.tuSlicePanel3);
      this.viewPanel.Controls.Add(this.tuSlicePanel2);
      this.viewPanel.Controls.Add(this.tuSlicePanel1);
      this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPanel.Location = new System.Drawing.Point(0, 0);
      this.viewPanel.Name = "viewPanel";
      this.viewPanel.Size = new System.Drawing.Size(764, 475);
      this.viewPanel.TabIndex = 0;
      // 
      // tuSlicePanel3
      // 
      this.tuSlicePanel3.EdgeHeight = 5;
      this.tuSlicePanel3.EdgeWidth = 5;
      this.tuSlicePanel3.Location = new System.Drawing.Point(292, 66);
      this.tuSlicePanel3.Name = "tuSlicePanel3";
      this.tuSlicePanel3.OriginalImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.tuSlicePanel3.Size = new System.Drawing.Size(472, 409);
      this.tuSlicePanel3.TabIndex = 2;
      // 
      // tuSlicePanel2
      // 
      this.tuSlicePanel2.EdgeHeight = 5;
      this.tuSlicePanel2.EdgeWidth = 5;
      this.tuSlicePanel2.Location = new System.Drawing.Point(0, 66);
      this.tuSlicePanel2.Name = "tuSlicePanel2";
      this.tuSlicePanel2.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.tuSlicePanel2.Size = new System.Drawing.Size(286, 409);
      this.tuSlicePanel2.TabIndex = 1;
      // 
      // tuSlicePanel1
      // 
      this.tuSlicePanel1.EdgeHeight = 5;
      this.tuSlicePanel1.EdgeWidth = 5;
      this.tuSlicePanel1.Location = new System.Drawing.Point(0, 0);
      this.tuSlicePanel1.Name = "tuSlicePanel1";
      this.tuSlicePanel1.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.tuSlicePanel1.Size = new System.Drawing.Size(764, 60);
      this.tuSlicePanel1.TabIndex = 0;
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
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControls.TUPanel viewPanel;
    private CustomControls.TUSlicePanel tuSlicePanel1;
    private CustomControls.TUSlicePanel tuSlicePanel2;
    private CustomControls.TUSlicePanel tuSlicePanel3;
  }
}