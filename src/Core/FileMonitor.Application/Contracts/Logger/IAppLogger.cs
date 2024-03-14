namespace FileMonitor.Application.Contracts.Logger;

/// <summary>
/// General logging interface
/// </summary>
public interface IAppLogger<T>
{
    /// <summary>
    /// Logging information event
    /// </summary>
    /// <param name="message">Information message</param>
    /// <param name="args">Arguments for concatenate strings</param>
    void LogInformation(string message,
                        params object[] args);
    /// <summary>
    /// Logging warning event
    /// </summary>
    /// <param name="message">Warning message</param>
    /// <param name="args">Arguments for concatenate strings</param>
    void LogWarning(string message,
                    params object[] args);
    /// <summary>
    /// Logging error event
    /// </summary>
    /// <param name="message">Error message</param>
    /// <param name="args">Arguments for concatenate strings</param>
    void LogError(string message,
                  params object[] args);
}
