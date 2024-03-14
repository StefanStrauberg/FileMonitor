namespace FileMonitor.Logger;

/// <summary>
/// Dependency Injection LoggerService
/// </summary>
public static class LoggerService
{
    /// <summary>
    /// Adding logging features to the application
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddLoggerServices(this IServiceCollection services)
    {
        services.AddSingleton(typeof(IAppLogger<>), typeof(AppLogger<>));
        return services;
    }
}
