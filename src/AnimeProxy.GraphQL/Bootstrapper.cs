using AnimeProxy.GraphQL.Schema.Queries.Animes;
using AnimeProxy.GraphQL.Schema.Queries.Genres;
using Microsoft.Extensions.DependencyInjection;

namespace AnimeProxy.GraphQL
{
  public static class Bootstrapper
  {
    public static void AddAnimeGraphQL(this IServiceCollection serviceCollection)
    {
      serviceCollection.AddGraphQLServer()
      .AddQueryType(q => q.Name("Query"))
        .AddType<AnimeQuery>()
        .AddTypeExtension<AnimeExtensions>()
        .AddType<GenreQuery>();
    }
  }
}