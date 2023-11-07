using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeApi.Adapter.ApiClient
{
  internal interface IAnimeApiClient
  {
    Task<List<Anime>> GetAllAnimeAsync();
    Task<List<Genre>> GetAllGenreAsync();
    Task<List<Genre>> GetGenresByIdsAsync(List<string> ids);
    Task<List<Image>> GetImagesByIdsAsync(Guid id);
  }
}