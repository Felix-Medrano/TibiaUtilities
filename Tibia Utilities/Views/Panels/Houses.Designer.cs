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
      this.houseViewport = new Tibia_Utilities.CustomControls.TUPanel();
      this.rightScrollBar = new Tibia_Utilities.CustomControls.TibiaVScrollBar();
      this.housesContainer = new Tibia_Utilities.CustomControls.TUPanel();
      this.rightLblNoInfo = new System.Windows.Forms.Label();
      this.leftPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.lblBedsCant = new System.Windows.Forms.Label();
      this.lblBeds = new System.Windows.Forms.Label();
      this.noBidInfo = new System.Windows.Forms.Label();
      this.coinImg = new System.Windows.Forms.PictureBox();
      this.infoC = new System.Windows.Forms.TableLayoutPanel();
      this.leftTitleC = new System.Windows.Forms.Label();
      this.leftDescC = new System.Windows.Forms.Label();
      this.infoB = new System.Windows.Forms.TableLayoutPanel();
      this.leftTitleB = new System.Windows.Forms.Label();
      this.leftDescB = new System.Windows.Forms.Label();
      this.infoA = new System.Windows.Forms.TableLayoutPanel();
      this.leftTitleA = new System.Windows.Forms.Label();
      this.leftDescA = new System.Windows.Forms.Label();
      this.mapView = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.houseMapImg = new Tibia_Utilities.CustomControls.TUWebBrowser();
      this.leftStateLbl = new System.Windows.Forms.Label();
      this.controlPanel = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.cleanBtn = new Tibia_Utilities.CustomControls.TUSliceButton();
      this.houseStateComboBox = new Tibia_Utilities.CustomControls.TibiaComboBox();
      this.housesTypeComboBox = new Tibia_Utilities.CustomControls.TibiaComboBox();
      this.townsComboBox = new Tibia_Utilities.CustomControls.TibiaComboBox();
      this.showHousesBtn = new Tibia_Utilities.CustomControls.TUSliceButton();
      this.worldsComboBox = new Tibia_Utilities.CustomControls.TibiaComboBox();
      this.viewPanel.SuspendLayout();
      this.rightPanel.SuspendLayout();
      this.houseViewport.SuspendLayout();
      this.leftPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.coinImg)).BeginInit();
      this.infoC.SuspendLayout();
      this.infoB.SuspendLayout();
      this.infoA.SuspendLayout();
      this.mapView.SuspendLayout();
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
      this.rightPanel.Controls.Add(this.houseViewport);
      this.rightPanel.EdgeHeight = 5;
      this.rightPanel.EdgeWidth = 5;
      this.rightPanel.Location = new System.Drawing.Point(292, 66);
      this.rightPanel.Name = "rightPanel";
      this.rightPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.rightPanel.Size = new System.Drawing.Size(472, 409);
      this.rightPanel.TabIndex = 3;
      // 
      // houseViewport
      // 
      this.houseViewport.Controls.Add(this.rightScrollBar);
      this.houseViewport.Controls.Add(this.rightLblNoInfo);
      this.houseViewport.Controls.Add(this.housesContainer);
      this.houseViewport.Location = new System.Drawing.Point(3, 2);
      this.houseViewport.Name = "houseViewport";
      this.houseViewport.Size = new System.Drawing.Size(468, 405);
      this.houseViewport.TabIndex = 1;
      // 
      // rightScrollBar
      // 
      this.rightScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
      this.rightScrollBar.Location = new System.Drawing.Point(452, 0);
      this.rightScrollBar.Name = "rightScrollBar";
      this.rightScrollBar.Size = new System.Drawing.Size(16, 405);
      this.rightScrollBar.Step = 10;
      this.rightScrollBar.TabIndex = 3;
      this.rightScrollBar.ViewContainer = this.housesContainer;
      this.rightScrollBar.ViewPort = this.houseViewport;
      // 
      // housesContainer
      // 
      this.housesContainer.BackColor = System.Drawing.Color.IndianRed;
      this.housesContainer.Location = new System.Drawing.Point(0, 0);
      this.housesContainer.Name = "housesContainer";
      this.housesContainer.Size = new System.Drawing.Size(452, 50);
      this.housesContainer.TabIndex = 0;
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
      this.leftPanel.Controls.Add(this.lblBedsCant);
      this.leftPanel.Controls.Add(this.lblBeds);
      this.leftPanel.Controls.Add(this.noBidInfo);
      this.leftPanel.Controls.Add(this.coinImg);
      this.leftPanel.Controls.Add(this.infoC);
      this.leftPanel.Controls.Add(this.infoB);
      this.leftPanel.Controls.Add(this.infoA);
      this.leftPanel.Controls.Add(this.mapView);
      this.leftPanel.Controls.Add(this.leftStateLbl);
      this.leftPanel.EdgeHeight = 5;
      this.leftPanel.EdgeWidth = 5;
      this.leftPanel.Location = new System.Drawing.Point(0, 66);
      this.leftPanel.Name = "leftPanel";
      this.leftPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.leftPanel.Size = new System.Drawing.Size(286, 409);
      this.leftPanel.TabIndex = 2;
      // 
      // lblBedsCant
      // 
      this.lblBedsCant.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
      this.lblBedsCant.Location = new System.Drawing.Point(234, 28);
      this.lblBedsCant.Name = "lblBedsCant";
      this.lblBedsCant.Size = new System.Drawing.Size(43, 25);
      this.lblBedsCant.TabIndex = 13;
      this.lblBedsCant.Text = "99";
      this.lblBedsCant.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lblBeds
      // 
      this.lblBeds.AutoSize = true;
      this.lblBeds.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
      this.lblBeds.Location = new System.Drawing.Point(233, 13);
      this.lblBeds.Name = "lblBeds";
      this.lblBeds.Size = new System.Drawing.Size(46, 16);
      this.lblBeds.TabIndex = 12;
      this.lblBeds.Text = "Beds:";
      // 
      // noBidInfo
      // 
      this.noBidInfo.AutoSize = true;
      this.noBidInfo.Location = new System.Drawing.Point(8, 290);
      this.noBidInfo.Name = "noBidInfo";
      this.noBidInfo.Size = new System.Drawing.Size(137, 13);
      this.noBidInfo.TabIndex = 11;
      this.noBidInfo.Text = "No hay ofertas actualmente";
      // 
      // coinImg
      // 
      this.coinImg.BackColor = System.Drawing.Color.Transparent;
      this.coinImg.Image = global::Tibia_Utilities.Properties.Resources.singleGP;
      this.coinImg.Location = new System.Drawing.Point(263, 335);
      this.coinImg.Name = "coinImg";
      this.coinImg.Size = new System.Drawing.Size(12, 12);
      this.coinImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.coinImg.TabIndex = 10;
      this.coinImg.TabStop = false;
      // 
      // infoC
      // 
      this.infoC.ColumnCount = 2;
      this.infoC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.infoC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.infoC.Controls.Add(this.leftTitleC, 0, 0);
      this.infoC.Controls.Add(this.leftDescC, 1, 0);
      this.infoC.Location = new System.Drawing.Point(0, 328);
      this.infoC.Name = "infoC";
      this.infoC.RowCount = 1;
      this.infoC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.infoC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.infoC.Size = new System.Drawing.Size(260, 20);
      this.infoC.TabIndex = 4;
      // 
      // leftTitleC
      // 
      this.leftTitleC.Dock = System.Windows.Forms.DockStyle.Fill;
      this.leftTitleC.Location = new System.Drawing.Point(3, 0);
      this.leftTitleC.Name = "leftTitleC";
      this.leftTitleC.Size = new System.Drawing.Size(124, 20);
      this.leftTitleC.TabIndex = 0;
      this.leftTitleC.Text = "Highest Bidder:";
      this.leftTitleC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // leftDescC
      // 
      this.leftDescC.Dock = System.Windows.Forms.DockStyle.Fill;
      this.leftDescC.Location = new System.Drawing.Point(133, 0);
      this.leftDescC.Name = "leftDescC";
      this.leftDescC.Size = new System.Drawing.Size(124, 20);
      this.leftDescC.TabIndex = 1;
      this.leftDescC.Text = "999,999,999";
      this.leftDescC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // infoB
      // 
      this.infoB.ColumnCount = 2;
      this.infoB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.infoB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.infoB.Controls.Add(this.leftTitleB, 0, 0);
      this.infoB.Controls.Add(this.leftDescB, 1, 0);
      this.infoB.Location = new System.Drawing.Point(0, 306);
      this.infoB.Name = "infoB";
      this.infoB.RowCount = 1;
      this.infoB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.infoB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.infoB.Size = new System.Drawing.Size(260, 20);
      this.infoB.TabIndex = 3;
      // 
      // leftTitleB
      // 
      this.leftTitleB.Dock = System.Windows.Forms.DockStyle.Fill;
      this.leftTitleB.Location = new System.Drawing.Point(3, 0);
      this.leftTitleB.Name = "leftTitleB";
      this.leftTitleB.Size = new System.Drawing.Size(124, 20);
      this.leftTitleB.TabIndex = 0;
      this.leftTitleB.Text = "Highest Bidder:";
      this.leftTitleB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // leftDescB
      // 
      this.leftDescB.Dock = System.Windows.Forms.DockStyle.Fill;
      this.leftDescB.Location = new System.Drawing.Point(133, 0);
      this.leftDescB.Name = "leftDescB";
      this.leftDescB.Size = new System.Drawing.Size(124, 20);
      this.leftDescB.TabIndex = 1;
      this.leftDescB.Text = "Pololo";
      this.leftDescB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // infoA
      // 
      this.infoA.ColumnCount = 2;
      this.infoA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.infoA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.infoA.Controls.Add(this.leftTitleA, 0, 0);
      this.infoA.Controls.Add(this.leftDescA, 1, 0);
      this.infoA.Location = new System.Drawing.Point(0, 285);
      this.infoA.Name = "infoA";
      this.infoA.RowCount = 1;
      this.infoA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.infoA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.infoA.Size = new System.Drawing.Size(260, 20);
      this.infoA.TabIndex = 2;
      // 
      // leftTitleA
      // 
      this.leftTitleA.Dock = System.Windows.Forms.DockStyle.Fill;
      this.leftTitleA.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.leftTitleA.Location = new System.Drawing.Point(3, 0);
      this.leftTitleA.Name = "leftTitleA";
      this.leftTitleA.Size = new System.Drawing.Size(124, 20);
      this.leftTitleA.TabIndex = 0;
      this.leftTitleA.Text = "Highest Bidder:";
      this.leftTitleA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // leftDescA
      // 
      this.leftDescA.Dock = System.Windows.Forms.DockStyle.Fill;
      this.leftDescA.Location = new System.Drawing.Point(133, 0);
      this.leftDescA.Name = "leftDescA";
      this.leftDescA.Size = new System.Drawing.Size(124, 20);
      this.leftDescA.TabIndex = 1;
      this.leftDescA.Text = "Pololo";
      this.leftDescA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // mapView
      // 
      this.mapView.Controls.Add(this.houseMapImg);
      this.mapView.Location = new System.Drawing.Point(9, 9);
      this.mapView.Name = "mapView";
      this.mapView.OriginalImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.mapView.Padding = new System.Windows.Forms.Padding(2, 1, 1, 1);
      this.mapView.Size = new System.Drawing.Size(216, 246);
      this.mapView.TabIndex = 1;
      // 
      // houseMapImg
      // 
      this.houseMapImg.AllowWebBrowserDrop = false;
      this.houseMapImg.Dock = System.Windows.Forms.DockStyle.Fill;
      this.houseMapImg.Location = new System.Drawing.Point(2, 1);
      this.houseMapImg.MinimumSize = new System.Drawing.Size(20, 20);
      this.houseMapImg.Name = "houseMapImg";
      this.houseMapImg.ScrollBarsEnabled = false;
      this.houseMapImg.Size = new System.Drawing.Size(213, 244);
      this.houseMapImg.TabIndex = 0;
      this.houseMapImg.WebBrowserShortcutsEnabled = false;
      // 
      // leftStateLbl
      // 
      this.leftStateLbl.AutoSize = true;
      this.leftStateLbl.Location = new System.Drawing.Point(8, 264);
      this.leftStateLbl.Name = "leftStateLbl";
      this.leftStateLbl.Size = new System.Drawing.Size(73, 13);
      this.leftStateLbl.TabIndex = 0;
      this.leftStateLbl.Text = "Rental Details";
      // 
      // controlPanel
      // 
      this.controlPanel.Controls.Add(this.cleanBtn);
      this.controlPanel.Controls.Add(this.houseStateComboBox);
      this.controlPanel.Controls.Add(this.housesTypeComboBox);
      this.controlPanel.Controls.Add(this.townsComboBox);
      this.controlPanel.Controls.Add(this.showHousesBtn);
      this.controlPanel.Controls.Add(this.worldsComboBox);
      this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.controlPanel.Location = new System.Drawing.Point(0, 0);
      this.controlPanel.Name = "controlPanel";
      this.controlPanel.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.controlPanel.Size = new System.Drawing.Size(764, 60);
      this.controlPanel.TabIndex = 0;
      // 
      // cleanBtn
      // 
      this.cleanBtn.Location = new System.Drawing.Point(528, 33);
      this.cleanBtn.Name = "cleanBtn";
      this.cleanBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.cleanBtn.PressedImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.cleanBtn.Size = new System.Drawing.Size(95, 23);
      this.cleanBtn.TabIndex = 5;
      this.cleanBtn.Text = "Clean";
      this.cleanBtn.UnpressedImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.cleanBtn.UseVisualStyleBackColor = true;
      this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
      // 
      // houseStateComboBox
      // 
      this.houseStateComboBox.Location = new System.Drawing.Point(397, 4);
      this.houseStateComboBox.MainView = this.viewPanel;
      this.houseStateComboBox.Name = "houseStateComboBox";
      this.houseStateComboBox.Size = new System.Drawing.Size(125, 23);
      this.houseStateComboBox.TabIndex = 4;
      // 
      // housesTypeComboBox
      // 
      this.housesTypeComboBox.Location = new System.Drawing.Point(266, 4);
      this.housesTypeComboBox.MainView = this.viewPanel;
      this.housesTypeComboBox.Name = "housesTypeComboBox";
      this.housesTypeComboBox.Size = new System.Drawing.Size(125, 23);
      this.housesTypeComboBox.TabIndex = 3;
      // 
      // townsComboBox
      // 
      this.townsComboBox.Location = new System.Drawing.Point(135, 4);
      this.townsComboBox.MainView = this.viewPanel;
      this.townsComboBox.Name = "townsComboBox";
      this.townsComboBox.Size = new System.Drawing.Size(125, 23);
      this.townsComboBox.TabIndex = 2;
      // 
      // showHousesBtn
      // 
      this.showHousesBtn.Location = new System.Drawing.Point(528, 4);
      this.showHousesBtn.Name = "showHousesBtn";
      this.showHousesBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.showHousesBtn.PressedImage = global::Tibia_Utilities.Properties.Resources.BorderedPanel;
      this.showHousesBtn.Size = new System.Drawing.Size(95, 23);
      this.showHousesBtn.TabIndex = 1;
      this.showHousesBtn.Text = "Search";
      this.showHousesBtn.UnpressedImage = global::Tibia_Utilities.Properties.Resources.RaisedPanel;
      this.showHousesBtn.UseVisualStyleBackColor = true;
      this.showHousesBtn.Click += new System.EventHandler(this.showHousesBtn_Click);
      // 
      // worldsComboBox
      // 
      this.worldsComboBox.Location = new System.Drawing.Point(4, 4);
      this.worldsComboBox.MainView = this.viewPanel;
      this.worldsComboBox.Name = "worldsComboBox";
      this.worldsComboBox.Size = new System.Drawing.Size(125, 23);
      this.worldsComboBox.TabIndex = 0;
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
      this.houseViewport.ResumeLayout(false);
      this.houseViewport.PerformLayout();
      this.leftPanel.ResumeLayout(false);
      this.leftPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.coinImg)).EndInit();
      this.infoC.ResumeLayout(false);
      this.infoB.ResumeLayout(false);
      this.infoA.ResumeLayout(false);
      this.mapView.ResumeLayout(false);
      this.controlPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControls.TUPanel viewPanel;
    private CustomControls.TUSlicePanel controlPanel;
    private CustomControls.TUSlicePanel leftPanel;
    private CustomControls.TUSlicePanel rightPanel;
    private System.Windows.Forms.Label rightLblNoInfo;
    private System.Windows.Forms.Label leftStateLbl;
    private CustomControls.TUPanel houseViewport;
    private CustomControls.TUPanel housesContainer;
    private CustomControls.TibiaComboBox worldsComboBox;
    private CustomControls.TibiaVScrollBar rightScrollBar;
    private CustomControls.TUSliceButton showHousesBtn;
    private CustomControls.TibiaComboBox townsComboBox;
    private CustomControls.TibiaComboBox houseStateComboBox;
    private CustomControls.TibiaComboBox housesTypeComboBox;
    private CustomControls.TUSliceButton cleanBtn;
    private CustomControls.TUSlicePanel mapView;
    private System.Windows.Forms.TableLayoutPanel infoA;
    private System.Windows.Forms.Label leftTitleA;
    private System.Windows.Forms.Label leftDescA;
    private System.Windows.Forms.TableLayoutPanel infoB;
    private System.Windows.Forms.Label leftTitleB;
    private System.Windows.Forms.Label leftDescB;
    private System.Windows.Forms.TableLayoutPanel infoC;
    private System.Windows.Forms.Label leftTitleC;
    private System.Windows.Forms.Label leftDescC;
    private System.Windows.Forms.PictureBox coinImg;
    private CustomControls.TUWebBrowser houseMapImg;
    private System.Windows.Forms.Label noBidInfo;
    private System.Windows.Forms.Label lblBedsCant;
    private System.Windows.Forms.Label lblBeds;
  }
}