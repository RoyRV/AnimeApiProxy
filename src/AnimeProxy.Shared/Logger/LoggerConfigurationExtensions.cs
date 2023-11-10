using Serilog;
using Serilog.Events;

namespace AnimeProxy.Shared.Logger
{
  public static class LoggerConfigurationExtensions
  {
    public static void SetupLoggerConfiguration(string appName) => Log.Logger = new LoggerConfiguration()
          .ConfigureBaseLogging(appName)
          .CreateLogger();

    public static LoggerConfiguration ConfigureBaseLogging(this LoggerConfiguration loggerConfiguration, string appName)
    {
      loggerConfiguration
          .MinimumLevel.Information()
          .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
          .Enrich.FromLogContext()
          .Enrich.WithProperty("ApplicationName", appName);

      return loggerConfiguration;
    }

  }
}