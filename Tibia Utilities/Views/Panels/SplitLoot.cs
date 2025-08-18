using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Tibia_Utilities.Core;
using Tibia_Utilities.CustomControls;
using Tibia_Utilities.CustomControls.SplitLoot;
using Tibia_Utilities.Interfaces.Panels;
using Tibia_Utilities.Lib;
using Tibia_Utilities.Models.SplitLoot;
using Tibia_Utilities.Properties;

namespace Tibia_Utilities.Views.Panels
{
  public partial class SplitLoot : Form, IViewPanel
  {

    private List<PartyLootModel> players;
    private List<PartyLootModel> hidePlayers = new();

    private ObjectPool<PartyPlayerData> playerPool = new ObjectPool<PartyPlayerData>(5);
    private ObjectPool<PlayerTransfer> transferPool = new ObjectPool<PlayerTransfer>(5);

    public SplitLoot()
    {
      InitializeComponent();

      leftScrollBar.UpdateThumbHeight();

      rightScrollBar.UpdateThumbHeight();
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
      base.OnMouseWheel(e);

      leftScrollBar.MoveThumbByWheel(e.Delta);
    }

    public void SetViewPanel(TUPanel panel)
    {
      panel.Controls.Clear();
      panel.Controls.Add(viewPanel);

      leftScrollBar.UpdateThumbHeight();
    }

    private void Button_Click(object sender, System.EventArgs e)
    {
      try
      {
        string clipboardText = Clipboard.GetText();

        if (string.IsNullOrWhiteSpace(clipboardText))
        {
          MessageBox.Show("El portapapeles está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        players = ExtractPlayers(clipboardText);
        if (players.Count == 0)
        {
          MessageBox.Show("No se encontraron jugadores en la sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        Clear(false);

        string leader = players.First().Name;

        int offsetY = 0;

        List<Control> controlsList = new();

        foreach (var player in players)
        {
          var playerData = playerPool.AltGet<PartyPlayerData>();

          playerData.SetData(player);
          playerData.PanelClick += TopPanel_Click;
          playerData.HideClick += HideButton_Click;
          playerData.MouseWheel += MouseWheelEvent;
          playerData.Location = new Point(0, offsetY);
          offsetY += playerData.Height;

          controlsList.Add(playerData);

          //partyPlayersContainer.Controls.Add(playerData);
        }

        partyPlayersContainer.Controls.AddRange(controlsList.ToArray());

        ViewPortUpdate();

        SetTransfersData(players);

        leftScrollBar.UpdateThumbHeight();
        rightScrollBar.UpdateThumbHeight();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al procesar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void MouseWheelEvent(object sender, MouseEventArgs e)
    {
      OnMouseWheel(e);
    }


    private void TopPanel_Click(object sender, EventArgs e)
    {
      ViewPortUpdate();
    }

    private void SetTransfersData(List<PartyLootModel> players)
    {

      List<TransferModel> splitTransfers = CalculateSplit(players);
      int profitEach;

      if (players.Count == 0)
        profitEach = 0;
      else
        profitEach = players.Sum(p => p.Balance) / players.Count;

      playerTransfersContainer.Controls.Clear();

      int offsetY = 0;
      int transferViewPortHeight = 0;

      foreach (var transfer in splitTransfers)
      {
        var playerTransfer = transferPool.AltGet<PlayerTransfer>();
        playerTransfer.SetData(transfer);
        playerTransfer.Location = new Point(0, offsetY);
        offsetY += playerTransfer.Height;

        transferViewPortHeight += playerTransfer.Height;
        playerTransfersContainer.Controls.Add(playerTransfer);

      }

      playerTransfersContainer.Height = transferViewPortHeight;

      PictureBox coins = new PictureBox()
      {
        Image = Resources.GoldCoin,
        SizeMode = PictureBoxSizeMode.AutoSize,
        Location = new Point(5, playerTransfersContainer.Bottom + 10)
      };

      Label lblProfitEach = new Label
      {
        AutoSize = true,
        Text = $"Profit each: {profitEach:N0}",
        Font = Helper.safeFont10,
        ForeColor = Helper.HexToColor(TUStrings.Colors.TITLE_TEXT_COLOR),
        Visible = true
      };

      lblProfitEach.Location = new Point(coins.Right + 5,
                                        (coins.Bottom - (coins.Height / 2)) - lblProfitEach.Height / 2);

      playerTransfersContainer.Controls.Add(coins);
      playerTransfersContainer.Controls.Add(lblProfitEach);
      playerTransfersContainer.Height = coins.Bottom;

      if (playerTransfersContainer.Height >= rightPanel.Height)
        rightScrollBar.Visible = true;
    }

    static List<PartyLootModel> ExtractPlayers(string sessionText)
    {
      var players = new List<PartyLootModel>();

      string pattern = @"(?<name>[\w' ]+?)(?: \(Leader\))?\s+Loot:\s(?<loot>[\d,]+)\s+Supplies:\s(?<supplies>[\d,]+)\s+Balance:\s(?<balance>-?[\d,]+)\s+Damage:\s(?<damage>[\d,]+)\s+Healing:\s(?<healing>[\d,]+)";
      MatchCollection matches = Regex.Matches(sessionText, pattern);

      foreach (Match match in matches)
      {
        players.Add(new PartyLootModel
        {
          Name = match.Groups["name"].Value.Trim(),
          Loot = int.Parse(match.Groups["loot"].Value.Replace(",", "")),
          Supplies = int.Parse(match.Groups["supplies"].Value.Replace(",", "")),
          Balance = int.Parse(match.Groups["balance"].Value.Replace(",", "")),
          Damage = int.Parse(match.Groups["damage"].Value.Replace(",", "")),
          Healing = int.Parse(match.Groups["healing"].Value.Replace(",", ""))
        });
      }

      return players;
    }

    static List<TransferModel> CalculateSplit(List<PartyLootModel> players)
    {
      List<TransferModel> transfers = new List<TransferModel>();

      // Calcular el profit promedio por jugador
      int totalBalance = players.Sum(p => p.Balance);
      int playerCount = players.Count;
      int profitEach;

      if (playerCount == 0)
        profitEach = 0;
      else
        profitEach = totalBalance / playerCount;

      // Crear una lista de diferencias usando la clase PlayerDifference
      var differences = players.Select(p => new PlayerDifferenceModel
      {
        Name = p.Name,
        Difference = p.Balance - profitEach
      }).ToList();

      // Realizar las transferencias
      foreach (var giver in differences.Where(d => d.Difference > 0).OrderByDescending(d => d.Difference))
      {
        foreach (var receiver in differences.Where(d => d.Difference < 0).OrderBy(d => d.Difference))
        {
          if (giver.Difference == 0 || receiver.Difference == 0)
            continue;

          // Calcular la cantidad a transferir
          int amountToTransfer = Math.Min(giver.Difference, -receiver.Difference);

          // Agregar la transferencia
          transfers.Add(new TransferModel
          {
            Payer = giver.Name,
            Receiver = receiver.Name,
            Amount = amountToTransfer
          });

          // Actualizar las diferencias
          giver.Difference -= amountToTransfer;
          receiver.Difference += amountToTransfer;
        }
      }

      return transfers;
    }

    private void partyPlayerViewPort_Resize(object sender, EventArgs e)
    {
      leftScrollBar.UpdateThumbHeight();
    }

    private void ViewPortUpdate()
    {
      int offsetY = 0;
      foreach (PartyPlayerData player in partyPlayersContainer.Controls)
      {
        player.Location = new Point(0, offsetY);
        offsetY += player.Height;

        partyPlayersContainer.Height = player.Bottom;
      }

      if (partyPlayersContainer.Height <= leftPanel.Height)
        partyPlayersContainer.Top = 0;

      leftScrollBar.UpdateThumbHeight();
    }

    private void HideButton_Click(object sender, EventArgs e)
    {
      var obj = (PartyPlayerData)sender;

      if (obj.PartyLootModel.IsHide)
      {
        if (players.Contains(obj.PartyLootModel))
        {
          players.Remove(obj.PartyLootModel);
          hidePlayers.Add(obj.PartyLootModel);
        }
      }
      else
      {
        if (hidePlayers.Contains(obj.PartyLootModel))
        {
          hidePlayers.Remove(obj.PartyLootModel);
          players.Add(obj.PartyLootModel);
        }
      }
      SetTransfersData(players);
    }

    private void clearBtn_Click(object sender, EventArgs e)
    {
      Clear(true);
    }

    private void Clear(bool cleanList)
    {
      List<Control> controlsList = new();

      foreach (Control control in partyPlayersContainer.Controls)
      {
        if (control is PartyPlayerData player)
        {
          player.PanelClick -= TopPanel_Click;
          player.HideClick -= HideButton_Click;
          player.MouseWheel -= MouseWheelEvent;
          player.Reset();
          controlsList.Add(player);
        }
      }

      playerPool.AltReturn(controlsList);
      controlsList.Clear();

      foreach (Control control in playerTransfersContainer.Controls)
      {
        if (control is PlayerTransfer transfer)
          controlsList.Add(transfer);
      }
      transferPool.AltReturn(controlsList);

      partyPlayersContainer.Height =
      playerTransfersContainer.Height = 0;

      rightScrollBar.Visible = false;

      if (cleanList)
      {
        if (players != null)
          players.Clear();

        if (hidePlayers != null)
          hidePlayers.Clear();
      }

      leftScrollBar.UpdateThumbHeight();
      rightScrollBar.UpdateThumbHeight();

      Invalidate();
    }
  }
}
