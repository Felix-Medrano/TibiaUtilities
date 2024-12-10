using System.Drawing;
using System.Windows.Forms;

using TibiaUtilities.Interfaces;
using TibiaUtilities.Properties;

namespace TibiaUtilities.Views.Panels
{
  public class HousesPanelView : Form, IPanelView
  {
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
      this.SuspendLayout();
      // 
      // tuPanel1
      // 
      this.tuPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.tuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tuPanel1.Location = new System.Drawing.Point(0, 0);
      this.tuPanel1.Name = "tuPanel1";
      this.tuPanel1.Size = new System.Drawing.Size(284, 261);
      this.tuPanel1.TabIndex = 0;
      // 
      // HousesPanelView
      // 
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.tuPanel1);
      this.Name = "HousesPanelView";
      this.ResumeLayout(false);

    }
  }
}
