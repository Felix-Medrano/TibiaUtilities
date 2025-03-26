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
      this.rightContainer = new Tibia_Utilities.CustomControls.TUPanel();
      this.rightScrollBar = new Tibia_Utilities.CustomControls.TibiaVScrollBar();
      this.transferPlayerViewport = new Tibia_Utilities.CustomControls.TUPanel();
      this.leftPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.container = new Tibia_Utilities.CustomControls.TUPanel();
      this.leftScrollBar = new Tibia_Utilities.CustomControls.TibiaVScrollBar();
      this.partyPlayerViewPort = new Tibia_Utilities.CustomControls.TUPanel();
      this.topPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.clearBtn = new Tibia_Utilities.CustomControls.TUSliceButton();
      this.splitLootBtn = new Tibia_Utilities.CustomControls.TUSliceButton();
      this.viewPanel.SuspendLayout();
      this.rightPanel.SuspendLayout();
      this.rightContainer.SuspendLayout();
      this.leftPanel.SuspendLayout();
      this.container.SuspendLayout();
      this.topPanel.SuspendLayout();
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
      this.rightPanel.Controls.Add(this.rightContainer);
      this.rightPanel.EdgeHeight = 5;
      this.rightPanel.EdgeWidth = 5;
      this.rightPanel.Location = new System.Drawing.Point(292, 66);
      this.rightPanel.Name = "rightPanel";
      this.rightPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.FramedBackground;
      this.rightPanel.Size = new System.Drawing.Size(472, 409);
      this.rightPanel.TabIndex = 2;
      // 
      // rightContainer
      // 
      this.rightContainer.Controls.Add(this.rightScrollBar);
      this.rightContainer.Controls.Add(this.transferPlayerViewport);
      this.rightContainer.Location = new System.Drawing.Point(4, 4);
      this.rightContainer.Name = "rightContainer";
      this.rightContainer.Size = new System.Drawing.Size(462, 400);
      this.rightContainer.TabIndex = 1;
      // 
      // rightScrollBar
      // 
      this.rightScrollBar.Location = new System.Drawing.Point(446, 0);
      this.rightScrollBar.Name = "rightScrollBar";
      this.rightScrollBar.Size = new System.Drawing.Size(16, 400);
      this.rightScrollBar.Step = 10;
      this.rightScrollBar.TabIndex = 1;
      this.rightScrollBar.ViewPort = null;
      this.rightScrollBar.ViewContainer = null;
      this.rightScrollBar.Visible = false;
      // 
      // transferPlayerViewport
      // 
      this.transferPlayerViewport.Location = new System.Drawing.Point(0, 0);
      this.transferPlayerViewport.Name = "transferPlayerViewport";
      this.transferPlayerViewport.Size = new System.Drawing.Size(446, 0);
      this.transferPlayerViewport.TabIndex = 0;
      // 
      // leftPanel
      // 
      this.leftPanel.Controls.Add(this.container);
      this.leftPanel.EdgeHeight = 5;
      this.leftPanel.EdgeWidth = 5;
      this.leftPanel.Location = new System.Drawing.Point(0, 66);
      this.leftPanel.Name = "leftPanel";
      this.leftPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.FramedBackground;
      this.leftPanel.Size = new System.Drawing.Size(286, 409);
      this.leftPanel.TabIndex = 1;
      // 
      // container
      // 
      this.container.Controls.Add(this.leftScrollBar);
      this.container.Controls.Add(this.partyPlayerViewPort);
      this.container.Location = new System.Drawing.Point(4, 4);
      this.container.Name = "container";
      this.container.Size = new System.Drawing.Size(277, 400);
      this.container.TabIndex = 0;
      // 
      // leftScrollBar
      // 
      this.leftScrollBar.Location = new System.Drawing.Point(261, 0);
      this.leftScrollBar.Name = "leftScrollBar";
      this.leftScrollBar.Size = new System.Drawing.Size(16, 400);
      this.leftScrollBar.Step = 10;
      this.leftScrollBar.TabIndex = 1;
      this.leftScrollBar.ViewPort = null;
      this.leftScrollBar.ViewContainer = null;
      // 
      // partyPlayerViewPort
      // 
      this.partyPlayerViewPort.Location = new System.Drawing.Point(0, 0);
      this.partyPlayerViewPort.Name = "partyPlayerViewPort";
      this.partyPlayerViewPort.Size = new System.Drawing.Size(261, 0);
      this.partyPlayerViewPort.TabIndex = 0;
      this.partyPlayerViewPort.Resize += new System.EventHandler(this.partyPlayerViewPort_Resize);
      // 
      // topPanel
      // 
      this.topPanel.Controls.Add(this.clearBtn);
      this.topPanel.Controls.Add(this.splitLootBtn);
      this.topPanel.EdgeHeight = 5;
      this.topPanel.EdgeWidth = 5;
      this.topPanel.Location = new System.Drawing.Point(0, 0);
      this.topPanel.Name = "topPanel";
      this.topPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.topPanel.Size = new System.Drawing.Size(764, 60);
      this.topPanel.TabIndex = 0;
      // 
      // clearBtn
      // 
      this.clearBtn.Location = new System.Drawing.Point(105, 16);
      this.clearBtn.Name = "clearBtn";
      this.clearBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.clearBtn.PressedImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.clearBtn.Size = new System.Drawing.Size(87, 26);
      this.clearBtn.TabIndex = 1;
      this.clearBtn.Text = "Clear";
      this.clearBtn.UnpressedImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.clearBtn.UseVisualStyleBackColor = true;
      this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
      // 
      // splitLootBtn
      // 
      this.splitLootBtn.Location = new System.Drawing.Point(12, 16);
      this.splitLootBtn.Name = "splitLootBtn";
      this.splitLootBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.splitLootBtn.PressedImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.splitLootBtn.Size = new System.Drawing.Size(87, 26);
      this.splitLootBtn.TabIndex = 0;
      this.splitLootBtn.Text = "Split Loot";
      this.splitLootBtn.UnpressedImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.splitLootBtn.UseVisualStyleBackColor = true;
      this.splitLootBtn.Click += new System.EventHandler(this.Button_Click);
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
      this.rightPanel.ResumeLayout(false);
      this.rightContainer.ResumeLayout(false);
      this.leftPanel.ResumeLayout(false);
      this.container.ResumeLayout(false);
      this.topPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControls.TUPanel viewPanel;
    private CustomControls.TUSlicePanel topPanel;
    private CustomControls.TUSlicePanel leftPanel;
    private CustomControls.TUSlicePanel rightPanel;
    private CustomControls.TUPanel partyPlayerViewPort;
    private CustomControls.TibiaVScrollBar leftScrollBar;
    private CustomControls.TUPanel container;
    private CustomControls.TUPanel rightContainer;
    private CustomControls.TibiaVScrollBar rightScrollBar;
    private CustomControls.TUPanel transferPlayerViewport;
    private CustomControls.TUSliceButton clearBtn;
    private CustomControls.TUSliceButton splitLootBtn;
  }
}