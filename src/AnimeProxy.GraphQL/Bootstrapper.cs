using AnimeProxy.GraphQL.Schema;
using Microsoft.Extensions.DependencyInjection;

namespace AnimeProxy.GraphQL
{
  public static class Bootstrapper
  {
    public static void AddAnimeGraphQL(this IServiceCollection serviceCollection)
    {
      serviceCollection.AddGraphQLServer().AddQueryType<Queries>();
    }
  }
}
