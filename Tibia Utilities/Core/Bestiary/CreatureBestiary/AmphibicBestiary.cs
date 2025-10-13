using System.Collections.Generic;

using Tibia_Utilities.Models.Bestiary;

namespace Tibia_Utilities.Core.Bestiary.CreatureBestiary
{
  public class AmphibicBestiary
  {
    public List<CreatureTypeModel> Creatures { get; set; } = new List<CreatureTypeModel>()
    {
      new CreatureTypeModel { Name = "Azure Frog", Image = "https://www.tibiawiki.com.br/images/4/4f/Azure_Frog.gif" },
      new CreatureTypeModel { Name = "Bog Frog", Image = "https://www.tibiawiki.com.br/images/8/81/Bog_Frog.gif" },
      new CreatureTypeModel { Name = "Coral Frog", Image = "https://www.tibiawiki.com.br/images/9/91/Coral_Frog.gif" },
      new CreatureTypeModel { Name = "Crimson Frog", Image = "https://www.tibiawiki.com.br/images/2/2b/Crimson_Frog.gif" },
      new CreatureTypeModel { Name = "Filth Toad", Image = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif" },
      new CreatureTypeModel { Name = "Green Frog", Image = "https://www.tibiawiki.com.br/images/9/90/Green_Frog.gif" },
      new CreatureTypeModel { Name = "Infernal Frog", Image = "https://www.tibiawiki.com.br/images/7/79/Infernal_Frog.gif" },
      new CreatureTypeModel { Name = "Makara", Image = "https://www.tibiawiki.com.br/images/1/1c/Makara.gif" },
      new CreatureTypeModel { Name = "Orchid Frog", Image = "https://www.tibiawiki.com.br/images/d/d5/Orchid_Frog.gif" },
      new CreatureTypeModel { Name = "Salamander", Image = "https://www.tibiawiki.com.br/images/3/3a/Salamander.gif" },
      new CreatureTypeModel { Name = "Toad", Image = "https://www.tibiawiki.com.br/images/c/cd/Toad.gif" }
    };
  }
}
