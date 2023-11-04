using System.Text.Json;

namespace AnimeProxyApi.Core.Infrastructure.Http
{
  public static class HttpDeserializer
  {
    private static readonly JsonSerializerOptions JsonSerializerOptions = new()
    { PropertyNameCaseInsensitive = true };

    public static T DeserializeResponse<T>(string json, string serviceName)
    {
      try  
      {
        var apiResponse = JsonSerializer.Deserialize<HttpResponseResult<T>>(json, JsonSerializerOptions);

        if (apiResponse.Error)
        {
          throw new Exception(apiResponse.Message);
        }

        return apiResponse.Data;
      }
      catch (JsonException jsonException)
      {
        throw new InvalidResponseException($"Failed to deserialize {serviceName} response.", jsonException);
      }
    }
  }
}

