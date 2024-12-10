using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using TibiaUtilities.CustomControls;
using TibiaUtilities.Interfaces;
using TibiaUtilities.Lib;
using TibiaUtilities.Properties;

namespace TibiaUtilities.Views.Components
{
  public class MainButtonPanelView : TUPanel
  {
    public event EventHandler<IPanelView> ButtonClicked;

    private TUMainButton currentBtn = null;

    public TUMainButton CurrentBtn { get { return currentBtn; } }

    public MainButtonPanelView()
    {
      this.BackgroundImage = Resources.MainButtonPanel;
      this.Size = Resources.MainButtonPanel.Size;

      foreach (var panel in TUHelper.TUData.Panels)
      {
        var btn = new TUMainButton()
        {
          Text = Regex.Replace(panel.Key, "([a-z])([A-Z])", "$1 $2"),
          BackgroundImage = Resources.MainButtonUnpressed,
          Image = panel.Value.ButtonImage,
          Top = 1,
          Tag = panel.Value
        };
        btn.Click += Btn_Click;
        Controls.Add(btn);
      }

      currentBtn = (TUMainButton)Controls[0];
      currentBtn.ActivateButton();
      TUHelper.TUFunctions.AlignButtons(Controls);
    }

    private void Btn_Click(object sender, EventArgs e)
    {
      var btn = (TUMainButton)sender;
      var parent = btn.Parent;
      var panelView = btn.Tag as IPanelView;

      if (currentBtn != btn)
      {
        foreach (Control control in parent.Controls)
        {
          if (control is TUMainButton tuBtn)
          {
            tuBtn.ResetButton();
          }
        }
      }

      currentBtn = btn;
      currentBtn.BackgroundImage = Resources.MainButtonPressed;
      currentBtn.Invalidate();

      ButtonClicked?.Invoke(this, panelView);

      TUHelper.TUFunctions.AlignButtons(parent.Controls);
    }
  }
}
