using System.Threading.Tasks;

using Tibia_Utilities.Models.Houses;
using Tibia_Utilities.Service;

namespace Tibia_Utilities.Controllers.Houses
{
  internal class WorldController
  {
    private HTTPService _httpClient;

    public WorldController()
    {
      _httpClient = new HTTPService();
    }

    public async Task<Worlds> GetWorlds()
    {
      var data = await _httpClient.GetAsync<WorldsModel>("https://api.tibiadata.com/v4/worlds");

      if (data != null)
      {
        return data.worlds;
      }

      return null;
    }
  }
}
