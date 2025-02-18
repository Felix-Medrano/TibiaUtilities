using System.Windows.Forms;

using Tibia_Utilities.CustomControls;
using Tibia_Utilities.CustomControls.SplitLoot;
using Tibia_Utilities.Interfaces.Panels;
using Tibia_Utilities.Lib;
using Tibia_Utilities.Models;
using Tibia_Utilities.Properties;

namespace Tibia_Utilities.Views.Panels
{
  public partial class SplitLoot : Form, IViewPanel
  {
    public SplitLoot()
    {
      InitializeComponent();

      lblSplitLoot.Font = Helper.safeFont8;
      lblSplitLoot.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);

      lblSplitLoot.CenterControlToParent();

      //TODO: Eventos, MouseDown, Up, para manejar la animacion de Click, com ose hace en TUMainPanelButton
      tuSlicePanel1.Click += Button_Click;
      lblSplitLoot.Click += Button_Click;
    }

    public void SetViewPanel(TUPanel panel)
    {
      panel.Controls.Clear();
      panel.Controls.Add(viewPanel);
    }

    private void Button_Click(object sender, System.EventArgs e)
    {
      tuSlicePanel1.OriginalImage = Resources.BorderedPanel;

      var partyLoot = new PartyLootModel()
      {
        Name = "Player 1",
        Loot = -1000,
        Supplies = 100,
        Balance = -100,
        Damage = 1000,
        Healing = 1000
      };

      var partyLootData = new PartyLootData(partyLoot);
      partyLootData.Location = new System.Drawing.Point(10, 10);
      leftPanel.Controls.Add(partyLootData);
    }
  }
}
