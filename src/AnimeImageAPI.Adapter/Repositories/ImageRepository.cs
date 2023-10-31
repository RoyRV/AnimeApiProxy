using AnimeImageAPI.Adapter.Fixtures;
using AnimeProxyApi.Core.Application.Ports;
using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeImageAPI.Adapter.Repositories
{
  internal sealed class ImageRepository : IImageRepository
  {
    private readonly List<Image> _list;

    public ImageRepository()
    {
      _list = new List<Image>
      {
        ImageFixture.OnePiece1,
        ImageFixture.OnePiece2,
        ImageFixture.DrStone1,
        ImageFixture.DrStone2,
        ImageFixture.AttackOnTitan1,
        ImageFixture.AttackOnTitan2
      };
    }

    public Task<Image?> Get(int id)
    {
      return Task.FromResult(_list.FirstOrDefault(x => x.Id == id));
    }
  }
}