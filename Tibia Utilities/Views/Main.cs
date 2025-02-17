using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.CustomControls;
using Tibia_Utilities.Lib;
using Tibia_Utilities.Models;
using Tibia_Utilities.Properties;
using Tibia_Utilities.Views.Panels;

using static Tibia_Utilities.Lib.Helper;

namespace Tibia_Utilities
{
  public partial class Main : Form
  {
    private List<PanelDataModel> panels = new List<PanelDataModel>();

    TUMainPanelButton currentButton;

    public Main()
    {
      InitializeComponent();
    }

    #region Override Events
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      SetPanelModels();
      SetMainButtons();

      DoubleBuffered = true;

      mainTopControlPanel.MouseDown += TopPanel_MouseDown;
      mainTitle.MouseDown += TopPanel_MouseDown;
      closeButton.Click += CloseButton_Click;
      minimizeButton.Click += MinimizeButton_Click;

      // Configurar la fuente
      Font safeFont = FontHelper.GetSafeFont(
                preferredFontName: TUStrings.Fonts.PREFERRED_FONT, // Fuente preferida
                fallbackFontName: TUStrings.Fonts.FLLBACK_FONT,    // Fuente alternativa
                size: 12,
                style: FontStyle.Bold
            );

      mainTitle.Text = "Tibia Utilities";
      mainTitle.Font = safeFont;
      mainTitle.ForeColor = Helper.HexToColor(TUStrings.Colors.TITLE_TEXT_COLOR);

      mainTitle.CenterControlToParent();

      currentButton?.Panel?.SetViewPanel(mainView);

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

    private void MainButton_Click(object sender, EventArgs e)
    {
      currentButton.SetSelected(false);
      currentButton = null;
      if (sender is TUMainPanelButton btn)
      {
        if (btn.CurrentState == TUMainPanelButton.ButtonState.Selected) return;

        currentButton = btn;
        currentButton.SetSelected(true);
        currentButton.Panel.SetViewPanel(mainView);
      }

      var parent = currentButton.Parent;
      Point buttonLocation = new Point(1, 1);
      foreach (Control control in parent.Controls)
      {
        control.Location = buttonLocation;
        buttonLocation.X += control.Width;
      }
    }

    #endregion

    #region Private Functions

    private void SetPanelModels()
    {
      var Main = new PanelDataModel
      {
        ButtonText = "Main",
        ButtonImage = Resources.BPUtilities,
        Panel = new MainPanel()
      };
      panels.Add(Main);

      var SplitLoot = new PanelDataModel
      {
        ButtonText = "Split Loot",
        ButtonImage = Resources.Backpack,
        Panel = new SplitLoot()
      };
      panels.Add(SplitLoot);

      var Houses = new PanelDataModel
      {
        ButtonText = "Houses",
        ButtonImage = Resources.House,
        Panel = new Houses()
      };
      panels.Add(Houses);

      //KEEP: Add new panels before here, Info should be the last one
      var Info = new PanelDataModel
      {
        ButtonText = "Info",
        ButtonImage = Resources.informacion,
        Panel = new Info()
      };
      panels.Add(Info);
    }

    private void SetMainButtons()
    {
      Point buttonLocation = new Point(1, 1);

      foreach (var panel in panels)
      {
        int buttonWidth;
        var button = new TUMainPanelButton
        {
          Location = buttonLocation,
          Icon = panel.ButtonImage,
          SelectedText = panel.ButtonText,
          Panel = panel.Panel
        };
        button.Click += MainButton_Click;

        mainButtonPanel.Controls.Add(button);

        buttonWidth = button.Width;

        if (currentButton == null)
        {
          currentButton = button;
          currentButton.SetSelected(true);
          buttonWidth = currentButton.Width;
        }

        buttonLocation.X += buttonWidth;
      }

      #endregion

      #region Public Functions

      #endregion
    }
  }
}
