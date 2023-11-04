using AnimeApi.Adapter.ApiClient;
using AnimeProxyApi.Core.Application.Ports;
using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeApi.Adapter.Repositories
{
  internal sealed class GenreRepository : IGenreRepository
  {
    private IAnimeApiClient _apiClient;

    public GenreRepository(IAnimeApiClient apiClient)
    {
      _apiClient = apiClient;
    }

    public async Task<List<Genre>> GetGenresByIdsAsync(List<string> ids)
    {
      return await _apiClient.GetGenresByIdsAsync(ids);
    }
  }
}