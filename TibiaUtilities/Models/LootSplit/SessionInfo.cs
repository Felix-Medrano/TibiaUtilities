using System;

namespace TibiaUtilities.Models.LootSplit
{
  public class SessionInfo
  {
    public DateTime SessionStart { get; set; }
    public DateTime SessionEnd { get; set; }
    public TimeSpan SessionDuration { get; set; }
    public string LootType { get; set; }
    public int LootAmount { get; set; }
    public int SuppliesAmount { get; set; }
    public int BalanceAmount { get; set; }

    public SessionInfo()
    {
      // Constructor vacío
    }

    public SessionInfo(DateTime start, DateTime end, TimeSpan duration, string lootType, int loot, int supplies, int balance)
    {
      SessionStart = start;
      SessionEnd = end;
      SessionDuration = duration;
      LootType = lootType;
      LootAmount = loot;
      SuppliesAmount = supplies;
      BalanceAmount = balance;
    }

    public string ToHTML()
    {
      return $"<div class='session-info'>" +
               $"<div class='tv-gray'>From: <span class='white-signs'>{SessionStart:yyyy-MM-dd HH:mm:ss}</span></div>" +
               $"<div class='tv-gray'>To: <span class='white-signs'>{SessionEnd:yyyy-MM-dd HH:mm:ss}</span></div>" +
               $"<div class='tv-gray'>Session: <span class='white-signs'>{SessionDuration:hh\\:mm\\h}</span></div>" +
               $"<div class='tv-gray'>Loot Type: <span class='white-signs'>{LootType}</span></div>" +
               $"<div class='tv-gray'>Loot: <span class='white-signs'>{LootAmount:N0}</span></div>" +
               $"<div class='tv-gray'>Supplies: <span class='white-signs'>{SuppliesAmount:N0}</span></div>" +
               $"<div class='tv-gray'>Balance: <span class='white-signs'>{BalanceAmount:N0}</span></div>" +
               "</div>";
    }
  }
}
