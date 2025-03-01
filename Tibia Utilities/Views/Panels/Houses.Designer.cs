namespace Tibia_Utilities.Views.Panels
{
  partial class Houses
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
      this.rightContainer = new Tibia_Utilities.CustomControls.TUPanel();
      this.rightScrollBar = new Tibia_Utilities.CustomControls.TibiaVScrollBar();
      this.houseViewport = new Tibia_Utilities.CustomControls.TUPanel();
      this.rightLblNoInfo = new System.Windows.Forms.Label();
      this.leftPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.leftLblNoInfo = new System.Windows.Forms.Label();
      this.controlPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.tibiaComboBox1 = new Tibia_Utilities.CustomControls.TibiaComboBox();
      this.tibiaComboBox2 = new Tibia_Utilities.CustomControls.TibiaComboBox();
      this.viewPanel.SuspendLayout();
      this.rightPanel.SuspendLayout();
      this.rightContainer.SuspendLayout();
      this.leftPanel.SuspendLayout();
      this.controlPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // viewPanel
      // 
      this.viewPanel.BackColor = System.Drawing.Color.Transparent;
      this.viewPanel.Controls.Add(this.rightPanel);
      this.viewPanel.Controls.Add(this.leftPanel);
      this.viewPanel.Controls.Add(this.controlPanel);
      this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPanel.Location = new System.Drawing.Point(0, 0);
      this.viewPanel.Name = "viewPanel";
      this.viewPanel.Size = new System.Drawing.Size(764, 475);
      this.viewPanel.TabIndex = 0;
      // 
      // rightPanel
      // 
      this.rightPanel.Controls.Add(this.rightContainer);
      this.rightPanel.EdgeHeight = 5;
      this.rightPanel.EdgeWidth = 5;
      this.rightPanel.Location = new System.Drawing.Point(292, 66);
      this.rightPanel.Name = "rightPanel";
      this.rightPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.rightPanel.Size = new System.Drawing.Size(472, 409);
      this.rightPanel.TabIndex = 3;
      // 
      // rightContainer
      // 
      this.rightContainer.Controls.Add(this.rightScrollBar);
      this.rightContainer.Controls.Add(this.rightLblNoInfo);
      this.rightContainer.Controls.Add(this.houseViewport);
      this.rightContainer.Location = new System.Drawing.Point(3, 2);
      this.rightContainer.Name = "rightContainer";
      this.rightContainer.Size = new System.Drawing.Size(468, 405);
      this.rightContainer.TabIndex = 1;
      // 
      // rightScrollBar
      // 
      this.rightScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
      this.rightScrollBar.Location = new System.Drawing.Point(452, 0);
      this.rightScrollBar.Name = "rightScrollBar";
      this.rightScrollBar.Size = new System.Drawing.Size(16, 405);
      this.rightScrollBar.Step = 10;
      this.rightScrollBar.TabIndex = 1;
      this.rightScrollBar.viewContainer = this.rightContainer;
      this.rightScrollBar.viewPort = this.houseViewport;
      // 
      // houseViewport
      // 
      this.houseViewport.BackColor = System.Drawing.Color.Transparent;
      this.houseViewport.Location = new System.Drawing.Point(0, 0);
      this.houseViewport.Name = "houseViewport";
      this.houseViewport.Size = new System.Drawing.Size(452, 0);
      this.houseViewport.TabIndex = 0;
      // 
      // rightLblNoInfo
      // 
      this.rightLblNoInfo.AutoSize = true;
      this.rightLblNoInfo.Location = new System.Drawing.Point(199, 237);
      this.rightLblNoInfo.Name = "rightLblNoInfo";
      this.rightLblNoInfo.Size = new System.Drawing.Size(35, 13);
      this.rightLblNoInfo.TabIndex = 2;
      this.rightLblNoInfo.Text = "label2";
      // 
      // leftPanel
      // 
      this.leftPanel.Controls.Add(this.leftLblNoInfo);
      this.leftPanel.EdgeHeight = 5;
      this.leftPanel.EdgeWidth = 5;
      this.leftPanel.Location = new System.Drawing.Point(0, 66);
      this.leftPanel.Name = "leftPanel";
      this.leftPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.leftPanel.Size = new System.Drawing.Size(286, 409);
      this.leftPanel.TabIndex = 2;
      // 
      // leftLblNoInfo
      // 
      this.leftLblNoInfo.AutoSize = true;
      this.leftLblNoInfo.Location = new System.Drawing.Point(102, 170);
      this.leftLblNoInfo.Name = "leftLblNoInfo";
      this.leftLblNoInfo.Size = new System.Drawing.Size(35, 13);
      this.leftLblNoInfo.TabIndex = 0;
      this.leftLblNoInfo.Text = "label1";
      // 
      // controlPanel
      // 
      this.controlPanel.Controls.Add(this.tibiaComboBox2);
      this.controlPanel.Controls.Add(this.tibiaComboBox1);
      this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.controlPanel.Location = new System.Drawing.Point(0, 0);
      this.controlPanel.Name = "controlPanel";
      this.controlPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.controlPanel.Size = new System.Drawing.Size(764, 60);
      this.controlPanel.TabIndex = 0;
      // 
      // tibiaComboBox1
      // 
      this.tibiaComboBox1.Location = new System.Drawing.Point(36, 16);
      this.tibiaComboBox1.MainView = this.viewPanel;
      this.tibiaComboBox1.Name = "tibiaComboBox1";
      this.tibiaComboBox1.Size = new System.Drawing.Size(210, 23);
      this.tibiaComboBox1.TabIndex = 0;
      // 
      // tibiaComboBox2
      // 
      this.tibiaComboBox2.Location = new System.Drawing.Point(399, 16);
      this.tibiaComboBox2.MainView = this.viewPanel;
      this.tibiaComboBox2.Name = "tibiaComboBox2";
      this.tibiaComboBox2.Size = new System.Drawing.Size(210, 23);
      this.tibiaComboBox2.TabIndex = 1;
      // 
      // Houses
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(764, 475);
      this.Controls.Add(this.viewPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Houses";
      this.Text = "Form";
      this.viewPanel.ResumeLayout(false);
      this.rightPanel.ResumeLayout(false);
      this.rightContainer.ResumeLayout(false);
      this.rightContainer.PerformLayout();
      this.leftPanel.ResumeLayout(false);
      this.leftPanel.PerformLayout();
      this.controlPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControls.TUPanel viewPanel;
    private CustomControls.TUSlicePanel controlPanel;
    private CustomControls.TUSlicePanel leftPanel;
    private CustomControls.TUSlicePanel rightPanel;
    private System.Windows.Forms.Label rightLblNoInfo;
    private System.Windows.Forms.Label leftLblNoInfo;
    private CustomControls.TUPanel rightContainer;
    private CustomControls.TibiaVScrollBar rightScrollBar;
    private CustomControls.TUPanel houseViewport;
    private CustomControls.TibiaComboBox tibiaComboBox1;
    private CustomControls.TibiaComboBox tibiaComboBox2;
  }
}