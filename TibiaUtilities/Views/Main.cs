using FloatingStickyNotes.Core;

using System;
using System.Drawing;
using System.Windows.Forms;

using TibiaUtilities.Interfaces;
using TibiaUtilities.Lib;
using TibiaUtilities.Views.Components;

namespace TibiaUtilities.Views
{
  public partial class Main : Form
  {
    public Main()
    {
      InitializeComponent();
      this.DoubleBuffered = true;
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      var mainButtonPanel = new MainButtonPanelView()
      {
        Location = new Point(18,33)
      };
      mainButtonPanel.ButtonClicked += MainButtonPanelView_ButtonClicked;

      Controls.Add(mainButtonPanel);
      var panel = mainButtonPanel.CurrentBtn.Tag as IPanelView;
      viewPanel.Controls.Add(panel.GetPanel());

      label1.Font = TUFonts.Title.TextFont;
      label1.ForeColor = TUFonts.Title.TextColor;

      label1.Left = (this.Width - label1.Width) / 2;

    }

    private void Main_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Win32.ReleaseCapture();
        Win32.SendMessage(Handle, Win32.WM_NCLBUTTONDOWN, Win32.HT_CAPTION, 0);
      }
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void tuControlButton1_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }

    private void MainButtonPanelView_ButtonClicked(object sender, IPanelView panelView)
    {
      viewPanel.Controls.Clear();

      if (panelView != null)
      {
        var panel = panelView.GetPanel();
        viewPanel.Controls.Add(panel);
      }
    }
  }
}
