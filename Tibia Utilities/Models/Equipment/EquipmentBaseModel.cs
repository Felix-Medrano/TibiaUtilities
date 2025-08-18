
using Tibia_Utilities.Lib;

namespace Tibia_Utilities.Models.Equipment
{
  public class EquipmentBaseModel
  {
    // Default values
    private string name;
    private bool isEquipped = false;
    private TUEnums.EquipmentSlot slot;
    private int duration = 0; // Duration in seconds
    private int currentDuration = 0; // Current duration in seconds

    // Properties
    public string Name { get => name; }
    public bool IsEquipped { get => isEquipped; }
    public TUEnums.EquipmentSlot Slot { get => slot; }
    public int Duration { get => duration; }
    public int CurrentDuration { get => currentDuration; }

    // Set methods
    public void SetName(string value) { name = value; }
    public void SetIsEquipped(bool value) { isEquipped = value; }
    public void SetSlot(TUEnums.EquipmentSlot value) { slot = value; }
    public void SetDuration(int value) { duration = value; }
    public void SetCurrentDuration(int value) { currentDuration = value; }

  }
}
