namespace TibiaUtilities.Models.LootSplit
{
  public class Player
  {
    public string Name { get; set; }
    public int Loot { get; set; }
    public int Supplies { get; set; }
    public int Balance => Loot - Supplies;
    public int Damage { get; set; }
    public int Healing { get; set; }

    public Player(string name, int loot, int supplies, int damage = 0, int healing = 0)
    {
      Name = name;
      Loot = loot;
      Supplies = supplies;
      Damage = damage;
      Healing = healing;
    }

    public override string ToString()
    {
      return $"{Name} - Loot: {Loot}, Supplies: {Supplies}, Balance: {Balance}, Damage: {Damage}, Healing: {Healing}";
    }
  }
}