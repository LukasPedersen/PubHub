using Microsoft.Extensions.Logging;

namespace PubHubWebServer.Services.Logger
{
    public sealed class PubHubServiceLoggerConfiguration
    {
        public Guid EventId { get; set; } = Guid.NewGuid();

        public Dictionary<LogLevel, ConsoleColor> LogEventToDB { get; set; } = new()
        {
            [LogLevel.Information] = ConsoleColor.White,
            [LogLevel.Warning] = ConsoleColor.DarkYellow,
            [LogLevel.Error] = ConsoleColor.Red,
        };
    }
}
