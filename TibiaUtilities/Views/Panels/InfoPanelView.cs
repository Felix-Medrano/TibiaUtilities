using System.Drawing;
using System.Windows.Forms;

using TibiaUtilities.Interfaces;
using TibiaUtilities.Properties;

namespace TibiaUtilities.Views.Panels
{
  public class InfoPanelView : Form, IPanelView
  {
    private Label label1;
    private CustomControls.TUPanel panelView;

    public Image ButtonImage => Resources.informacion;

    public Panel GetPanel()
    {
      return panelView;
    }

    private void InitializeComponent()
    {
      this.panelView = new TibiaUtilities.CustomControls.TUPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.panelView.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelView
      // 
      this.panelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.panelView.Controls.Add(this.label1);
      this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelView.Location = new System.Drawing.Point(0, 0);
      this.panelView.Name = "panelView";
      this.panelView.Size = new System.Drawing.Size(764, 475);
      this.panelView.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(86, 84);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "InfoPanel!!!!!";
      // 
      // InfoPanelView
      // 
      this.ClientSize = new System.Drawing.Size(764, 475);
      this.Controls.Add(this.panelView);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "InfoPanelView";
      this.panelView.ResumeLayout(false);
      this.panelView.PerformLayout();
      this.ResumeLayout(false);

    }
  }
}
