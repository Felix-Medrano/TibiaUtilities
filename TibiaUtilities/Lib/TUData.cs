using System.Collections.Generic;

using TibiaUtilities.Interfaces;
using TibiaUtilities.Views.Panels;

namespace TibiaUtilities.Lib
{
  public class TUData
  {
    public Dictionary<string, IPanelView> Panels = new Dictionary<string, IPanelView>()
    {
      {TUStrings.MAIN_PANEL, new MainPanelView() },
      {TUStrings.HOUSES, new HousesPanelView() },
      {TUStrings.LOOT_SPLIT, new LootSplitPanelView() },
      {TUStrings.INFO_PANEL, new InfoPanelView() }//Mantener Info panel al final
    };
  }
}
