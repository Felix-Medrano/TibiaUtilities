namespace TibiaUtilities.Views
{
  partial class Main
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.topControlBar = new TibiaUtilities.CustomControls.TUPanel();
      this.lblTitle = new System.Windows.Forms.Label();
      this.closeBtn = new TibiaUtilities.CustomControls.TUControlButton();
      this.tuControlButton1 = new TibiaUtilities.CustomControls.TUControlButton();
      this.viewPanel = new TibiaUtilities.CustomControls.TUPanel();
      this.bottomSeparator = new TibiaUtilities.CustomControls.TUPanel();
      this.topControlBar.SuspendLayout();
      this.SuspendLayout();
      // 
      // topControlBar
      // 
      this.topControlBar.BackColor = System.Drawing.Color.Transparent;
      this.topControlBar.Controls.Add(this.lblTitle);
      this.topControlBar.Controls.Add(this.closeBtn);
      this.topControlBar.Controls.Add(this.tuControlButton1);
      this.topControlBar.Location = new System.Drawing.Point(0, 0);
      this.topControlBar.Name = "topControlBar";
      this.topControlBar.Size = new System.Drawing.Size(800, 19);
      this.topControlBar.TabIndex = 5;
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.BackColor = System.Drawing.Color.Transparent;
      this.lblTitle.Location = new System.Drawing.Point(386, 3);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(35, 13);
      this.lblTitle.TabIndex = 4;
      this.lblTitle.Text = "label1";
      // 
      // closeBtn
      // 
      this.closeBtn.CornerHeight = 17;
      this.closeBtn.CornerWidth = 5;
      this.closeBtn.DrawText = false;
      this.closeBtn.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
      this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
      this.closeBtn.Image = global::TibiaUtilities.Properties.Resources.CloseBtn;
      this.closeBtn.Location = new System.Drawing.Point(780, 3);
      this.closeBtn.Name = "closeBtn";
      this.closeBtn.Size = new System.Drawing.Size(15, 15);
      this.closeBtn.SliceType = TibiaUtilities.Lib.TUFunctions.SliceType.NineSlice;
      this.closeBtn.TabIndex = 1;
      this.closeBtn.Text = "tuControlButton1";
      this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
      // 
      // tuControlButton1
      // 
      this.tuControlButton1.CornerHeight = 17;
      this.tuControlButton1.CornerWidth = 5;
      this.tuControlButton1.DrawText = false;
      this.tuControlButton1.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
      this.tuControlButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
      this.tuControlButton1.Image = global::TibiaUtilities.Properties.Resources.MinimizeBtn;
      this.tuControlButton1.Location = new System.Drawing.Point(763, 3);
      this.tuControlButton1.Name = "tuControlButton1";
      this.tuControlButton1.Size = new System.Drawing.Size(15, 15);
      this.tuControlButton1.SliceType = TibiaUtilities.Lib.TUFunctions.SliceType.None;
      this.tuControlButton1.TabIndex = 2;
      this.tuControlButton1.Text = "tuControlButton1";
      this.tuControlButton1.Click += new System.EventHandler(this.tuControlButton1_Click);
      // 
      // viewPanel
      // 
      this.viewPanel.BackColor = System.Drawing.Color.Transparent;
      this.viewPanel.Location = new System.Drawing.Point(18, 81);
      this.viewPanel.Name = "viewPanel";
      this.viewPanel.Size = new System.Drawing.Size(764, 475);
      this.viewPanel.TabIndex = 3;
      // 
      // bottomSeparator
      // 
      this.bottomSeparator.BackgroundImage = global::TibiaUtilities.Properties.Resources.BottomSeparator;
      this.bottomSeparator.Location = new System.Drawing.Point(18, 560);
      this.bottomSeparator.Name = "bottomSeparator";
      this.bottomSeparator.Size = new System.Drawing.Size(764, 3);
      this.bottomSeparator.TabIndex = 6;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(800, 615);
      this.Controls.Add(this.bottomSeparator);
      this.Controls.Add(this.topControlBar);
      this.Controls.Add(this.viewPanel);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximumSize = new System.Drawing.Size(800, 615);
      this.MinimumSize = new System.Drawing.Size(800, 615);
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Main";
      this.topControlBar.ResumeLayout(false);
      this.topControlBar.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private CustomControls.TUControlButton closeBtn;
    private CustomControls.TUControlButton tuControlButton1;
    private CustomControls.TUPanel viewPanel;
    private System.Windows.Forms.Label lblTitle;
    private CustomControls.TUPanel topControlBar;
    private CustomControls.TUPanel bottomSeparator;
  }
}