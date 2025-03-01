using Newtonsoft.Json;

namespace Services
{
  public class HTTPClient : IDisposable
  {
    private readonly HttpClient _httpClient;

    public HTTPClient()
    {
      _httpClient = new HttpClient();
    }

    public void Dispose()
    {
      _httpClient.Dispose();
    }

    public async Task<T> GetAsync<T>(string url) where T : class
    {
      try
      {
        HttpResponseMessage responseMessage = await _httpClient.GetAsync(url);
        responseMessage.EnsureSuccessStatusCode();

        string response = await responseMessage.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(response);
      }
      catch (Exception)
      {
        //Mejorar Exception
        return null;
      }
    }
  }
}
