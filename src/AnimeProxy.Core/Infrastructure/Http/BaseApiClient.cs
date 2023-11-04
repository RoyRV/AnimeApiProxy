using System.Net.Http;

namespace AnimeProxyApi.Core.Infrastructure.Http
{
  public abstract class BaseApiClient
  {

    protected  IHttpClientFactory _httpClientFactory;

    protected BaseApiClient(IHttpClientFactory httpClientFactory)
    {
      _httpClientFactory = httpClientFactory;
    }

    public async Task<string> Get(string clientName, string resource)
    {
      var client = _httpClientFactory.CreateClient(clientName);
      var response = await client.GetAsync(resource);

      return await response.Content.ReadAsStringAsync();
    }
  }
}
