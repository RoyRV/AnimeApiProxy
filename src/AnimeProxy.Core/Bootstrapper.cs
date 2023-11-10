using Microsoft.Extensions.DependencyInjection;
using AnimeProxy.Shared.Logger;

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