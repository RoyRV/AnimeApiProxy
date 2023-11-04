using AnimeProxyApi.Core.Domain.Entities;
using AnimeProxyApi.Core.Infrastructure.Http;

namespace AnimeApi.Adapter.ApiClient
{
  internal sealed class AnimeApiClient : IAnimeApiClient
  {

    private IHttpClientFactory _httpClientFactory;

    public AnimeApiClient(IHttpClientFactory httpClientFactory)
    {
      _httpClientFactory = httpClientFactory;
    }

    public async Task<List<Anime>> GetAllAnimeAsync()
    {
      try
      {
        var client = _httpClientFactory.CreateClient(ApiSettings.ClientName);

        var response = await client.GetAsync(ApiClientResources.ANIME);

        var content = await response.Content.ReadAsStringAsync();

        if (string.IsNullOrWhiteSpace(content))
        {
          return new List<Anime>();
        }
        
        return HttpDeserializer.DeserializeResponse<List<Anime>>(content, ApiSettings.ClientName);
      }
      catch (Exception ex)
      {
        var message = string.Format(HttpErrorTemplateMessages.HTTP_GET_ERROR, ApiClientResources.ANIME, ApiClientResources.ANIME);

        throw new DependencyException(ApiSettings.ClientName, message, ex);
      }
    }
  }
}
