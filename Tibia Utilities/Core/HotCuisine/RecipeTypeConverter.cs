using System;
using System.ComponentModel;

using Tibia_Utilities.Lib;

namespace Tibia_Utilities.Core.HotCuisine
{
  public class RecipeTypeConverter : TypeConverter
  {
    public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => true;
    public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => true;

    public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
    {
      return new StandardValuesCollection(new string[]
      {
        TUStrings.Recipes.ROTWORM_STEW,
        TUStrings.Recipes.HYDRA_TONGUE_SALAD,
        TUStrings.Recipes.ROASTED_DRAGON_WINGS,
        TUStrings.Recipes.TROPICAL_FRIED_TERRORBIRD,
        TUStrings.Recipes.BANANA_CHOCOLATE_SHAKE,
        TUStrings.Recipes.VEGGIE_CASSEROLE,
        TUStrings.Recipes.FILLED_JALAPENO_PEPPERS,
        TUStrings.Recipes.BLESSED_STEAK,
        TUStrings.Recipes.NORTHERN_FISHBURGER,
        TUStrings.Recipes.CARROT_CAKE,
        TUStrings.Recipes.COCONUT_SHRIMP_BAKE,
        TUStrings.Recipes.POT_OF_BLACKJACK,
        TUStrings.Recipes.DEMONIC_CANDY_BALLS,
        TUStrings.Recipes.SWEET_MANGONAISE_ELIXIR,
        TUStrings.Recipes.ZAOAN_SAUCE
      });
    }

    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
    }

    public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
    {
      return value is string str ? str : base.ConvertFrom(context, culture, value);
    }
  }
}
