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
      this.label1 = new System.Windows.Forms.Label();
      this.viewPanel = new TibiaUtilities.CustomControls.TUPanel();
      this.tuControlButton1 = new TibiaUtilities.CustomControls.TUControlButton();
      this.closeBtn = new TibiaUtilities.CustomControls.TUControlButton();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Location = new System.Drawing.Point(346, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(66, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tibia Utilities";
      // 
      // viewPanel
      // 
      this.viewPanel.BackColor = System.Drawing.Color.Transparent;
      this.viewPanel.Location = new System.Drawing.Point(19, 81);
      this.viewPanel.Name = "viewPanel";
      this.viewPanel.Size = new System.Drawing.Size(764, 474);
      this.viewPanel.TabIndex = 3;
      // 
      // tuControlButton1
      // 
      this.tuControlButton1.Image = global::TibiaUtilities.Properties.Resources.MinimizeBtn;
      this.tuControlButton1.Location = new System.Drawing.Point(764, 3);
      this.tuControlButton1.Name = "tuControlButton1";
      this.tuControlButton1.Size = new System.Drawing.Size(15, 15);
      this.tuControlButton1.TabIndex = 2;
      this.tuControlButton1.Text = "tuControlButton1";
      this.tuControlButton1.Click += new System.EventHandler(this.tuControlButton1_Click);
      // 
      // closeBtn
      // 
      this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
      this.closeBtn.Location = new System.Drawing.Point(780, 3);
      this.closeBtn.Name = "closeBtn";
      this.closeBtn.Size = new System.Drawing.Size(15, 15);
      this.closeBtn.TabIndex = 1;
      this.closeBtn.Text = "tuControlButton1";
      this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(800, 615);
      this.Controls.Add(this.viewPanel);
      this.Controls.Add(this.tuControlButton1);
      this.Controls.Add(this.closeBtn);
      this.Controls.Add(this.label1);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximumSize = new System.Drawing.Size(800, 615);
      this.MinimumSize = new System.Drawing.Size(800, 615);
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Main";
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private CustomControls.TUControlButton closeBtn;
    private CustomControls.TUControlButton tuControlButton1;
    private CustomControls.TUPanel viewPanel;
  }
}