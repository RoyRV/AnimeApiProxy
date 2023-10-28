using AnimeAPI.Core.Domain.Entities;

namespace AnimeAPI.Core.Application.Ports
{
  public interface IImageRepository
  {
    public Task<Image?> Get(int id);
  }
}
