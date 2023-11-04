namespace AnimeProxyApi.Core.Domain.Entities
{
  public class Genre
  {
    public Guid Id { get; init; }

    public string Name { get; init; }

    public Genre(Guid id, string name)
    {
      Id = id;
      Name = name;
    }
  }
}