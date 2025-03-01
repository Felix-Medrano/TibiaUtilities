using System.Threading.Tasks;

using Tibia_Utilities.Models.Houses;
using Tibia_Utilities.Service;

namespace Tibia_Utilities.Controllers.Houses
{
  public class HouseController
  {
    HTTPService _httpClient;

    public HouseController()
    {
      _httpClient = new HTTPService();
    }

    public async Task<House> GetHouseById(string world, int id)
    {
      var data = await _httpClient.GetAsync<HouseByIDModel>($"https://api.tibiadata.com/v4/house/{world}/{id}");
      if (data != null)
      {
        return data.house;
      }
      return null;
    }

    public async Task<Models.Houses.Houses> GetHousesByWorld(string world, string town)
    {
      var data = await _httpClient.GetAsync<HousesByTownModel>($"https://api.tibiadata.com/v4/houses/{world}/{town}");
      if (data != null)
      {
        return data.houses;
      }
      return null;
    }
  }
}
