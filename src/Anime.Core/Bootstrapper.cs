using AnimeAPI.Core.Infrastructure.Logger;
using Microsoft.Extensions.DependencyInjection;

namespace AnimeAPI.Core
{
  public static class Bootstrapper
  {
    public static void AddCore(this IServiceCollection serviceCollection, string appName)
    {
      LoggerConfigurationExtensions.SetupLoggerConfiguration(appName);
    }
  }
}
