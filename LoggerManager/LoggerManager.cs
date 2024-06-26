using NLog;
using ShipmentTracker.Core.Domain.Extentions;

namespace LoggerManager;

public class LoggerManager : ILoggerManager
{
    private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
    public LoggerManager()
    {
    }
    public void LogDebug(string message) => Logger.Debug(message);
    public void LogError(string message) => Logger.Error(message);
    public void LogInfo(string message) => Logger.Info(message);
    public void LogWarn(string message) => Logger.Warn(message);
}
