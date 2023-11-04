using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeProxyApi.Core.Application.Ports
{
  public interface IImageRepository
  {
    public Task<Image?> Get(int id);
  }
}