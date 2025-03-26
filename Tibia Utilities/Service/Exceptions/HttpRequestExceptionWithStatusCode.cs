using System.Net;
using System.Net.Http;

namespace Tibia_Utilities.Service.Exceptions
{
  public class HttpRequestExceptionWithStatusCode : HttpRequestException
  {
    public HttpStatusCode StatusCode { get; }

    public HttpRequestExceptionWithStatusCode(HttpStatusCode statusCode, string message)
        : base(message)
    {
      StatusCode = statusCode;
    }
  }
}
