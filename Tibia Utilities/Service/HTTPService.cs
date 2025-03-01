using Newtonsoft.Json;

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tibia_Utilities.Service
{
  public class HTTPService
  {
    private HttpClient httpClient;
    public HTTPService() { httpClient = new HttpClient(); }


    public async Task<T> GetAsync<T>(string url) where T : class
    {
      T info = null;
      string responseJson = string.Empty;

      if (httpClient == null) { httpClient = new HttpClient(); }

      try
      {
        HttpResponseMessage responseMessage = await httpClient.GetAsync(url);
        responseMessage.EnsureSuccessStatusCode();
        responseJson = await responseMessage.Content.ReadAsStringAsync();

        info = JsonConvert.DeserializeObject<T>(responseJson);

        return info;

      }
      catch (TaskCanceledException)
      {
        Console.WriteLine("Request was canceled by timeout.");
        return null;
      }
      catch (HttpRequestException ex)
      {
        Console.WriteLine($"Error en peticion {ex.Message}");
        return null;
      }
      catch (Exception ex)
      {
        System.Windows.Forms.MessageBox.Show(ex.Message);
        return null;
      }
    }
  }
}
