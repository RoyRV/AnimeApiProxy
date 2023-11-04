using HotChocolate.Types;
using HotChocolate;
using System.Text.Json.Serialization;

namespace AnimeProxyApi.Core.Domain.Entities
{
  public class Genre
  {
    [GraphQLType(typeof(IdType))]
    public Guid Id { get; init; }

    public string Name { get; init; }

    [JsonConstructor]
    public Genre(Guid id, string name)
    {
      Id = id;
      Name = name;
    }
  }
}