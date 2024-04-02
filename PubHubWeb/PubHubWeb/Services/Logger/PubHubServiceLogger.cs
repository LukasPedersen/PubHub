using PubHubWeb.Data;

namespace PubHubAPI.Services.Logger
{
    public sealed class PubHubServiceLogger(string name, Func<PubHubServiceLoggerConfiguration> getCurrentConfig) : ILogger
    {
        private readonly PubHubDBContext _dbContext;

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            throw new NotImplementedException();
        }
    }
}
