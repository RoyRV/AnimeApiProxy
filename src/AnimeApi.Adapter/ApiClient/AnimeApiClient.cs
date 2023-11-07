using AnimeApi.Adapter.Resources;
using AnimeProxyApi.Core.Domain.Entities;
using AnimeProxyApi.Core.Infrastructure.Exceptions;
using AnimeProxyApi.Core.Infrastructure.Http;

namespace AnimeApi.Adapter.ApiClient
{
  internal sealed class AnimeApiClient : BaseApiClient, IAnimeApiClient
  {

    public AnimeApiClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }

    public async Task<List<Anime>> GetAllAnimeAsync()
    {
      try
      {
        var content = await Get(ApiSettings.ClientName, ApiClientResources.ANIME);

        if (string.IsNullOrWhiteSpace(content))
        {
          return new List<Anime>();
        }

        return HttpDeserializer.DeserializeResponse<List<Anime>>(content, ApiSettings.ClientName);
      }
      catch (Exception ex)
      {
        var message = string.Format(HttpErrorTemplateMessages.HTTP_GET_ERROR, ApiSettings.ClientName, ApiClientResources.ANIME);

        throw new DependencyException(ApiSettings.ClientName, message, ex);
      }
    }

    public Task<List<Genre>> GetAllGenreAsync()
    {
      throw new NotImplementedException();
    }

    public async Task<List<Genre>> GetGenresByIdsAsync(List<string> ids)
    {
      var resource = $"{ApiClientResources.GENRE}/ids/{string.Join(",", ids)}";
      try
      {
        var content = await Get(ApiSettings.ClientName, resource);

        if (string.IsNullOrWhiteSpace(content))
        {
          return new List<Genre>();
        }

        return HttpDeserializer.DeserializeResponse<List<Genre>>(content, ApiSettings.ClientName);
      }
      catch (Exception ex)
      {
        var message = string.Format(HttpErrorTemplateMessages.HTTP_GET_ERROR, ApiSettings.ClientName, resource);

        throw new DependencyException(ApiSettings.ClientName, message, ex);
      }
    }

    public async Task<List<Image>> GetImagesByIdsAsync(Guid id)
    {
      var resource = string.Format($"{ApiClientResources.ANIME_IMAGE}", id);
      try
      {
        var content = await Get(ApiSettings.ClientName, resource);

        if (string.IsNullOrWhiteSpace(content))
        {
          return new List<Image>();
        }

        return HttpDeserializer.DeserializeResponse<List<Image>>(content, ApiSettings.ClientName);
      }
      catch (Exception ex)
      {
        var message = string.Format(HttpErrorTemplateMessages.HTTP_GET_ERROR, ApiSettings.ClientName, resource);

        throw new DependencyException(ApiSettings.ClientName, message, ex);
      }
    }
  }
}