using Newtonsoft.Json;

using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Tibia_Utilities.Lib;
using Tibia_Utilities.Service.Exceptions;

namespace Tibia_Utilities.Service
{
  public class HTTPService
  {
    private HttpClient httpClient;
    public HTTPService()
    {
      httpClient = new HttpClient();
    }


    public async Task<T> GetAsync<T>(string url) where T : class
    {
      string responseJson = string.Empty;

      if (httpClient == null) { httpClient = new HttpClient(); }

      try
      {
        HttpResponseMessage responseMessage = await httpClient.GetAsync(url);
#if DEBUG
        $"===Type: {typeof(T).Name}===".ConsoleWL();
        responseMessage.ConsoleWL();
#endif
        responseMessage.EnsureSuccessStatusCode();
        responseJson = await responseMessage.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<T>(responseJson);
      }
      catch (HttpRequestException ex)
      {
        if (ex.Data.Contains("StatusCode"))
        {
          var statusCode = (HttpStatusCode)ex.Data["StatusCode"];
          throw new HttpRequestExceptionWithStatusCode(statusCode, ex.Message);
        }
        throw;
      }
    }
  }
}
