namespace FileMonitor.Logger;

/// <summary>
/// Provide methods of custom implementation logic of logging
/// </summary>
/// <typeparam name="T"></typeparam>
internal sealed class AppLogger<T>(ILoggerFactory loggerFactory) 
    : IAppLogger<T>
{
    readonly ILogger<T> _logger = loggerFactory.CreateLogger<T>()
        ?? throw new ArgumentNullException(nameof(loggerFactory));

    /// <summary>
    /// Write an information log
    /// </summary>
    /// <param name="message">Information message log</param>
    /// <param name="args">An object array that contains zero or more objects to format message log</param>
    void IAppLogger<T>.LogInformation(string message,
                                      params object[] args)
            => _logger.LogInformation(message,
                                      args);

    /// <summary>
    /// Write an warning log
    /// </summary>
    /// <param name="message">Warning message log</param>
    /// <param name="args">An object array that contains zero or more objects to format message log</param>
    void IAppLogger<T>.LogWarning(string message,
                                  params object[] args)
        => _logger.LogWarning(message,
                              args);

    /// <summary>
    /// Write an error log
    /// </summary>
    /// <param name="message">Error message log</param>
    /// <param name="args">An object array that contains zero or more objects to format message log</param>
    void IAppLogger<T>.LogError(string message,
                                params object[] args)
        => _logger.LogError(message,
                            args);
}