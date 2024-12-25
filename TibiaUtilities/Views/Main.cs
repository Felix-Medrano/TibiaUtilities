using FloatingStickyNotes.Core;

using System;
using System.Drawing;
using System.Windows.Forms;

using TibiaUtilities.Classes;
using TibiaUtilities.CustomControls;
using TibiaUtilities.Interfaces;
using TibiaUtilities.Lib;
using TibiaUtilities.Properties;
using TibiaUtilities.Views.Components;

namespace TibiaUtilities.Views
{
  public partial class Main : Form
  {
    public Main()
    {
      InitializeComponent();
      this.DoubleBuffered = true;
      this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
      this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
      this.SetStyle(ControlStyles.UserPaint, true);
      GenerateImageCache();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      TUHelper.Initialize();

      var mainButtonPanel = new MainButtonPanelView()
      {
        Location = new Point(18,33)
      };
      mainButtonPanel.ButtonClicked += MainButtonPanelView_ButtonClicked;

      Controls.Add(mainButtonPanel);
      var panel = mainButtonPanel.CurrentBtn.Tag as IPanelView;
      viewPanel.Controls.Add(panel.GetPanel());

      lblTitle.Font = TUFonts.Title.TextFont;
      lblTitle.ForeColor = TUFonts.Title.TextColor;
      lblTitle.Text = TUStrings.MAIN_TITLE;
      lblTitle.Left = (topControlBar.Width - lblTitle.Width) / 2;

      lblTitle.MouseDown += Main_MouseDown;
      topControlBar.MouseDown += Main_MouseDown;
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

    private void GenerateImageCache()
    {
      var cacheImageGenerator = new CacheImageGenerator();

      //LootDisplayData
      cacheImageGenerator.GenerateCacheImage(nameof(LootDisplayData), Resources.Background, 5, 17,
        TUConsts.LOOT_DISPLAY_DATA_WIDTH, TUConsts.LOOT_DISPLAY_DATA_HEIGHT, TUFunctions.SliceType.NineSlice);

      //LootDisplayPanel::topPanel 
      cacheImageGenerator.GenerateCacheImage($"{nameof(LootDisplayData)}TopPanel", Resources.LeftDataPanel,
        20, 20, 764, 60, TUFunctions.SliceType.NineSlice);

      cacheImageGenerator.GenerateCacheImage($"{nameof(LootDisplayData)}LeftViewPort", Resources.RightDataPanel,
        20, 20, 276, 400, TUFunctions.SliceType.NineSlice);
    }
  }
}
