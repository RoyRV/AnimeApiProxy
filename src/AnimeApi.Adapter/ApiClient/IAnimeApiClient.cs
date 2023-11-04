using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeApi.Adapter.ApiClient
{
  internal interface IAnimeApiClient
  {
    Task<List<Anime>> GetAllAnimeAsync();
  }
}
