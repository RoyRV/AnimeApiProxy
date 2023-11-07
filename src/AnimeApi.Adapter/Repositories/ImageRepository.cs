using AnimeApi.Adapter.ApiClient;
using AnimeProxyApi.Core.Application.Ports;
using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeApi.Adapter.Repositories
{
  internal sealed class ImageRepository : IImageRepository
  {
    private IAnimeApiClient _apiClient;

    public ImageRepository(IAnimeApiClient apiClient)
    {
      _apiClient = apiClient;
    }

    public async Task<List<Image>> GetAsync(Guid animeId)
    {
      return await _apiClient.GetImagesByIdsAsync(animeId);
    }
  }
}