using System;
using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.Lib;

using static Tibia_Utilities.Lib.Helper;

namespace Tibia_Utilities
{
  public partial class Main : Form
  {
    public Main()
    {
      InitializeComponent();
      DoubleBuffered = true;
    }

    #region Override Events
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      mainTopControlPanel.MouseDown += TopPanel_MouseDown;
      mainTitle.MouseDown += TopPanel_MouseDown;
      closeButton.Click += CloseButton_Click;
      minimizeButton.Click += MinimizeButton_Click;

      // Configurar la fuente
      Font safeFont = FontHelper.GetSafeFont(
                preferredFontName: TUStrings.PREFERRED_FONT, // Fuente preferida
                fallbackFontName: TUStrings.FLLBACK_FONT,    // Fuente alternativa
                size: 12,
                style: FontStyle.Bold
            );

      mainTitle.Text = "Tibia Utilities";
      mainTitle.Font = safeFont;
      mainTitle.ForeColor = Helper.HexToColor(TUStrings.TITLE_TEXT_COLOR);

      mainTitle.CenterControlToParent();
    }

    #endregion

    #region Control Events
    private void TopPanel_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Win32.ReleaseCapture();
        Win32.SendMessage(Handle, Win32.WM_NCLBUTTONDOWN, Win32.HT_CAPTION, 0);
      }
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void MinimizeButton_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }

    #endregion

    #region Private Functions

    #endregion

    #region Public Functions

    #endregion
  }
}
