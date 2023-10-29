using AnimeApi.GraphQL.Schema;
using Microsoft.Extensions.DependencyInjection;

namespace AnimeApi.GraphQL
{
  public static class Bootstrapper
  {
    public static void AddAnimeGraphQL(this IServiceCollection serviceCollection)
    {
      serviceCollection.AddGraphQLServer().AddQueryType<Queries>();
    }
  }
}
