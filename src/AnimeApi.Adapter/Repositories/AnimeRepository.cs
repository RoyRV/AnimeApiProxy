using AnimeApi.Adapter.ApiClient;
using AnimeProxyApi.Core.Application.Ports;
using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeApi.Adapter.Repositories
{
  internal sealed class AnimeRepository : IAnimeRepository
  {
    private IAnimeApiClient _apiClient;

    public AnimeRepository(IAnimeApiClient apiClient)
    {
      _apiClient = apiClient;
    }

    public async Task<List<Anime>> GetAsync()
    {
      return await _apiClient.GetAllAnimeAsync();
    }

    public Task<Anime?> Get(int id)
    {
      return null;
    }
  }
}