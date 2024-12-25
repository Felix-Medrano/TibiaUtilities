using System;
using System.Drawing;
using System.Windows.Forms;

using TibiaUtilities.Interfaces;
using TibiaUtilities.Properties;

namespace TibiaUtilities.Views.Panels
{
  public class HousesPanelView : Form, IPanelView
  {
    private CustomControls.TUControlButton tuControlButton1;
    private CustomControls.TUPanel tuPanel1;

    public Image ButtonImage { get; }

    public HousesPanelView()
    {
      InitializeComponent();
      ButtonImage = Resources.House;
    }

    public Panel GetPanel()
    {
      return tuPanel1;
    }

    private void InitializeComponent()
    {
      this.tuPanel1 = new TibiaUtilities.CustomControls.TUPanel();
      this.tuControlButton1 = new TibiaUtilities.CustomControls.TUControlButton();
      this.tuPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tuPanel1
      // 
      this.tuPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.tuPanel1.Controls.Add(this.tuControlButton1);
      this.tuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tuPanel1.Location = new System.Drawing.Point(0, 0);
      this.tuPanel1.Name = "tuPanel1";
      this.tuPanel1.Size = new System.Drawing.Size(764, 475);
      this.tuPanel1.TabIndex = 0;
      // 
      // tuControlButton1
      // 
      this.tuControlButton1.BackColor = System.Drawing.Color.IndianRed;
      this.tuControlButton1.CornerHeight = 10;
      this.tuControlButton1.CornerWidth = 10;
      this.tuControlButton1.DrawText = false;
      this.tuControlButton1.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
      this.tuControlButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
      this.tuControlButton1.Image = null;
      this.tuControlButton1.Location = new System.Drawing.Point(68, 62);
      this.tuControlButton1.Name = "tuControlButton1";
      this.tuControlButton1.Size = new System.Drawing.Size(75, 23);
      this.tuControlButton1.SliceType = TibiaUtilities.Lib.TUFunctions.SliceType.None;
      this.tuControlButton1.TabIndex = 0;
      this.tuControlButton1.Text = "tuControlButton1";
      this.tuControlButton1.Click += new System.EventHandler(this.tuControlButton1_Click);
      // 
      // HousesPanelView
      // 
      this.ClientSize = new System.Drawing.Size(764, 475);
      this.Controls.Add(this.tuPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "HousesPanelView";
      this.tuPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    private void tuControlButton1_Click(object sender, System.EventArgs e)
    {
      Console.WriteLine("Houses Panel button click");
    }
  }
}
