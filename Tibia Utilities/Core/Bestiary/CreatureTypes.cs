using System.Collections.Generic;

using Tibia_Utilities.Models.Bestiary;

namespace Tibia_Utilities.Core.Bestiary
{
  public class CreatureTypes
  {
    public List<CreatureTypeModel> Items { get; set; } = new List<CreatureTypeModel>()
    {
        new CreatureTypeModel { Name = "Amphibic", Image = "https://www.tibiawiki.com.br/images/c/c4/Anf%C3%ADbios.png" },
        new CreatureTypeModel { Name = "Aquatic", Image = "https://www.tibiawiki.com.br/images/6/63/Aqu%C3%A1ticos.png" },
        new CreatureTypeModel { Name = "Bird", Image = "https://www.tibiawiki.com.br/images/7/72/Aves.png" },
        new CreatureTypeModel { Name = "Construct", Image = "https://www.tibiawiki.com.br/images/7/78/Constructos.png" },
        new CreatureTypeModel { Name = "Demon", Image = "https://www.tibiawiki.com.br/images/a/a8/Dem%C3%B4nios.png" },
        new CreatureTypeModel { Name = "Dragon", Image = "https://www.tibiawiki.com.br/images/1/12/Drag%C3%B5es.png" },
        new CreatureTypeModel { Name = "Elemental", Image = "https://www.tibiawiki.com.br/images/b/b1/Elementais.png" },
        new CreatureTypeModel { Name = "Extra Dimensional", Image = "https://www.tibiawiki.com.br/images/7/7c/Extra_Dimensionais.png" },
        new CreatureTypeModel { Name = "Fey", Image = "https://www.tibiawiki.com.br/images/1/14/Fadas.png" },
        new CreatureTypeModel { Name = "Giant", Image = "https://www.tibiawiki.com.br/images/d/df/Gigantes.png" },
        new CreatureTypeModel { Name = "Human", Image = "https://www.tibiawiki.com.br/images/3/39/Humanos.png" },
        new CreatureTypeModel { Name = "Humanoid", Image = "https://www.tibiawiki.com.br/images/d/de/Human%C3%B3ides.png" },
        new CreatureTypeModel { Name = "Inkborn", Image = "https://www.tibiawiki.com.br/images/4/4d/Inkborn.png" },
        new CreatureTypeModel { Name = "Lycanthrope", Image = "https://www.tibiawiki.com.br/images/3/32/Licantropos.png" },
        new CreatureTypeModel { Name = "Magical", Image = "https://www.tibiawiki.com.br/images/3/38/Criaturas_M%C3%A1gicas.png" },
        new CreatureTypeModel { Name = "Mammal", Image = "https://www.tibiawiki.com.br/images/a/ac/Mam%C3%ADferos.png" },
        new CreatureTypeModel { Name = "Plant", Image = "https://www.tibiawiki.com.br/images/c/ce/Plantas_%28Criatura%29.png" },
        new CreatureTypeModel { Name = "Reptile", Image = "https://www.tibiawiki.com.br/images/6/65/R%C3%A9pteis.png" },
        new CreatureTypeModel { Name = "Slime", Image = "https://www.tibiawiki.com.br/images/0/03/Slimes.png" },
        new CreatureTypeModel { Name = "Undead", Image = "https://www.tibiawiki.com.br/images/3/3d/Mortos-Vivos.png" },
        new CreatureTypeModel { Name = "Vermin", Image = "https://www.tibiawiki.com.br/images/d/d2/Vermes.png" },
    };
  }
}
