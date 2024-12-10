using System.Drawing;
using System.Windows.Forms;

using TibiaUtilities.Interfaces;
using TibiaUtilities.Properties;

namespace TibiaUtilities.Views.Panels
{
  public class MainPanelView : Form, IPanelView
  {
    private CustomControls.TUPanel viewPanel;

    public Image ButtonImage { get; }

    public MainPanelView()
    {
      InitializeComponent();
      ButtonImage = Resources.MainPanelIcon;
    }

    public Panel GetPanel()
    {
      return viewPanel;
    }

    private void InitializeComponent()
    {
      this.viewPanel = new TibiaUtilities.CustomControls.TUPanel();
      this.SuspendLayout();
      // 
      // viewPanel
      // 
      this.viewPanel.BackgroundImage = global::TibiaUtilities.Properties.Resources.Logo;
      this.viewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPanel.Location = new System.Drawing.Point(0, 0);
      this.viewPanel.Name = "viewPanel";
      this.viewPanel.Size = new System.Drawing.Size(800, 615);
      this.viewPanel.TabIndex = 0;
      // 
      // MainPanelView
      // 
      this.ClientSize = new System.Drawing.Size(800, 615);
      this.Controls.Add(this.viewPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MainPanelView";
      this.ResumeLayout(false);

    }
  }
}
