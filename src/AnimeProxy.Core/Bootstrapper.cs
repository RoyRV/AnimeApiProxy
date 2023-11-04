using AnimeProxyApi.Core.Infrastructure.Logger;
using Microsoft.Extensions.DependencyInjection;

namespace AnimeProxyApi.Core
{
  public static class Bootstrapper
  {
    public static void AddCore(this IServiceCollection serviceCollection, string appName)
    {
      LoggerConfigurationExtensions.SetupLoggerConfiguration(appName);
    }
  }
}