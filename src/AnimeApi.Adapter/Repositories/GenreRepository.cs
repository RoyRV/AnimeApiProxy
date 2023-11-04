using AnimeApi.Adapter.Fixtures;
using AnimeProxyApi.Core.Application.Ports;
using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeApi.Adapter.Repositories
{
  internal sealed class GenreRepository : IGenreRepository
  {
    private readonly List<Genre> _list;

    public GenreRepository()
    {
      //_list = new()
      //      {
      //        GenreFixture.Comedy,
      //        GenreFixture.Action,
      //        GenreFixture.Adventure,
      //        GenreFixture.Fantasy,
      //        GenreFixture.Terror
      //      };
    }

    public Task<List<Genre>> Get()
    {
      return Task.FromResult(_list);
    }

    public Task<Genre?> Get(Guid id)
    {
      return Task.FromResult(_list.FirstOrDefault(x => x.Id == id));
    }
  }
}