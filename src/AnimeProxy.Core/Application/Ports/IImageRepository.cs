using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeProxyApi.Core.Application.Ports
{
  public interface IImageRepository
  {
    Task<List<Image>> GetAsync(Guid animeId);
  }
}