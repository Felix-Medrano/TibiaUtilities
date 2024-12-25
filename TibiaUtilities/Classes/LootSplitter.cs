using System;
using System.Collections.Generic;
using System.Linq;

using TibiaUtilities.CustomControls;
using TibiaUtilities.Models.LootSplit;

namespace TibiaUtilities.Classes
{
  public class LootSplitter
  {
    private List<Player> players;

    public LootSplitter(List<Player> players)
    {
      this.players = players;
    }

    public List<Transfers> SplitLoot()
    {
      int totalLoot = players.Sum(player => player.Loot);
      int totalSupplies = players.Sum(player => player.Supplies);
      int totalBalance = totalLoot - totalSupplies;
      int splitAmount = totalBalance / players.Count;

      List<Player> playersToReceive = players.Where(p => p.Balance > splitAmount).ToList();
      List<Player> playersToPay = players.Where(p => p.Balance < splitAmount).ToList();
      List<(string payer, string receiver, int amount)> transfers = new List<(string, string, int)>();

      foreach (var playerToPay in playersToPay)
      {
        int amountToPay = splitAmount - playerToPay.Balance;
        while (amountToPay > 0 && playersToReceive.Any())
        {
          var playerToReceive = playersToReceive.First();
          int amountReceivable = playerToReceive.Balance - splitAmount;

          int transferAmount = Math.Min(amountToPay, amountReceivable);

          transfers.Add((playerToPay.Name, playerToReceive.Name, transferAmount));

          amountToPay -= transferAmount;
          playerToReceive.Loot -= transferAmount;

          if (playerToReceive.Balance <= splitAmount)
          {
            playersToReceive.Remove(playerToReceive);
          }
        }
      }

      List<Transfers> transfersList = new List<Transfers>();
      foreach (var transfer in transfers.GroupBy(t => t.receiver))
      {
        foreach (var entry in transfer)
        {
          Transfers transfers1 = new Transfers(entry.receiver, entry.amount, entry.payer);
          transfersList.Add(transfers1);
        }
      }

      return transfersList;
    }
  }
}
