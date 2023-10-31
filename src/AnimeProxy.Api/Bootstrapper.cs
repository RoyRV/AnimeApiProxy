using Microsoft.Extensions.DependencyInjection;

namespace AnimeProxy.Api
{
  public static class Bootstrapper
  {
    public static void AddApi(this IServiceCollection serviceCollection)
    {
      serviceCollection.AddControllers();
      // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
      serviceCollection.AddEndpointsApiExplorer();
      serviceCollection.AddSwaggerGen();
    }
  }
}
