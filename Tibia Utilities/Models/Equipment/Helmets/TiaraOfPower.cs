using System;

using Tibia_Utilities.Lib;

namespace Tibia_Utilities.Models.Equipment.Helmets
{
  public class TiaraOfPower : EquipmentBaseModel
  {
    public TiaraOfPower()
    {
      SetName("Tiara of Power");
      SetIsEquipped(false);
      SetSlot(TUEnums.EquipmentSlot.Head);
      SetDuration(3600); // Duration in seconds (1 hour)
      SetCurrentDuration(Duration); // Initialize current duration to the full duration
    }

    public override string ToString()
    {
      string text;

      text =
        $"Name: {Name}\n" +
        $"Equipped: {IsEquipped}\n";

      if (IsEquipped)
      {
        TimeSpan currentTime = TimeSpan.FromSeconds(CurrentDuration);
        text += $"Current Duration: {currentTime.ToString(@"hh\:mm\:ss")}\n";
      }
      else
      {
        TimeSpan totalTime = TimeSpan.FromSeconds(Duration);
        text += $"Total Duration: {totalTime.ToString(@"hh\:mm\:ss")}\n";
      }

      return text;

    }
  }
}
