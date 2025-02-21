using System;
using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.Lib;
using Tibia_Utilities.Models.SplitLoot;

using static Tibia_Utilities.Lib.Helper;

namespace Tibia_Utilities.CustomControls.SplitLoot
{
  public partial class PartyPlayerData : UserControl
  {
    public EventHandler PanelClick;
    public EventHandler HideClick;

    private const int MAX_HEIGHT = 150;

    private PartyLootModel _partyLootModel;

    private ToolTip toolTip;

    private bool minimized = false;
    private bool hideData = false;

    public PartyLootModel PartyLootModel
    {
      get => _partyLootModel;
    }

    public PartyPlayerData()
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

      topPanel.Click += TopPanel_Click;
      lblName.Click += TopPanel_Click;
    }

    public void SetData(PartyLootModel model)
    {
      _partyLootModel = model;

      toolTip = new ToolTip
      {
        AutoPopDelay = 5000,
        InitialDelay = 500,
        ReshowDelay = 200,
        ShowAlways = true
      };

      string tooltipText = "Ocultar jugador";
      toolTip.SetToolTip(hideBtn, tooltipText);

      if (_partyLootModel != null)
      {
        lblName.Text = _partyLootModel.Name;
        lblLootCant.Text = _partyLootModel.Loot.ToString("N0");
        lblSuppliesCant.Text = _partyLootModel.Supplies.ToString("N0");
        lblBalanceCant.Text = _partyLootModel.Balance.ToString("N0");
        lblDamageCant.Text = _partyLootModel.Damage.ToString("N0");
        lblHealingCant.Text = _partyLootModel.Healing.ToString("N0");
      }

      SetLblConfig();
    }

    private void SetLblConfig()
    {
      var font = !hideData ? safeFont8 : safeFont8Strike;

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
      lblHealingCant.Font = font;

      lblName.ForeColor = HexToColor(TUStrings.Colors.TITLE_TEXT_COLOR);

      var color = !hideData ? HexToColor(TUStrings.Colors.DESC_TEXT_COLOR) : Color.Black;

      lblLoot.ForeColor =
      lblLootCant.ForeColor =
      lblSupplies.ForeColor =
      lblBalance.ForeColor =
      lblDamage.ForeColor =
      lblDamageCant.ForeColor =
      lblHealing.ForeColor =
      lblHealingCant.ForeColor = color;

      //Cambio de colores

      var suppliesColor = !hideData ? _partyLootModel.Supplies switch
      {
        > 0 => HexToColor(TUStrings.Colors.POSI_TEXT_COLOR),
        < 0 => HexToColor(TUStrings.Colors.NEGA_TEXT_COLOR),
        _ => HexToColor(TUStrings.Colors.DESC_TEXT_COLOR)
      } : color;

      lblSuppliesCant.ForeColor = suppliesColor;

      var balanceColor = !hideData ? _partyLootModel.Balance switch
      {
        > 0 => HexToColor(TUStrings.Colors.POSI_TEXT_COLOR),
        < 0 => HexToColor(TUStrings.Colors.NEGA_TEXT_COLOR),
        _ => HexToColor(TUStrings.Colors.DESC_TEXT_COLOR)
      } : color;

      lblBalanceCant.ForeColor = balanceColor;

      lblName.CenterControlToParent();
    }

    private void TopPanel_Click(object sender, EventArgs e)
    {
      Height = minimized ? 150 : topPanel.Height + 5;
      minimized = !minimized;
      PanelClick?.Invoke(this, e);
    }

    private void hideBtn_Click(object sender, EventArgs e)
    {
      hideData = !hideData;

      _partyLootModel.IsHide = !_partyLootModel.IsHide;

      hideBtn.Image = !hideData ? Properties.Resources.hide : Properties.Resources.show;

      SetLblConfig();
      Update();

      string tooltipText = hideData ? "Mostrar jugador" : "Ocultar jugador";
      toolTip.SetToolTip(hideBtn, tooltipText);

      HideClick?.Invoke(this, e);
    }

    public void Reset()
    {
      hideData = false;
      _partyLootModel.IsHide = false;
      hideBtn.Image = Properties.Resources.hide;
      Height = MAX_HEIGHT;

      lblName.Text =
      lblLoot.Text =
      lblLootCant.Text =
      lblSupplies.Text =
      lblSuppliesCant.Text =
      lblBalance.Text =
      lblBalanceCant.Text =
      lblDamage.Text =
      lblDamageCant.Text =
      lblHealing.Text =
      lblHealingCant.Text = string.Empty;

      Location = new Point(0, 0);
      SetLblConfig();
    }
  }
}
