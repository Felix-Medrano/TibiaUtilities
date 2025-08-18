using System.Collections.Generic;

using Tibia_Utilities.Lib;
using Tibia_Utilities.Models.HotCuisine;
using Tibia_Utilities.Properties;

namespace Tibia_Utilities.Core.HotCuisine
{
  public class HotCuisineManager
  {
    private HotCuisineIngredients _ingredients = new HotCuisineIngredients();
    private Dictionary<string, RecipeModel> _recipes = new();

    public Dictionary<string, RecipeModel> Recipes { get => _recipes; }

    public HotCuisineManager()
    {
      AddRecipes();
    }

    private void AddRecipes()
    {
      var rotwormStew = new RecipeModel
      {
        Name = TUStrings.Recipes.ROTWORM_STEW,
        Icon = Resources.Rotworm_Stew,
        Ingredients = new List<IngredientModel>
            {
              _ingredients.Meat(2),
              _ingredients.VialOfBeer(2),
              _ingredients.Potato(20),
              _ingredients.Onion(1),
              _ingredients.BulbofGarlic(1),
              _ingredients.Flour(5)
            },
        Effect = "Te recuperara la hp por completó"
      };
      _recipes.Add(rotwormStew.Name, rotwormStew);

      var hydraTongueSalad = new RecipeModel
      {
        Name = TUStrings.Recipes.HYDRA_TONGUE_SALAD,
        Icon = Resources.Hydra_Tongue_Salad,
        Ingredients = new List<IngredientModel>
            {
              _ingredients.HydraTongue(2),
              _ingredients.Tomato(2),
              _ingredients.Cucumber(1),
              _ingredients.Egg(2),
              _ingredients.TrollGreen(1),
              _ingredients.VialOfWine(1)
            },
        Effect = "Te cura de todas las condiciones negativas"
      };
      _recipes.Add(hydraTongueSalad.Name, hydraTongueSalad);

      var roastedDragonWings = new RecipeModel
      {
        Name = TUStrings.Recipes.ROASTED_DRAGON_WINGS,
        Icon = Resources.Roasted_Dragon_Wings,
        Ingredients = new List<IngredientModel>
            {
              _ingredients.DeadBat(1),
              _ingredients.JalapenoPepper(3),
              _ingredients.BrownBread(5),
              _ingredients.Egg(2),
              _ingredients.PowderHerb(1),
              _ingredients.RedMushroom(5)
            },
        Effect = "Aumenta 10 puntos de Shielding Skill durante 1 hora"
      };
      _recipes.Add(roastedDragonWings.Name, roastedDragonWings);

      var tropicalFriedTerrorbird = new RecipeModel
      {
        Name = TUStrings.Recipes.TROPICAL_FRIED_TERRORBIRD,
        Icon = Resources.Tropical_Fried_Terrorbird,
        Ingredients = new List<IngredientModel>
            {
              _ingredients.DeadChicken(1),
              _ingredients.Lemon(2),
              _ingredients.Orange(2),
              _ingredients.Mango(2),
              _ingredients.CoconutMilk(2),
              _ingredients.StoneHerb(1)
            },
        Effect = "Aumenta 5 puntos de Magic Level durante 1 hora"
      };
      _recipes.Add(tropicalFriedTerrorbird.Name, tropicalFriedTerrorbird);

      var bananaChocolateShake = new RecipeModel
      {
        Name = TUStrings.Recipes.BANANA_CHOCOLATE_SHAKE,
        Icon = Resources.Banana_Chocolate_Shake,
        Ingredients = new List<IngredientModel>
            {
              _ingredients.BarOfChocolate(1),
              _ingredients.CreamCake(1),
              _ingredients.Banana(2),
              _ingredients.VialOfMilk(2),
              _ingredients.SlingHerb(1),
              _ingredients.StarHerb(1)
            },
        Effect = "Te hace feliz"
      };
      _recipes.Add(bananaChocolateShake.Name, bananaChocolateShake);

      var veggieCasserole = new RecipeModel
      {
        Name = TUStrings.Recipes.VEGGIE_CASSEROLE,
        Icon = Resources.Veggie_Casserole,
        Ingredients = new List<IngredientModel>
            {
              _ingredients.Carrot(2),
              _ingredients.Tomato(2),
              _ingredients.Corncob(2),
              _ingredients.Cucumber(2),
              _ingredients.Onion(1),
              _ingredients.BulbofGarlic(1),
              _ingredients.Cheese(1),
              _ingredients.WhiteMushroom(20),
              _ingredients.BrownMushroom(5)
            },
        Effect = "Aumenta 10 puntos de Sword/Axe/Club Skill durante 1 hora"
      };
      _recipes.Add(veggieCasserole.Name, veggieCasserole);

      var filledJalapenoPeppers = new RecipeModel
      {
        Name = TUStrings.Recipes.FILLED_JALAPENO_PEPPERS,
        Icon = Resources.Filled_Jalapeño_Peppers,
        Ingredients = new List<IngredientModel>
            {
              _ingredients.JalapenoPepper(10),
              _ingredients.Cheese(2),
              _ingredients.TrollGreen(1),
              _ingredients.ShadowHerb(1),
              _ingredients.VialOfMead(1),
              _ingredients.Egg(2)
            },
        Effect = "Aumenta 100 puntos de Speed durante 1 hora"
      };
      _recipes.Add(filledJalapenoPeppers.Name, filledJalapenoPeppers);

      var blessedSteak = new RecipeModel
      {
        Name = TUStrings.Recipes.BLESSED_STEAK,
        Icon = Resources.Blessed_Steak,
        Ingredients = new List<IngredientModel>
            {
              _ingredients.Ham(1),
              _ingredients.Plum(5),
              _ingredients.Onion(1),
              _ingredients.Beetroot(2),
              _ingredients.Pumpkin(1),
              _ingredients.JalapenoPepper(2)
            },
        Effect = "Llena tu barra de mana por completo"
      };
      _recipes.Add(blessedSteak.Name, blessedSteak);

      var northernFishburger = new RecipeModel
      {
        Name = TUStrings.Recipes.NORTHERN_FISHBURGER,
        Icon = Resources.Northern_Fishburger,
        Ingredients = new List<IngredientModel>
            {
              _ingredients.NorthernPike(1),
              _ingredients.RainbowTrout(1),
              _ingredients.GreenPerch(1),
              _ingredients.Shrimp(5),
              _ingredients.Roll(2),
              _ingredients.Fern(1)
            },
        Effect = "Aumenta 50 puntos de Fishing Skill durante 1 hora"
      };
      _recipes.Add(northernFishburger.Name, northernFishburger);

      var carrotCake = new RecipeModel
      {
        Name = TUStrings.Recipes.CARROT_CAKE,
        Icon = Resources.Carrot_Cake,
        Ingredients = new List<IngredientModel>
            {
              _ingredients.Carrot(5),
              _ingredients.VialOfMilk(1),
              _ingredients.Lemon(1),
              _ingredients.Flour(10),
              _ingredients.Egg(2),
              _ingredients.Cookie(10),
              _ingredients.Peanut(2)
            },
        Effect = "Aumenta 10 puntos de Distance Skill durante 1 hora"
      };
      _recipes.Add(carrotCake.Name, carrotCake);

      var coconutShrimpBake = new RecipeModel
      {
        Name = TUStrings.Recipes.COCONUT_SHRIMP_BAKE,
        Icon = Resources.Coconut_Shrimp_Bake,
        Ingredients = new List<IngredientModel>
            {
              _ingredients.CoconutMilk(5),
              _ingredients.BrownMushroom(5),
              _ingredients.RedMushroom(5),
              _ingredients.RiceBall(10),
              _ingredients.Shrimp(10)
            },
        Effect = "Aumenta tu velocidad al caminar bajo el agua durante 24 horas"
      };
      _recipes.Add(coconutShrimpBake.Name, coconutShrimpBake);

      var potOfBlackjack = new RecipeModel
      {
        Name = TUStrings.Recipes.POT_OF_BLACKJACK,
        Icon = Resources.Pot_of_Blackjack,
        Ingredients = new List<IngredientModel>
            {
              _ingredients.SandcrawlerShell(5),
              _ingredients.VialOfWater(2),
              _ingredients.Carrot(20),
              _ingredients.Potato(10),
              _ingredients.JalapenoPepper(3)
            },
        Effect = "Recupera 5000hp y se puede usar de 2 a 4 veces"
      };
      _recipes.Add(potOfBlackjack.Name, potOfBlackjack);

      var demonicCandyBalls = new RecipeModel
      {
        Name = TUStrings.Recipes.DEMONIC_CANDY_BALLS,
        Icon = Resources.Demonic_Candy_Balls,
        Ingredients = new List<IngredientModel>
            {
              _ingredients.Candy(3),
              _ingredients.CandyCane(3),
              _ingredients.BarOfChocolate(2),
              _ingredients.Gingerbreadman(15),
              _ingredients.FlaskOfDemonicBlood(1)
            },
        Effect = "Posibles Efectos:\n\n" +
                 "*Aumenta 3 puntos de Sword/Axe/Club Skill durante 1 hora.\n" +
                 "*Aumenta 3 puntos de Distance Skill durante una hora.\n" +
                 "*Aumenta 6 puntos de Shielding Skill durante una hora.\n" +
                 "*Aumenta 3 puntos de Magic Level durante una hora.\n" +
                 "*Aumenta 50 puntos de Speed durante una hora.\n" +
                 "*Te hace invisible durante 10 minutos.\n" +
                 "*Efecto negativo (1% de probabilidad):\n" +
                 "--Poisoned\n" +
                 "--Cursed\n" +
                 "--Dazzled\n" +
                 "--Burning\n" +
                 "--Freezing\n" +
                 "--Drowning\n" +
                 "causando 364 puntos de daño si no tienes equipo que modifique estos tipos de daño.\n" +
                 "*Efecto raro adicional:\n" +
                 "--Te transforma en 'The Mutated Pumpkin' y emites luz en un radio de 6 casillas.\n"
      };
      _recipes.Add(demonicCandyBalls.Name, demonicCandyBalls);

      var sweetMangonaiseElixir = new RecipeModel
      {
        Name = TUStrings.Recipes.SWEET_MANGONAISE_ELIXIR,
        Icon = Resources.Sweet_Mangonaise_Elixir,
        Ingredients = new List<IngredientModel>
            {
              _ingredients.Egg(40),
              _ingredients.Mango(20),
              _ingredients.Honeycomb(10),
              _ingredients.BottleofBugMilk(1),
              _ingredients.BlessedWoodenStake(1)
            },
        Effect = "Crea 10 copias del anillo(consumible) equipado"
      };
      _recipes.Add(sweetMangonaiseElixir.Name, sweetMangonaiseElixir);

      var zaoanSauce = new RecipeModel
      {
        Name = TUStrings.Recipes.ZAOAN_SAUCE,
        Icon = Resources.Zaoan_Sauce,
        Ingredients = new List<IngredientModel>
        {
          _ingredients.Salt(1),
          _ingredients.CoconutMilk(2),
          _ingredients.Dragonfruit(1),
          _ingredients.YoungLichWorm(1),
          _ingredients.Taiyaki(1)
        },
        Effect = "Aumenta 10 puntos de Fist Skill durante 1 hora"
      };
      _recipes.Add(zaoanSauce.Name, zaoanSauce);
    }
  }
}
