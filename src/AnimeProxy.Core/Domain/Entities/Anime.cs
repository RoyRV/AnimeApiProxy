using HotChocolate;
using HotChocolate.Types;
using System.Text.Json.Serialization;

namespace AnimeProxyApi.Core.Domain.Entities
{
  public sealed class Anime
  {
    [GraphQLType(typeof(IdType))]
    public Guid Id { get; init; }

    public string Title { get; init; }

    public string Description { get; init; }

    public DateTime StartDate { get; init; }

    public DateTime? EndDate { get; init; }

    //public Image? Image { get; init; }

    public List<string> Genres { get; init; }

    [JsonConstructor]
    public Anime(Guid id, string title, string description, DateTime startDate, List<string> genres)
    {
      Id = id;
      Title = title;
      Description = description;
      StartDate = startDate;
      Genres = genres;
    }

    public Anime(Guid id, string title, string description, DateTime startDate, List<string> genres, DateTime? endDate) : this(id, title, description, startDate, genres)
    {
      EndDate = endDate;
    }
  }
}