using AnimeApi.Adapter.Fixtures;
using AnimeProxyApi.Core.Application.Ports;
using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeApi.Adapter.Repositories
{
  internal sealed class AnimeRepository : IAnimeRepository
  {
    private readonly List<Anime> _list;

    public AnimeRepository()
    {
      _list = new()
            {
               AnimeFixture.OnePiece,
               AnimeFixture.DrStone,
               AnimeFixture.AttackOnTitan
            };
    }

    public Task<List<Anime>> Get()
    {
      return Task.FromResult(_list);
    }

    public Task<Anime?> Get(int id)
    {
      return Task.FromResult(_list.FirstOrDefault(item => item.Id == id));
    }
  }
}