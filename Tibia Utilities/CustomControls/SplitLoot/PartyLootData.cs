using System;
using System.Windows.Forms;

using Tibia_Utilities.Lib;
using Tibia_Utilities.Models;

using static Tibia_Utilities.Lib.Helper;

namespace Tibia_Utilities.CustomControls.SplitLoot
{
  public partial class PartyLootData : UserControl
  {
    private PartyLootModel _partyLootModel;

    private bool minimized = false;

    public PartyLootData()
    {
      InitializeComponent();

      DoubleBuffered = true;

      //Dummy data
      _partyLootModel = new PartyLootModel()
      {
        Name = "Player Name",
        Loot = 999999,
        Supplies = -800,
        Balance = 50000,
        Damage = 1000000,
        Healing = 123456789
      };
      SetData();
    }

    public PartyLootData(PartyLootModel model)
    {
      InitializeComponent();

      DoubleBuffered = true;
      _partyLootModel = model;

      SetData();
    }

    private void SetData()
    {
      if (_partyLootModel != null)
      {
        lblName.Text = _partyLootModel.Name;
        lblLootCant.Text = _partyLootModel.Loot.ToString("N0");
        lblSuppliesCant.Text = _partyLootModel.Supplies.ToString("N0");
        lblBalanceCant.Text = _partyLootModel.Balance.ToString("N0");
        lblDamageCant.Text = _partyLootModel.Damage.ToString("N0");
        lblHealingCant.Text = _partyLootModel.Healing.ToString("N0");
      }

      lblName.Font = safeFont12;
      lblLoot.Font =
      lblLootCant.Font =
      lblSupplies.Font =
      lblSuppliesCant.Font =
      lblBalance.Font =
      lblBalanceCant.Font =
      lblDamage.Font =
      lblDamageCant.Font =
      lblHealing.Font =
      lblHealingCant.Font = safeFont8;

      lblName.ForeColor = HexToColor(TUStrings.Colors.TITLE_TEXT_COLOR);
      lblLoot.ForeColor =
      lblLootCant.ForeColor =
      lblSupplies.ForeColor =
      lblBalance.ForeColor =
      lblDamage.ForeColor =
      lblDamageCant.ForeColor =
      lblHealing.ForeColor =
      lblHealingCant.ForeColor = HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);

      //Cambio de colores
      //TODO: Cambiar colores dependiendo de la cantidad de loot
      lblSuppliesCant.ForeColor = _partyLootModel.Supplies switch
      {
        > 0 => HexToColor(TUStrings.Colors.POSI_TEXT_COLOR),
        < 0 => HexToColor(TUStrings.Colors.NEGA_TEXT_COLOR),
        _ => HexToColor(TUStrings.Colors.DESC_TEXT_COLOR)
      };
      lblBalanceCant.ForeColor = _partyLootModel.Balance switch
      {
        > 0 => HexToColor(TUStrings.Colors.POSI_TEXT_COLOR),
        < 0 => HexToColor(TUStrings.Colors.NEGA_TEXT_COLOR),
        _ => HexToColor(TUStrings.Colors.DESC_TEXT_COLOR)
      };

      lblName.CenterControlToParent();

      topPanel.Click += TopPanel_Click;
      lblName.Click += TopPanel_Click;
    }

    private void TopPanel_Click(object sender, EventArgs e)
    {
      Height = minimized ? 150 : topPanel.Height + 5;
      minimized = !minimized;
    }
  }
}
