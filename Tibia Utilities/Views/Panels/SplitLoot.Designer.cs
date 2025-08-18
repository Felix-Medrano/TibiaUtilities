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
      this.playerTransfersViewPort = new Tibia_Utilities.CustomControls.TUPanel();
      this.playerTransfersContainer = new Tibia_Utilities.CustomControls.TUPanel();
      this.rightScrollBar = new Tibia_Utilities.CustomControls.TibiaVScrollBar();
      this.tuSlicePanel1 = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.topPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.clearBtn = new Tibia_Utilities.CustomControls.TUSliceButton();
      this.splitLootBtn = new Tibia_Utilities.CustomControls.TUSliceButton();
      this.leftPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.leftScrollBar = new Tibia_Utilities.CustomControls.TibiaVScrollBar();
      this.partyPlayersContainer = new Tibia_Utilities.CustomControls.TUPanel();
      this.partyPlayersViewPort = new Tibia_Utilities.CustomControls.TUPanel();
      this.viewPanel.SuspendLayout();
      this.rightPanel.SuspendLayout();
      this.playerTransfersViewPort.SuspendLayout();
      this.tuSlicePanel1.SuspendLayout();
      this.topPanel.SuspendLayout();
      this.leftPanel.SuspendLayout();
      this.partyPlayersViewPort.SuspendLayout();
      this.SuspendLayout();
      // 
      // viewPanel
      // 
      this.viewPanel.Controls.Add(this.rightPanel);
      this.viewPanel.Controls.Add(this.tuSlicePanel1);
      this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPanel.Location = new System.Drawing.Point(0, 0);
      this.viewPanel.Name = "viewPanel";
      this.viewPanel.Size = new System.Drawing.Size(764, 475);
      this.viewPanel.TabIndex = 0;
      // 
      // rightPanel
      // 
      this.rightPanel.Controls.Add(this.playerTransfersViewPort);
      this.rightPanel.Controls.Add(this.rightScrollBar);
      this.rightPanel.EdgeHeight = 5;
      this.rightPanel.EdgeWidth = 5;
      this.rightPanel.Location = new System.Drawing.Point(292, 66);
      this.rightPanel.Name = "rightPanel";
      this.rightPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.FramedBackground;
      this.rightPanel.Padding = new System.Windows.Forms.Padding(4);
      this.rightPanel.Size = new System.Drawing.Size(472, 409);
      this.rightPanel.TabIndex = 2;
      // 
      // playerTransfersViewPort
      // 
      this.playerTransfersViewPort.BackColor = System.Drawing.Color.Transparent;
      this.playerTransfersViewPort.Controls.Add(this.playerTransfersContainer);
      this.playerTransfersViewPort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.playerTransfersViewPort.Location = new System.Drawing.Point(4, 4);
      this.playerTransfersViewPort.Name = "playerTransfersViewPort";
      this.playerTransfersViewPort.Size = new System.Drawing.Size(448, 401);
      this.playerTransfersViewPort.TabIndex = 2;
      // 
      // playerTransfersContainer
      // 
      this.playerTransfersContainer.Location = new System.Drawing.Point(0, 0);
      this.playerTransfersContainer.Name = "playerTransfersContainer";
      this.playerTransfersContainer.Size = new System.Drawing.Size(448, 0);
      this.playerTransfersContainer.TabIndex = 0;
      // 
      // rightScrollBar
      // 
      this.rightScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
      this.rightScrollBar.Location = new System.Drawing.Point(452, 4);
      this.rightScrollBar.Name = "rightScrollBar";
      this.rightScrollBar.Size = new System.Drawing.Size(16, 401);
      this.rightScrollBar.Step = 10;
      this.rightScrollBar.TabIndex = 1;
      this.rightScrollBar.ViewContainer = this.playerTransfersContainer;
      this.rightScrollBar.ViewPort = this.playerTransfersViewPort;
      // 
      // tuSlicePanel1
      // 
      this.tuSlicePanel1.Controls.Add(this.topPanel);
      this.tuSlicePanel1.Controls.Add(this.leftPanel);
      this.tuSlicePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tuSlicePanel1.Location = new System.Drawing.Point(0, 0);
      this.tuSlicePanel1.Name = "tuSlicePanel1";
      this.tuSlicePanel1.OriginalImage = global::Tibia_Utilities.Properties.Resources.TextureBackground;
      this.tuSlicePanel1.Size = new System.Drawing.Size(764, 475);
      this.tuSlicePanel1.TabIndex = 3;
      // 
      // topPanel
      // 
      this.topPanel.Controls.Add(this.clearBtn);
      this.topPanel.Controls.Add(this.splitLootBtn);
      this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
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
      // leftPanel
      // 
      this.leftPanel.Controls.Add(this.leftScrollBar);
      this.leftPanel.Controls.Add(this.partyPlayersViewPort);
      this.leftPanel.EdgeHeight = 5;
      this.leftPanel.EdgeWidth = 5;
      this.leftPanel.Location = new System.Drawing.Point(0, 66);
      this.leftPanel.Name = "leftPanel";
      this.leftPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.FramedBackground;
      this.leftPanel.Padding = new System.Windows.Forms.Padding(4);
      this.leftPanel.Size = new System.Drawing.Size(286, 409);
      this.leftPanel.TabIndex = 1;
      // 
      // leftScrollBar
      // 
      this.leftScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
      this.leftScrollBar.Location = new System.Drawing.Point(266, 4);
      this.leftScrollBar.Name = "leftScrollBar";
      this.leftScrollBar.Size = new System.Drawing.Size(16, 401);
      this.leftScrollBar.Step = 10;
      this.leftScrollBar.TabIndex = 0;
      this.leftScrollBar.ViewContainer = this.partyPlayersContainer;
      this.leftScrollBar.ViewPort = this.partyPlayersViewPort;
      // 
      // partyPlayersContainer
      // 
      this.partyPlayersContainer.Location = new System.Drawing.Point(0, 0);
      this.partyPlayersContainer.Name = "partyPlayersContainer";
      this.partyPlayersContainer.Size = new System.Drawing.Size(262, 0);
      this.partyPlayersContainer.TabIndex = 0;
      // 
      // partyPlayersViewPort
      // 
      this.partyPlayersViewPort.BackColor = System.Drawing.Color.Transparent;
      this.partyPlayersViewPort.Controls.Add(this.partyPlayersContainer);
      this.partyPlayersViewPort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.partyPlayersViewPort.Location = new System.Drawing.Point(4, 4);
      this.partyPlayersViewPort.Name = "partyPlayersViewPort";
      this.partyPlayersViewPort.Size = new System.Drawing.Size(278, 401);
      this.partyPlayersViewPort.TabIndex = 1;
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
      this.playerTransfersViewPort.ResumeLayout(false);
      this.tuSlicePanel1.ResumeLayout(false);
      this.topPanel.ResumeLayout(false);
      this.leftPanel.ResumeLayout(false);
      this.partyPlayersViewPort.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControls.TUPanel viewPanel;
    private CustomControls.TUSlicePanel topPanel;
    private CustomControls.TUSlicePanel leftPanel;
    private CustomControls.TUSlicePanel rightPanel;
    private CustomControls.TUSliceButton clearBtn;
    private CustomControls.TUSliceButton splitLootBtn;
    private CustomControls.TUSlicePanel tuSlicePanel1;
    private CustomControls.TibiaVScrollBar leftScrollBar;
    private CustomControls.TibiaVScrollBar rightScrollBar;
    private CustomControls.TUPanel partyPlayersViewPort;
    private CustomControls.TUPanel playerTransfersViewPort;
    private CustomControls.TUPanel playerTransfersContainer;
    private CustomControls.TUPanel partyPlayersContainer;
  }
}